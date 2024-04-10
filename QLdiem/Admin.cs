using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Xml.Linq;
namespace QLdiem
{
    public partial class Admin : Form
    {
        SqlConnection conn;
        public Admin()
        {
            InitializeComponent();
            createConnection();
        }
        private void createConnection()
        {
            try
            {
                String stringConnection = "Server=DESKTOP-BTIGREQ\\SQLEXPRESS;Database=QLdiem; Integrated Security = true";
                conn = new SqlConnection(stringConnection);
                MessageBox.Show(" ket noi csdl thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra ow createconnection " + ex.Message);
            }

        }
        private void DisplayDataSinhVien()
        {

            try
            {
                conn.Open();
                // khia bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                string sql = "select * from SINHVIEN";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable data = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                dgv.DataSource = data;
                MessageBox.Show(" lay du lieu thanh cong!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra DisplayDataStudent " + ex.Message);
            }

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            DisplayDataSinhVien();
        }
        private void CreateSinhVien()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                String sql = " INSERT INTO SINHVIEN( MaSV, TenSV, GioiTinh, SDT, Diem) VALUES ( @MaSV, @TenSV, @GioiTinh, @SDT, @Diem)";
                // khai bao bien trong sql va gan gia tri cho bien
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar);
                cmd.Parameters["@MaSV"].Value = tbMaSV.Text.ToString();

                cmd.Parameters.Add("@TenSV", SqlDbType.VarChar);
                cmd.Parameters["@TenSV"].Value = tbTenSV.Text.ToString();

                cmd.Parameters.Add("@GioiTinh", SqlDbType.VarChar);
                cmd.Parameters["@GioiTinh"].Value = cbbGioiTinh.SelectedItem.ToString();

                cmd.Parameters.Add("@SDT", SqlDbType.VarChar);
                cmd.Parameters["@SDT"].Value = tbSDT.Text.ToString();

                cmd.Parameters.Add("@Diem", SqlDbType.Decimal);
                cmd.Parameters["@Diem"].Value = tbDiem.Text.ToString();

                cmd.CommandText = sql;
                // thuc thi cau lenh
                cmd.ExecuteNonQuery();

