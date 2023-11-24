using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO.Ports;
namespace WindowsFormsApp1
{
    public partial class Serial_connection : Form
    {
        
        public Serial_connection()
        {
            InitializeComponent();

        }

        private void Serial_connection_Load(object sender, EventArgs e)
        {
            cb_baud.Text = "9600";
            cb_SerialPort.DataSource = SerialPort.GetPortNames();

        }

        private void b_connect_Click(object sender, EventArgs e)
        {
            SerialCOM.PortName = cb_SerialPort.Text;
            SerialCOM.BaudRate = Convert.ToInt32( cb_baud.Text);
            SerialCOM.Open();
            if (SerialCOM.IsOpen )
            {
                connection_status.Text = "Connected";

                
            }
            else
                connection_status.Text = "Disconnected";
        }

        private void Serial_connection_FormClosed(object sender, FormClosedEventArgs e)
        {
            Scanner.instance.st_baud.Text = cb_baud.Text;
            Scanner.instance.st_com.Text = cb_SerialPort.Text;
        }
    }
}
