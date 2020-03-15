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
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeout)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(44, 272);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(184, 25);
            label7.TabIndex = 14;
            label7.Text = "Optional Features";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Protocol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(787, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Location";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Timeout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "PortNumber";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(899, 374);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttom_exit
            // 
            this.buttom_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttom_exit.Location = new System.Drawing.Point(749, 374);
            this.buttom_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttom_exit.Name = "buttom_exit";
            this.buttom_exit.Size = new System.Drawing.Size(100, 44);
            this.buttom_exit.TabIndex = 6;
            this.buttom_exit.Text = "Exit";
            this.buttom_exit.UseVisualStyleBackColor = true;
            this.buttom_exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(16, 54);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(245, 26);
            this.tb_username.TabIndex = 7;
            this.tb_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_location
            // 
            this.tb_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_location.Location = new System.Drawing.Point(737, 54);
            this.tb_location.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(260, 26);
            this.tb_location.TabIndex = 8;
            this.tb_location.Visible = false;
            this.tb_location.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // timeout
            // 
            this.timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeout.Location = new System.Drawing.Point(49, 374);
            this.timeout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.timeout.Size = new System.Drawing.Size(160, 26);
            this.timeout.TabIndex = 9;
            this.timeout.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // tb_portnumber
            // 
            this.tb_portnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_portnumber.Location = new System.Drawing.Point(391, 171);
            this.tb_portnumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_portnumber.Name = "tb_portnumber";
            this.tb_portnumber.Size = new System.Drawing.Size(151, 26);
            this.tb_portnumber.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "ServerName";
            // 
            // tb_servername
            // 
            this.tb_servername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_servername.Location = new System.Drawing.Point(16, 171);
            this.tb_servername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_servername.Name = "tb_servername";
            this.tb_servername.Size = new System.Drawing.Size(245, 26);
            this.tb_servername.TabIndex = 13;
            // 
            // cb_protocol
            // 
            this.cb_protocol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_protocol.FormattingEnabled = true;
            this.cb_protocol.Items.AddRange(new object[] {
            "Whois",
            "-h0",
            "-h9",
            "-h1"});
            this.cb_protocol.Location = new System.Drawing.Point(404, 52);
            this.cb_protocol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_protocol.Name = "cb_protocol";
            this.cb_protocol.Size = new System.Drawing.Size(181, 28);
            this.cb_protocol.TabIndex = 15;
            // 
            // Locationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Locationform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locationform";
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
    }
}