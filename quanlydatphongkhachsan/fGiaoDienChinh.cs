using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using quanlydatphongkhachsan.Properties;

namespace quanlydatphongkhachsan
{

    public partial class fGiaodienchinh : Form
    {

        SqlConnection conn;
        String constring = Settings.Default["QUANLYDATPHONGKHACHSAN1ConnectionString"].ToString();
        int intTienPhong = 0;

        public fGiaodienchinh()
        {
            InitializeComponent();
            // Kết nối CSDL
            Connection();
            // Đổ dữ liệu ra list
            fillToTable();
            FillToComboboxMaPhong();
            FillToComboboxMaKhach();

            tbTienphong.Text = "0";
            tbConlai.Text = "0";
            txtDatCoc.Text = "0";
            tbThoigianthue.Text = "1";

            
        }

        public void Connection()
        {
            //thực hiện kết nối với sql
            conn = new SqlConnection(constring);
        }

        public void fillToTable()
        {

            String sql = "SELECT * FROM DONDATPHONG";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // xóa tất cả dữ liệu
            listDatPhong.Items.Clear();

            // lặp dữ liệu
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Đổ dữ liệu ở đây từng hàng
                ListViewItem lvi = new ListViewItem(dt.Rows[i]["MaDonDatPhong"].ToString());
                DateTime oDate1 = Convert.ToDateTime(dt.Rows[i]["NgayDatPhong"]);
                DateTime oDate2 = Convert.ToDateTime(dt.Rows[i]["NgayDen"]);
                DateTime oDate3 = Convert.ToDateTime(dt.Rows[i]["NgayDi"]);

                lvi.SubItems.Add(dt.Rows[i]["MaPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["MaKhach"].ToString());
                lvi.SubItems.Add(oDate1.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(oDate2.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(oDate3.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(dt.Rows[i]["ThoiGianThue"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TienPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["DatCoc"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["ConLai"].ToString());
                if (dt.Rows[i]["HuyDon"].ToString().Equals("False"))
                {
                    lvi.SubItems.Add("Chưa hủy");
                }
                else
                {
                    lvi.SubItems.Add("Đã hủy");
                }

                listDatPhong.Items.Add(lvi);
            }

        }

        public void findByDonDatPhong(String donDatPhong)
        {
            String sql = "SELECT * FROM DONDATPHONG WHERE MaDonDatPhong LIKE '%" + donDatPhong + "%'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            listDatPhong.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(dt.Rows[i]["MaDonDatPhong"].ToString());
                DateTime oDate1 = Convert.ToDateTime(dt.Rows[i]["NgayDatPhong"]);
                DateTime oDate2 = Convert.ToDateTime(dt.Rows[i]["NgayDen"]);
                DateTime oDate3 = Convert.ToDateTime(dt.Rows[i]["NgayDi"]);

                lvi.SubItems.Add(dt.Rows[i]["MaPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["MaKhach"].ToString());
                lvi.SubItems.Add(oDate1.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(oDate2.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(oDate3.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(dt.Rows[i]["ThoiGianThue"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TienPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["DatCoc"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["ConLai"].ToString());
                if (dt.Rows[i]["HuyDon"].ToString().Equals("False"))
                {
                    lvi.SubItems.Add("Chưa");
                }
                else
                {
                    lvi.SubItems.Add("Đã hủy");
                }

                listDatPhong.Items.Add(lvi);
            }
        }

        public void FillToForm(String maDonDatPhong)
        {
            String sql = "SELECT * FROM DONDATPHONG WHERE MaDonDatPhong = '" + maDonDatPhong + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            cbbMaPhong.SelectedIndex = cbbMaPhong.Items.IndexOf(dt.Rows[0]["MaPhong"].ToString());
            cbbKhach.SelectedIndex = cbbKhach.Items.IndexOf(dt.Rows[0]["MaKhach"].ToString());
            tbMadondatphong.Text = dt.Rows[0]["MaDonDatPhong"].ToString();
            tbTienphong.Text = dt.Rows[0]["TienPhong"].ToString();
            tbConlai.Text = dt.Rows[0]["ConLai"].ToString();
            DateTime oDate1 = Convert.ToDateTime(dt.Rows[0]["NgayDatPhong"]);
            dateTimePicker1.Value = oDate1;
            DateTime oDate2 = Convert.ToDateTime(dt.Rows[0]["NgayDen"]);
            dateTimePicker2.Value = oDate2;
            DateTime oDate3 = Convert.ToDateTime(dt.Rows[0]["NgayDi"]);
            dateTimePicker3.Value = oDate3;
            tbThoigianthue.Text = dt.Rows[0]["ThoiGianThue"].ToString();
            txtDatCoc.Text = dt.Rows[0]["DatCoc"].ToString();
            if (dt.Rows[0]["HuyDon"].ToString().Equals("False"))
            {
                cbbHuyDon.SelectedIndex = 0;
            }
            else
            {
                cbbHuyDon.SelectedIndex = 1;
            }


        }

        public bool CheckMa(String maDonDatPhong)
        {
            String sql = "SELECT * FROM DONDATPHONG WHERE MaDonDatPhong = '" + maDonDatPhong + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Data có tồn tại?
            if (dt.Rows.Count != 0)
            {
                return true;
            }

            return false;

        }

        public void update(String maDonDatPhong)
        {

            String sql = "UPDATE DONDATPHONG SET MaPhong = '" + cbbMaPhong.SelectedItem.ToString() + "', MaKhach = '" + cbbKhach.SelectedItem.ToString() + "', NgayDatPhong = '" +
                dateTimePicker1.Value + "', NgayDen = '" + dateTimePicker2.Value + "',NgayDi = '" + dateTimePicker3.Value + "', HuyDon = " + cbbHuyDon.SelectedIndex +
                ", ThoiGianThue = '" + tbThoigianthue.Text + "',TienPhong ='" + tbTienphong.Text + "',ConLai ='" + tbConlai.Text
                + "'  WHERE MaDonDatPhong = '" + tbMadondatphong.Text + "'";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            MessageBox.Show("Cập nhật thành công", "Thông báo");

        }


        public void delete(String maDonDatPhong)
        {

            String sql = "DELETE FROM DONDATPHONG WHERE MaDonDatPhong = '" + tbMadondatphong.Text + "'";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            MessageBox.Show("Đã xóa thành công", "Thông báo");

        }

        private void clearForm()
        {
            tbConlai.Text = "";
            tbMadondatphong.Text = "";
            tbThoigianthue.Text = "0";
            tbTienphong.Text = "";
        }

        private void FillToComboboxMaPhong()
        {
            // Kết nối cơ sở dữ liệu (Database)
            Connection();

            String sql = "SELECT MaPhong FROM PHONG";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Kiểm tra xem mã phòng có tồn tại
            if (dt.Rows.Count != 0)
            {
                cbbMaPhong.Items.Clear();
                // Lặp danh sách
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbbMaPhong.Items.Add(dt.Rows[i]["MaPhong"].ToString());
                }
            }
        }

        private void FillToComboboxMaKhach()
        {

            // Kết nối cơ sở dữ liệu (Database)
            Connection();

            String sql = "SELECT MaKhach FROM KHACHHANG";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Kiểm tra xem mã phòng có tồn tại
            if (dt.Rows.Count != 0)
            {
                cbbKhach.Items.Clear();
                // Lặp danh sách
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbbKhach.Items.Add(dt.Rows[i]["MaKhach"].ToString());
                }
            }
        }

        private void TinhNgay()
        {
            if (dateTimePicker2.Value > dateTimePicker3.Value && dateTimePicker2.Value == dateTimePicker3.Value)
            {
                dateTimePicker2.Value = DateTime.Today.AddDays(0);
                dateTimePicker3.Value = DateTime.Today.AddDays(0);
                return;
            }

            int date = (dateTimePicker3.Value - dateTimePicker2.Value).Days;
            date += 1;
            tbThoigianthue.Text = date.ToString();
        }

        private void GetPriceTypeRoom(string maPhong)
        {
            // Kết nối cơ sở dữ liệu (Database)
            Connection();

            String sql = "SELECT GiaPhong FROM LOAIPHONG LP INNER JOIN PHONG P ON P.MaLoaiPhong = LP.MaLoaiPhong WHERE MaPhong = '" + maPhong + "'";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Kiểm tra xem mã phòng có tồn tại
            if (dt.Rows.Count != 0)
            {
                tbTienphong.Text = dt.Rows[0]["GiaPhong"].ToString();
                intTienPhong = int.Parse(dt.Rows[0]["GiaPhong"].ToString());
                tbTienphong.Text = dt.Rows[0]["GiaPhong"].ToString();
            }
        }

        private void fGiaodienchinh_Click(object sender, EventArgs e)
        {

        }

        private void listDatPhong_Click(object sender, EventArgs e)
        {
            // Khi click từng hàng trong bảng
            if (listDatPhong.SelectedItems.Count >= 1)
            {
                ListViewItem item = listDatPhong.SelectedItems[0];
                // Đổ dữ liệu đúng với mã đặt phòng
                FillToForm(item.Text);
            }
        }

        private void btTimFgiaodienchinh_Click(object sender, EventArgs e)
        {
            string maDonDatPhong = tbTimdondatphong.Text;
            findByDonDatPhong(maDonDatPhong);
        }

        private void btSuaFgiaodienchinh_Click(object sender, EventArgs e)
        {
            string strMaDonDatPhong = tbMadondatphong.Text;

            if (strMaDonDatPhong == "")
            {
                MessageBox.Show("Vui lòng nhập mã đơn phòng!", "Thông báo");
            }
            else if (strMaDonDatPhong.Length > 10)
            {
                MessageBox.Show("Mã đơn phòng phải nhỏ hơn 11 ký tự!", "Thông báo");
            }
            else if ((CheckMa(strMaDonDatPhong)) == false)
            {
                MessageBox.Show("Mã đơn đặt phòng không tồn tại", "Thông báo");
            }
            else if (cbbMaPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn mã phòng!", "Thông báo");
            }
            else if (cbbKhach.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn mã khách!", "Thông báo");
            }
            else if (cbbHuyDon.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn hủy đơn phòng!", "Thông báo");
            }
            else
            {
                // Hiển thị thông báo
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa đơn đặt phòng không?", "Thông báo", MessageBoxButtons.YesNo);

                // Nếu chọn YES
                if (dialogResult == DialogResult.Yes)
                {
                    update(strMaDonDatPhong);
                    fillToTable();
                }

            }
        }

        private void btXoaFgiaodienchinh_Click(object sender, EventArgs e)
        {
            string strMaDonPhong = "";
            // Khi click từng hàng trong bảng
            if (listDatPhong.SelectedItems.Count >= 1)
            {
                ListViewItem item = listDatPhong.SelectedItems[0];
                // Đổ dữ liệu đúng với mã đặt phòng
                strMaDonPhong = item.Text;
            }

            // Kiểm tra mã đơn không để trống
            if (strMaDonPhong == "")
            {
                MessageBox.Show("Mã đơn đặt phòng không tồn tại", "Thông báo");
            }
            else if (CheckMa(tbMadondatphong.Text)) // == true
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa đơn đặt phòng không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    delete(strMaDonPhong);
                    clearForm();
                    fillToTable();
                }
            }
            else
            { // false
                MessageBox.Show("Mã đơn không tồn tại", "Thông báo");
            }
        }

        private void btThemFgiaodienchinh_Click(object sender, EventArgs e)
        {
            fThemDonDatPhong ftddp = new fThemDonDatPhong();
            ftddp.ShowDialog();
        }

        private void fGiaodienchinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKS.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.qLKS.PHONG);
            // TODO: This line of code loads data into the 'qUANLYDATPHONGKHACHSAN1DataSet.DONDATPHONG' table. You can move, or remove it, as needed.
            this.dONDATPHONGTableAdapter.Fill(this.qUANLYDATPHONGKHACHSAN1DataSet.DONDATPHONG);

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void quảnLýThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinKhachHang fThongTinKhachHang = new fThongTinKhachHang();
            fThongTinKhachHang.ShowDialog();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyPhong fQuanLyPhong = new fQuanLyPhong();
            fQuanLyPhong.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void listDatPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe thongKe = new ThongKe();
            thongKe.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            fillToTable();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TinhNgay();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            TinhNgay();
        }

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

            string maPhong = cbbMaPhong.SelectedItem.ToString();
            GetPriceTypeRoom(maPhong);

        }

        private void cbbMaPhong_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void txtDatCoc_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value == dateTimePicker2.Value)
            {
                tbThoigianthue.Text = "1";
            }
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                dateTimePicker1.Value = dateTimePicker3.Value;
            }
        }

        private void tbThoigianthue_TextChanged(object sender, EventArgs e)
        {
            if (tbTienphong.Text != "") 
            {
                int thoiGianThue = int.Parse(tbThoigianthue.Text);

                tbTienphong.Text = (thoiGianThue * intTienPhong).ToString();
            }
        }

        private void tbTienphong_TextChanged(object sender, EventArgs e)
        {
            if (tbThoigianthue.Text != "")
            {
                int thoiGianThue = int.Parse(tbThoigianthue.Text);
                tbTienphong.Text = (thoiGianThue * intTienPhong).ToString();

                int tienPhong = int.Parse(tbTienphong.Text);
                double douDatCoc = Math.Round(tienPhong * 0.3, 0);
                txtDatCoc.Text = douDatCoc.ToString();

                tienPhong = int.Parse(tbTienphong.Text);
                int datCoc = int.Parse(txtDatCoc.Text);
                tbConlai.Text = (tienPhong - datCoc).ToString();
            }
        }

        private void tbConlai_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbMaPhong_Click(object sender, EventArgs e)
        {
            FillToComboboxMaPhong();
        }

        private void cbbKhach_Click(object sender, EventArgs e)
        {
            FillToComboboxMaKhach();
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
