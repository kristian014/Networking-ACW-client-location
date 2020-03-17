namespace location
{
    partial class Locationform
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
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locationform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttom_exit = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.timeout = new System.Windows.Forms.NumericUpDown();
            this.tb_portnumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_servername = new System.Windows.Forms.TextBox();
            this.cb_protocol = new System.Windows.Forms.ComboBox();
            this.Response = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeout)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttom_exit
            // 
            resources.ApplyResources(this.buttom_exit, "buttom_exit");
            this.buttom_exit.Name = "buttom_exit";
            this.buttom_exit.UseVisualStyleBackColor = true;
            this.buttom_exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.tb_username, "tb_username");
            this.tb_username.Name = "tb_username";
            this.tb_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_location
            // 
            this.tb_location.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.tb_location, "tb_location");
            this.tb_location.Name = "tb_location";
            this.tb_location.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // timeout
            // 
            this.timeout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.timeout, "timeout");
            this.timeout.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.timeout.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timeout.Name = "timeout";
            this.timeout.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timeout.ValueChanged += new System.EventHandler(this.timeout_ValueChanged);
            // 
            // tb_portnumber
            // 
            this.tb_portnumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.tb_portnumber, "tb_portnumber");
            this.tb_portnumber.Name = "tb_portnumber";
            this.tb_portnumber.TextChanged += new System.EventHandler(this.tb_portnumber_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tb_servername
            // 
            this.tb_servername.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.tb_servername, "tb_servername");
            this.tb_servername.Name = "tb_servername";
            this.tb_servername.TextChanged += new System.EventHandler(this.tb_servername_TextChanged);
            // 
            // cb_protocol
            // 
            this.cb_protocol.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.cb_protocol, "cb_protocol");
            this.cb_protocol.FormattingEnabled = true;
            this.cb_protocol.Items.AddRange(new object[] {
            resources.GetString("cb_protocol.Items"),
            resources.GetString("cb_protocol.Items1"),
            resources.GetString("cb_protocol.Items2"),
            resources.GetString("cb_protocol.Items3")});
            this.cb_protocol.Name = "cb_protocol";
            this.cb_protocol.SelectedIndexChanged += new System.EventHandler(this.cb_protocol_SelectedIndexChanged);
            // 
            // Response
            // 
            resources.ApplyResources(this.Response, "Response");
            this.Response.Name = "Response";
            this.Response.Click += new System.EventHandler(this.Response_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Locationform
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::location.Properties.Resources.networking1;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.cb_protocol);
            this.Controls.Add(label7);
            this.Controls.Add(this.tb_servername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_portnumber);
            this.Controls.Add(this.timeout);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.buttom_exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Locationform";
            this.Load += new System.EventHandler(this.Locationform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttom_exit;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.NumericUpDown timeout;
        private System.Windows.Forms.TextBox tb_portnumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_servername;
        private System.Windows.Forms.ComboBox cb_protocol;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.Label Response;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}