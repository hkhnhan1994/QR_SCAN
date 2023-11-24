using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transmit_serialport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            serCOM.PortName = cb_COM.Text;
            serCOM.BaudRate = Convert.ToInt32(cb_baud.Text);
            serCOM.Open();
            if (serCOM.IsOpen)
            {
                lb_status.Text = "Connected";


            }
            else
                lb_status.Text = "Disconnected";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_baud.Text = "9600";
            cb_COM.DataSource = SerialPort.GetPortNames();
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            if (serCOM.IsOpen ) serCOM.WriteLine(tb_mess.Text);
        }
    }
}
