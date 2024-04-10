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
    public partial class Login : Form
    {
        SqlConnection conn;
        public Login()
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
    
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                conn.Open();
                // khai bao lenh 
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu lenh 
                cmd.CommandType = System.Data.CommandType.Text;
                // Sử dụng tham số trong câu lệnh SQL
                cmd.CommandText = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";

                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters["@username"].Value = tbUsername.Text.ToString();

                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters["@password"].Value = tbPassword.Text.ToString();


                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int role = Convert.ToInt32(reader["Role"]);

                    // Kiểm tra giá trị của role và thực hiện hành động tương ứng
                    if (role == 0)
                    {
                        MessageBox.Show("Đăng nhập thành công với vai trò Admin!");
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide(); // Ẩn form hiện tại
                    }
                    else if (role == 1)
                    {
                        MessageBox.Show("Đăng nhập thành công với vai trò User!");
                        User user = new User();
                        user.Show();
                        this.Hide(); // Ẩn form hiện tại
                    }
                    else
                    {
                        MessageBox.Show("Vai trò không hợp lệ!");
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra ở btnLogin_Click " + ex.Message);
            }
        }

    }
}
