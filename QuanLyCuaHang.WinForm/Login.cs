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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        //Click button Đăng nhập đẩy form Manager
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //show FormManager
            FormManager f = new FormManager();
            this.Hide();
            //Ẩn from phía trước, cụ thể ẩn from đăng nhập sau khi hiện from manager
            //Chỉ thao tác được trên form Dialog
            f.ShowDialog();
            this.Show();
        }
    }
}
