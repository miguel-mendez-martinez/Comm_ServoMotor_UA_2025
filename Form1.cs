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

            this.IPtextbox.Invoke(new Action(() => this.IPtextbox.Text = "192.168.1.50"));

            this.initialiceModbus();

        }

        private void initialiceModbus()
        {
            ModbusClient.IPAddress = this.IPtextbox.Text;
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

        }

        private void resetDriver()
        {
            ModbusClient?.WriteSingleRegister(41, 1);

            Thread.Sleep(200);

            ModbusClient?.WriteSingleRegister(41, 0);
        }

        private void readPositions()
        {
            // posicion absoluta
            int[] posAbs;
            posAbs = this.ModbusClient.ReadHoldingRegisters(470, 1);

            this.PosMovABS.Invoke(new Action(() => this.PosMovABS.Value = (int)posAbs[0]));

            // posicion relativa
            int[] posRel;
            posRel = this.ModbusClient.ReadHoldingRegisters(460, 1);

            this.PosMovREL.Invoke(new Action(() => this.PosMovREL.Value = (int)posRel[0]));
        }

        private void readVelocities()
        {
            // velocidad de vuelta a HOME
            int[] veloHome;
            veloHome = this.ModbusClient.ReadHoldingRegisters(410, 1);

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
                error = this.ModbusClient.ReadHoldingRegisters(1200, 2);
                int errorValue = ((ushort)error[1] << 16) | ((ushort)error[0]);

                this.labelError.Invoke(new Action(() => this.labelError.Text = errorValue.ToString()));

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

                this.readPositions();

                //leemos el modo
                int[] modeHome;
                modeHome = this.ModbusClient.ReadHoldingRegisters(400, 1);

                this.ModeMovHOME.Invoke(new Action(() => this.ModeMovHOME.Value = (int)modeHome[0]));

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
            this.ModbusClient?.WriteSingleRegister(27, 1);
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

        private void PosMovABS_ValueChanged(object sender, EventArgs e)
        {
            this.escribeUnRegistro(this.PosMovABS.Value, 470);
        }

        private void VelMovREL_ValueChanged(object sender, EventArgs e)
        {
            this.escribeUnRegistro(this.VelMovREL.Value, 440);
        }

        private void PosMovREL_ValueChanged(object sender, EventArgs e)
        {
            this.escribeUnRegistro(this.PosMovREL.Value, 460);
        }

        private void VelMovJOG_ValueChanged(object sender, EventArgs e)
        {
            this.escribeUnRegistro(this.VelMovJOG.Value, 420);
        }

        private void VelMovHOME_ValueChanged(object sender, EventArgs e)
        {
            this.escribeUnRegistro(this.VelMovHOME.Value, 410);
        }

        private void ModeMovHOME_ValueChanged(object sender, EventArgs e)
        {
            this.escribeUnRegistro(this.ModeMovHOME.Value, 400);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // mandamos un pulso a la variable velocidad 
            ModbusClient?.WriteSingleRegister(39, 1);
            Thread.Sleep(300);

            ModbusClient?.WriteSingleRegister(39, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.stopServo();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ModbusClient?.WriteSingleRegister(37, 1);
            Thread.Sleep(300);

            ModbusClient?.WriteSingleRegister(37, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.stopServo();
        }


        private void button13_Click(object sender, EventArgs e)
        {
            ModbusClient?.WriteSingleRegister(40, 1);
            Thread.Sleep(300);

            ModbusClient?.WriteSingleRegister(40, 0);
        }

        private void VelMovABS_ValueChanged(object sender, EventArgs e)
        {
            this.escribeUnRegistro(this.VelMovABS.Value, 450);
        }

        private void button11_MouseUp(object sender, MouseEventArgs e)
        {
            ModbusClient?.WriteSingleRegister(31, 0);
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            ModbusClient?.WriteSingleRegister(31, 1);
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            ModbusClient?.WriteSingleRegister(33, 1);
        }

        private void button10_MouseUp(object sender, MouseEventArgs e)
        {
            ModbusClient?.WriteSingleRegister(33, 0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.ModbusClient?.WriteSingleRegister(27, 0);
        }
    }
}
