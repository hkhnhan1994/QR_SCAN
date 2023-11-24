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
        public Label st_com;
        public Label st_baud;
        public SerialPort serialport;
        string database_path = database_helper.connectionString;
        string serial_data;
        string total_code;
        public static int total_box =0;
        DateTime today = DateTime.Today;
        public Scanner()
        {
            InitializeComponent();
            instance = this;
            st_com = lb_Serial_status_COM;
            st_baud = lb_Serial_status_Baud;
            serialport = SerialCOM;
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
                return this.lb_Serial_status_COM.Text;
            }
            set
            {
                this.lb_Serial_status_COM.Text = value;
            }
        }
        public string Serial_label_Baud
        {
            get
            {
                return this.lb_Serial_status_Baud.Text;
            }
            set
            {
                this.lb_Serial_status_Baud.Text = value;
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
            
            serial_data = serialport.ReadExisting();
            this.Invoke(new EventHandler(processingsteps));
            
        }

        private void processingsteps(object sender, EventArgs e)
        {
            string _prefix = tb_box_id.Text;
            tb_Serial_content.Text = serial_data;
            lb_code_counter.Text = total_code;
            if (cb_prefix.Checked)
            {
                if (!cb_auto.Checked)
                    _prefix = serial_data.Split(tb_prefix.Text.FirstOrDefault())[0];
                else
                {
                    _prefix = serial_data.Split(tb_prefix.Text.FirstOrDefault())[0];
                    tb_prefix.Text = _prefix;
                }
            }

                if (tb_box_id.Text != total_box.ToString("8X") + _prefix)
                    tb_box_id.Text = total_box.ToString("8X") + _prefix;
                string formattedDateTime = today.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                total_code = database_helper.insertcode(tb_box_id.Text, serial_data, formattedDateTime);
                string[] row = new string[] { tb_box_id.Text, serial_data, formattedDateTime };
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "BoxID";
                dataGridView1.Columns[1].Name = "Code";
                dataGridView1.Columns[2].Name = "Timestamp";
                lb_cur_box.Text = Convert.ToString(total_box);
                if (total_box > Convert.ToInt32(tb_number_product.Text))
                {
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.Rows.Clear();
                    //print QRcode
                }

        }
    }
}