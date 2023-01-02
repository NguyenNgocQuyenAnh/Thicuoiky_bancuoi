using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thicuoiky
{
   
    public partial class frmqlnv : Form
    {
        NhanVien model = new NhanVien();
        public frmqlnv()
        {
            InitializeComponent();
            loadDataToGrv();
        }
        void loadDataToGrv()
        {
            try
            {
                dgvnv.AutoGenerateColumns = false;
                using (QLGiayEntities db = new QLGiayEntities())
                {

                    dgvnv.DataSource = Luu.CreateDataTable<NhanVien>(db.NhanViens.ToList<NhanVien>());

                }
            }
            catch { }
        }

        private void dgvnv_Click(object sender, EventArgs e)
        {

            int i = dgvnv.CurrentRow.Index;
            txtht.Text = dgvnv[2, i].Value.ToString();
            txtdc.Text = dgvnv[3, i].Value.ToString();
            txtsdt.Text = dgvnv[4, i].Value.ToString();
            txtemail.Text = dgvnv[5, i].Value.ToString();
            txtun.Text = dgvnv[6, i].Value.ToString();
            txtpass.Text = dgvnv[7, i].Value.ToString();
            btnadd.Enabled = false;
            btndelete.Enabled = btnupdate.Enabled = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            model.HoTen = txtht.Text;
            model.DiaChi = txtdc.Text;
            model.SDT = txtsdt.Text;
            model.Email = txtemail.Text;
            model.NgaySinh = Convert.ToDateTime(dtngaysinhnv.Value);
            model.username = txtun.Text;
            model.pass = txtpass.Text;
            using (QLGiayEntities db = new QLGiayEntities())
            {
                db.NhanViens.Add(model);
                db.SaveChanges();
                MessageBox.Show("add thành công", "thông báo");
                txtht.Text = txtdc.Text = txtsdt.Text = txtemail.Text= txtun.Text = txtpass.Text = "";
                loadDataToGrv();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            model.HoTen = txtht.Text;
            model.DiaChi = txtdc.Text;
            model.SDT = txtsdt.Text;
            model.Email = txtemail.Text;
            model.NgaySinh = dtngaysinhnv.Value;
            model.username = txtun.Text;
            model.pass = txtpass.Text;
            using (QLGiayEntities db = new QLGiayEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                try
                {
                    db.SaveChanges();
                }
                catch (OptimisticConcurrencyException)
                {
                    db.Refresh(RefreshMode.ClientWins,"");
                    db.SaveChanges();
                }
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

            model.HoTen = txtht.Text;
            model.DiaChi = txtdc.Text;
            model.SDT = txtsdt.Text;
            model.Email = txtemail.Text;
            model.NgaySinh = dtngaysinhnv.Value;
            model.username = txtun.Text;
            model.pass = txtpass.Text;
            using (QLGiayEntities db = new QLGiayEntities())
            {

                db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("delete thành công", "thông báo");
                txtht.Text = txtdc.Text = txtsdt.Text = txtemail.Text = txtun.Text = txtpass.Text = "";
                loadDataToGrv();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
