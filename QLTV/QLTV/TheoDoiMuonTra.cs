using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTV
{
    public partial class TheoDoiMuonTra : Form
    {
        public TheoDoiMuonTra()
        {
            InitializeComponent();
        }
        AccessData ac = new AccessData();
        private void Xoa()
        {
            cbxSoPhieu.Text = "";
        }
        private void HienThi()
        {
            string sql = "Select *from ChiTietMuonSach";
            dataGridViewMuon.DataSource = ac.TaoBang(sql);

        }
        public static DataTable LaySoPhieu()
        {
            string sql;
            sql = "Select DISTINCT SoPhieu from PhieuMuon ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayMaTheDocGia()
        {
            string sql;
            sql = "Select MaThe from The ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayMaTheMuon()
        {
            string sql;
            sql = "Select DISTINCT MaThe from PhieuMuon ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayMaDocGia()
        {
            string sql;
            sql = "Select MaDocGia from The ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        
        public static DataTable LayMaSach()
        {
            string sql;
            sql = "Select MaSach from Sach where hientrang=N'Chưa thuê'";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable laymasacht()
        {
            string sql;
            sql = "Select masach from Sach ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayTenSach()
        {
            string sql;
            sql = "Select TenSach from TuaSach ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayNgayHenTra()
        {
            string sql;
            sql = "Select NgayTra from PhieuMuon ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }

        private void TheoDoiMuonTra_Load(object sender, EventArgs e)
        {
            //Lấy Mã Thẻ Độc giả đưa vào mượn
            cbxMaTheMuon.DataSource = LayMaTheDocGia();
            cbxMaTheMuon.DisplayMember = "MaThe";
            //Lấy Mã Thẻ đã mượn để theo dõi trả
            cbxMaTheTra.DataSource = LayMaTheMuon();
            cbxMaTheTra.DisplayMember = "MaThe";

            //Lấy số phiếu
            //cbxSP.DataSource = LaySoPhieu();
            //cbxSP.DisplayMember = "SoPhieu";
          //  cbxSoPhieu.DataSource = LaySoPhieu();
         //   cbxSoPhieu.DisplayMember = "SoPhieu";

            //Lấy mã sách đưa vào mượn
         //   cbxmts.DataSource= LayMaSach();
          //  cbxmts.DisplayMember = "MaTuaSach";
            cbxMaSachMuon.DataSource = LayMaSach();
            cbxMaSachMuon.DisplayMember = "MaSach";
            //Lấy tên Sách đưa vòa mượn
            cbxTenSachMuon.DataSource = LayTenSach();
            cbxTenSachMuon.DisplayMember = "TenSach";
            cbxmtt.DataSource = laymasacht();
            cbxmtt.DisplayMember = "MaSach";
            //Lấy ngày hẹn trả đưa vào trả
            cbxNgayHenTraMuon.DataSource = LayNgayHenTra();
            cbxNgayHenTraMuon.DisplayMember = "NgayHenTra";
            cbxTinhTrangTra.SelectedItem = "Tốt";
            HienThi();
            Xoa();

        }
        int dong;
        private void dataGridViewMuon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            cbxSoPhieu.Text = dataGridViewMuon.Rows[dong].Cells[0].Value.ToString();
            cbxMaSachMuon.Text = dataGridViewMuon.Rows[dong].Cells[1].Value.ToString();

        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            try
            {
                AccessData ac = new AccessData();

                string str = "ThemPhieuMuon";
                SqlConnection con = new SqlConnection(ac.getconnect());
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mathe", cbxMaTheMuon.Text);
                cmd.Parameters.AddWithValue("@ngaymuon", Convert.ToDateTime(dtNgayMuon.Text.ToString()));
                cmd.Parameters.AddWithValue("@ngaytra", Convert.ToDateTime(dtNgayHenTra.Text.ToString()));
                SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
                para.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(para);
                cmd.ExecuteNonQuery();
                string kq = para.Value.ToString();
                cmd.Dispose();
                con.Close();
                if (kq == "0") MessageBox.Show("Lỗi dữ liệu ngày mượn");
                else
                    if (kq == "1") MessageBox.Show("Lỗi dữ liệu ngày trả");
                    else
                        if (kq == "3") MessageBox.Show("Thẻ đã mượn quá số lượng cho phép");
                        else
                            MessageBox.Show("Thêm thành công");
            }
            catch (Exception er)
            { MessageBox.Show(er.Message); }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string sql = "xoaphieu " + cbxSP.Text.ToString() + "";
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa Nhà Phiếu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                ac.ExcuteNonQuery(sql);
                HienThi();
                Xoa();
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

        private void btnTra_Click(object sender, EventArgs e)
        {

            string sql = "xoaphieu";
            SqlConnection con = new SqlConnection(ac.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sophieu",  cbxSoPhieu.Text);
            cmd.Parameters.AddWithValue("@masach", cbxmtt.Text);
                //cmd.Parameters.AddWithValue("@ngaymuon", Convert.ToDateTime(dtNgayMuon.Text.ToString()));
                //cmd.Parameters.AddWithValue("@ngaytra", Convert.ToDateTime(dtNgayHenTra.Text.ToString()));
               // SqlDataAdapter ad = new SqlDataAdapter(cmd);
             //   DataTable dt = new DataTable();
                
                SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
                para.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(para);
                cmd.ExecuteNonQuery();
                string kq = para.Value.ToString();
               
                if (kq == "1"  && cbxTinhTrangTra.Text.ToString() == "Tốt")
                {
                    ac.ExcuteNonQuery(sql);
                    HienThi();
                    textBox2.Text = "Đã trả sách và tình trạng sách " + cbxTinhTrangTra.Text.ToString() + " và số tiền bị phạt là: 0 vnđ";

                }
                if (kq != "0")
                {
                    //TimeSpan songay = ngaytraCT - ngayhenTra;
                    int ngay = 3;
                    float sotien = (float)(ngay * 0.1);
                    ac.ExcuteNonQuery(sql);
                    HienThi();
                    textBox2.Text = "Đã trả sách và tình trạng sách " + cbxTinhTrangTra.Text.ToString() + " bạn đã trả muộn " + ngay + " ngày và số tiền bị phạt là: " + sotien + " vnđ";


                }

            }
            
                 
    
        

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //Lấy Mã Thẻ Độc giả đưa vào mượn
            cbxMaTheMuon.DataSource = LayMaTheDocGia();
            cbxMaTheMuon.DisplayMember = "MaThe";
            //Lấy Mã sách đưa vào mượn
           // cbxMaSachMuon.DataSource = LayMaSach();
           // cbxMaSachMuon.DisplayMember = "MaTuaSach";
            cbxMaSachMuon.DataSource = LayMaSach();
            cbxMaSachMuon.DisplayMember = "MaSach";
            //Lấy tên sách
            cbxTenSachMuon.DataSource = LayTenSach();
            cbxTenSachMuon.DisplayMember = "TenSach";

            //Lấy Mã Thẻ đã mượn để theo dõi trả
            cbxMaTheTra.DataSource = LayMaTheMuon();
            cbxMaTheTra.DisplayMember = "MaThe";

            //Lấy số phiếu đã mượn
            cbxSoPhieu.DataSource = LaySoPhieu();
            cbxSoPhieu.DisplayMember = "SoPhieu";
            //Lấy ngày hẹn trả
            cbxNgayHenTraMuon.DataSource = LayNgayHenTra();
            cbxNgayHenTraMuon.DisplayMember = "NgayTra";

            cbxSoPhieu.Text = "";

        }

        private void cbxMaTheMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessData ac = new AccessData();
            string str = "LaySoPhieu";
            SqlConnection con = new SqlConnection(ac.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mathe", cbxMaTheMuon.Text.ToString());
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cbxSP.DataSource = dt;
            cbxSP.DisplayMember = "SoPhieu";
            
        }

        private void cbxMaSachMuon_TextChanged(object sender, EventArgs e)
        {
            //Lấy tên sach
            string sach = "Select TenSach from TuaSach where TenSach='" + cbxMaSachMuon.Text.ToString() + "'";
            string TenS = Convert.ToString(ac.executeScalar(sach));
            cbxTenSachMuon.Text = TenS;
        }

        private void cbxTenSachMuon_TextChanged(object sender, EventArgs e)
        {

            //Lấy mã sach
            string sach = "Select MaSach from TuaSach where TenSach=N'%" + cbxTenSachMuon.Text.ToString() + "N'%'";
            string MaS = Convert.ToString(ac.executeScalar(sach));
            cbxMaSachMuon.Text = MaS;
        }

        private void cbxSoPhieu_TextChanged(object sender, EventArgs e)
        {
            string ngayhentra = "Select NgayTra from PhieuMuon where SoPhieu='" + cbxSoPhieu.Text.ToString() + "'";
            string ngay = Convert.ToString(ac.executeScalar(ngayhentra));
            cbxNgayHenTraMuon.Text = ngay;
        }

        private void txtSoPhieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;


        }

        private void cbxMaSachMuon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void cbxTenSachMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AccessData ac = new AccessData();
                string str = "LaySach";
                SqlConnection con = new SqlConnection(ac.getconnect());
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tensach", cbxTenSachMuon.Text.ToString());
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                cbxMaSachMuon.DataSource = dt;
                cbxMaSachMuon.DisplayMember = "MaSach";
            }
            catch (Exception er)
            { MessageBox.Show(er.Message); }
        }

        private void cbxSP_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void cbxMaTheMuon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AccessData ac = new AccessData();
                string str = "laysophieu";
                SqlConnection con = new SqlConnection(ac.getconnect());
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mathe", cbxMaTheMuon.Text.ToString());
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                cbxSoPhieu.DataSource = dt;
                cbxSoPhieu.DisplayMember = "SoPhieu";
            }
        }

        private void bntChoMuon_Click(object sender, EventArgs e)
        {
            try
            {
                AccessData ac = new AccessData();
                string str = "Themchitietmuon";
                SqlConnection con = new SqlConnection(ac.getconnect());
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sophieu", cbxSP.Text);
                cmd.Parameters.AddWithValue("@masach", cbxMaSachMuon.Text);
                SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
                para.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(para);
                cmd.ExecuteNonQuery();
                string kq = para.Value.ToString();
                if (kq == "0") MessageBox.Show("Dữ liệu đầu vào sai");
                else MessageBox.Show("Thêm thành công");
                cmd.Dispose();
                con.Close();
            }
            catch (Exception er)
            { MessageBox.Show(er.Message); }
        }

        private void cbxMaTheTra_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessData ac = new AccessData();
            string str = "LaySoPhieu";
            SqlConnection con = new SqlConnection(ac.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mathe", cbxMaTheTra.Text.ToString());
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cbxSoPhieu.DataSource = dt;
            cbxSoPhieu.DisplayMember = "SoPhieu";
          
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cbxmtt_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxSoPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessData ac = new AccessData();
            string str = "laymasach";
            SqlConnection con = new SqlConnection(ac.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maphieu", cbxSoPhieu.Text.ToString());
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cbxmtt.DataSource = dt;
            cbxmtt.DisplayMember = "MaSach";
        }

        /*private void cbxMaSachMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sach = "Select MaSach from Sach where TuaSach='" + cbxMaSachMuon.Text.ToString() + "'";
            string TenS = Convert.ToString(ac.executeScalar(sach));
            cbxTenSachMuon.Text = TenS;
        }*/

    
        

  
       
        
    }
}