                MessageBox.Show(" them moi thanh cong");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra CreateSinhVien " + ex.Message);
            }
        }

        private void btnCreateSinhVien_Click(object sender, EventArgs e)
        {
            DisplayDataSinhVien();
            CreateSinhVien();
        }
        private void DeleteSinhVien()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                String sql = " DELETE FROM SINHVIEN WHERE MaSV = @MaSv";
                // khai bao bien trong sql va gan gia tri cho bien
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar);
                cmd.Parameters["@MaSV"].Value = tbDeleteUpdateSinhVien.Text.ToString();

                cmd.CommandText = sql;
                // thuc thi cau lenh
                cmd.ExecuteNonQuery();
                MessageBox.Show(" xoa thanh cong");
                // thuc thi cau lenh
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra DeleteSinhVien " + ex.Message);
            }
        }

        private void btnDeleteSinhVien_Click(object sender, EventArgs e)
        {
            String MaSv = tbDeleteUpdateSinhVien.Text.ToString();
            DialogResult re = MessageBox.Show(" ban co chac muon xoa ban ghi " + MaSv, "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                DeleteSinhVien();
                DisplayDataSinhVien();
            }
        }
        private void UpdateSinhVien()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                string sql = "UPDATE SINHVIEN  SET TenSV = @TenSV, GioiTinh = @GioiTinh, SDT = @SDT WHERE MaSV = @MaSV";
                // khai bao bien trong sql va gan gia tri cho bien
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar);
                cmd.Parameters["@MaSV"].Value = tbDeleteUpdateSinhVien.Text.ToString();

                cmd.Parameters.Add("@TenSV", SqlDbType.VarChar);
                cmd.Parameters["@TenSV"].Value = tbTenSV.Text.ToString();

                cmd.Parameters.Add("@GioiTinh", SqlDbType.VarChar);
                cmd.Parameters["@GioiTinh"].Value = cbbGioiTinh.SelectedItem.ToString();

                cmd.Parameters.Add("@SDT", SqlDbType.VarChar);
                cmd.Parameters["@SDT"].Value = tbSDT.Text.ToString();

                cmd.Parameters.Add("@Diem", SqlDbType.Decimal);
                cmd.Parameters["@Diem"].Value = tbDiem.Text.ToString();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                MessageBox.Show("du lieu da duoc cap nhat thanh cong ");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cap nhat du lieu chua thanh cong");
            }
        }

        private void btnUpdateSinhVien_Click(object sender, EventArgs e)
        {
            UpdateSinhVien();
            DisplayDataSinhVien();
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////
        /// </summary>
        private void DisplayDataDiemHP()
        {

            try
            {
                conn.Open();
                // khia bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                string sql = "select * from DIEMHP";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable data = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                dgv1.DataSource = data;
                MessageBox.Show(" lay du lieu thanh cong!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra DisplayDataStudent " + ex.Message);
            }

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            DisplayDataDiemHP();
        }
        private void CreateDiemHP()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                String sql = " INSERT INTO DIEMHP( MaSV, HocKy, NamHoc, Diem, XepLoai) VALUES ( @MaSV, @HocKy, @NamHoc, @Diem, @XepLoai)";
                // khai bao bien trong sql va gan gia tri cho bien
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar);
                cmd.Parameters["@MaSV"].Value = tbMaSV1.Text.ToString();

                cmd.Parameters.Add("@HocKy", SqlDbType.VarChar);
                cmd.Parameters["@HocKy"].Value = cbbHocKy.SelectedItem.ToString();

                cmd.Parameters.Add("@XepLoai", SqlDbType.VarChar);
                cmd.Parameters["@XepLoai"].Value =cbbXepLoai.SelectedItem.ToString();

                cmd.Parameters.Add("@NamHoc", SqlDbType.VarChar);
                cmd.Parameters["@NamHoc"].Value = tbNamHoc.Text.ToString();

                cmd.Parameters.Add("@Diem", SqlDbType.Decimal);
                cmd.Parameters["@Diem"].Value = tbDiem1.Text.ToString();

                cmd.CommandText = sql;
                // thuc thi cau lenh
                cmd.ExecuteNonQuery();

                MessageBox.Show(" them moi thanh cong");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra CreateSinhVien " + ex.Message);
            }
        }

        private void btnDiemHP_Click(object sender, EventArgs e)
        {
            DisplayDataDiemHP();
            CreateDiemHP();
        }
        private void DeleteDIEMHP()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                String sql = " DELETE FROM DIEMHP WHERE MaSV = @MaSv";
                // khai bao bien trong sql va gan gia tri cho bien
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar);
                cmd.Parameters["@MaSV"].Value = tbDeleteUpdateDiemHP.Text.ToString();

                cmd.CommandText = sql;
                // thuc thi cau lenh
                cmd.ExecuteNonQuery();
                MessageBox.Show(" xoa thanh cong");
                // thuc thi cau lenh
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra DeleteDiemHP " + ex.Message);
            }
        }

        private void btnDeleteDiemHP_Click(object sender, EventArgs e)
        {
            String MaSv = tbDeleteUpdateSinhVien.Text.ToString();
            DialogResult re = MessageBox.Show(" ban co chac muon xoa ban ghi " + MaSv, "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                DisplayDataDiemHP();
                DeleteDIEMHP();
            }
            DisplayDataDiemHP();
            DeleteDIEMHP();
        }
        private void UpdateDiemHP()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                string sql = "UPDATE DIEMHP  SET HocKy = @HocKy, NamHoc = @NamHoc, Diem = @Diem, XepLoai = @XepLoai WHERE MaSV = @MaSV";
                // khai bao bien trong sql va gan gia tri cho bien
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar);
                cmd.Parameters["@MaSV"].Value = tbDeleteUpdateDiemHP.Text.ToString();

                cmd.Parameters.Add("@HocKy", SqlDbType.VarChar);
                cmd.Parameters["@HocKy"].Value = cbbHocKy.SelectedItem.ToString();

                cmd.Parameters.Add("@XepLoai", SqlDbType.VarChar);
                cmd.Parameters["@XepLoai"].Value = cbbXepLoai.SelectedItem.ToString();

                cmd.Parameters.Add("@NamHoc", SqlDbType.VarChar);
                cmd.Parameters["@NamHoc"].Value = tbNamHoc.Text.ToString();

                cmd.Parameters.Add("@Diem", SqlDbType.Decimal);
                cmd.Parameters["@Diem"].Value = tbDiem1.Text.ToString();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                MessageBox.Show("du lieu da duoc cap nhat thanh cong ");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cap nhat du lieu chua thanh cong");
            }
        }

        private void btnUpdateDiemHP_Click(object sender, EventArgs e)
        {
            UpdateDiemHP();
            DisplayDataDiemHP();
        }
    }
}
