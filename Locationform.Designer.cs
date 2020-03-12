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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.buttom_exit = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.timeout = new System.Windows.Forms.NumericUpDown();
            this.lb_protocol = new System.Windows.Forms.ListBox();
            this.tb_portnumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_servername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.timeout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Protocol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Timeout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PortNumber";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(659, 197);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 5;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttom_exit
            // 
            this.buttom_exit.Location = new System.Drawing.Point(532, 197);
            this.buttom_exit.Name = "buttom_exit";
            this.buttom_exit.Size = new System.Drawing.Size(75, 23);
            this.buttom_exit.TabIndex = 6;
            this.buttom_exit.Text = "Exit";
            this.buttom_exit.UseVisualStyleBackColor = true;
            this.buttom_exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(20, 34);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 20);
            this.tb_username.TabIndex = 7;
            this.tb_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_location
            // 
            this.tb_location.Location = new System.Drawing.Point(585, 34);
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(100, 20);
            this.tb_location.TabIndex = 8;
            this.tb_location.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // timeout
            // 
            this.timeout.Location = new System.Drawing.Point(20, 130);
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
            this.timeout.Size = new System.Drawing.Size(120, 20);
            this.timeout.TabIndex = 9;
            this.timeout.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lb_protocol
            // 
            this.lb_protocol.FormattingEnabled = true;
            this.lb_protocol.Items.AddRange(new object[] {
            "Whois",
            "-h1",
            "-h9",
            "-h0"});
            this.lb_protocol.Location = new System.Drawing.Point(289, 34);
            this.lb_protocol.Name = "lb_protocol";
            this.lb_protocol.Size = new System.Drawing.Size(125, 30);
            this.lb_protocol.TabIndex = 10;
            // 
            // tb_portnumber
            // 
            this.tb_portnumber.Location = new System.Drawing.Point(302, 130);
            this.tb_portnumber.Name = "tb_portnumber";
            this.tb_portnumber.Size = new System.Drawing.Size(100, 20);
            this.tb_portnumber.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ServerName";
            // 
            // tb_servername
            // 
            this.tb_servername.Location = new System.Drawing.Point(12, 281);
            this.tb_servername.Name = "tb_servername";
            this.tb_servername.Size = new System.Drawing.Size(100, 20);
            this.tb_servername.TabIndex = 13;
            // 
            // Locationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_servername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_portnumber);
            this.Controls.Add(this.lb_protocol);
            this.Controls.Add(this.timeout);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.buttom_exit);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Locationform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locationform";
            ((System.ComponentModel.ISupportInitialize)(this.timeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button buttom_exit;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.NumericUpDown timeout;
        private System.Windows.Forms.ListBox lb_protocol;
        private System.Windows.Forms.TextBox tb_portnumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_servername;
    }
}