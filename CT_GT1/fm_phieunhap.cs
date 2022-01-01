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
    public partial class fm_phieunhap : Form
    {
        public fm_phieunhap()
        {
            InitializeComponent();
        }
        Controller.SqlDataProvider db = new Controller.SqlDataProvider();
        public void getdata()
        {
            string tv = "select * from phieunhap";
            DataSet ds = new DataSet();
            ds = db.getdata(tv, "n");
            dgvPN.DataSource = ds.Tables["n"];

        }
        void getncc()
        {
            string tv = "select * from nhaCC";
            DataSet ds = db.getdata(tv, "ncc");
            cmbncc.DataSource = ds.Tables["ncc"];
            cmbncc.DisplayMember = "tenNCC";
            cmbncc.ValueMember = "maNCC";

        }
        public string layngay()
        {

            DateTime date = dtpngaynhap.Value;
            string t = date.ToString("MM/dd/yyyy");
            return t;
        }
        private void fm_phieunhap_Load(object sender, EventArgs e)
        {
            getdata();
            getncc();
        }
        public void cleartxt()
        {
            nudthanhtien.Value = 0;
            txtma.Text = "";
            cmbncc.SelectedValue = "";

          
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            cleartxt();
        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if (vt >= 0)
            {
                txtma.Text = dgvPN.Rows[vt].Cells["maPN"].Value.ToString();
                nudthanhtien.Value = int.Parse(dgvPN.Rows[vt].Cells["tienNhap"].Value.ToString());
                dtpngaynhap.Text = dgvPN.Rows[vt].Cells["ngaynhap"].Value.ToString();
                cmbncc.SelectedValue = dgvPN.Rows[vt].Cells["maNCC"].Value.ToString();

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string t = txtma.Text;
            string ncc = cmbncc.SelectedValue.ToString();
            string date = dtpngaynhap.Value.ToString("MM/dd/yyyy");
            string tv = "insert into phieunhap(maPN,ngaynhap,maNCC) values ('"+t+"','"+date+"','"+ncc+"')";
            db.executeScalar(tv);
            getdata();
            cleartxt();
        }

        private void btn_cậpnhật_Click(object sender, EventArgs e)
        {
            string tv = "update phieunhap set tiennhap = (select sum(thanhtien) from phieunhap,ChiTietPN where phieunhap.maPN = CHiTietPN.maPN)";
            db.executeNonQuery(tv);
            getdata();
        }
    }
}
