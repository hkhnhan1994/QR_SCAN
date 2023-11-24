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
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Serial_content = new System.Windows.Forms.TextBox();
            this.lb_Serial_status_Baud = new System.Windows.Forms.Label();
            this.lb_Serial_status_COM = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_cur_box = new System.Windows.Forms.Label();
            this.lb_total_box = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_box_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_auto = new System.Windows.Forms.CheckBox();
            this.cb_prefix = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tb_prefix = new System.Windows.Forms.TextBox();
            this.SerialCOM = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_code_counter = new System.Windows.Forms.Label();
            this.tb_number_product = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialToolStripMenuItem,
            this.cameraToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.serialToolStripMenuItem.Text = "Serial";
            this.serialToolStripMenuItem.Click += new System.EventHandler(this.serialToolStripMenuItem_Click);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Serial_content);
            this.groupBox1.Controls.Add(this.lb_Serial_status_Baud);
            this.groupBox1.Controls.Add(this.lb_Serial_status_COM);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial input";
            // 
            // tb_Serial_content
            // 
            this.tb_Serial_content.Location = new System.Drawing.Point(6, 76);
            this.tb_Serial_content.Name = "tb_Serial_content";
            this.tb_Serial_content.Size = new System.Drawing.Size(140, 20);
            this.tb_Serial_content.TabIndex = 2;
            // 
            // lb_Serial_status_Baud
            // 
            this.lb_Serial_status_Baud.AutoSize = true;
            this.lb_Serial_status_Baud.Location = new System.Drawing.Point(20, 47);
            this.lb_Serial_status_Baud.Name = "lb_Serial_status_Baud";
            this.lb_Serial_status_Baud.Size = new System.Drawing.Size(10, 13);
            this.lb_Serial_status_Baud.TabIndex = 1;
            this.lb_Serial_status_Baud.Text = "-";
            // 
            // lb_Serial_status_COM
            // 
            this.lb_Serial_status_COM.AutoSize = true;
            this.lb_Serial_status_COM.Location = new System.Drawing.Point(20, 26);
            this.lb_Serial_status_COM.Name = "lb_Serial_status_COM";
            this.lb_Serial_status_COM.Size = new System.Drawing.Size(10, 13);
            this.lb_Serial_status_COM.TabIndex = 0;
            this.lb_Serial_status_COM.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.ID,
            this.Code,
            this.Timestamp});
            this.dataGridView1.Location = new System.Drawing.Point(170, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 209);
            this.dataGridView1.TabIndex = 2;
            // 
            // number
            // 
            this.number.HeaderText = "Number";
            this.number.MinimumWidth = 2;
            this.number.Name = "number";
            this.number.Width = 50;
            // 
            // ID
            // 
            this.ID.HeaderText = "Box_ID";
            this.ID.Name = "ID";
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // Timestamp
            // 
            this.Timestamp.HeaderText = "Timestamp";
            this.Timestamp.Name = "Timestamp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_cur_box);
            this.groupBox2.Controls.Add(this.lb_total_box);
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
            // lb_cur_box
            // 
            this.lb_cur_box.AutoSize = true;
            this.lb_cur_box.Location = new System.Drawing.Point(163, 202);
            this.lb_cur_box.Name = "lb_cur_box";
            this.lb_cur_box.Size = new System.Drawing.Size(13, 13);
            this.lb_cur_box.TabIndex = 16;
            this.lb_cur_box.Text = "0";
            // 
            // lb_total_box
            // 
            this.lb_total_box.AutoSize = true;
            this.lb_total_box.Location = new System.Drawing.Point(163, 176);
            this.lb_total_box.Name = "lb_total_box";
            this.lb_total_box.Size = new System.Drawing.Size(13, 13);
            this.lb_total_box.TabIndex = 15;
            this.lb_total_box.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 202);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total";
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Date time include";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tb_prefix
            // 
            this.tb_prefix.Location = new System.Drawing.Point(138, 54);
            this.tb_prefix.Name = "tb_prefix";
            this.tb_prefix.Size = new System.Drawing.Size(57, 20);
            this.tb_prefix.TabIndex = 2;
            // 
            // SerialCOM
            // 
            this.SerialCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialCOM_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tb_number_product);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.tb_prefix);
            this.groupBox3.Controls.Add(this.cb_prefix);
            this.groupBox3.Controls.Add(this.cb_auto);
            this.groupBox3.Location = new System.Drawing.Point(560, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 113);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
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
            // tb_number_product
            // 
            this.tb_number_product.Location = new System.Drawing.Point(138, 87);
            this.tb_number_product.Name = "tb_number_product";
            this.tb_number_product.Size = new System.Drawing.Size(57, 20);
            this.tb_number_product.TabIndex = 6;
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
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 477);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Serial_status_COM;
        private System.Windows.Forms.Label lb_Serial_status_Baud;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_prefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_auto;
        private System.Windows.Forms.CheckBox cb_prefix;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.IO.Ports.SerialPort SerialCOM;
        private System.Windows.Forms.TextBox tb_Serial_content;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_box_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_cur_box;
        private System.Windows.Forms.Label lb_total_box;
        private System.Windows.Forms.Label lb_code_counter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_number_product;
    }
}

