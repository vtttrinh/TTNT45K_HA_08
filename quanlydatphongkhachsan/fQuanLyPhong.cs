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

        private void lbMadondatphong_Click(object sender, EventArgs e)
        {

        }

    }
}
