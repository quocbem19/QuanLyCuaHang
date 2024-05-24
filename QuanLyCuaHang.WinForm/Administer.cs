using QuanLyCuaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHang.DataLayer;
using Microsoft.SqlServer.Management.Sdk.Sfc;



namespace QuanLyCuaHang.WinForm
{
    public partial class Administer : Form
    {

        BindingSource foodList = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource accountList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        public Account loginAccount;
        public Administer()
        {
            InitializeComponent();
             LoadData();
        }
       #region methods

        List<Food> SearchFoodByName(string name)
         {
             List<Food> ListFood = FoodDataLayer.Instance.SearchFoodByName(name);

            return ListFood;
         }

        void LoadData()
        {
            //Quản Lý Mặt Hàng
            dtgvFood.DataSource = foodList;
            //Quản Lý Tài khoản
            dtgvAccount.DataSource = accountList;
            //Quản Lý Khu vực
            dtgvTable.DataSource = tableList;
            //Quản Lý Danh mục
            dtgvCategory.DataSource = categoryList;
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListFood();
            LoadListTable();
            LoadAccount();
            LoadListCategory();
            LoadCategoryIntoCombobox(cbFoodCategory);
            AddFoodBinding();
            AddAccountBinding();
        }

        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDataLayer.Instance.GetListAccount();
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }


        void LoadListBillByDate(DateTime chenkIn, DateTime chenkOut)
        {
            dtgvBill.DataSource = BillDataLayer.Instance.GetBillListByDate(chenkIn, chenkOut);
        }

        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }



        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDataLayer.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }


        void LoadListFood()
        {
            foodList.DataSource = FoodDataLayer.Instance.GetListFood();
        }


        void LoadListTable()
        {
            tableList.DataSource = TableDataLayer.Instance.GetListTable();
        }

        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDataLayer.Instance.GetListCategory();
        }

        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDataLayer.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Them Tai Khoan Thanh Cong");
            }else
            {
                MessageBox.Show("Them Tai Khoan That Bai");
            }
            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if(AccountDataLayer.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cap Nhat Tai Khoan Thanh Cong!");
            }
            else
            {
                MessageBox.Show("Cap Nhat Tai Khoan That Bai!");
            }
            LoadAccount();
        }
        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Khong The Xoa Chinh Ban!");
                return;
            }
            if (AccountDataLayer.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xoa Tai Khoan Thanh Cong!");
            }
            else
            {
                MessageBox.Show("Xoa Tai Khoan That Bai!");
            }
            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDataLayer.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Dat Lai Mat Khau Thanh Cong!");
            }
            else
            {
                MessageBox.Show("Dat Lai Mat Khau That Bai!");
            }
        }
        #endregion
        #region events

        private void Admin_Load(object sender, EventArgs e)
        {
         //   this.USP_GetListBillByDateForReportTableAdapter.Fill(this.QuanLyCuaHangDataSet2.USP_GetListBillByDateForReport, dtpkFromDate.Value, dtpkToDate.Value);

         //   this.rpViewer.RefreshReport();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFristBillPage_Click(object sender, EventArgs e)
        {
            txbPageBill.Text = "1";
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)numericUpDown1.Value;

            AddAccount(userName, displayName, type);    
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            DeleteAccount(userName);

        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)numericUpDown1.Value;

            EditAccount(userName, displayName, type);   
        }

        private void btnResetPassWord_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            ResetPass(userName);
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txbSearchFoodName.Text);
        }

        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category category = CategoryDataLayer.Instance.GetCategoryByID(id);

                    cbFoodCategory.SelectedItem = category;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbFoodCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbFoodCategory.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;

            if (FoodDataLayer.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Them Mat Hang Thanh Cong!");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Co Loi Khi Them Mat Hang!");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDataLayer.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sua Mat Hang Thanh Cong!");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Co Loi Khi Sua Mat Hang!");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDataLayer.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xoa Mat Hang Thanh Cong");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Co Loi Khi Xoa Mat Hang");
            }
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        #endregion

        private void btnLastBillPage_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDataLayer.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);

            int lastPage = sumRecord / 10;

            if (sumRecord % 10 != 0)
                lastPage++;

            txbPageBill.Text = lastPage.ToString();
        }

        private void txbPageBill_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDataLayer.Instance.GetBillListByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txbPageBill.Text));
        }

        private void btnPrevioursBillPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPageBill.Text);

            if (page > 1)
                page--;

            txbPageBill.Text = page.ToString();
        }

        private void btnNextBillPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPageBill.Text);
            int sumRecord = BillDataLayer.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);

            if (page < sumRecord)
                page++;

            txbPageBill.Text = page.ToString();
        }

        private void dtgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}