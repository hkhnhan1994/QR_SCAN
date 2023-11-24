namespace transmit_serialport
{
    partial class Form1
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
            this.bt_connect = new System.Windows.Forms.Button();
            this.cb_COM = new System.Windows.Forms.ComboBox();
            this.cb_baud = new System.Windows.Forms.ComboBox();
            this.tb_mess = new System.Windows.Forms.TextBox();
            this.bt_send = new System.Windows.Forms.Button();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.lb_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(160, 32);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(75, 23);
            this.bt_connect.TabIndex = 0;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // cb_COM
            // 
            this.cb_COM.FormattingEnabled = true;
            this.cb_COM.Location = new System.Drawing.Point(13, 32);
            this.cb_COM.Name = "cb_COM";
            this.cb_COM.Size = new System.Drawing.Size(121, 21);
            this.cb_COM.TabIndex = 1;
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
            this.cb_baud.Location = new System.Drawing.Point(13, 71);
            this.cb_baud.Name = "cb_baud";
            this.cb_baud.Size = new System.Drawing.Size(121, 21);
            this.cb_baud.TabIndex = 2;
            // 
            // tb_mess
            // 
            this.tb_mess.Location = new System.Drawing.Point(13, 200);
            this.tb_mess.Name = "tb_mess";
            this.tb_mess.Size = new System.Drawing.Size(206, 20);
            this.tb_mess.TabIndex = 3;
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(13, 171);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(75, 23);
            this.bt_send.TabIndex = 4;
            this.bt_send.Text = "Send";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(166, 79);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(10, 13);
            this.lb_status.TabIndex = 5;
            this.lb_status.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.tb_mess);
            this.Controls.Add(this.cb_baud);
            this.Controls.Add(this.cb_COM);
            this.Controls.Add(this.bt_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.ComboBox cb_COM;
        private System.Windows.Forms.ComboBox cb_baud;
        private System.Windows.Forms.TextBox tb_mess;
        private System.Windows.Forms.Button bt_send;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Label lb_status;
    }
}

