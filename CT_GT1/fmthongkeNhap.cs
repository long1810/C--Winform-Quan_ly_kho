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
    public partial class fmthongkeNhap : Form
    {
        public fmthongkeNhap()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void tongtien()
        {
            try
            {
                DateTime date = dtp_ngaynhap.Value;
                string t = date.ToString("MM/dd/yyyy");
                int data = int.Parse(db.executeScalar("select SUM(thanhtien)from ChiTietPN where ngayNhap ='" + t + "'"));
                nubtongtien.Value = data;
            }
            catch
            {
                return;
            }
                
               
        }
        public void tongsoluong()
        {
            try
            {
                DateTime date = dtp_ngaynhap.Value;
                string t = date.ToString("MM/dd/yyyy");
                int data = int.Parse(db.executeScalar("select SUM(soluong)from ChiTietPN where ngayNhap ='" + t + "'"));
                nudsoluiong.Value = data;
            }
            catch
            {
                return;
            }


        }
        Controller.SqlDataProvider db = new Controller.SqlDataProvider();
        private void btnngay_Click(object sender, EventArgs e)
        {
            DateTime date = dtp_ngaynhap.Value;
            string t = date.ToString("MM/dd/yyyy");
            MessageBox.Show(" ngay : " + t);
            string tv = "select * from ChiTietPN where ngayNhap ='"+t+"'";
            DataSet ds = db.getdata(tv, "ngay");

            dgcphieunhap.DataSource = ds.Tables["ngay"];
            tongtien();
            tongsoluong();
            


        }

        private void btnthang_Click(object sender, EventArgs e)
        {
            DateTime date = dtp_ngaynhap.Value;
            string t = date.ToString("MM");
            string tv = "select * from ChiTietPN where month(ngayNhap) ='" + t + "'";
            MessageBox.Show(t);
            DataSet ds = db.getdata(tv, "ngay");

            dgcphieunhap.DataSource = ds.Tables["ngay"];
            tongtien(); tongsoluong();
        }

        private void btnnam_Click(object sender, EventArgs e)
        {
            DateTime date = dtp_ngaynhap.Value;
            string t = date.ToString("yyyy");
            string tv = "select * from ChiTietPN where year(ngayNhap) ='" + t + "'";
            MessageBox.Show(t);
            DataSet ds = db.getdata(tv, "ngay");

            dgcphieunhap.DataSource = ds.Tables["ngay"];
            tongtien(); tongsoluong();
        }

        private void fmthongkeNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
