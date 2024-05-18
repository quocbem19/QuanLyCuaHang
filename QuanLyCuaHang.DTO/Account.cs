using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHang.DTO;


namespace QuanLyCuaHang.DTO
{
    public class Account
    {
        // Constructor dùng cho việc khởi tạo đối tượng Account
        public Account(string userName, string displayName, int type, string password = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.Password = password;
        }

        // Constructor dùng để khởi tạo đối tượng Account từ DataRow
        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Type = (int)row["type"];
            this.Password = row["password"].ToString();
        }

        // Thuộc tính Type
        private int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        // Thuộc tính Password
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // Thuộc tính DisplayName
        private string displayName;
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        // Thuộc tính UserName
        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
