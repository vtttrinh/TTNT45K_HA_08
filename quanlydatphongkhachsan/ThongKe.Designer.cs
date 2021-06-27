namespace quanlydatphongkhachsan
{
    partial class ThongKe
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listDonDatHang = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchTime = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTime0 = new System.Windows.Forms.DateTimePicker();
            this.dtpTime1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTime0 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbTime1 = new System.Windows.Forms.ComboBox();
            this.btnSearchPrice = new System.Windows.Forms.Button();
            this.dtpTime2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTime3 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbHuyPhong0 = new System.Windows.Forms.CheckBox();
            this.ckbHuyPhong1 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(988, 599);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listDonDatHang);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(980, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê đơn đặt phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // listDonDatHang
            // 
            this.listDonDatHang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDonDatHang.Location = new System.Drawing.Point(6, 126);
            this.listDonDatHang.Name = "listDonDatHang";
            this.listDonDatHang.Size = new System.Drawing.Size(968, 432);
            this.listDonDatHang.TabIndex = 3;
            this.listDonDatHang.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 119);
            this.panel2.TabIndex = 2;
            // 
            // btnSearchTime
            // 
            this.btnSearchTime.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTime.Location = new System.Drawing.Point(315, 63);
            this.btnSearchTime.Name = "btnSearchTime";
            this.btnSearchTime.Size = new System.Drawing.Size(92, 27);
            this.btnSearchTime.TabIndex = 3;
            this.btnSearchTime.Text = "Tìm kiếm";
            this.btnSearchTime.UseVisualStyleBackColor = true;
            this.btnSearchTime.Click += new System.EventHandler(this.btnSearchTime_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Từ ngày";
            // 
            // dtpTime0
            // 
            this.dtpTime0.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime0.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTime0.Location = new System.Drawing.Point(77, 25);
            this.dtpTime0.Name = "dtpTime0";
            this.dtpTime0.Size = new System.Drawing.Size(120, 27);
            this.dtpTime0.TabIndex = 1;
            // 
            // dtpTime1
            // 
            this.dtpTime1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTime1.Location = new System.Drawing.Point(78, 63);
            this.dtpTime1.Name = "dtpTime1";
            this.dtpTime1.Size = new System.Drawing.Size(119, 27);
            this.dtpTime1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1093, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê khách hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 576);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbHuyPhong0);
            this.groupBox1.Controls.Add(this.cbbTime0);
            this.groupBox1.Controls.Add(this.btnSearchTime);
            this.groupBox1.Controls.Add(this.dtpTime0);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpTime1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 107);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã đơn đặt phòng";
            // 
            // cbbTime0
            // 
            this.cbbTime0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTime0.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTime0.FormattingEnabled = true;
            this.cbbTime0.Items.AddRange(new object[] {
            "Theo ngày",
            "Theo tháng",
            "Theo năm"});
            this.cbbTime0.Location = new System.Drawing.Point(203, 63);
            this.cbbTime0.Name = "cbbTime0";
            this.cbbTime0.Size = new System.Drawing.Size(106, 27);
            this.cbbTime0.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbHuyPhong1);
            this.groupBox2.Controls.Add(this.cbbTime1);
            this.groupBox2.Controls.Add(this.btnSearchPrice);
            this.groupBox2.Controls.Add(this.dtpTime2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpTime3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(441, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 107);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính tổng thời gian, tiền";
            // 
            // cbbTime1
            // 
            this.cbbTime1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTime1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTime1.FormattingEnabled = true;
            this.cbbTime1.Items.AddRange(new object[] {
            "Theo ngày",
            "Theo tháng",
            "Theo năm"});
            this.cbbTime1.Location = new System.Drawing.Point(206, 62);
            this.cbbTime1.Name = "cbbTime1";
            this.cbbTime1.Size = new System.Drawing.Size(106, 27);
            this.cbbTime1.TabIndex = 8;
            // 
            // btnSearchPrice
            // 
            this.btnSearchPrice.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPrice.Location = new System.Drawing.Point(318, 62);
            this.btnSearchPrice.Name = "btnSearchPrice";
            this.btnSearchPrice.Size = new System.Drawing.Size(84, 27);
            this.btnSearchPrice.TabIndex = 3;
            this.btnSearchPrice.Text = "Tìm kiếm";
            this.btnSearchPrice.UseVisualStyleBackColor = true;
            this.btnSearchPrice.Click += new System.EventHandler(this.btnSearchPrice_Click);
            // 
            // dtpTime2
            // 
            this.dtpTime2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTime2.Location = new System.Drawing.Point(77, 25);
            this.dtpTime2.Name = "dtpTime2";
            this.dtpTime2.Size = new System.Drawing.Size(123, 27);
            this.dtpTime2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ ngày";
            // 
            // dtpTime3
            // 
            this.dtpTime3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTime3.Location = new System.Drawing.Point(78, 63);
            this.dtpTime3.Name = "dtpTime3";
            this.dtpTime3.Size = new System.Drawing.Size(122, 27);
            this.dtpTime3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "đến";
            // 
            // ckbHuyPhong0
            // 
            this.ckbHuyPhong0.AutoSize = true;
            this.ckbHuyPhong0.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHuyPhong0.Location = new System.Drawing.Point(203, 26);
            this.ckbHuyPhong0.Name = "ckbHuyPhong0";
            this.ckbHuyPhong0.Size = new System.Drawing.Size(101, 23);
            this.ckbHuyPhong0.TabIndex = 9;
            this.ckbHuyPhong0.Text = "Hủy phòng";
            this.ckbHuyPhong0.UseVisualStyleBackColor = true;
            // 
            // ckbHuyPhong1
            // 
            this.ckbHuyPhong1.AutoSize = true;
            this.ckbHuyPhong1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHuyPhong1.Location = new System.Drawing.Point(206, 25);
            this.ckbHuyPhong1.Name = "ckbHuyPhong1";
            this.ckbHuyPhong1.Size = new System.Drawing.Size(101, 23);
            this.ckbHuyPhong1.TabIndex = 10;
            this.ckbHuyPhong1.Text = "Hủy phòng";
            this.ckbHuyPhong1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(865, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 96);
            this.panel3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 44);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đơn đặt nhiều nhất";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.tabControl1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listDonDatHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTime0;
        private System.Windows.Forms.DateTimePicker dtpTime1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTime0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbTime1;
        private System.Windows.Forms.Button btnSearchPrice;
        private System.Windows.Forms.DateTimePicker dtpTime2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTime3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbHuyPhong1;
        private System.Windows.Forms.CheckBox ckbHuyPhong0;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;

    }
}