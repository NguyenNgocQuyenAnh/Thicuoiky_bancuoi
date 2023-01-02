using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thicuoiky
{
    public partial class frmquanlykh : Form
    {
        KhachHang model = new KhachHang();
        public frmquanlykh()
        {
            InitializeComponent();
            loadDataToGrv();
        }
        void loadDataToGrv()
        {
            try {
                dgvkh.AutoGenerateColumns = false;
                using (QLGiayEntities db = new QLGiayEntities())
                {

                    dgvkh.DataSource = Luu.CreateDataTable<KhachHang>(db.KhachHangs.ToList<KhachHang>());

                }
            }
            catch { }
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvkh_Click(object sender, EventArgs e)
        {
            int i = dgvkh.CurrentRow.Index;
            txtht.Text = dgvkh[2, i].Value.ToString();
            txtdc.Text = dgvkh[3, i].Value.ToString();
            txtsdt.Text = dgvkh[4, i].Value.ToString();
            txtemail.Text = dgvkh[5, i].Value.ToString();
        
            btnadd.Enabled = false;
            btndelete.Enabled = btnupdate.Enabled = true;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            model.hoten = txtht.Text;
            model.diachi = txtdc.Text;
            model.sodt = txtsdt.Text;
            model.email = txtemail.Text;
            model.ngaysinh = Convert.ToDateTime(dtngaysinh.Value);
           
            using (QLGiayEntities db = new QLGiayEntities())
            {
                db.KhachHangs.Add(model);
                db.SaveChanges();
                MessageBox.Show("add thành công", "thông báo");
                txtht.Text = txtdc.Text = txtsdt.Text = txtemail.Text = "";
                loadDataToGrv();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            model.hoten = txtht.Text;
            model.diachi = txtdc.Text;
            model.sodt = txtsdt.Text;
            model.email = txtemail.Text;
            model.ngaysinh =dtngaysinh.Value;

            using (QLGiayEntities db = new QLGiayEntities())
            {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("update thành công", "thông báo");
                    txtht.Text = txtdc.Text = txtsdt.Text = txtemail.Text = "";
                    btnadd.Enabled = false;
                    btndelete.Enabled = btnupdate.Enabled = false;
                    loadDataToGrv();
              
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            model.hoten = txtht.Text;
            model.diachi = txtdc.Text;
            model.sodt = txtsdt.Text;
            model.email = txtemail.Text;
            model.ngaysinh = Convert.ToDateTime(dtngaysinh.Value);

            using (QLGiayEntities db = new QLGiayEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("delete thành công", "thông báo");
                txtht.Text = txtdc.Text = txtsdt.Text = txtemail.Text = "";
                btnadd.Enabled = false;
                loadDataToGrv();
            }

        }
    }
}
