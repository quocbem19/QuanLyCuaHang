using QuanLyCuaHang.DTO; // Đảm bảo bạn có tham chiếu này
using QuanLyCuaHang.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.WinForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        //Thoát chương trình sẽ xuất hiện form thông báo. tránh nhầm lẫn khi nhấn nhầm
        //Sử dụng FormClosing để áp dụng tất cả trường hợp thoát chương trình
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }



        //nút đăng nhập
        //Click button Đăng nhập đẩy form Manager
        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string password = txbPassWord.Text;
            if (PerformLogin(userName, password))
            {
                Account loginAccount = AccountDataLayer.Instance.GetAccountByUserName(userName); // Dòng 55

                // Tạo một đối tượng AccountProfile từ thông tin của đối tượng Account
                AccountProfile loginProfile = new AccountProfile(loginAccount);

                // Show FormManager với đối tượng AccountProfile vừa tạo
                FormManager f = new FormManager(loginProfile);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập lại, Tài Khoản Hoặc Mật Khẩu!");
            }
        }


        bool PerformLogin(string userName, string password)
        {
            return AccountDataLayer.Instance.Login(userName, password);
        }

        //nút thoát 
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
