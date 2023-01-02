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
    public partial class frmoption : Form
    {
        public frmoption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmChinh f = new frmChinh();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmnhanvien f = new frmnhanvien();
            f.Show();
        }
    }
}
