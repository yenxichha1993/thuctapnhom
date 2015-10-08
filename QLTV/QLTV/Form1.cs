using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace QLTV
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
                private void button7_Click(object sender, EventArgs e)
        {
            ThongTin fm = new ThongTin();
            fm.ShowDialog();
        }

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            QuanLyDocGia fm = new QuanLyDocGia();
            fm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuanLySach fm = new QuanLySach();
            fm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            QuanLyTacGia fm = new QuanLyTacGia();
            fm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimKiem fm = new TimKiem();
            fm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TheoDoiMuonTra fm = new TheoDoiMuonTra();
            fm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            ThongKe fm = new ThongKe();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuanLyThe fm = new QuanLyThe();
            fm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ThongTInThuVien fm = new ThongTInThuVien();
            fm.ShowDialog();
        }
        int danhdau = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (danhdau == 0)
            
            {
                int x = label1.Left;
                x =x+2;
                label1.Left =x;
                
                if(x+272>831)
                    danhdau=1;
            }
            if (danhdau == 1)
            {
                int x = label1.Left;
                x =x-2;
                label1.Left = x;
                if (x < 5)
                    danhdau = 0;
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void abcdc_Click(object sender, EventArgs e)
        {
            test111 fm = new test111();
            fm.ShowDialog();
        }

       
    }
}
