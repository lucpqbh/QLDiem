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
namespace QLdiem
{
    public partial class User : Form
    {
        SqlConnection conn;
        public User()
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
        private void User_Load(object sender, EventArgs e)
        {
            DisplayDataDiemHP();
        }
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
                dgv.DataSource = data;
                MessageBox.Show(" lay du lieu thanh cong!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra DisplayDiemHP " + ex.Message);
            }

        }
        private void SearchDiemHP(string MaSV)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "SELECT MaSV, HocKy, NamHoc, Diem, XepLoai FROM DIEMHP WHERE MaSV = @MaSV";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar);
                cmd.Parameters["@MaSV"].Value = MaSV;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Đọc thông tin điểm danh của sinh viên từ dữ liệu đọc được
                    string MaSVResult = reader["MaSV"].ToString();
                    string HocKyResult = reader["HocKy"].ToString();
                    string XepLoaiResult = reader["XepLoai"].ToString();
                    string NamHocResult = reader["NamHoc"].ToString();
                    string DiemResult = reader["Diem"].ToString();

                    // Hiển thị thô string DiemResult = reader["Diem"].ToString();ng tin điểm danh hoặc làm gì đó với thông tin này
                    MessageBox.Show("MaSV: " + MaSVResult + "\nHocKy: " + HocKyResult + "\nXepLoai: " + XepLoaiResult+
                        "\nNamHoc: " + NamHocResult + "\nDiem: " + DiemResult);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin điểm danh của sinh viên theo MaSV: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string MaSV = tbMaSV.Text;
            SearchDiemHP(MaSV);
            DisplayDataDiemHP();
        }
    }
}
