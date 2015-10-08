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
    public partial class QuanLyThe : Form
    {
        public QuanLyThe()
        {
            InitializeComponent();
        }
         
        
        AccessData ac = new AccessData();
        public static DataTable LayMaDocGia()
        {
            string sql;
            sql = "Select MaDocGia from DocGia ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        private void Xoa()
        {
            this.txtMaThe.Clear();

        }

        private void QuanLyThe_Load(object sender, EventArgs e)
        {
            string sql1 = "Select *from The";
            dataGridViewThe.DataSource = ac.TaoBang(sql1);
            Xoa();
            //Hiển thị mã độc giả
            cbxMaDocGiaThe.DataSource = LayMaDocGia();
            cbxMaDocGiaThe.DisplayMember = "MaDocGia";
        }
        int dong;

        private void dataGridViewThe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaThe.Text = dataGridViewThe.Rows[dong].Cells[0].Value.ToString();
            cbxMaDocGiaThe.Text = dataGridViewThe.Rows[dong].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridViewThe.Rows[dong].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridViewThe.Rows[dong].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Lấy tên độc giả
            string docgia = "Select TenDocGia from DocGia where MaDocGia='" + cbxMaDocGiaThe.Text.ToString() + "'";
            string TenDocGia = Convert.ToString(ac.executeScalar(docgia));

            string sql = "Insert into The values('" + txtMaThe.Text + "','" + cbxMaDocGiaThe.Text.ToString() + "',N'"
           + TenDocGia + "','" + dateTimePicker1.Value.ToString() + "','"
           + dateTimePicker2.Value.ToString() + "'," + nbSoSachDuocMuon.Value.ToString() + ")";

            if (txtMaThe.Text.Length != 0)
            {
                try
                {
                    ac.ExcuteNonQuery(sql);
                    string sql1 = "Select *from The";
                    dataGridViewThe.DataSource = ac.TaoBang(sql1);
                    Xoa();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã thẻ đã tồn !", "Thêm Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaThe.Clear();
                }
            }
            else
                MessageBox.Show("Mã thẻ và mã độc giả không được để trống !", "Thêm Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Update The set NgayCapThe='" + dateTimePicker1.Value.ToString() + "',NgayHetHan='"
                + dateTimePicker2.Value.ToString() + "',SoSachDuocMuon='" + nbSoSachDuocMuon.Value.ToString() + "'where MaThe='" + txtMaThe.Text + "'";
            ac.ExcuteNonQuery(sql);
            string sql1 = "Select *from The";
            dataGridViewThe.DataSource = ac.TaoBang(sql1);
            Xoa();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "Delete from The where MaThe='" + txtMaThe.Text + "'";
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa Thẻ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                ac.ExcuteNonQuery(sql);
                string sql1 = "Select *from The";
                dataGridViewThe.DataSource = ac.TaoBang(sql1);
                Xoa();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
