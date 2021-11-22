using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlydatphongkhachsan.Properties;

namespace quanlydatphongkhachsan
{
    public partial class fThemDonDatPhong : Form
    {

        SqlConnection conn;
        String constring = Settings.Default["QUANLYDATPHONGKHACHSAN1ConnectionString"].ToString();
        int intTienPhong = 0;

        public fThemDonDatPhong()
        {
            InitializeComponent();

            FillToComboboxMaPhong();
            FillToComboboxMaKhach();

            tbTienphong.Text = "0";
            tbConlai.Text = "0";
            tbDatCoc.Text = "0";
            tbThoigianthue.Text = "1";
        }
        public void Connection()
        {
            //thực hiện kết nối với sql
            conn = new SqlConnection(constring);
        }

        /**
         * Thêm đơn đặt phòng vào Database
         */
        public void insert()
        {
            // Kết nối cơ sở dữ liệu (Database)
            Connection();

            String sql = "INSERT INTO DONDATPHONG (MaDonDatPhong,MaPhong,MaKhach,NgayDatPhong,NgayDen,NgayDi,HuyDon,ThoiGianThue,TienPhong,ConLai, DatCoc)"+
                " VALUES ('" + tbMadondatphong.Text + "','" + cbbMaPhong.SelectedItem.ToString() + "','" + cbbKhach.SelectedItem.ToString() + 
                "','" + dateTimePicker1.Value + "', '" + dateTimePicker2.Value + "','" + dateTimePicker3.Value + "'," + cbbHuyDon.SelectedIndex +
                 ",'" + tbThoigianthue.Text + "','" + tbTienphong.Text + "','" + tbConlai.Text + "','" + tbDatCoc.Text + "')";
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            
        }

        /**
         * Check mã đơn đặt phòng
         */
        public bool CheckMa(String maDonDatPhong)
        {
            Connection();

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
                return false;
            }

            return true;

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

        private void btThemFthemdondatphong_Click(object sender, EventArgs e)
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
            else if (CheckMa(strMaDonDatPhong) == false)
            {
                MessageBox.Show("Mã đơn đặt phòng đã tồn tại!", "Thông báo");
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
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm đơn đặt phòng không?", "Thông báo", MessageBoxButtons.YesNo);

                // Nếu chọn YES
                if (dialogResult == DialogResult.Yes)
                {
                    insert();
                    this.Close();
                }

            }

        }

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maPhong = cbbMaPhong.SelectedItem.ToString();
            GetPriceTypeRoom(maPhong);
        }

        private void tbTienphong_TextChanged(object sender, EventArgs e)
        {
            if (tbThoigianthue.Text != "")
            {
                int thoiGianThue = int.Parse(tbThoigianthue.Text);
                tbTienphong.Text = (thoiGianThue * intTienPhong).ToString();

                int tienPhong = int.Parse(tbTienphong.Text);
                double douDatCoc = Math.Round(tienPhong * 0.3, 0);
                tbDatCoc.Text = douDatCoc.ToString();

                tienPhong = int.Parse(tbTienphong.Text);
                int datCoc = int.Parse(tbDatCoc.Text);
                tbConlai.Text = (tienPhong - datCoc).ToString();
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

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            TinhNgay();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TinhNgay();
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
    }
}
