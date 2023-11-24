namespace LineBarScanner
{
    partial class Scanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testScannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Serial_scanner_content = new System.Windows.Forms.Label();
            this.lb_Serial_scanner_status_Baud = new System.Windows.Forms.Label();
            this.lb_Serial_scanner_status_COM = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pb_qr = new System.Windows.Forms.PictureBox();
            this.lb_cur_box = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_box_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_auto = new System.Windows.Forms.CheckBox();
            this.cb_prefix = new System.Windows.Forms.CheckBox();
            this.cb_qr_date = new System.Windows.Forms.CheckBox();
            this.tb_prefix = new System.Windows.Forms.TextBox();
            this.Ser_Com_scanner = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_set_number_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_code_counter = new System.Windows.Forms.Label();
            this.lb_store_status = new System.Windows.Forms.Label();
            this.Ser_Com_printer = new System.IO.Ports.SerialPort(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_Serial_printer_content = new System.Windows.Forms.Label();
            this.lb_Serial_printer_status_Baud = new System.Windows.Forms.Label();
            this.lb_Serial_printer_status_COM = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_qr)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.testScannerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serialToolStripMenuItem.Text = "Serial";
            this.serialToolStripMenuItem.Click += new System.EventHandler(this.serialToolStripMenuItem_Click);
            // 
            // testScannerToolStripMenuItem
            // 
            this.testScannerToolStripMenuItem.Name = "testScannerToolStripMenuItem";
            this.testScannerToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.testScannerToolStripMenuItem.Text = "TestScanner";
            this.testScannerToolStripMenuItem.Click += new System.EventHandler(this.testScannerToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Serial_scanner_content);
            this.groupBox1.Controls.Add(this.lb_Serial_scanner_status_Baud);
            this.groupBox1.Controls.Add(this.lb_Serial_scanner_status_COM);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial input(scanner)";
            // 
            // lb_Serial_scanner_content
            // 
            this.lb_Serial_scanner_content.AutoSize = true;
            this.lb_Serial_scanner_content.Location = new System.Drawing.Point(20, 83);
            this.lb_Serial_scanner_content.Name = "lb_Serial_scanner_content";
            this.lb_Serial_scanner_content.Size = new System.Drawing.Size(10, 13);
            this.lb_Serial_scanner_content.TabIndex = 2;
            this.lb_Serial_scanner_content.Text = "-";
            // 
            // lb_Serial_scanner_status_Baud
            // 
            this.lb_Serial_scanner_status_Baud.AutoSize = true;
            this.lb_Serial_scanner_status_Baud.Location = new System.Drawing.Point(20, 47);
            this.lb_Serial_scanner_status_Baud.Name = "lb_Serial_scanner_status_Baud";
            this.lb_Serial_scanner_status_Baud.Size = new System.Drawing.Size(10, 13);
            this.lb_Serial_scanner_status_Baud.TabIndex = 1;
            this.lb_Serial_scanner_status_Baud.Text = "-";
            // 
            // lb_Serial_scanner_status_COM
            // 
            this.lb_Serial_scanner_status_COM.AutoSize = true;
            this.lb_Serial_scanner_status_COM.Location = new System.Drawing.Point(20, 26);
            this.lb_Serial_scanner_status_COM.Name = "lb_Serial_scanner_status_COM";
            this.lb_Serial_scanner_status_COM.Size = new System.Drawing.Size(10, 13);
            this.lb_Serial_scanner_status_COM.TabIndex = 0;
            this.lb_Serial_scanner_status_COM.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(170, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 209);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pb_qr);
            this.groupBox2.Controls.Add(this.lb_cur_box);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_box_id);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(560, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 230);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QR Output";
            // 
            // pb_qr
            // 
            this.pb_qr.Location = new System.Drawing.Point(63, 19);
            this.pb_qr.Name = "pb_qr";
            this.pb_qr.Size = new System.Drawing.Size(122, 123);
            this.pb_qr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_qr.TabIndex = 17;
            this.pb_qr.TabStop = false;
            // 
            // lb_cur_box
            // 
            this.lb_cur_box.AutoSize = true;
            this.lb_cur_box.Location = new System.Drawing.Point(163, 177);
            this.lb_cur_box.Name = "lb_cur_box";
            this.lb_cur_box.Size = new System.Drawing.Size(13, 13);
            this.lb_cur_box.TabIndex = 16;
            this.lb_cur_box.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Current";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "BoxID";
            // 
            // tb_box_id
            // 
            this.tb_box_id.Location = new System.Drawing.Point(57, 173);
            this.tb_box_id.Name = "tb_box_id";
            this.tb_box_id.Size = new System.Drawing.Size(57, 20);
            this.tb_box_id.TabIndex = 8;
            this.tb_box_id.Text = "LPX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // cb_auto
            // 
            this.cb_auto.AutoSize = true;
            this.cb_auto.Location = new System.Drawing.Point(63, 57);
            this.cb_auto.Name = "cb_auto";
            this.cb_auto.Size = new System.Drawing.Size(48, 17);
            this.cb_auto.TabIndex = 5;
            this.cb_auto.Text = "Auto";
            this.cb_auto.UseVisualStyleBackColor = true;
            // 
            // cb_prefix
            // 
            this.cb_prefix.AutoSize = true;
            this.cb_prefix.Location = new System.Drawing.Point(7, 57);
            this.cb_prefix.Name = "cb_prefix";
            this.cb_prefix.Size = new System.Drawing.Size(55, 17);
            this.cb_prefix.TabIndex = 4;
            this.cb_prefix.Text = "PreFix";
            this.cb_prefix.UseVisualStyleBackColor = true;
            // 
            // cb_qr_date
            // 
            this.cb_qr_date.AutoSize = true;
            this.cb_qr_date.Location = new System.Drawing.Point(7, 31);
            this.cb_qr_date.Name = "cb_qr_date";
            this.cb_qr_date.Size = new System.Drawing.Size(108, 17);
            this.cb_qr_date.TabIndex = 3;
            this.cb_qr_date.Text = "Date time include";
            this.cb_qr_date.UseVisualStyleBackColor = true;
            // 
            // tb_prefix
            // 
            this.tb_prefix.Location = new System.Drawing.Point(138, 54);
            this.tb_prefix.Name = "tb_prefix";
            this.tb_prefix.Size = new System.Drawing.Size(57, 20);
            this.tb_prefix.TabIndex = 2;
            this.tb_prefix.Text = "-";
            // 
            // Ser_Com_scanner
            // 
            this.Ser_Com_scanner.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialCOM_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tb_set_number_code);
            this.groupBox3.Controls.Add(this.cb_qr_date);
            this.groupBox3.Controls.Add(this.tb_prefix);
            this.groupBox3.Controls.Add(this.cb_prefix);
            this.groupBox3.Controls.Add(this.cb_auto);
            this.groupBox3.Location = new System.Drawing.Point(560, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 113);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Setting QRCode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Number of products/box";
            // 
            // tb_set_number_code
            // 
            this.tb_set_number_code.Location = new System.Drawing.Point(138, 87);
            this.tb_set_number_code.Name = "tb_set_number_code";
            this.tb_set_number_code.Size = new System.Drawing.Size(57, 20);
            this.tb_set_number_code.TabIndex = 6;
            this.tb_set_number_code.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Code Counter";
            // 
            // lb_code_counter
            // 
            this.lb_code_counter.AutoSize = true;
            this.lb_code_counter.Location = new System.Drawing.Point(530, 244);
            this.lb_code_counter.Name = "lb_code_counter";
            this.lb_code_counter.Size = new System.Drawing.Size(13, 13);
            this.lb_code_counter.TabIndex = 14;
            this.lb_code_counter.Text = "0";
            // 
            // lb_store_status
            // 
            this.lb_store_status.AutoSize = true;
            this.lb_store_status.Location = new System.Drawing.Point(167, 244);
            this.lb_store_status.Name = "lb_store_status";
            this.lb_store_status.Size = new System.Drawing.Size(10, 13);
            this.lb_store_status.TabIndex = 15;
            this.lb_store_status.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_Serial_printer_content);
            this.groupBox4.Controls.Add(this.lb_Serial_printer_status_Baud);
            this.groupBox4.Controls.Add(this.lb_Serial_printer_status_COM);
            this.groupBox4.Location = new System.Drawing.Point(12, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 110);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serial output(printer)";
            // 
            // lb_Serial_printer_content
            // 
            this.lb_Serial_printer_content.AutoSize = true;
            this.lb_Serial_printer_content.Location = new System.Drawing.Point(20, 83);
            this.lb_Serial_printer_content.Name = "lb_Serial_printer_content";
            this.lb_Serial_printer_content.Size = new System.Drawing.Size(10, 13);
            this.lb_Serial_printer_content.TabIndex = 2;
            this.lb_Serial_printer_content.Text = "-";
            // 
            // lb_Serial_printer_status_Baud
            // 
            this.lb_Serial_printer_status_Baud.AutoSize = true;
            this.lb_Serial_printer_status_Baud.Location = new System.Drawing.Point(20, 47);
            this.lb_Serial_printer_status_Baud.Name = "lb_Serial_printer_status_Baud";
            this.lb_Serial_printer_status_Baud.Size = new System.Drawing.Size(10, 13);
            this.lb_Serial_printer_status_Baud.TabIndex = 1;
            this.lb_Serial_printer_status_Baud.Text = "-";
            // 
            // lb_Serial_printer_status_COM
            // 
            this.lb_Serial_printer_status_COM.AutoSize = true;
            this.lb_Serial_printer_status_COM.Location = new System.Drawing.Point(20, 26);
            this.lb_Serial_printer_status_COM.Name = "lb_Serial_printer_status_COM";
            this.lb_Serial_printer_status_COM.Size = new System.Drawing.Size(10, 13);
            this.lb_Serial_printer_status_COM.TabIndex = 0;
            this.lb_Serial_printer_status_COM.Text = "-";
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 388);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lb_store_status);
            this.Controls.Add(this.lb_code_counter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Scanner";
            this.Text = "Scanner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_qr)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Serial_scanner_status_COM;
        private System.Windows.Forms.Label lb_Serial_scanner_status_Baud;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_prefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_auto;
        private System.Windows.Forms.CheckBox cb_prefix;
        private System.Windows.Forms.CheckBox cb_qr_date;
        private System.IO.Ports.SerialPort Ser_Com_scanner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_box_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_cur_box;
        private System.Windows.Forms.Label lb_code_counter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_set_number_code;
        private System.Windows.Forms.Label lb_store_status;
        private System.Windows.Forms.PictureBox pb_qr;
        private System.IO.Ports.SerialPort Ser_Com_printer;
        private System.Windows.Forms.Label lb_Serial_scanner_content;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_Serial_printer_content;
        private System.Windows.Forms.Label lb_Serial_printer_status_Baud;
        private System.Windows.Forms.Label lb_Serial_printer_status_COM;
        private System.Windows.Forms.ToolStripMenuItem testScannerToolStripMenuItem;
    }
}

