using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
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


            int[] result;
            result = ModbusClient.ReadHoldingRegisters(25, 1);
            textBoxVelocidad.Text = result[0].ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModbusClient.Disconnect();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModbusClient?.WriteSingleRegister(25, 0);

            int[] result;
            result = ModbusClient.ReadHoldingRegisters(25, 1);
            textBoxVelocidad.Text = result[0].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModbusClient?.WriteSingleCoil(52, true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ModbusClient?.WriteSingleCoil(52, true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.StopPLC();
        }

        private void StopPLC()
        {
            ModbusClient?.WriteSingleCoil(54, true);
        }
    }
}
