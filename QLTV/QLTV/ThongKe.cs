using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        AccessData ac = new AccessData();   
        private void ThongKe_Load(object sender, EventArgs e)
        {
         //   this.tacGiaTableAdapter.Fill(this.quanLyThuVienDataSet.TacGia);
            string sql1 = "Select COUNT(*) from TuaSach";
            string sql2 = "Select COUNT(*) from DocGia";
            string sql3 = "Select COUNT(*) from TacGia";
            string sql4 = "Select COUNT(*) from TheLoai";
            string sql5 = "Select COUNT(*) from NhaXuatBan";
            string sql6 = "Select COUNT(*) from PhieuMuon";


            int a = Convert.ToInt32(ac.executeScalar(sql1));
            int b = Convert.ToInt32(ac.executeScalar(sql2));
            int c = Convert.ToInt32(ac.executeScalar(sql3));
            int d = Convert.ToInt32(ac.executeScalar(sql4));
            int f = Convert.ToInt32(ac.executeScalar(sql5));
            int g = Convert.ToInt32(ac.executeScalar(sql6));


            labSoSach.Text += a;
            labSoDocGia.Text += b;
            labSoTacGia.Text += c;
            labSoTL.Text += d;
            labSoNXB.Text += f;
            labChoMuon.Text += g;
        }

       
    }
}
