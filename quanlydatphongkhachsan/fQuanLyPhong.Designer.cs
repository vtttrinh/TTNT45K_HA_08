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
            this.grbPhong = new System.Windows.Forms.GroupBox();
            this.listPhong = new System.Windows.Forms.ListView();
            this.MaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaLoaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MoTaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listLoaiphong = new System.Windows.Forms.TabPage();
            this.grbThongtindondatphong = new System.Windows.Forms.GroupBox();
            this.tbMaphong = new System.Windows.Forms.TextBox();
            this.tbMakhach = new System.Windows.Forms.TextBox();
            this.tbMadondatphong = new System.Windows.Forms.TextBox();
            this.lbMadondatphong = new System.Windows.Forms.Label();
            this.lbMaphong = new System.Windows.Forms.Label();
            this.lbDatcoc = new System.Windows.Forms.Label();
            this.lbMakhach = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFalse = new System.Windows.Forms.RadioButton();
            this.rdoTrue = new System.Windows.Forms.RadioButton();
            this.tbDatcoc = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbPhong.SuspendLayout();
            this.grbPhong.SuspendLayout();
            this.grbThongtindondatphong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPhong);
            this.tabControl1.Controls.Add(this.listLoaiphong);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPhong
            // 
            this.tbPhong.Controls.Add(this.grbPhong);
            this.tbPhong.Location = new System.Drawing.Point(4, 29);
            this.tbPhong.Margin = new System.Windows.Forms.Padding(2);
            this.tbPhong.Name = "tbPhong";
            this.tbPhong.Padding = new System.Windows.Forms.Padding(2);
            this.tbPhong.Size = new System.Drawing.Size(1024, 578);
            this.tbPhong.TabIndex = 0;
            this.tbPhong.Text = "Phòng";
            this.tbPhong.UseVisualStyleBackColor = true;
            // 
            // grbPhong
            // 
            this.grbPhong.BackColor = System.Drawing.Color.Transparent;
            this.grbPhong.Controls.Add(this.grbThongtindondatphong);
            this.grbPhong.Controls.Add(this.listPhong);
            this.grbPhong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbPhong.Location = new System.Drawing.Point(4, 4);
            this.grbPhong.Margin = new System.Windows.Forms.Padding(2);
            this.grbPhong.Name = "grbPhong";
            this.grbPhong.Padding = new System.Windows.Forms.Padding(2);
            this.grbPhong.Size = new System.Drawing.Size(1012, 565);
            this.grbPhong.TabIndex = 0;
            this.grbPhong.TabStop = false;
            this.grbPhong.Text = "Phòng";
            // 
            // listPhong
            // 
            this.listPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaPhong,
            this.MaLoaiPhong,
            this.TenPhong,
            this.MoTaPhong,
            this.TrangThai});
            this.listPhong.Location = new System.Drawing.Point(4, 26);
            this.listPhong.Margin = new System.Windows.Forms.Padding(2);
            this.listPhong.Name = "listPhong";
            this.listPhong.Size = new System.Drawing.Size(1000, 311);
            this.listPhong.TabIndex = 0;
            this.listPhong.UseCompatibleStateImageBehavior = false;
            this.listPhong.View = System.Windows.Forms.View.Details;
            // 
            // MaPhong
            // 
            this.MaPhong.Text = "Mã Phòng";
            this.MaPhong.Width = 120;
            // 
            // MaLoaiPhong
            // 
            this.MaLoaiPhong.Text = "Mã Loại Phòng";
            this.MaLoaiPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaLoaiPhong.Width = 140;
            // 
            // TenPhong
            // 
            this.TenPhong.Text = "Tên Phòng";
            this.TenPhong.Width = 150;
            // 
            // MoTaPhong
            // 
            this.MoTaPhong.Text = "Mô Tả Phòng";
            this.MoTaPhong.Width = 400;
            // 
            // TrangThai
            // 
            this.TrangThai.Text = "Trạng Thái";
            this.TrangThai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TrangThai.Width = 150;
            // 
            // listLoaiphong
            // 
            this.listLoaiphong.Location = new System.Drawing.Point(4, 29);
            this.listLoaiphong.Margin = new System.Windows.Forms.Padding(2);
            this.listLoaiphong.Name = "listLoaiphong";
            this.listLoaiphong.Padding = new System.Windows.Forms.Padding(2);
            this.listLoaiphong.Size = new System.Drawing.Size(1012, 613);
            this.listLoaiphong.TabIndex = 1;
            this.listLoaiphong.Text = "Loại phòng";
            this.listLoaiphong.UseVisualStyleBackColor = true;
            // 
            // grbThongtindondatphong
            // 
            this.grbThongtindondatphong.Controls.Add(this.groupBox1);
            this.grbThongtindondatphong.Controls.Add(this.tbDatcoc);
            this.grbThongtindondatphong.Controls.Add(this.tbMaphong);
            this.grbThongtindondatphong.Controls.Add(this.tbMakhach);
            this.grbThongtindondatphong.Controls.Add(this.tbMadondatphong);
            this.grbThongtindondatphong.Controls.Add(this.lbMadondatphong);
            this.grbThongtindondatphong.Controls.Add(this.lbMaphong);
            this.grbThongtindondatphong.Controls.Add(this.lbDatcoc);
            this.grbThongtindondatphong.Controls.Add(this.lbMakhach);
            this.grbThongtindondatphong.Location = new System.Drawing.Point(6, 348);
            this.grbThongtindondatphong.Margin = new System.Windows.Forms.Padding(2);
            this.grbThongtindondatphong.Name = "grbThongtindondatphong";
            this.grbThongtindondatphong.Padding = new System.Windows.Forms.Padding(2);
            this.grbThongtindondatphong.Size = new System.Drawing.Size(736, 213);
            this.grbThongtindondatphong.TabIndex = 1;
            this.grbThongtindondatphong.TabStop = false;
            this.grbThongtindondatphong.Text = "Thông tin đơn đặt phòng";
            // 
            // tbMaphong
            // 
            this.tbMaphong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaphong.Location = new System.Drawing.Point(120, 63);
            this.tbMaphong.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaphong.Name = "tbMaphong";
            this.tbMaphong.Size = new System.Drawing.Size(131, 24);
            this.tbMaphong.TabIndex = 15;
            // 
            // tbMakhach
            // 
            this.tbMakhach.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMakhach.Location = new System.Drawing.Point(120, 97);
            this.tbMakhach.Margin = new System.Windows.Forms.Padding(2);
            this.tbMakhach.Name = "tbMakhach";
            this.tbMakhach.Size = new System.Drawing.Size(131, 24);
            this.tbMakhach.TabIndex = 14;
            // 
            // tbMadondatphong
            // 
            this.tbMadondatphong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMadondatphong.Location = new System.Drawing.Point(120, 27);
            this.tbMadondatphong.Margin = new System.Windows.Forms.Padding(2);
            this.tbMadondatphong.Name = "tbMadondatphong";
            this.tbMadondatphong.Size = new System.Drawing.Size(131, 24);
            this.tbMadondatphong.TabIndex = 13;
            // 
            // lbMadondatphong
            // 
            this.lbMadondatphong.AutoSize = true;
            this.lbMadondatphong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMadondatphong.Location = new System.Drawing.Point(4, 32);
            this.lbMadondatphong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMadondatphong.Name = "lbMadondatphong";
            this.lbMadondatphong.Size = new System.Drawing.Size(67, 17);
            this.lbMadondatphong.TabIndex = 2;
            this.lbMadondatphong.Text = "Mã phòng";
            this.lbMadondatphong.Click += new System.EventHandler(this.lbMadondatphong_Click);
            // 
            // lbMaphong
            // 
            this.lbMaphong.AutoSize = true;
            this.lbMaphong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaphong.Location = new System.Drawing.Point(4, 68);
            this.lbMaphong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaphong.Name = "lbMaphong";
            this.lbMaphong.Size = new System.Drawing.Size(91, 17);
            this.lbMaphong.TabIndex = 3;
            this.lbMaphong.Text = "Mã loại phòng";
            // 
            // lbDatcoc
            // 
            this.lbDatcoc.AutoSize = true;
            this.lbDatcoc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatcoc.Location = new System.Drawing.Point(300, 27);
            this.lbDatcoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDatcoc.Name = "lbDatcoc";
            this.lbDatcoc.Size = new System.Drawing.Size(82, 17);
            this.lbDatcoc.TabIndex = 11;
            this.lbDatcoc.Text = "Mô tả phòng";
            // 
            // lbMakhach
            // 
            this.lbMakhach.AutoSize = true;
            this.lbMakhach.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMakhach.Location = new System.Drawing.Point(4, 102);
            this.lbMakhach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMakhach.Name = "lbMakhach";
            this.lbMakhach.Size = new System.Drawing.Size(70, 17);
            this.lbMakhach.TabIndex = 4;
            this.lbMakhach.Text = "Tên phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTrue);
            this.groupBox1.Controls.Add(this.rdoFalse);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 79);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng thái";
            // 
            // rdoFalse
            // 
            this.rdoFalse.AutoSize = true;
            this.rdoFalse.Location = new System.Drawing.Point(6, 25);
            this.rdoFalse.Name = "rdoFalse";
            this.rdoFalse.Size = new System.Drawing.Size(90, 23);
            this.rdoFalse.TabIndex = 0;
            this.rdoFalse.TabStop = true;
            this.rdoFalse.Text = "Hết phòng";
            this.rdoFalse.UseVisualStyleBackColor = true;
            // 
            // rdoTrue
            // 
            this.rdoTrue.AutoSize = true;
            this.rdoTrue.Location = new System.Drawing.Point(6, 50);
            this.rdoTrue.Name = "rdoTrue";
            this.rdoTrue.Size = new System.Drawing.Size(94, 23);
            this.rdoTrue.TabIndex = 1;
            this.rdoTrue.TabStop = true;
            this.rdoTrue.Text = "Còn phòng";
            this.rdoTrue.UseVisualStyleBackColor = true;
            // 
            // tbDatcoc
            // 
            this.tbDatcoc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatcoc.Location = new System.Drawing.Point(396, 26);
            this.tbDatcoc.Margin = new System.Windows.Forms.Padding(2);
            this.tbDatcoc.Multiline = true;
            this.tbDatcoc.Name = "tbDatcoc";
            this.tbDatcoc.Size = new System.Drawing.Size(310, 174);
            this.tbDatcoc.TabIndex = 16;
            // 
            // fQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fQuanLyPhong";
            this.Text = "fQuanLyPhong";
            this.tabControl1.ResumeLayout(false);
            this.tbPhong.ResumeLayout(false);
            this.grbPhong.ResumeLayout(false);
            this.grbThongtindondatphong.ResumeLayout(false);
            this.grbThongtindondatphong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPhong;
        private System.Windows.Forms.TabPage listLoaiphong;
        private System.Windows.Forms.GroupBox grbPhong;
        private System.Windows.Forms.ListView listPhong;
        private System.Windows.Forms.ColumnHeader MaPhong;
        private System.Windows.Forms.ColumnHeader MaLoaiPhong;
        private System.Windows.Forms.ColumnHeader TenPhong;
        private System.Windows.Forms.ColumnHeader MoTaPhong;
        private System.Windows.Forms.ColumnHeader TrangThai;
        private System.Windows.Forms.GroupBox grbThongtindondatphong;
        private System.Windows.Forms.TextBox tbMaphong;
        private System.Windows.Forms.TextBox tbMakhach;
        private System.Windows.Forms.TextBox tbMadondatphong;
        private System.Windows.Forms.Label lbMadondatphong;
        private System.Windows.Forms.Label lbMaphong;
        private System.Windows.Forms.Label lbDatcoc;
        private System.Windows.Forms.Label lbMakhach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTrue;
        private System.Windows.Forms.RadioButton rdoFalse;
        private System.Windows.Forms.TextBox tbDatcoc;
    }
}