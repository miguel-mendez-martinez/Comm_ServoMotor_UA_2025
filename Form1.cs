using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace Comm_ServoMotor_2_UA_2025
{
    public partial class Form1: Form
    {
        public ModbusClient ModbusClient;
        public bool isConnected;

        public bool shutdown = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ModbusClient = new ModbusClient();

            ModbusClient.IPAddress = "192.168.1.50";
            ModbusClient.Port = 502;


        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ModbusClient?.Connect();

            Thread.Sleep(500);
            
            this.isConnected = ModbusClient.Connected;

            if (isConnected)
            {
                labelConectado.Visible = true;
            }
            else
            {
                labelConectado.Visible = false;
            }

            Thread reader_thread = new Thread(new ThreadStart(ReadRegisters));
            reader_thread.Start();

            // si el servo da error, tenemos que pulsar reset

            /*int[] error;
            error = ModbusClient.ReadHoldingRegisters(52, 1);

            labelError.Text = error[0].ToString();

            if (error[0] > 0) {
                
            }

            error = ModbusClient.ReadHoldingRegisters(52, 1);

            labelError.Text = error[0].ToString();


            int[] result;
            result = ModbusClient.ReadHoldingRegisters(28, 1);
            textBoxVelocidad.Text = result[0].ToString();*/



        }

        private void resetDriver()
        {
            ModbusClient?.WriteSingleRegister(41, 1);

            Thread.Sleep(200);

            ModbusClient?.WriteSingleRegister(41, 0);
        }

        private void readVelocities()
        {
            // velocidad de vuelta a HOME
            int[] veloHome;
            veloHome = this.ModbusClient.ReadHoldingRegisters(400, 1);

            this.VelMovHOME.Invoke(new Action(() => this.VelMovHOME.Value = (int)veloHome[0]));

            //velocidad modo JOG
            int[] veloJogfast;
            veloJogfast = this.ModbusClient.ReadHoldingRegisters(420, 1);

            this.VelMovJOG.Invoke(new Action(() => this.VelMovJOG.Value = (int)veloJogfast[0]));

            //velocidad del movimiento por velocidad constante
            int[] veloMovVelo;
            veloMovVelo = this.ModbusClient.ReadHoldingRegisters(430, 1);

            this.VelMovVEL.Invoke(new Action(() => this.VelMovVEL.Value = (int)veloMovVelo[0] ));

            // velocidad de movimiento relativo
            int[] veloMovRel;
            veloMovRel = this.ModbusClient.ReadHoldingRegisters(440, 1);

            this.VelMovREL.Invoke(new Action(() => this.VelMovREL.Value = (int)veloMovRel[0]));

            // velocidad del movimiento absoluto
            int[] veloMovAbs;
            veloMovAbs = this.ModbusClient.ReadHoldingRegisters(450, 1);

            this.VelMovABS.Invoke(new Action(() => this.VelMovABS.Value = (int)veloMovAbs[0]));
        }

        private void ReadRegisters()
        {
            // hilo que se encarga de leer los registros necesarios cada 1 segundo

            while (this.shutdown == false)
            {
                
                // ejecutamos un read de las distintas variables imporatntes 

                int[] error;
                error = this.ModbusClient.ReadHoldingRegisters(52, 1);

                this.labelError.Invoke(new Action(() => this.labelError.Text = error[0].ToString()));

                int[] powerEnabled;
                powerEnabled = this.ModbusClient.ReadHoldingRegisters(60, 1);


                if (powerEnabled[0] != 0)
                {
                    this.PowerLabel.Invoke(new Action(() => this.PowerLabel.Text = "ON"));
                    this.PowerLabel.Invoke(new Action(() => this.PowerLabel.BackColor = Color.Green));
                }
                else
                {
                    this.PowerLabel.Invoke(new Action(() => this.PowerLabel.Text = "OFF"));
                    this.PowerLabel.Invoke(new Action(() => this.PowerLabel.BackColor = Color.Red));
                }

                int[] actualpos;
                actualpos = this.ModbusClient.ReadHoldingRegisters(300, 2);
                int actualPositionValue = ((ushort)actualpos[1] << 16) | ((ushort)actualpos[0]);

                // para este servo, 1Rm son 1280000 Pulsos, con una reductora 1:45 y diametro 80mm
                

                this.labelPosicion.Invoke(new Action(() => this.labelPosicion.Text = actualPositionValue.ToString() + "mm"));

                this.readVelocities();

                Thread.Sleep(3000);
            }
        }

        private void stopServo()
        {
            ModbusClient?.WriteSingleRegister(29, 1);
            Thread.Sleep(200);

            ModbusClient?.WriteSingleRegister(29, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModbusClient.Disconnect();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModbusClient?.WriteSingleRegister(28, 1);
            Thread.Sleep(200);

            ModbusClient?.WriteSingleRegister(28, 0);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.resetDriver();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // mandamos un pulso a la variable velocidad 
            ModbusClient?.WriteSingleRegister(35, 1);
            Thread.Sleep(300);

            ModbusClient?.WriteSingleRegister(35, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.stopServo();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void escribeDosRegistros(decimal input, int direccionMemoria)
        {
            int value = Convert.ToInt32(input);

            ushort primeraPalabra = (ushort)(value >> 16);
            ushort segundaPalabra = (ushort)(value & 0xFFFF);

            int[] registros = new int[] { primeraPalabra, segundaPalabra };

            this.ModbusClient.WriteMultipleRegisters(660, registros);
        }

        private void escribeUnRegistro(decimal input, int direccion)
        {
            int value = Convert.ToInt16(input);


            this.ModbusClient.WriteSingleRegister(direccion, value);
        }

        private void textBoxVelocidad_Leave(object sender, EventArgs e)
        {
            // mandamos el nuevo valor de velocidad al PLC, primero dividimos el valor en dos palabras
            this.escribeUnRegistro(this.VelMovVEL.Value, 430);

            //this.escribeDosRegistros(this.inputVelocidad.Value, 660);

        }
    }
}
