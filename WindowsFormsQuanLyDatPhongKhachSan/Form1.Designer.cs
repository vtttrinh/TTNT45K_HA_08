namespace WindowsFormsQuanLyDatPhongKhachSan
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbTK = new System.Windows.Forms.Label();
            this.lbMK = new System.Windows.Forms.Label();
            this.btDn = new System.Windows.Forms.Button();
            this.btDK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 22);
            this.textBox2.TabIndex = 1;
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Location = new System.Drawing.Point(80, 67);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(73, 17);
            this.lbTK.TabIndex = 2;
            this.lbTK.Text = "Tai Khoan";
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Location = new System.Drawing.Point(78, 130);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(68, 17);
            this.lbMK.TabIndex = 3;
            this.lbMK.Text = "Mat Khau";
            // 
            // btDn
            // 
            this.btDn.Location = new System.Drawing.Point(185, 190);
            this.btDn.Name = "btDn";
            this.btDn.Size = new System.Drawing.Size(98, 38);
            this.btDn.TabIndex = 4;
            this.btDn.Text = "Dang Nhap";
            this.btDn.UseVisualStyleBackColor = true;
            // 
            // btDK
            // 
            this.btDK.Location = new System.Drawing.Point(325, 190);
            this.btDK.Name = "btDK";
            this.btDK.Size = new System.Drawing.Size(92, 38);
            this.btDK.TabIndex = 5;
            this.btDK.Text = "Dang Ky";
            this.btDK.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 318);
            this.Controls.Add(this.btDK);
            this.Controls.Add(this.btDn);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.lbTK);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Button btDn;
        private System.Windows.Forms.Button btDK;
    }
}

