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
            listLoaiPhong1.FullRowSelect = true;
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
            listPhong.FullRowSelect = true;
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

        public void FillToFormPhong(String MaPhong)
        {
            String sql = "SELECT * FROM PHONG WHERE MaPhong = '" + MaPhong + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            tbMaPhong.Text = dt.Rows[0]["MaPhong"].ToString();
            tbMaTenPhong.Text = dt.Rows[0]["MaLoaiPhong"].ToString();
            tbTenPhong.Text = dt.Rows[0]["TenPhong"].ToString();
            if (dt.Rows[0]["TrangThai"].ToString() == "False")
            {
                rdoFalse.Checked = true;
                rdoTrue.Checked = false;
            }
            else
            {
                rdoTrue.Checked = true;
                rdoFalse.Checked = false;
            }
            tbMoTa.Text = dt.Rows[0]["MoTaPhong"].ToString();
        }


        private bool checkMaPhong(string MaPhong)
        {
            // Kết nối cơ sở dữ liệu (Database)
            Connection();

            String sql = "SELECT * FROM PHONG WHERE MaPhong = '" + MaPhong + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Kiểm tra xem mã phòng có tồn tại
            if (dt.Rows.Count != 0)
            {
                return false;
            }
            return true;
        }

        public void insertPhong()
        {
            string strMaLoaiPhong = tbMaTenPhong.Text;
            string strMaPhong = tbMaPhong.Text;
            if (checkMaPhong(strMaPhong) == false)
            {
                MessageBox.Show("Mã phòng đã tồn tại!", "Thông báo");
                return;
            }
            if (checkData(strMaLoaiPhong) == false)
            {
                MessageBox.Show("Mã loại phòng không tồn tại!", "Thông báo");
                return;
            }
            else
            {
                int trangthai = 0;
                if (rdoFalse.Checked)
                {
                    trangthai = 0;
                }
                else
                {
                    trangthai = 1;
                }
                string sql = "INSERT INTO PHONG (MaPhong, MaLoaiPhong,TenPhong, MoTaPhong, TrangThai) VALUES ('" + tbMaPhong.Text +
                    "','" + tbMaTenPhong.Text + "','" + tbTenPhong.Text + "',N'" + tbMoTa.Text + "'," + trangthai + ")";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
    
                conn.Open();
                da.Fill(dt);
                da.Dispose();
                conn.Close();

                MessageBox.Show("Thêm phòng thành công!", "Thông báo");
                clearphongtxt();
            }

        }

        public void updatePhong()
        {
            string strMaLoaiPhong = tbMaTenPhong.Text;
            string strMaPhong = tbMaPhong.Text;
            if (checkMaPhong(strMaPhong) == true)
            {
                MessageBox.Show("Mã phòng không tồn tại!", "Thông báo");
                return;
            }
            if (checkData(strMaLoaiPhong) == false)
            {
                MessageBox.Show("Mã loại phòng không tồn tại!", "Thông báo");
                return;
            }
            else
            {
                int trangthai = 0;
                if (rdoFalse.Checked)
                {
                    trangthai = 0;
                }
                else
                {
                    trangthai = 1;
                }
                string sql = "UPDATE PHONG SET  MaLoaiPhong = '" + tbMaTenPhong.Text + "', TenPhong = '" + tbTenPhong.Text + 
                    "', MoTaPhong = N'" + tbMoTa.Text + "', TrangThai = " + trangthai + " WHERE MaPhong = '" + tbMaPhong.Text + "'"; ;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                conn.Open();
                da.Fill(dt);
                da.Dispose();
                conn.Close();

                MessageBox.Show("Cập nhật phòng thành công!", "Thông báo");
                clearphongtxt();
            }

        }

        public void clearphongtxt()
        {
            tbMaPhong.Text = "";
            tbMaTenPhong.Text = "";
            tbTenPhong.Text = "";
            tbMoTa.Text = "";
            rdoTrue.Checked = false;

        }

        public bool checkFormPhong()
        {
            if (tbMaPhong.Text.Equals(""))
            {
                MessageBox.Show("Mã phòng không được để trống!", "Thông báo");
                return true;
            }
            if (tbMaTenPhong.Text.Equals(""))
            {
                MessageBox.Show("Mã tên phòng không được để trống!", "Thông báo");
                return true;
            }
            if (tbTenPhong.Text.Equals(""))
            {
                MessageBox.Show("Tên phòng không được để trống!", "Thông báo");
                return true;
            }
            if (tbMoTa.Text.Equals(""))
            {
                MessageBox.Show("Mô tả không được để trống!", "Thông báo");
                return true;
            }
            return false;
        }

        public void deletePhong(String MaPhong)
        {
            string strMaPhong = tbMaPhong.Text;
            if (checkMaPhong(strMaPhong) == true)
            {
                MessageBox.Show("Mã phòng không tồn tại!", "Thông báo");
                return;
            }
            else
            {
                String sql = "DELETE PHONG WHERE MaPhong = '" + tbMaPhong.Text + "'";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                conn.Open();
                da.Fill(dt);
                da.Dispose();
                conn.Close();

                MessageBox.Show("Xóa phòng thành công!", "Thông báo");
            }
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
            int n;
            bool isNumeric = int.TryParse(txtSoGiuong.Text, out n);
            bool isNumeric1 = int.TryParse(txtGiaPhong.Text, out n);
            if (checkData(strMaLoaiPhong) == true)
            {
                MessageBox.Show("Mã phòng đã tồn tại!", "Thông báo");
                return;
            }
            if (!isNumeric)
            {
                MessageBox.Show("Vui lòng nhập số ở số giường!", "Thông báo");
                return;
            }
            if (!isNumeric1)
            {
                MessageBox.Show("Vui lòng nhập số ở giá phòng!", "Thông báo");
                return;
            }
            else
            {
                string sql = "INSERT INTO LOAIPHONG (MaLoaiPhong,LoaiPhong,SoGiuong,GiaPhong) VALUES ('" + txtMaLoaiPhong.Text + "','" + txtLoaiPhong.Text + "'," + txtSoGiuong.Text + "," + txtGiaPhong.Text + ")";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                conn.Open();
                da.Fill(dt);
                da.Dispose();
                conn.Close();

                MessageBox.Show("Thêm loại phòng thành công!", "Thông báo");
                cleartxt();
            }

        }

        public void update(String MaLoaiPhong)
        {
            int n;
            bool isNumeric = int.TryParse(txtSoGiuong.Text, out n);
            bool isNumeric1 = int.TryParse(txtGiaPhong.Text, out n);
            string strMaLoaiPhong = txtMaLoaiPhong.Text;
            if (checkData(strMaLoaiPhong) == false)
            {
                MessageBox.Show("Mã phòng không tồn tại!", "Thông báo");
                return;
            }
            if (!isNumeric)
            {
                MessageBox.Show("Vui lòng nhập số ở số giường!", "Thông báo");
                return;
            }
            if (!isNumeric1)
            {
                MessageBox.Show("Vui lòng nhập số ở giá phòng!", "Thông báo");
                return;
            }
            else
            {
                String sql = "UPDATE LOAIPHONG SET LoaiPhong = '" + txtLoaiPhong.Text + "', SoGiuong = " + txtSoGiuong.Text + ", GiaPhong = '" + txtGiaPhong.Text + "' WHERE MaLoaiPhong = '" + txtMaLoaiPhong.Text + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                conn.Open();
                da.Fill(dt);
                da.Dispose();
                conn.Close();

                MessageBox.Show("Cập nhật loại phòng thành công!", "Thông báo");
                cleartxt();
            }
        }

        public void cleartxt()
        {
            txtLoaiPhong.Text = "";
            txtSoGiuong.Text = "";
            txtGiaPhong.Text = "";
            txtMaLoaiPhong.Text = "";

        }

        public bool checkEmpty()
        {
            if (txtLoaiPhong.Text.Equals(""))
            {
                MessageBox.Show("Loại phòng không được để trống!", "Thông báo");
                return true;
            }
            if (txtSoGiuong.Text.Equals(""))
            {
                MessageBox.Show("Số Giường không được để trống!", "Thông báo");
                return true;
            }
            if (txtGiaPhong.Text.Equals(""))
            {
                MessageBox.Show("Giá phòng không được để trống!", "Thông báo");
                return true;
            }
            if (txtMaLoaiPhong.Text.Equals(""))
            {
                MessageBox.Show("Mã Loại phòng không được để trống!", "Thông báo");
                return true;
            }
            return false;
        }

        public void delete(String MaLoaiPhong)
        {
            string strMaLoaiPhong = txtMaLoaiPhong.Text;
            if (checkData(strMaLoaiPhong) == false)
            {
                MessageBox.Show("Mã phòng không tồn tại!", "Thông báo");
                return;
            }
            else
            {
                String sql = "DELETE LOAIPHONG WHERE MaLoaiPhong = '" + txtMaLoaiPhong.Text + "'";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                conn.Open();
                da.Fill(dt);
                da.Dispose();
                conn.Close();

                MessageBox.Show("Xóa loại phòng thành công!", "Thông báo");
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
            if (checkEmpty() == false)
            {
                insert();
                FillToTableLoaiPhong();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaLoaiPhong_Click(object sender, EventArgs e)
        {
            if (checkEmpty() == false)
            {
                update(txtMaLoaiPhong.Text);
                FillToTableLoaiPhong();
            }

        }

        private void btnXoaLoaiPhong_Click(object sender, EventArgs e)
        {
            string strMaPhong = "";
            // Khi click từng hàng trong bảng
            if (listPhong.SelectedItems.Count >= 1)
            {
                ListViewItem item = listPhong.SelectedItems[0];
                // Đổ dữ liệu đúng với mã đặt phòng
                strMaPhong = item.Text;
            }

            // Kiểm tra mã đơn không để trống
            if (strMaPhong == "")
            {
                MessageBox.Show("Mã phòng không tồn tại", "Thông báo");
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa loại phòng này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                delete(strMaPhong);
                FillToTableLoaiPhong();
                cleartxt();
            }
        }

        private void listPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listPhong_Click(object sender, EventArgs e)
        {
            // Khi click từng hàng trong bảng
            if (listPhong.SelectedItems.Count >= 1)
            {
                ListViewItem item = listPhong.SelectedItems[0];
                // Đổ dữ liệu đúng với mã đặt phòng
                FillToFormPhong(item.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkFormPhong() == false)
            {
                updatePhong();
                FillToTable();
            }
        }

        private void bttThemPhong_Click(object sender, EventArgs e)
        {
            if (checkFormPhong() == false)
            {
                insertPhong();
                FillToTable();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string strMaLoaiPhong = "";
            // Khi click từng hàng trong bảng
            if (listLoaiPhong1.SelectedItems.Count >= 1)
            {
                ListViewItem item = listLoaiPhong1.SelectedItems[0];
                // Đổ dữ liệu đúng với mã đặt phòng
                strMaLoaiPhong = item.Text;
            }

            // Kiểm tra mã đơn không để trống
            if (strMaLoaiPhong == "")
            {
                MessageBox.Show("Mã đơn đặt phòng không tồn tại", "Thông báo");
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa phòng này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                deletePhong(strMaLoaiPhong);
                FillToTable();
                clearphongtxt();
            }
        }

    }
}
