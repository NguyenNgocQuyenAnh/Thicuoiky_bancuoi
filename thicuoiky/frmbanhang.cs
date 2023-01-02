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

namespace thicuoiky
{
    
    public partial class frmbanhang : Form
    {
        string chuoiketnoi = "Server =LAPTOP-MB50MFR1 ; Initial Catalog = QLGiay; User ID = sa;" + "Password = Ron25251325";
        SqlConnection con = new SqlConnection();
        int Makh , damua;
        String Tenkh;
        giay model = new giay();
        hoadon hd = new hoadon();
        ChiTietHoaDon ct = new ChiTietHoaDon();
       public frmbanhang()
        {
            InitializeComponent();
            loadDataToGrv();
            loadDataToCmb();
           
        }
        void loadDataToGrv()
        {
            dgvsp.AutoGenerateColumns = false;
            using (QLGiayEntities db = new QLGiayEntities())
            {

                dgvsp.DataSource = Luu.CreateDataTable<giay>(db.giays.ToList<giay>());

            }
        }
        private void ketnoicsdl()
        {
            try
            {
                con = new SqlConnection(chuoiketnoi);
                con.Open();
                // MessageBox.Show("Kết nối thành công");
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại");
            }
        }
        void loadDataToGrvhd()
        {
            string sql = "select MaHoaDon from HoaDon order by MaHoaDon DESC";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvhd.DataSource = dt;
        }
        void loadDataToCmb()
        {
            using (QLGiayEntities db = new QLGiayEntities())
            {
                var list = db.KhachHangs.ToList();
                foreach (var item in list)
                {
                    cmbtenkh.Items.Add(item.hoten);
                    cmbmakh.Items.Add(item.makh);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmquanlykh f = new frmquanlykh();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemhd_Click(object sender, EventArgs e)
        {
            hd.makh = Makh;
            var time = DateTime.Now;
            hd.NgayMua = Convert.ToDateTime(time);
            hd.damua = true;
            using (QLGiayEntities db = new QLGiayEntities())
            {
                db.hoadons.Add(hd);
                db.SaveChanges();
                MessageBox.Show("thêm hóa đơn thành công", "thông báo");
                txtmg.Text = txtg.Text = txtsl.Text = "";
                //loadDataToGrv(Makh.ToString());
            }
        }

        private void dgvsp_Click(object sender, EventArgs e)
        {
            int i = dgvsp.CurrentRow.Index;
            txtmg.Text = dgvsp[1, i].Value.ToString();
            txtg.Text = dgvsp[2, i].Value.ToString();
            txtsl.Text = dgvsp[5, i].Value.ToString();
            txtgia.Text = dgvsp[4, i].Value.ToString();
        }

        private void frmbanhang_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            loadDataToGrvhd();
        }

        private void dgvhd_Click(object sender, EventArgs e)
        {
            int i = dgvhd.CurrentRow.Index;
            txtmhd.Text = dgvhd[0, i].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ct.MaGiay = txtmg.Text;
            ct.SoLuongMua = int.Parse(txtsl.Text);
            ct.MaHoaDon = long.Parse(txtmhd.Text);
            model.gia = long.Parse(txtgia.Text);
            ct.damua = true;
            using (QLGiayEntities db = new QLGiayEntities())
            {
                db.ChiTietHoaDons.Add(ct);
                db.SaveChanges();
                MessageBox.Show("Thanh toán thành công , Số tiền phải trả :" + (int.Parse(txtsl.Text)* long.Parse(txtgia.Text)+"đ"), "thông báo");
                txtmg.Text = txtg.Text = txtsl.Text = "";
            }
        }
        private void cmbtenkh_SelectedIndexChanged(object sender, EventArgs e)
        {
           Makh = int.Parse(cmbmakh.Items[cmbtenkh.SelectedIndex].ToString());

            cmbmakh.Text = Makh.ToString();

            
           // loadDatatoGridView(cmbmakh.Items[cmbtenkh.SelectedIndex].ToString());
        }
    }
}
