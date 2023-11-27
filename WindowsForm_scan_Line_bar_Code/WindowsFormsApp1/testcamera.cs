using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using IronBarCode;
using ZXing;
namespace LineBarScanner
{
    public partial class testcamera : Form
    {
        public static testcamera instance;
        public DataGridView show_code_grid;
        public testcamera()
        {
            InitializeComponent();
            instance = this;
            show_code_grid = dataGridView1;
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        string txtQRcode = "";
        private void testcamera_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in filterInfoCollection)
            {
                cb_camera.Items.Add(filterInfo.Name);
                cb_camera.SelectedIndex = 0;
            }
        }

        private void bt_connect_camera_Click(object sender, EventArgs e)
        {
            if(captureDevice == null)
            {
                captureDevice = new VideoCaptureDevice(filterInfoCollection[cb_camera.SelectedIndex].MonikerString);
            }
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
                timer1.Stop();
                bt_connect_camera.Text = "Connect Camera";
            }
            else
            {
                bt_connect_camera.Text = "Disconnect Camera";
                //captureDevice = new VideoCaptureDevice(filterInfoCollection[cb_camera.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                timer1.Start();

            }
            
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            pb_camera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pb_camera.Image!=null)
            {
                ZXing.BarcodeReader barcodeReader = new ZXing.BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pb_camera.Image);
                if (result != null)
                    NewMethod(result);
            }
        }


        private void show_gridview(DataTable dt)
        {
            dt.Columns.Remove("BoxID");
            dt.Columns.Remove("Timestamp");
            dataGridView1.DataSource = dt;
            int nRowIndex = dataGridView1.Rows.Count - 1;
            int nColumnIndex = 0;

            dataGridView1.Rows[nRowIndex].Selected = true;
            dataGridView1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void NewMethod(Result result)
        {
            txtQRcode = result.ToString();
            tb_test_input_camera.Text = txtQRcode;
            DataTable dataTable = database_helper.get_code(tb_test_input_camera.Text, tb_split_code.Text);
            show_gridview(dataTable);
            // timer1.Stop();
            // if (captureDevice.IsRunning) captureDevice.Stop();
        }

        private void bt_check_Click(object sender, EventArgs e)
        {
            //testcamera.instance.show_code_grid.DataSource = dataTable;
            DataTable dataTable = database_helper.get_code(tb_test_input_camera.Text, tb_split_code.Text);
            show_gridview(dataTable);
        }

        private void testcamera_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (captureDevice != null)
            {
                captureDevice.Stop();
                timer1.Stop();
            }
        }
    }
}
