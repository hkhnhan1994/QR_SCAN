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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace LineBarScanner
{
    public partial class Scanner : Form
    {
        public static Scanner instance;
        public static Serial_connection sc = new Serial_connection();
        static string rececived_data;
        public Label st_com_scanner;
        public Label st_baud_scanner;
        public Label st_com_printer;
        public Label st_baud_printer;
        public SerialPort serialport_scanner;
        public SerialPort serialport_printer;
        string serial_data;
        string total_code;
        public static int total_box =0;
        string _new_box_name;
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
            DataTable dt = database_helper.get_code("", "");
            show_gridview(dt);
            string latest_box_id = database_helper.get_latest_code();
            string get_number_box_id;
            if (latest_box_id != "")
                get_number_box_id = latest_box_id.Substring(latest_box_id.Length - 4);
            else get_number_box_id = "0";
            total_box = Convert.ToInt32(get_number_box_id,16);
        }
  

        private void serialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Serial_connection sc = new Serial_connection();
             sc.ShowDialog();
        }

        private void SerialCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serial_data = serialport_scanner.ReadExisting();
            rececived_data += serial_data;
            this.Invoke(new EventHandler(enable_timer));
           

        }

        private void enable_timer(object sender, EventArgs e)
        {
            t_received_transform.Start();
        }

        private string generate_QR(string s, DateTime Date)
        {
            //print QRcode
            string qr_code_string;
            if (cb_qr_date.Checked)
                qr_code_string = s + "-" + tb_set_number_code.Text + Date.ToFileTimeUtc().ToString();
            else qr_code_string = s + "-" + tb_set_number_code.Text;
            lb_Serial_printer_content.Text = qr_code_string;
            QRCoder.QRCodeGenerator qrcode = new QRCoder.QRCodeGenerator();
            var qr1 = qrcode.CreateQrCode(qr_code_string, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(qr1);
            pb_qr.Image = code.GetGraphic(10);
            return qr_code_string;
        }
        private void show_gridview(DataTable dt)
        {
            dataGridView1.DataSource = dt;
            int nRowIndex = dataGridView1.Rows.Count - 1;
            int nColumnIndex = 2;

            dataGridView1.Rows[nRowIndex].Selected = true;
            dataGridView1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void processingsteps(object sender, EventArgs e)
        {
            string _prefix = "";
            DateTime today = DateTime.UtcNow;
            string formattedDateTime = today.ToString("dd/MM/yyyy, H:mm");

            lb_Serial_scanner_content.Text = rececived_data;
            lb_code_counter.Text = total_code;
            if (cb_prefix.Checked)
            {
                if (cb_auto.Checked)
                    _prefix = rececived_data.Split(tb_prefix.Text.FirstOrDefault())[0];
                else  _prefix = tb_box_id.Text;
            }
            
            _new_box_name = _prefix + total_box.ToString("X4");
           
            if (database_helper.insertcode(_new_box_name, rececived_data))
            {
                lb_store_status.Text = "stored!";
                // string[] row = new string[] { _new_box_name, serial_data, formattedDateTime };
                // dataGridView1.ColumnCount = 3;
                // dataGridView1.Columns[0].Name = "BoxID";
                // dataGridView1.Columns[1].Name = "Code";
                // dataGridView1.Columns[2].Name = "Timestamp";
                // dataGridView1.Rows.Add(row);
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                DataRow drToAdd = dataTable.NewRow();

                drToAdd["BoxID"] = _new_box_name;
                drToAdd["Code"] = rececived_data;
                drToAdd["Timestamp"] = formattedDateTime;

                dataTable.Rows.Add(drToAdd);
                dataTable.AcceptChanges();
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
                string new_qr = generate_QR(_new_box_name, today);
                if (serialport_printer.IsOpen) serialport_printer.WriteLine(new_qr);
            }
            rececived_data = "";

        }

        private void testScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testcamera tc = new testcamera();
            tc.ShowDialog();
        }

        private void cb_qr_date_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.UtcNow;
            string formattedDateTime = today.ToString("dd MMMM yyyy HH:mm:ss");
            string new_qr = generate_QR(_new_box_name, today);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (database_helper.cleardatabase())
            {
                
                dataGridView1.DataSource =null;
                dataGridView1.Refresh();
                DataTable dt = database_helper.get_code("", "");
                show_gridview(dt);
                total_box = 0;
                lb_cur_box.Text = total_box.ToString();
                lb_code_counter.Text = "0";
            }
        }

        private void t_received_transform_Tick(object sender, EventArgs e)
        {
            t_received_transform.Stop();
            this.Invoke(new EventHandler(processingsteps));
        }
    }
}