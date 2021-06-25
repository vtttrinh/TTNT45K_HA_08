namespace quanlydatphongkhachsan
{
    partial class fLogin
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
            this.btDangnhap = new System.Windows.Forms.Button();
            this.lbDangnhap = new System.Windows.Forms.Label();
            this.lbMatkhau = new System.Windows.Forms.Label();
            this.TB_user = new System.Windows.Forms.TextBox();
            this.TB_pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btDangnhap
            // 
            this.btDangnhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangnhap.Location = new System.Drawing.Point(107, 139);
            this.btDangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.btDangnhap.Name = "btDangnhap";
            this.btDangnhap.Size = new System.Drawing.Size(84, 34);
            this.btDangnhap.TabIndex = 0;
            this.btDangnhap.Text = "Đăng nhập";
            this.btDangnhap.UseVisualStyleBackColor = true;
            this.btDangnhap.Click += new System.EventHandler(this.btDangnhap_Click);
            // 
            // lbDangnhap
            // 
            this.lbDangnhap.AutoSize = true;
            this.lbDangnhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangnhap.Location = new System.Drawing.Point(16, 58);
            this.lbDangnhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDangnhap.Name = "lbDangnhap";
            this.lbDangnhap.Size = new System.Drawing.Size(72, 17);
            this.lbDangnhap.TabIndex = 1;
            this.lbDangnhap.Text = "Đăng nhập";
            // 
            // lbMatkhau
            // 
            this.lbMatkhau.AutoSize = true;
            this.lbMatkhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatkhau.Location = new System.Drawing.Point(23, 101);
            this.lbMatkhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMatkhau.Name = "lbMatkhau";
            this.lbMatkhau.Size = new System.Drawing.Size(64, 17);
            this.lbMatkhau.TabIndex = 2;
            this.lbMatkhau.Text = "Mật khẩu";
            // 
            // TB_user
            // 
            this.TB_user.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_user.Location = new System.Drawing.Point(95, 52);
            this.TB_user.Margin = new System.Windows.Forms.Padding(2);
            this.TB_user.Name = "TB_user";
            this.TB_user.Size = new System.Drawing.Size(174, 24);
            this.TB_user.TabIndex = 3;
            this.TB_user.Text = "vothitotrinh";
            // 
            // TB_pass
            // 
            this.TB_pass.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_pass.Location = new System.Drawing.Point(95, 95);
            this.TB_pass.Margin = new System.Windows.Forms.Padding(2);
            this.TB_pass.Name = "TB_pass";
            this.TB_pass.Size = new System.Drawing.Size(174, 24);
            this.TB_pass.TabIndex = 4;
            this.TB_pass.Text = "vothitotrinh";
            this.TB_pass.UseSystemPasswordChar = true;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 193);
            this.Controls.Add(this.TB_pass);
            this.Controls.Add(this.TB_user);
            this.Controls.Add(this.lbMatkhau);
            this.Controls.Add(this.lbDangnhap);
            this.Controls.Add(this.btDangnhap);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDangnhap;
        private System.Windows.Forms.Label lbDangnhap;
        private System.Windows.Forms.Label lbMatkhau;
        private System.Windows.Forms.TextBox TB_user;
        private System.Windows.Forms.TextBox TB_pass;
    }
}

