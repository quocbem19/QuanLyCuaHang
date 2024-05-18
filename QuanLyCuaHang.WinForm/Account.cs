using QuanLyCuaHang.DataLayer;
using QuanLyCuaHang.DTO;
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
    public partial class Account : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; ChangeAccount(LoginAccount); }
            set { loginAccount = value; ChangeAccount(LoginAccount); }
        }
        public Account( Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }


        void ChangeAccount(Account acc) 
        {
            txbUserName.Text = LoginAccount.UserName;
            txbDisplayName.Text = LoginAccount.DisplayName;
        }
        void UpdateAccountInfo()
        {
            string displayName = txbDisplayName.Text;
            string password = txbPassWord.Text;
            string newpass = txbNewPass.Text;
            string reenterPass = txbReEnterPass.Text;
            string userName = txbUserName.Text;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui Long Nhap Lai Mat Khau Dung Mat Khau Moi!");
            }else
            {
                if(AccountDataLayer.Instance.UpdateAccount(userName, displayName, password, newpass))
                {
                    MessageBox.Show("Cap nhat tai khoan thanh cong!");
                    if(updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDataLayer.Instance.GetAccountByUserName(userName)));
                }else
                {
                    MessageBox.Show("Vui long dien dung mat khau!");
                }            
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

    }

    public class AccountEvent:EventArgs
    {
        public Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(Account acc)
        {
            this.Acc = acc; 
        }
    }
}
