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

namespace quanlydatphongkhachsan
{
    public partial class fThemDonDatPhong : Form
    {

        SqlConnection conn;
        String constring = "Data Source=ADMIN;Initial Catalog=QUANLYDATPHONGKHACHSAN1;Integrated Security=True";

        public fThemDonDatPhong()
        {
            InitializeComponent();

            FillToComboboxMaPhong();
            FillToComboboxMaKhach();
            
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
    }
}
