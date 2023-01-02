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
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
            lock_unlock(Luu.KT1);
        }
        void lock_unlock(bool kt1)
        {
            mnuDangnhap.Enabled = mnuthoatkhoi.Enabled = kt1;
            mnuThoat.Enabled = mnuDangxuat.Enabled = mnuTracuu.Enabled = mnuDanhmuc.Enabled = mnuBaocao.Enabled = !kt1;
        }
        private void mnuSinhvien_Click(object sender, EventArgs e)
        {
            frmbanhang f = new frmbanhang();
            f.Show();
        }

        private void mnuTracuuLop_Click(object sender, EventArgs e)
        {
            frmTraCuu f = new frmTraCuu();
            f.Show();
        }

        private void mnuTracuuSinhVien_Click(object sender, EventArgs e)
        {
            frmTracuukh f = new frmTracuukh();
            f.Show();
        }

        private void mnudoanhthu_Click(object sender, EventArgs e)
        {
            frmDoanhthu f = new frmDoanhthu();
            f.Show();
        }

        private void frmnhanvien_Activated(object sender, EventArgs e)
        {
            lock_unlock(Luu.KT1);
        }

        private void mnuDangnhap_Click(object sender, EventArgs e)
        {
            frmDangnhapNv f = new frmDangnhapNv();
            f.Show();
        }

        private void mnuDangxuat_Click(object sender, EventArgs e)
        {
            frmnhanvien f = new frmnhanvien();
            f.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            frmDoiMk f = new frmDoiMk();
            f.Show();
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frmquanlykh f = new frmquanlykh();
            f.Show();
        }

        private void mnuthoatkhoi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
