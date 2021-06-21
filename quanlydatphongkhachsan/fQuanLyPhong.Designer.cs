namespace quanlydatphongkhachsan
{
    partial class fQuanLyPhong
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPhong = new System.Windows.Forms.TabPage();
            this.tbLoaiphong = new System.Windows.Forms.TabPage();
            this.grbPhong = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tbPhong.SuspendLayout();
            this.grbPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPhong);
            this.tabControl1.Controls.Add(this.tbLoaiphong);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1500, 795);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPhong
            // 
            this.tbPhong.Controls.Add(this.grbPhong);
            this.tbPhong.Location = new System.Drawing.Point(4, 34);
            this.tbPhong.Name = "tbPhong";
            this.tbPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tbPhong.Size = new System.Drawing.Size(1492, 757);
            this.tbPhong.TabIndex = 0;
            this.tbPhong.Text = "Phòng";
            this.tbPhong.UseVisualStyleBackColor = true;
            // 
            // tbLoaiphong
            // 
            this.tbLoaiphong.Location = new System.Drawing.Point(4, 34);
            this.tbLoaiphong.Name = "tbLoaiphong";
            this.tbLoaiphong.Padding = new System.Windows.Forms.Padding(3);
            this.tbLoaiphong.Size = new System.Drawing.Size(1492, 757);
            this.tbLoaiphong.TabIndex = 1;
            this.tbLoaiphong.Text = "Loại phòng";
            this.tbLoaiphong.UseVisualStyleBackColor = true;
            // 
            // grbPhong
            // 
            this.grbPhong.BackColor = System.Drawing.Color.Transparent;
            this.grbPhong.Controls.Add(this.listView1);
            this.grbPhong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbPhong.Location = new System.Drawing.Point(6, 6);
            this.grbPhong.Name = "grbPhong";
            this.grbPhong.Size = new System.Drawing.Size(1480, 494);
            this.grbPhong.TabIndex = 0;
            this.grbPhong.TabStop = false;
            this.grbPhong.Text = "Phòng";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1468, 455);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // fQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 819);
            this.Controls.Add(this.tabControl1);
            this.Name = "fQuanLyPhong";
            this.Text = "fQuanLyPhong";
            this.tabControl1.ResumeLayout(false);
            this.tbPhong.ResumeLayout(false);
            this.grbPhong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPhong;
        private System.Windows.Forms.TabPage tbLoaiphong;
        private System.Windows.Forms.GroupBox grbPhong;
        private System.Windows.Forms.ListView listView1;
    }
}