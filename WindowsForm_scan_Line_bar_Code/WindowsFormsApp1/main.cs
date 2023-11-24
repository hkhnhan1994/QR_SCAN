using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.sql
namespace WindowsFormsApp1
{
    public partial class Scanner : Form
    {
        public static Scanner instance;
        public Label st_com;
        public Label st_baud;
        public Scanner()
        {
            InitializeComponent();
            instance = this;
            st_com = lb_Serial_status_COM;
            st_baud = lb_Serial_status_Baud;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Scanner_Load(object sender, EventArgs e)
        {

        }
    }
}
