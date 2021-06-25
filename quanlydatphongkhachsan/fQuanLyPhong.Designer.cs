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
            this.grbThongtindondatphong = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTrue = new System.Windows.Forms.RadioButton();
            this.rdoFalse = new System.Windows.Forms.RadioButton();
            this.tbDatcoc = new System.Windows.Forms.TextBox();
            this.tbMaphong = new System.Windows.Forms.TextBox();
            this.tbMakhach = new System.Windows.Forms.TextBox();
            this.tbMadondatphong = new System.Windows.Forms.TextBox();
            this.lbMadondatphong = new System.Windows.Forms.Label();
            this.lbMaphong = new System.Windows.Forms.Label();
            this.lbDatcoc = new System.Windows.Forms.Label();
            this.lbMakhach = new System.Windows.Forms.Label();
            this.listPhong = new System.Windows.Forms.ListView();
            this.MaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaLoaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MoTaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listLoaiphong = new System.Windows.Forms.TabPage();
            this.btnXoaLoaiPhong = new System.Windows.Forms.Button();
            this.btnSuaLoaiPhong = new System.Windows.Forms.Button();
            this.btnThemLoaiPhong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.txtSoGiuong = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtMaLoaiPhong = new System.Windows.Forms.TextBox();
            this.listLoaiPhong1 = new System.Windows.Forms.ListView();
            this.MaLoaiPhong1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoaiPhong1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaPhong1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tbPhong.SuspendLayout();
            this.grbPhong.SuspendLayout();
            this.grbThongtindondatphong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.listLoaiphong.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1137, 611);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbPhong
            // 
            this.tbPhong.Controls.Add(this.grbPhong);
            this.tbPhong.Location = new System.Drawing.Point(4, 29);
            this.tbPhong.Margin = new System.Windows.Forms.Padding(2);
            this.tbPhong.Name = "tbPhong";
            this.tbPhong.Padding = new System.Windows.Forms.Padding(2);
            this.tbPhong.Size = new System.Drawing.Size(1129, 578);
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
            this.grbThongtindondatphong.Enter += new System.EventHandler(this.grbThongtindondatphong_Enter);
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // tbMaphong
            // 
            this.tbMaphong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaphong.Location = new System.Drawing.Point(120, 63);
            this.tbMaphong.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaphong.Name = "tbMaphong";
            this.tbMaphong.Size = new System.Drawing.Size(131, 24);
            this.tbMaphong.TabIndex = 15;
            this.tbMaphong.TextChanged += new System.EventHandler(this.tbMaphong_TextChanged);
            // 
            // tbMakhach
            // 
            this.tbMakhach.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMakhach.Location = new System.Drawing.Point(120, 97);
            this.tbMakhach.Margin = new System.Windows.Forms.Padding(2);
            this.tbMakhach.Name = "tbMakhach";
            this.tbMakhach.Size = new System.Drawing.Size(131, 24);
            this.tbMakhach.TabIndex = 14;
            this.tbMakhach.TextChanged += new System.EventHandler(this.tbMakhach_TextChanged);
            // 
            // tbMadondatphong
            // 
            this.tbMadondatphong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMadondatphong.Location = new System.Drawing.Point(120, 27);
            this.tbMadondatphong.Margin = new System.Windows.Forms.Padding(2);
            this.tbMadondatphong.Name = "tbMadondatphong";
            this.tbMadondatphong.Size = new System.Drawing.Size(131, 24);
            this.tbMadondatphong.TabIndex = 13;
            this.tbMadondatphong.TextChanged += new System.EventHandler(this.tbMadondatphong_TextChanged);
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
            this.lbMaphong.Click += new System.EventHandler(this.lbMaphong_Click);
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
            this.lbMakhach.Click += new System.EventHandler(this.lbMakhach_Click);
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
            this.listLoaiphong.Controls.Add(this.btnXoaLoaiPhong);
            this.listLoaiphong.Controls.Add(this.btnSuaLoaiPhong);
            this.listLoaiphong.Controls.Add(this.btnThemLoaiPhong);
            this.listLoaiphong.Controls.Add(this.groupBox2);
            this.listLoaiphong.Controls.Add(this.listLoaiPhong1);
            this.listLoaiphong.Location = new System.Drawing.Point(4, 29);
            this.listLoaiphong.Margin = new System.Windows.Forms.Padding(2);
            this.listLoaiphong.Name = "listLoaiphong";
            this.listLoaiphong.Padding = new System.Windows.Forms.Padding(2);
            this.listLoaiphong.Size = new System.Drawing.Size(1129, 578);
            this.listLoaiphong.TabIndex = 1;
            this.listLoaiphong.Text = "Loại phòng";
            this.listLoaiphong.UseVisualStyleBackColor = true;
            this.listLoaiphong.Click += new System.EventHandler(this.listLoaiphong_Click);
            // 
            // btnXoaLoaiPhong
            // 
            this.btnXoaLoaiPhong.Location = new System.Drawing.Point(974, 283);
            this.btnXoaLoaiPhong.Name = "btnXoaLoaiPhong";
            this.btnXoaLoaiPhong.Size = new System.Drawing.Size(97, 35);
            this.btnXoaLoaiPhong.TabIndex = 4;
            this.btnXoaLoaiPhong.Text = "Xóa";
            this.btnXoaLoaiPhong.UseVisualStyleBackColor = true;
            // 
            // btnSuaLoaiPhong
            // 
            this.btnSuaLoaiPhong.Location = new System.Drawing.Point(790, 283);
            this.btnSuaLoaiPhong.Name = "btnSuaLoaiPhong";
            this.btnSuaLoaiPhong.Size = new System.Drawing.Size(81, 35);
            this.btnSuaLoaiPhong.TabIndex = 3;
            this.btnSuaLoaiPhong.Text = "Sửa";
            this.btnSuaLoaiPhong.UseVisualStyleBackColor = true;
            // 
            // btnThemLoaiPhong
            // 
            this.btnThemLoaiPhong.Location = new System.Drawing.Point(610, 283);
            this.btnThemLoaiPhong.Name = "btnThemLoaiPhong";
            this.btnThemLoaiPhong.Size = new System.Drawing.Size(99, 35);
            this.btnThemLoaiPhong.TabIndex = 2;
            this.btnThemLoaiPhong.Text = "Thêm";
            this.btnThemLoaiPhong.UseVisualStyleBackColor = true;
            this.btnThemLoaiPhong.Click += new System.EventHandler(this.btnThemLoaiPhong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtGiaPhong);
            this.groupBox2.Controls.Add(this.txtSoGiuong);
            this.groupBox2.Controls.Add(this.txtLoaiPhong);
            this.groupBox2.Controls.Add(this.txtMaLoaiPhong);
            this.groupBox2.Location = new System.Drawing.Point(540, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Loại Phòng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số Giường";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại Phòng";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Loại Phòng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(416, 109);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(115, 29);
            this.txtGiaPhong.TabIndex = 3;
            // 
            // txtSoGiuong
            // 
            this.txtSoGiuong.Location = new System.Drawing.Point(416, 42);
            this.txtSoGiuong.Name = "txtSoGiuong";
            this.txtSoGiuong.Size = new System.Drawing.Size(115, 29);
            this.txtSoGiuong.TabIndex = 2;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(120, 109);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(115, 29);
            this.txtLoaiPhong.TabIndex = 1;
            // 
            // txtMaLoaiPhong
            // 
            this.txtMaLoaiPhong.Location = new System.Drawing.Point(120, 42);
            this.txtMaLoaiPhong.Name = "txtMaLoaiPhong";
            this.txtMaLoaiPhong.Size = new System.Drawing.Size(115, 29);
            this.txtMaLoaiPhong.TabIndex = 0;
            // 
            // listLoaiPhong1
            // 
            this.listLoaiPhong1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaLoaiPhong1,
            this.LoaiPhong1,
            this.SoLuong1,
            this.GiaPhong1});
            this.listLoaiPhong1.Location = new System.Drawing.Point(5, 5);
            this.listLoaiPhong1.Name = "listLoaiPhong1";
            this.listLoaiPhong1.Size = new System.Drawing.Size(529, 480);
            this.listLoaiPhong1.TabIndex = 0;
            this.listLoaiPhong1.UseCompatibleStateImageBehavior = false;
            this.listLoaiPhong1.View = System.Windows.Forms.View.Details;
            this.listLoaiPhong1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listLoaiPhong1.Click += new System.EventHandler(this.listLoaiPhong1_Click);
            // 
            // MaLoaiPhong1
            // 
            this.MaLoaiPhong1.Text = "Mã loại phòng";
            this.MaLoaiPhong1.Width = 150;
            // 
            // LoaiPhong1
            // 
            this.LoaiPhong1.Text = "Loại Phòng";
            this.LoaiPhong1.Width = 124;
            // 
            // SoLuong1
            // 
            this.SoLuong1.Text = "Số Lượng";
            this.SoLuong1.Width = 100;
            // 
            // GiaPhong1
            // 
            this.GiaPhong1.Text = "Giá Phòng";
            this.GiaPhong1.Width = 100;
            // 
            // fQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 609);
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
            this.listLoaiphong.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ListView listLoaiPhong1;
        private System.Windows.Forms.ColumnHeader MaLoaiPhong1;
        private System.Windows.Forms.ColumnHeader LoaiPhong1;
        private System.Windows.Forms.ColumnHeader SoLuong1;
        private System.Windows.Forms.ColumnHeader GiaPhong1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaLoaiPhong;
        private System.Windows.Forms.Button btnSuaLoaiPhong;
        private System.Windows.Forms.Button btnThemLoaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.TextBox txtSoGiuong;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.TextBox txtMaLoaiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}