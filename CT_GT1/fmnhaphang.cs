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
    public partial class fmnhaphang : Form
    {
        public fmnhaphang()
        {
            InitializeComponent();
        }
        Controller.SqlDataProvider db = new Controller.SqlDataProvider();
        public void getdata()
        {
            string tv = "select * from phieunhap";
            DataSet ds = new DataSet();
            ds = db.getdata(tv, "n");
            dgvpn.DataSource = ds.Tables["n"];

        }
        public void getct()
        {
            string tv = "select * from ChiTietPN";
            DataSet ds = new DataSet();
            ds = db.getdata(tv, "n");
            dgvctpn.DataSource = ds.Tables["n"];

        }
        public void gethang()
        {
            string tv = "select * from hang";
            DataSet ds = db.getdata(tv, "n");
            cmbhang.DataSource = ds.Tables["n"];
            cmbhang.DisplayMember = "tenhg";
            cmbhang.ValueMember = "maHang";
        }
        private void fmnhaphang_Load(object sender, EventArgs e)
        {
            getdata();
            getct();
            gethang();
        }

        private void dgvpn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             int vt = e.RowIndex;
            if (vt >= 0)
            {
                txtmapn.Text = dgvpn.Rows[vt].Cells["maPN"].Value.ToString();
               

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtmactpn.Text = txtmapn.Text;
        }
        public void clear()
        {
            cmbhang.SelectedValue = "";
            txtmactpn.Text = "";
            nubgia.Value = 0;
            nubsoluong.Value = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string mapn = txtmactpn.Text;
            string hang = cmbhang.Text;
            int gia = (int)nubgia.Value;
            int soluong = (int)nubsoluong.Value;
            string tv = "insert into ChiTietPN (maPN,maHang,giaNhap,soluong) values ('"+mapn+"','"+hang+"',"+gia+","+soluong+")";
            db.executeNonQuery(tv);
            getct();
            
        }
    }
}
