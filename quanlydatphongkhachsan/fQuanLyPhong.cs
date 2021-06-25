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
    public partial class fQuanLyPhong : Form
    {

        SqlConnection conn;
        String constring = "Data Source=ADMIN;Initial Catalog=QUANLYDATPHONGKHACHSAN1;Integrated Security=True";

        public fQuanLyPhong()
        {
            InitializeComponent();
            Connection();
            FillToTable();
            FillToTableLoaiPhong();

            rdoFalse.Select();

        }

        public void Connection()
        {
            //thực hiện kết nối với sql
            conn = new SqlConnection(constring);
        }


        /**
         * Đổ dữ liệu vào list
         */
        public void FillToTableLoaiPhong()
        {

            String sql = "SELECT * FROM LOAIPHONG";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            listLoaiPhong1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(dt.Rows[i]["MaLoaiPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["LoaiPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["SoGiuong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["GiaPhong"].ToString());
                listLoaiPhong1.Items.Add(lvi);
            }

        }

        public void FillToTable()
        {

            String sql = "SELECT * FROM Phong";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            listPhong.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(dt.Rows[i]["MaPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["MaLoaiPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TenPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["MoTaPhong"].ToString());

                if (dt.Rows[i]["TrangThai"].ToString().Equals("False"))
                {
                    lvi.SubItems.Add("Hết phòng");
                }
                else
                {
                    lvi.SubItems.Add("Còn phòng");
                }

                listPhong.Items.Add(lvi);
            }

        }

        public void FillToForm(String MaLoaiPhong)
        {
            String sql = "SELECT * FROM LOAIPHONG WHERE MaLoaiPhong = '" + MaLoaiPhong + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            txtMaLoaiPhong.Text = dt.Rows[0]["MaLoaiPhong"].ToString();
            txtLoaiPhong.Text = dt.Rows[0]["LoaiPhong"].ToString();
            txtSoGiuong.Text = dt.Rows[0]["SoGiuong"].ToString();
            txtGiaPhong.Text = dt.Rows[0]["GiaPhong"].ToString();
            

        }

        private bool checkData(string MaLoaiPhong)
        {
            // Kết nối cơ sở dữ liệu (Database)
            Connection();

            String sql = "SELECT * FROM LOAIPHONG WHERE MaLoaiPhong = '" + MaLoaiPhong + "'";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Kiểm tra xem mã phòng có tồn tại
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        public void insert()
        {
            string strMaLoaiPhong = txtMaLoaiPhong.Text;
            if (checkData(strMaLoaiPhong) == true)
            {
                MessageBox.Show("Mã phong đã tồn tại", "Thông báo");
                return;
            }
            else
            {
                string sql = "INSERT INTO LOAIPHONG (MaLoaiPhong,LoaiPhong,SoGiuong,GiaPhong) VALUES ('" + txtMaLoaiPhong.Text + "','" + txtLoaiPhong.Text + "'," + txtSoGiuong.Text + ",'" + txtGiaPhong.Text + "')";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                conn.Open();
                da.Fill(dt);
                da.Dispose();
                conn.Close();

                MessageBox.Show("Thêm đơn đặt phòng thành công", "Thông báo");
            }
        }



        private void lbMadondatphong_Click(object sender, EventArgs e)
        {

        }

        private void btThemFgiaodienchinh_Click(object sender, EventArgs e)
        {

        }

        private void btSuaFgiaodienchinh_Click(object sender, EventArgs e)
        {

        }

        private void btXoaFgiaodienchinh_Click(object sender, EventArgs e)
        {

        }

        private void btTimFgiaodienchinh_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbMakhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMaphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMadondatphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMaphong_Click(object sender, EventArgs e)
        {

        }

        private void lbMakhach_Click(object sender, EventArgs e)
        {

        }

        private void grbThongtindondatphong_Enter(object sender, EventArgs e)
        {

        }

        private void listLoaiphong_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
                    }

        private void listLoaiPhong1_Click(object sender, EventArgs e)
        {
            // Khi click từng hàng trong bảng
            if (listLoaiPhong1.SelectedItems.Count >= 1)
            {
                ListViewItem item = listLoaiPhong1.SelectedItems[0];
                // Đổ dữ liệu đúng với mã đặt phòng
                FillToForm(item.Text);
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThemLoaiPhong_Click(object sender, EventArgs e)
        {
            insert();
            FillToTableLoaiPhong();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
