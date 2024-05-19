using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.WinForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Đặt mặt định from chính / Form mở đầu tiên. 
            //Ở đây cho form Login là form chính, mở đầu nên sau new là Login - muốn form nào mở lên trước thì sau new để trên form đó.
            Application.Run(new LoginForm());
        }
    }
}
