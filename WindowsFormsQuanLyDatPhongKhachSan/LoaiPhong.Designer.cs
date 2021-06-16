namespace WindowsFormsQuanLyDatPhongKhachSan
{
    partial class LoaiPhong
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
            this.gbTTCTP = new System.Windows.Forms.GroupBox();
            this.btT = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.btS = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbMP = new System.Windows.Forms.Label();
            this.lbDG = new System.Windows.Forms.Label();
            this.lbSG = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbNTTP = new System.Windows.Forms.GroupBox();
            this.gbTTCTP.SuspendLayout();
            this.gbNTTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTTCTP
            // 
            this.gbTTCTP.Controls.Add(this.listView1);
            this.gbTTCTP.Location = new System.Drawing.Point(110, 225);
            this.gbTTCTP.Name = "gbTTCTP";
            this.gbTTCTP.Size = new System.Drawing.Size(518, 193);
            this.gbTTCTP.TabIndex = 0;
            this.gbTTCTP.TabStop = false;
            this.gbTTCTP.Text = "Thong Tin Chi Tiet Phong";
            // 
            // btT
            // 
            this.btT.Location = new System.Drawing.Point(119, 183);
            this.btT.Name = "btT";
            this.btT.Size = new System.Drawing.Size(75, 23);
            this.btT.TabIndex = 1;
            this.btT.Text = "Them";
            this.btT.UseVisualStyleBackColor = true;
            // 
            // btX
            // 
            this.btX.Location = new System.Drawing.Point(275, 183);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(75, 23);
            this.btX.TabIndex = 2;
            this.btX.Text = "Xoa";
            this.btX.UseVisualStyleBackColor = true;
            // 
            // btS
            // 
            this.btS.Location = new System.Drawing.Point(431, 183);
            this.btS.Name = "btS";
            this.btS.Size = new System.Drawing.Size(75, 23);
            this.btS.TabIndex = 3;
            this.btS.Text = "Sua";
            this.btS.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(564, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Thoat";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbMP
            // 
            this.lbMP.AutoSize = true;
            this.lbMP.Location = new System.Drawing.Point(15, 42);
            this.lbMP.Name = "lbMP";
            this.lbMP.Size = new System.Drawing.Size(72, 17);
            this.lbMP.TabIndex = 5;
            this.lbMP.Text = "Ma Phong";
            // 
            // lbDG
            // 
            this.lbDG.AutoSize = true;
            this.lbDG.Location = new System.Drawing.Point(15, 100);
            this.lbDG.Name = "lbDG";
            this.lbDG.Size = new System.Drawing.Size(60, 17);
            this.lbDG.TabIndex = 6;
            this.lbDG.Text = "Don Gia";
            // 
            // lbSG
            // 
            this.lbSG.AutoSize = true;
            this.lbSG.Location = new System.Drawing.Point(254, 42);
            this.lbSG.Name = "lbSG";
            this.lbSG.Size = new System.Drawing.Size(75, 17);
            this.lbSG.TabIndex = 7;
            this.lbSG.Text = "So Giuong";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(335, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 12;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(18, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(479, 154);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // gbNTTP
            // 
            this.gbNTTP.Controls.Add(this.textBox1);
            this.gbNTTP.Controls.Add(this.textBox4);
            this.gbNTTP.Controls.Add(this.lbMP);
            this.gbNTTP.Controls.Add(this.lbDG);
            this.gbNTTP.Controls.Add(this.textBox2);
            this.gbNTTP.Controls.Add(this.lbSG);
            this.gbNTTP.Location = new System.Drawing.Point(110, 25);
            this.gbNTTP.Name = "gbNTTP";
            this.gbNTTP.Size = new System.Drawing.Size(529, 135);
            this.gbNTTP.TabIndex = 13;
            this.gbNTTP.TabStop = false;
            this.gbNTTP.Text = "Nhap Thong Tin Phong";
            // 
            // LoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 452);
            this.Controls.Add(this.gbNTTP);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btS);
            this.Controls.Add(this.btX);
            this.Controls.Add(this.btT);
            this.Controls.Add(this.gbTTCTP);
            this.Name = "LoaiPhong";
            this.Text = "LoaiPhong";
            this.gbTTCTP.ResumeLayout(false);
            this.gbNTTP.ResumeLayout(false);
            this.gbNTTP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTTCTP;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btT;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btS;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbMP;
        private System.Windows.Forms.Label lbDG;
        private System.Windows.Forms.Label lbSG;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox gbNTTP;
    }
}