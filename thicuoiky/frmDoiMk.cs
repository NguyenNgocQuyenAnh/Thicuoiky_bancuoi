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
    public partial class frmDoiMk : Form
    {
        NhanVien model = new NhanVien();
        public frmDoiMk()
        {
            InitializeComponent();
        }
        

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
   
        private void btndoimk_Click(object sender, EventArgs e)
        {

            model.pass= txtmk.Text;
            using (QLGiayEntities db = new QLGiayEntities())
            {

                string s = "select * from NhanVien where pass='" +
                        txtmk.Text + "' and username='" + txttk.Text+"'";
                var list = db.NhanViens.SqlQuery(s).ToList();
                if (list.Count > 0)
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("update thành công", "thông báo");
                    txttk.Text = txtmk.Text = txtmkm.Text = "";
                }
                else
                {
                    MessageBox.Show("Username hoặc password cũ không đúng", "thông báo");
                }
            }
        }

        private void frmDoiMk_Load(object sender, EventArgs e)
        {

        }
    }
}
