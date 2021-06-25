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

namespace quanlydatphongkhachsan
{

    public partial class fGiaodienchinh : Form
    {

        SqlConnection conn;
        String constring = "Data Source=ADMIN;Initial Catalog=QUANLYDATPHONGKHACHSAN1;Integrated Security=True";

        public fGiaodienchinh()
        {
            InitializeComponent();
            // Kết nối CSDL
            Connection();
            // Đổ dữ liệu ra list
            fillToTable();

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
                lvi.SubItems.Add(dt.Rows[i]["ConLai"].ToString());
                cbbHuyDon.SelectedValue = 0;
                if (dt.Rows[i]["HuyDon"].ToString().Equals("False"))
                {
                    cbbHuyDon.SelectedValue = 0;
                }
                else
                {
                    cbbHuyDon.SelectedValue = 1;
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
                lvi.SubItems.Add(dt.Rows[i]["ConLai"].ToString());
                if (dt.Rows[i]["HuyDon"].ToString().Equals("False"))
                {
                    lvi.SubItems.Add("Không");
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

            tbMadondatphong.Text = dt.Rows[0]["MaDonDatPhong"].ToString();
            tbMaphong.Text = dt.Rows[0]["MaPhong"].ToString();
            tbMakhach.Text = dt.Rows[0]["MaKhach"].ToString();
            tbTienphong.Text = dt.Rows[0]["TienPhong"].ToString();
            tbConlai.Text = dt.Rows[0]["ConLai"].ToString();
            DateTime oDate1 = Convert.ToDateTime(dt.Rows[0]["NgayDatPhong"]);
            dateTimePicker1.Value = oDate1;
            DateTime oDate2 = Convert.ToDateTime(dt.Rows[0]["NgayDen"]);
            dateTimePicker2.Value = oDate2;
            DateTime oDate3 = Convert.ToDateTime(dt.Rows[0]["NgayDi"]);
            dateTimePicker3.Value = oDate3;
            tbThoigianthue.Text = dt.Rows[0]["ThoiGianThue"].ToString();

            /**
            if (dt.Rows[0]["HuyDon"].ToString().Equals("False"))
            {
                tbHuydon.Text = "Chưa hủy";
            }
            else
            {
                tbHuydon.Text = "Đã hủy";
            }
            */

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
            int intHuyDon = 0;
            
            String sql = "UPDATE DONDATPHONG SET MaPhong = '" + tbMaphong.Text + "', MaKhach = '" + tbMakhach.Text + "', NgayDatPhong = '" +
                dateTimePicker1.Value + "', NgayDen = '" + dateTimePicker2.Value + "',NgayDi = '" + dateTimePicker3.Value + "', HuyDon = " + intHuyDon +
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

        /**
         * Kiểm tra dữ liệu nhập vào 
         * @params Mã phòng và mã khách
         */
        private string checkData(string maPhong, string maKhach)
        {
            // Kết nối cơ sở dữ liệu (Database)
            Connection();

            String sql = "SELECT KH.MaKhach FROM KHACHHANG AS KH, PHONG AS PH WHERE PH.MaPhong = '" + maPhong + "'";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Kiểm tra xem mã phòng có tồn tại
            if (dt.Rows.Count == 0)
            {
                return "Mã phòng không tồn tại!";
            }
            else
            {
                // Lặp danh sách
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // Kiểm tra danh sách có chứa MaKhach
                    if (dt.Rows[i]["MaKhach"].ToString() == maKhach)
                    {
                        return "";
                    }
                }
            }

            return "Mã khách không tồn tại!";
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
            if (strMaDonDatPhong.Equals("")) // Kiểm tra mã đơn không để trống
            {
                MessageBox.Show("Vui lòng nhập mã đơn đặt phòng", "Thông báo");
            }
            else if (CheckMa(strMaDonDatPhong)) // == true
            {
                string strMaPhong = tbMaphong.Text;
                string strMaKhach = tbMakhach.Text;
                string strError = checkData(strMaPhong, strMaKhach);

                // Check orror
                if (strError == "")
                {
                    update(tbMadondatphong.Text);
                    fillToTable();
                }
                else
                {
                    MessageBox.Show(strError, "Thông báo");
                }

            }
            else { // == false
                MessageBox.Show("Mã đơn không tồn tại", "Thông báo");
            }
        }

        private void btXoaFgiaodienchinh_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã đơn không để trống
            if (tbMadondatphong.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mã đơn đặt phòng", "Thông báo");
            }
            else if (CheckMa(tbMadondatphong.Text)) // == true
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa đơn đặt phòng không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    delete(tbMadondatphong.Text);
                    fillToTable();
                }
            }
            else { // false
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
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }
    }
}
