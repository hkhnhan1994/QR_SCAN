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
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cb_camera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (captureDevice.IsRunning) captureDevice.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pb_camera.Image!=null)
            {
                ZXing.BarcodeReader barcodeReader = new ZXing.BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pb_camera.Image);
                if (result != null)
                {
                    txtQRcode = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning) captureDevice.Stop();
                }
            }
        }


        private void tb_test_input_camera_DoubleClick(object sender, EventArgs e)
        {
            database_helper.get_code(tb_test_input_camera.Text, tb_split_code.Text);
           
        }
    }
}
