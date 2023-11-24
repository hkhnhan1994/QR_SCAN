using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LineBarScanner
{
    public partial class Scanner : Form
    {
        public static Scanner instance;
        public Label st_com_scanner;
        public Label st_baud_scanner;
        public Label st_com_printer;
        public Label st_baud_printer;
        public SerialPort serialport_scanner;
        public SerialPort serialport_printer;
        string database_path = database_helper.connectionString;
        string serial_data;
        string total_code;
        public static int total_box =0;
        public Scanner()
        {
            InitializeComponent();
            instance = this;
            st_com_scanner = lb_Serial_scanner_status_COM;
            st_baud_scanner = lb_Serial_scanner_status_Baud;
            st_com_printer = lb_Serial_printer_status_COM;
            st_baud_printer = lb_Serial_printer_status_Baud;
            serialport_scanner = Ser_Com_scanner;
            serialport_printer = Ser_Com_printer;
        }
  

        private void serialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serial_connection sc = new Serial_connection();
            sc.ShowDialog();
        }
        public string Serial_label_COM
        {
            get
            {
                return this.lb_Serial_scanner_status_COM.Text;
            }
            set
            {
                this.lb_Serial_scanner_status_COM.Text = value;
            }
        }
        public string Serial_label_Baud
        {
            get
            {
                return this.lb_Serial_scanner_status_Baud.Text;
            }
            set
            {
                this.lb_Serial_scanner_status_Baud.Text = value;
            }
        }
        private void datashow()
        {
            var conn = new SQLiteConnection(database_path);
            conn.Open();
            string show_query = "SELECT * FROM CodeBox ORDER BY Timestamp desc LIMIT 100";
            var ex_show_query = new SQLiteCommand(show_query, conn);
            SQLiteDataReader _read_record = ex_show_query.ExecuteReader();
            while (_read_record.Read())
            {
                dataGridView1.Rows.Insert(0, _read_record.GetString(0), _read_record.GetString(1),
                    _read_record.GetString(2),
                    _read_record.GetString(3));
            }

        }

        private void SerialCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            serial_data = serialport_scanner.ReadExisting();
            this.Invoke(new EventHandler(processingsteps));
            
        }

        private void processingsteps(object sender, EventArgs e)
        {
            string _prefix = "";
            string _new_box_name = "";
            lb_Serial_scanner_content.Text = serial_data;
            lb_code_counter.Text = total_code;
            if (cb_prefix.Checked)
            {
                if (cb_auto.Checked)
                    _prefix = serial_data.Split(tb_prefix.Text.FirstOrDefault())[0];
                else  _prefix = tb_box_id.Text;
            }
            DateTime today = DateTime.UtcNow;
            _new_box_name = _prefix + total_box.ToString("X4");
            string formattedDateTime = today.ToString("dd MMMM yyyy HH:mm:ss");
            if (database_helper.insertcode(_new_box_name, serial_data))
            {
                lb_store_status.Text = "stored!";
                string[] row = new string[] { _new_box_name, serial_data, formattedDateTime };
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "BoxID";
                dataGridView1.Columns[1].Name = "Code";
                dataGridView1.Columns[2].Name = "Timestamp";
                dataGridView1.Rows.Add(row);
            }
            else
            {
                lb_store_status.Text = "failed to add a new code!";
            }
            lb_code_counter.Text = database_helper.count_code(_new_box_name);
                lb_cur_box.Text = Convert.ToString(total_box);
                if (Convert.ToInt32(lb_code_counter.Text) > Convert.ToInt32(tb_set_number_code.Text)-1)
                {
                    total_box += 1;
                    lb_cur_box.Text = total_box.ToString();
                //print QRcode
                string qr_code_string = "";
                if (cb_qr_date.Checked)
                    qr_code_string = _new_box_name + "-" + tb_set_number_code.Text + today.ToFileTimeUtc().ToString();
                else qr_code_string = _new_box_name + "-" + tb_set_number_code.Text;
                lb_Serial_printer_content.Text = qr_code_string;
                QRCoder.QRCodeGenerator qrcode = new QRCoder.QRCodeGenerator();
                var qr1 = qrcode.CreateQrCode(qr_code_string, QRCoder.QRCodeGenerator.ECCLevel.H);
                var code = new QRCoder.QRCode(qr1);
                pb_qr.Image = code.GetGraphic(10);
                if (serialport_printer.IsOpen) serialport_printer.WriteLine(qr_code_string);
            }

        }

        private void testScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testcamera tc = new testcamera();
            tc.ShowDialog();
        }
    }
}