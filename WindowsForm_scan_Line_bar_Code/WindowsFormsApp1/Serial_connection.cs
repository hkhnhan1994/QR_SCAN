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
namespace LineBarScanner
{
    public partial class Serial_connection : Form
    {
        
        public Serial_connection()
        {
            InitializeComponent();

        }

        private void Serial_connection_Load(object sender, EventArgs e)
        {
            cb_baud_scanner.Text = "9600";
            cb_baud_printer.Text = "9600";
            cb_Ser_scanner.DataSource = SerialPort.GetPortNames();
            cb_Ser_printer.DataSource = SerialPort.GetPortNames();
        }

        private void b_connect_scanner_Click(object sender, EventArgs e)
        {
            if (Scanner.instance.serialport_scanner.IsOpen)
            {
                Scanner.instance.serialport_scanner.Close();
                connection_status_scanner.Text = "Disconnected";
                b_connect_scanner.Text = "Connect";
            }
            else
            {
                Scanner.instance.serialport_scanner.PortName = cb_Ser_scanner.Text;
                Scanner.instance.serialport_scanner.BaudRate = Convert.ToInt32(cb_baud_scanner.Text);
                Scanner.instance.serialport_scanner.Open();
                b_connect_scanner.Text = "Disconnect";
                connection_status_scanner.Text = "Connected";
            }
        }



            private void Serial_connection_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Scanner.instance.serialport_printer.IsOpen)
            {
                Scanner.instance.st_baud_printer.Text = cb_baud_printer.Text;
                Scanner.instance.st_com_printer.Text = cb_Ser_printer.Text;
            }
            if (Scanner.instance.serialport_scanner.IsOpen)
            {
                Scanner.instance.st_baud_scanner.Text = cb_baud_scanner.Text;
                Scanner.instance.st_com_scanner.Text = cb_Ser_scanner.Text;
            }
           
           
        }

        private void b_connect_printer_Click(object sender, EventArgs e)
        {
            if (Scanner.instance.serialport_printer.IsOpen)
            {
                Scanner.instance.serialport_printer.Close();
                connection_status_printer.Text = "Disconnected";
                b_connect_printer.Text = "Connect";
            }
            else
            {
                Scanner.instance.serialport_printer.PortName = cb_Ser_printer.Text;
                Scanner.instance.serialport_printer.BaudRate = Convert.ToInt32(cb_baud_printer.Text);
                Scanner.instance.serialport_printer.Open();
                b_connect_printer.Text = "Disconnect";
                connection_status_printer.Text = "Connected";
            }
                
        }


    }
}
