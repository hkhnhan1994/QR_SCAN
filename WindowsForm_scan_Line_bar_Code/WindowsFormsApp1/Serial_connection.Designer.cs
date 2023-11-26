namespace LineBarScanner
{
    partial class Serial_connection
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
            System.Windows.Forms.GroupBox groupBox2;
            this.connection_status_printer = new System.Windows.Forms.Label();
            this.cb_Ser_printer = new System.Windows.Forms.ComboBox();
            this.cb_baud_printer = new System.Windows.Forms.ComboBox();
            this.b_connect_printer = new System.Windows.Forms.Button();
            this.cb_Ser_scanner = new System.Windows.Forms.ComboBox();
            this.cb_baud_scanner = new System.Windows.Forms.ComboBox();
            this.b_connect_scanner = new System.Windows.Forms.Button();
            this.SerialCOM = new System.IO.Ports.SerialPort(this.components);
            this.connection_status_scanner = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.connection_status_printer);
            groupBox2.Controls.Add(this.cb_Ser_printer);
            groupBox2.Controls.Add(this.cb_baud_printer);
            groupBox2.Controls.Add(this.b_connect_printer);
            groupBox2.Location = new System.Drawing.Point(14, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(289, 100);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Connect to printer";
            // 
            // connection_status_printer
            // 
            this.connection_status_printer.AutoSize = true;
            this.connection_status_printer.Location = new System.Drawing.Point(15, 63);
            this.connection_status_printer.Name = "connection_status_printer";
            this.connection_status_printer.Size = new System.Drawing.Size(10, 13);
            this.connection_status_printer.TabIndex = 5;
            this.connection_status_printer.Text = "-";
            // 
            // cb_Ser_printer
            // 
            this.cb_Ser_printer.FormattingEnabled = true;
            this.cb_Ser_printer.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "57600",
            "115200",
            "128000 "});
            this.cb_Ser_printer.Location = new System.Drawing.Point(6, 19);
            this.cb_Ser_printer.Name = "cb_Ser_printer";
            this.cb_Ser_printer.Size = new System.Drawing.Size(174, 21);
            this.cb_Ser_printer.TabIndex = 0;
            // 
            // cb_baud_printer
            // 
            this.cb_baud_printer.FormattingEnabled = true;
            this.cb_baud_printer.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "57600",
            "115200",
            "128000 "});
            this.cb_baud_printer.Location = new System.Drawing.Point(189, 19);
            this.cb_baud_printer.Name = "cb_baud_printer";
            this.cb_baud_printer.Size = new System.Drawing.Size(94, 21);
            this.cb_baud_printer.TabIndex = 1;
            // 
            // b_connect_printer
            // 
            this.b_connect_printer.Location = new System.Drawing.Point(189, 57);
            this.b_connect_printer.Name = "b_connect_printer";
            this.b_connect_printer.Size = new System.Drawing.Size(94, 24);
            this.b_connect_printer.TabIndex = 3;
            this.b_connect_printer.Text = "Connect";
            this.b_connect_printer.UseVisualStyleBackColor = true;
            this.b_connect_printer.Click += new System.EventHandler(this.b_connect_printer_Click);
            // 
            // cb_Ser_scanner
            // 
            this.cb_Ser_scanner.FormattingEnabled = true;
            this.cb_Ser_scanner.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "57600",
            "115200",
            "128000 "});
            this.cb_Ser_scanner.Location = new System.Drawing.Point(6, 19);
            this.cb_Ser_scanner.Name = "cb_Ser_scanner";
            this.cb_Ser_scanner.Size = new System.Drawing.Size(174, 21);
            this.cb_Ser_scanner.TabIndex = 0;
            // 
            // cb_baud_scanner
            // 
            this.cb_baud_scanner.FormattingEnabled = true;
            this.cb_baud_scanner.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "57600",
            "115200",
            "128000 "});
            this.cb_baud_scanner.Location = new System.Drawing.Point(189, 19);
            this.cb_baud_scanner.Name = "cb_baud_scanner";
            this.cb_baud_scanner.Size = new System.Drawing.Size(94, 21);
            this.cb_baud_scanner.TabIndex = 1;
            // 
            // b_connect_scanner
            // 
            this.b_connect_scanner.Location = new System.Drawing.Point(189, 57);
            this.b_connect_scanner.Name = "b_connect_scanner";
            this.b_connect_scanner.Size = new System.Drawing.Size(94, 24);
            this.b_connect_scanner.TabIndex = 3;
            this.b_connect_scanner.Text = "Connect";
            this.b_connect_scanner.UseVisualStyleBackColor = true;
            this.b_connect_scanner.Click += new System.EventHandler(this.b_connect_scanner_Click);
            // 
            // connection_status_scanner
            // 
            this.connection_status_scanner.AutoSize = true;
            this.connection_status_scanner.Location = new System.Drawing.Point(15, 63);
            this.connection_status_scanner.Name = "connection_status_scanner";
            this.connection_status_scanner.Size = new System.Drawing.Size(10, 13);
            this.connection_status_scanner.TabIndex = 4;
            this.connection_status_scanner.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Ser_scanner);
            this.groupBox1.Controls.Add(this.cb_baud_scanner);
            this.groupBox1.Controls.Add(this.connection_status_scanner);
            this.groupBox1.Controls.Add(this.b_connect_scanner);
            this.groupBox1.Location = new System.Drawing.Point(14, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect to scanner";
            // 
            // Serial_connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 261);
            this.Controls.Add(groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Serial_connection";
            this.Text = "Connection setting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Serial_connection_FormClosed);
            this.Load += new System.EventHandler(this.Serial_connection_Load);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Ser_scanner;
        private System.Windows.Forms.ComboBox cb_baud_scanner;
        private System.Windows.Forms.Button b_connect_scanner;
        private System.IO.Ports.SerialPort SerialCOM;
        private System.Windows.Forms.Label connection_status_scanner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_Ser_printer;
        private System.Windows.Forms.ComboBox cb_baud_printer;
        private System.Windows.Forms.Button b_connect_printer;
        private System.Windows.Forms.Label connection_status_printer;
    }
}