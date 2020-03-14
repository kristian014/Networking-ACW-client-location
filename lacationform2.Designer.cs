namespace location
{
    partial class lacationform2
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
            this.BtnLookUp = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLookUp
            // 
            this.BtnLookUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLookUp.Location = new System.Drawing.Point(145, 250);
            this.BtnLookUp.Name = "BtnLookUp";
            this.BtnLookUp.Size = new System.Drawing.Size(230, 38);
            this.BtnLookUp.TabIndex = 0;
            this.BtnLookUp.Text = "LookUp Username";
            this.BtnLookUp.UseVisualStyleBackColor = true;
            this.BtnLookUp.Click += new System.EventHandler(this.BtnLookUp_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(444, 250);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(194, 37);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Update Location";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lacationform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnLookUp);
            this.Name = "lacationform2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lacationform2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLookUp;
        private System.Windows.Forms.Button BtnUpdate;
    }
}