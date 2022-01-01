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
    public partial class fmhang : Form
    {
        public fmhang()
        {
            InitializeComponent();
        }
        Controller.SqlDataProvider db = new Controller.SqlDataProvider();
        DataTable dt;
        public void getdata()
        {
            string tv = "select * from hang";

            DataSet ds = db.getdata(tv, "hang");
            dgvhang.DataSource = ds.Tables["hang"];
           

        }
        public void getnsx()
        {
            string tv = "select * from nhaNSX";
            DataSet ds = db.getdata(tv, "nsx");
            cmbNSX.DataSource = ds.Tables["nsx"];
            cmbNSX.DisplayMember = "tenNSX";
            cmbNSX.ValueMember = "maNSX";

        }
        public void  cleartxt()
        {
        
            txttinhtrang.Text ="";
            txttimkiem.Text = "";
            txtmahang.Text = "";
            txttenhang.Text = "";
            nubsoluong.Value = 0;
            cmbNSX.SelectedValue ="";
            nubgia.Value = 0;
            txtmahang.Enabled = true;
            btnthem.Enabled = true;
            getdata();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //string tk = txt_tim.Text;
            //string select_query = "select * from tb_LopNienChe  where TenLopNienChe  Like N'%" + tk + "%'";
            //DataSet ds = db.getData(select_query, "lopnienche");
            //dgv_lop.DataSource = ds.Tables["lopnienche"];


            string tv = "select * from hang where tenhg like '%" + txttimkiem.Text + "%'";
            DataSet ds = db.getdata(tv, "hang");
            dgvhang.DataSource = ds.Tables["hang"];
            
        }
        public void getlh()
        {
            string tv = "select * from loaihang";
            DataSet ds = db.getdata(tv, "loaihang");
            cmbloaihang.DataSource = ds.Tables["loaihang"];
            cmbloaihang.DisplayMember = "tenLH";
            cmbloaihang.ValueMember = "maLH";

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private List<Model.hang>  listhang= new List<Model.hang>();
        public void laydata()
        {
            string tv = "select * from hang";
            DataTable dt = db.laydata(tv);
            foreach(DataRow row in dt.Rows)
            {   

            string ma = row[0].ToString();
            string ten = row[1].ToString();
            int soluong = int.Parse(row[2].ToString());
            string lh = row[3].ToString();
            string nsx = row[4].ToString();
            string tinhtrang = row[5].ToString();
            int gia = int.Parse(row[6].ToString());

               // h.ma= row[0].ToString();
               //h.ten = row[1].ToString();
               // h.soluong= int.Parse(row[2].ToString());
               // h.loai= row[3].ToString();
               // h.nsx= row[4].ToString();
               // h.tinhtrang= row[5].ToString();
                listhang.Add( new Model.hang(ma,ten,soluong,lh,nsx,tinhtrang,gia));
            }
            int l = 0;
            int r = listhang.Count - 1;

        }


        public void quicksort(List<Model.hang> hang,int l,int r)
        {
            int i, j;
            int x = hang[(l + r) / 2].soluong;
            i = l;
            j = r;
            while (i < j)
            {
                while (hang[i].soluong < x) i++;
                while (hang[j].soluong > x) j--;
                if (i <= j)
                {
                    
                            
                                Model.hang tg = hang[i];
                                hang[i] = hang[j];
                                hang[j] = tg;
                            
                            i++; j--;
                }
            }
            if (l < j) quicksort(hang, l, j);
            if (r > i) quicksort(hang, i, r);
        }



        public void quicksort2(List<Model.hang> hang, int l, int r)
        {
            int i, j;
            int x = hang[(l + r) / 2].soluong;
            i = l;
            j = r;
            while (i < j)
            {
                while (hang[i].soluong > x) i++;
                while (hang[j].soluong < x) j--;
                if (i <= j)
                {

                    
                        Model.hang tg = hang[i];
                        hang[i] = hang[j];
                        hang[j] = tg;
                    
                    i++; j--;

                }
            }
            if (l < j) quicksort2(hang, l, j);
            if (r > i) quicksort2(hang, i, r);
        }


        int nhiphantimkiem(List<Model.hang> a, int n, int x)
        {
            int l = 0, r = n - 1;
            int mid;
            do
            {
                mid = (l + r) / 2;
                if (x == a[mid].soluong)
                {
                    return mid;
                }
                else
                {
                    if (x < a[mid].soluong)
                        r = mid - 1;
                    else
                        l = mid + 1;
                }
            } while (l <= r);
            return -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getdata();
            getnsx();
            getlh();

            string tv = "select * from hang";
            dt = db.laydata(tv);
            foreach (DataRow row in dt.Rows)
            {
                Model.hang h = new Model.hang();
                h.ma = row[0].ToString();
                h.ten = row[1].ToString();
                h.soluong = int.Parse(row[2].ToString());
                h.loai = row[3].ToString();
                h.nsx = row[4].ToString();
                h.tinhtrang = row[5].ToString();
                h.gia = int.Parse(row[6].ToString());
                listhang.Add(h);
            }
        }

        private void dgvhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if (vt >= 0)
            {
                txtmahang.Text = dgvhang.Rows[vt].Cells["maHang"].Value.ToString();
                txttenhang.Text = dgvhang.Rows[vt].Cells["tenhg"].Value.ToString();
                txttinhtrang.Text = dgvhang.Rows[vt].Cells["tinhtrang"].Value.ToString();
                nubsoluong.Value = int.Parse(dgvhang.Rows[vt].Cells["soluong"].Value.ToString());
                cmbNSX.SelectedValue = dgvhang.Rows[vt].Cells["maNSX"].Value.ToString();
                cmbloaihang.SelectedValue = dgvhang.Rows[vt].Cells["maLH"].Value.ToString();
                nubgia.Value = int.Parse(dgvhang.Rows[vt].Cells["gia"].Value.ToString());
            }
            txtmahang.Enabled = false;
            btnthem.Enabled = false;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            cleartxt();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
           
            
                string ma = txtmahang.Text;
                string ten = txttenhang.Text;
                string nsx = cmbNSX.SelectedValue.ToString();
                string tinhtrang = txttinhtrang.Text;
                string loai = cmbloaihang.SelectedValue.ToString();
                int n = (int)nubsoluong.Value;
                int g = (int)nubgia.Value;
                string tv = "insert into hang values ('" + ma + "',N'" + ten + "','" + n + "','" + loai + "','" + nsx + "',N' " + tinhtrang + " ',"+g+")";
                db.executeNonQuery(tv);


                getdata();
                cleartxt();
            
             
                
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ma = txtmahang.Text;
            string ten = txttenhang.Text;
            string nsx = cmbNSX.SelectedValue.ToString();
            string tinhtrang = txttinhtrang.Text;
            int n = (int)nubsoluong.Value;
            int g = (int)nubgia.Value;
            string tv = "update hang set tenhg ='"+ten+"', soluong ="+n+" , maNSX = '"+nsx+"', tinhtrang =N'"+tinhtrang+"', gia = "+g+" where maHang ='" + ma + "' ";            db.executeNonQuery(tv);
            db.executeNonQuery(tv);
            getdata();
            cleartxt();
            txtmahang.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string tv = "delete from hang where maHang ='"+txtmahang.Text+"'";
            db.executeNonQuery(tv);
            getdata();
            cleartxt();
            txtmahang.Enabled = true;
        }

        private void btn_tang_Click(object sender, EventArgs e)
        {
            //string tv = "select * from hang";
            //DataTable dt = db.laydata(tv);
            int i = 0;
            int l = 0;
            int r = listhang.Count;
            quicksort(listhang, l, r - 1);

            foreach (DataRow data in dt.Rows)
            {

                data[0] = listhang[i].ma;
                data[1] = listhang[i].ten;
                data[2] = listhang[i].soluong;
                data[3] = listhang[i].loai;
                data[4] = listhang[i].nsx;
                data[5] = listhang[i].tinhtrang;
                data[6] = listhang[i].gia;
                i++;
            }
            dgvhang.DataSource = dt;
            i = 0;
        }

        private void btn_giam_Click(object sender, EventArgs e)
        {
            int l = 0;
            int r = listhang.Count - 1;


            //string tv = "select * from hang";
            //DataTable dt = db.laydata(tv);
            int i = 0;
            int n = 0;

            quicksort2(listhang, l, r);

            foreach (DataRow data in dt.Rows)
            {
                data["maHang"] = listhang[i].ma;
                data[1] = listhang[i].ten;
                data[2] = listhang[i].soluong;
                data[3] = listhang[i].loai;
                data[4] = listhang[i].nsx;
                data[5] = listhang[i].tinhtrang;
                data[6] = listhang[i].gia;
                i++;
            }
            dgvhang.DataSource = dt;

        }

        private void btnnhiphantimkiem_Click(object sender, EventArgs e)
        {
            
            int l = 0;
            int r = listhang.Count - 1;
            
            quicksort(listhang, l, r);
            int i = 0;
            foreach (DataRow data in dt.Rows)
            {
                data["maHang"] = listhang[i].ma;
                data[1] = listhang[i].ten;
                data[2] = listhang[i].soluong;
                data[3] = listhang[i].loai;
                data[4] = listhang[i].nsx;
                data[5] = listhang[i].tinhtrang;
                data[6] = listhang[i].gia;
                i++;
            }
            dgvhang.DataSource = dt;

            int tg = (int)nudtim.Value;
            int n = listhang.Count ;
            int kt = nhiphantimkiem(listhang, n, tg);
            
            if (kt == -1)
            {
               
                MessageBox.Show("khong co  "+tg);
            }
            else
            {
                DataTable dtt = new DataTable();
                string ma = listhang[kt].ma;
                //dtt.Rows["maHang"] = listhang[kt].ma;

                dgvhang.Columns[0].HeaderText = "Mã Hàng";
                dgvhang.Columns[1].HeaderText = "Tên Hàng";
                dgvhang.Columns[2].HeaderText = "Số Lượng";
                dgvhang.Columns[3].HeaderText = "Loại Hàng";
                dgvhang.Columns[4].HeaderText = "NSX";
                dgvhang.Columns[5].HeaderText = "Tinh trang";
                dgvhang.Columns[6].HeaderText = "giá";
                DataSet ds = db.getdata("select * from hang where maHang = '"+ma+"'", "tim");
                dgvhang.DataSource = ds.Tables["tim"];
                
            }
        } 
       




        

      

    }
}
