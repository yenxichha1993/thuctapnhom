using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QLTV
{
    public partial class QuanLyDocGia : Form
    {
        public QuanLyDocGia()
        {
            InitializeComponent();
        }
        AccessData ac = new AccessData();

        private void Xoa()
        {

            txtMaDocGia.Clear();
            txtTenDocGia.Clear(); 
            txtChucDanh.Clear();
            txtDiaChi.Clear();
            txtSoCMT.Clear();
            txtSoTienGui.Clear();
        }

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.DocGia' table. You can move, or remove it, as needed.

            //this.docGiaTableAdapter1.Fill(this.quanLyThuVienDataSet1.DocGia);
            string sql = "Select *from DocGia";
            ac.TaoBang(sql);
            dataGridViewDocGia.DataSource = ac.TaoBang(sql);
            Xoa();

        }


        int dong;
    

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.rdbNam.Checked)
            {

                string sql = "Insert into DocGia values('" + txtMaDocGia.Text + "',N'"
                + txtTenDocGia.Text + "',N'Nam','" + dateTimePicker1.Value.ToString() + "',N'"
                + txtDiaChi.Text + "', N'" + txtChucDanh.Text + "','"
                + txtSoCMT.Text + "'," + txtSoTienGui.Text + ")";
                try
                {
                    ac.ExcuteNonQuery(sql);
                    string sql1 = "Select *from DocGia";
                    dataGridViewDocGia.DataSource = ac.TaoBang(sql1);
                    dataGridViewDocGia.Refresh();
                    Xoa();

                }
                catch (Exception ex)
                {
                    DialogResult traloi = MessageBox.Show("Mã độc giả đã được cấp !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (traloi == DialogResult.OK)
                    {
                        this.txtMaDocGia.Clear();
                        this.txtMaDocGia.Focus();
                    }

                }


            }
            else if (rdbNu.Checked)
            {
                string sql = "Insert into DocGia values('" + txtMaDocGia.Text + "',N'" + txtTenDocGia.Text + "',N'Nữ','" + dateTimePicker1.Value.ToString() + "',N'" + txtDiaChi.Text + "', N'" + txtChucDanh.Text + "','" + txtSoCMT.Text + "'," + txtSoTienGui.Text + ")";
                try
                {
                    ac.ExcuteNonQuery(sql);
                    string sql1 = "Select *from DocGia";
                    dataGridViewDocGia.DataSource = ac.TaoBang(sql1);
                    dataGridViewDocGia.Refresh();
                    Xoa();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã độc giả đã được cấp !", "Lỗi ", MessageBoxButtons.OK);
                    txtMaDocGia.Select();
                }

            }



            else
            {
                MessageBox.Show("Chưa chọn giới tính !", "Lỗi rồi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql1 = "Delete from DocGia where MaDocGia ='" + txtMaDocGia.Text + "'";
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa Độc Giả", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                ac.ExcuteNonQuery(sql1);
                Xoa();
            }
            string sql = "Select *from DocGia";
            dataGridViewDocGia.DataSource = ac.TaoBang(sql);

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (rdbNam.Checked)
            {
                string sql1 = "Update DocGia set MaDocGia='" + txtMaDocGia.Text+"',TenDocGia =N'" + txtTenDocGia.Text + "', GioiTinh=N'Nam', NgaySinh ='"
                + dateTimePicker1.Value.ToString() + "',DiaChi=N'" + txtDiaChi.Text + "',ChucDanh=N'" + txtChucDanh.Text + "',SoCMT ='"
                + txtSoCMT.Text + "',TienKiGui='" + txtSoTienGui.Text + "'";
                ac.ExcuteNonQuery(sql1);

                string sql = "Select *from DocGia";
                dataGridViewDocGia.DataSource = ac.TaoBang(sql);

                Xoa();

            }
            else if (rdbNu.Checked)
            {
                string sql1 = "Update DocGia set MaDocGia='" + txtMaDocGia.Text + "',TenDocGia =N'" + txtTenDocGia.Text + "', GioiTinh=N'Nam', NgaySinh ='"
                + dateTimePicker1.Value.ToString() + "',DiaChi=N'" + txtDiaChi.Text + "',ChucDanh=N'" + txtChucDanh.Text + "',SoCMT ='"
                + txtSoCMT.Text + "',TienKiGui='" + txtSoTienGui.Text + "'";
                ac.ExcuteNonQuery(sql1);

                string sql = "Select *from DocGia";
                dataGridViewDocGia.DataSource = ac.TaoBang(sql);

                Xoa();
            }
            else
            {
                MessageBox.Show("Chưa chọn giới tính !", "Lỗi rồi ", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDocGia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaDocGia.Text = dataGridViewDocGia.Rows[dong].Cells[0].Value.ToString();
            txtTenDocGia.Text = dataGridViewDocGia.Rows[dong].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridViewDocGia.Rows[dong].Cells[4].Value.ToString();
            txtChucDanh.Text = dataGridViewDocGia.Rows[dong].Cells[5].Value.ToString();
            txtSoCMT.Text = dataGridViewDocGia.Rows[dong].Cells[6].Value.ToString();
            txtSoTienGui.Text = dataGridViewDocGia.Rows[dong].Cells[7].Value.ToString();
            dateTimePicker1.Text = dataGridViewDocGia.Rows[dong].Cells[3].Value.ToString();
            string gioitinh = dataGridViewDocGia.Rows[dong].Cells[2].Value.ToString();

            if (gioitinh.Trim() == "Nam")
            {
                rdbNam.Checked = true;
            }
            if (gioitinh.Trim() == "Nữ")
            {
                rdbNu.Checked = true;
            }
        }

       

       

    }
}

