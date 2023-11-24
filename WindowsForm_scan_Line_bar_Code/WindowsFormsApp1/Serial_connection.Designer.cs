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
            this.cb_SerialPort = new System.Windows.Forms.ComboBox();
            this.cb_baud = new System.Windows.Forms.ComboBox();
            this.b_connect = new System.Windows.Forms.Button();
            this.SerialCOM = new System.IO.Ports.SerialPort(this.components);
            this.connection_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_SerialPort
            // 
            this.cb_SerialPort.FormattingEnabled = true;
            this.cb_SerialPort.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "57600",
            "115200",
            "128000 "});
            this.cb_SerialPort.Location = new System.Drawing.Point(11, 14);
            this.cb_SerialPort.Name = "cb_SerialPort";
            this.cb_SerialPort.Size = new System.Drawing.Size(174, 21);
            this.cb_SerialPort.TabIndex = 0;
            // 
            // cb_baud
            // 
            this.cb_baud.FormattingEnabled = true;
            this.cb_baud.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "57600",
            "115200",
            "128000 "});
            this.cb_baud.Location = new System.Drawing.Point(218, 14);
            this.cb_baud.Name = "cb_baud";
            this.cb_baud.Size = new System.Drawing.Size(94, 21);
            this.cb_baud.TabIndex = 1;
            // 
            // b_connect
            // 
            this.b_connect.Location = new System.Drawing.Point(218, 42);
            this.b_connect.Name = "b_connect";
            this.b_connect.Size = new System.Drawing.Size(94, 24);
            this.b_connect.TabIndex = 3;
            this.b_connect.Text = "Connect";
            this.b_connect.UseVisualStyleBackColor = true;
            this.b_connect.Click += new System.EventHandler(this.b_connect_Click);
            // 
            // connection_status
            // 
            this.connection_status.AutoSize = true;
            this.connection_status.Location = new System.Drawing.Point(11, 42);
            this.connection_status.Name = "connection_status";
            this.connection_status.Size = new System.Drawing.Size(0, 13);
            this.connection_status.TabIndex = 4;
            // 
            // Serial_connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 82);
            this.Controls.Add(this.connection_status);
            this.Controls.Add(this.b_connect);
            this.Controls.Add(this.cb_baud);
            this.Controls.Add(this.cb_SerialPort);
            this.Name = "Serial_connection";
            this.Text = "Connection setting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Serial_connection_FormClosed);
            this.Load += new System.EventHandler(this.Serial_connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_SerialPort;
        private System.Windows.Forms.ComboBox cb_baud;
        private System.Windows.Forms.Button b_connect;
        private System.IO.Ports.SerialPort SerialCOM;
        private System.Windows.Forms.Label connection_status;
    }
}