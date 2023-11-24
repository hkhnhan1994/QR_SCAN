namespace LineBarScanner
{
    partial class testcamera
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
            this.pb_camera = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_camera = new System.Windows.Forms.ComboBox();
            this.bt_connect_camera = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tb_test_input_camera = new System.Windows.Forms.TextBox();
            this.tb_split_code = new System.Windows.Forms.TextBox();
            this.lb_split_rule = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_camera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_camera
            // 
            this.pb_camera.Location = new System.Drawing.Point(21, 40);
            this.pb_camera.Name = "pb_camera";
            this.pb_camera.Size = new System.Drawing.Size(440, 381);
            this.pb_camera.TabIndex = 0;
            this.pb_camera.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(467, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(321, 272);
            this.dataGridView1.TabIndex = 1;
            // 
            // cb_camera
            // 
            this.cb_camera.FormattingEnabled = true;
            this.cb_camera.Location = new System.Drawing.Point(21, 13);
            this.cb_camera.Name = "cb_camera";
            this.cb_camera.Size = new System.Drawing.Size(328, 21);
            this.cb_camera.TabIndex = 2;
            // 
            // bt_connect_camera
            // 
            this.bt_connect_camera.Location = new System.Drawing.Point(355, 13);
            this.bt_connect_camera.Name = "bt_connect_camera";
            this.bt_connect_camera.Size = new System.Drawing.Size(106, 23);
            this.bt_connect_camera.TabIndex = 3;
            this.bt_connect_camera.Text = "Connect Camera";
            this.bt_connect_camera.UseVisualStyleBackColor = true;
            this.bt_connect_camera.Click += new System.EventHandler(this.bt_connect_camera_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tb_test_input_camera
            // 
            this.tb_test_input_camera.Location = new System.Drawing.Point(467, 335);
            this.tb_test_input_camera.Name = "tb_test_input_camera";
            this.tb_test_input_camera.Size = new System.Drawing.Size(100, 20);
            this.tb_test_input_camera.TabIndex = 4;
            this.tb_test_input_camera.DoubleClick += new System.EventHandler(this.tb_test_input_camera_DoubleClick);
            // 
            // tb_split_code
            // 
            this.tb_split_code.Location = new System.Drawing.Point(688, 335);
            this.tb_split_code.Name = "tb_split_code";
            this.tb_split_code.Size = new System.Drawing.Size(100, 20);
            this.tb_split_code.TabIndex = 5;
            this.tb_split_code.Text = "-";
            // 
            // lb_split_rule
            // 
            this.lb_split_rule.AutoSize = true;
            this.lb_split_rule.Location = new System.Drawing.Point(637, 338);
            this.lb_split_rule.Name = "lb_split_rule";
            this.lb_split_rule.Size = new System.Drawing.Size(45, 13);
            this.lb_split_rule.TabIndex = 6;
            this.lb_split_rule.Text = "slpit rule";
            // 
            // testcamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_split_rule);
            this.Controls.Add(this.tb_split_code);
            this.Controls.Add(this.tb_test_input_camera);
            this.Controls.Add(this.bt_connect_camera);
            this.Controls.Add(this.cb_camera);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pb_camera);
            this.Name = "testcamera";
            this.Text = "Camera tester";
            this.Load += new System.EventHandler(this.testcamera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_camera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_camera;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_camera;
        private System.Windows.Forms.Button bt_connect_camera;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tb_test_input_camera;
        private System.Windows.Forms.TextBox tb_split_code;
        private System.Windows.Forms.Label lb_split_rule;
    }
}