using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CT_GT1
{
    public partial class fmhethong : Form
    {
        public fmhethong()
        {
            InitializeComponent();
        }

        private void nhậpHầngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fmdangnhap f = new fmdangnhap();
            f.Show();
        }

        private void hàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmhang f = new fmhang();
            f.ShowDialog();
        }

        private void khoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmthongkensx f = new fmthongkensx();
            f.ShowDialog();
        }

        private void nhaCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmthongkencc f = new fmthongkencc();
            f.ShowDialog();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmthongkeNhap f = new fmthongkeNhap();
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_phieunhap f = new fm_phieunhap();
            f.ShowDialog();
        }

        private void cTPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmnhaphang f = new fmnhaphang();
            f.ShowDialog();
        }
    }
}
