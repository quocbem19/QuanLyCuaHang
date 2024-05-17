using QuanLyCuaHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHang.DTO;

namespace QuanLyCuaHang.DataLayer
{
    public class BillInfoDataLayer
    {
        private static BillInfoDataLayer instance;

        public static BillInfoDataLayer Instance
        {
            get { if (instance == null) instance = new BillInfoDataLayer(); return BillInfoDataLayer.instance; }
            private set { BillInfoDataLayer.instance = value; }
        }

        private BillInfoDataLayer() { }

        public void DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.BillInfo WHERE idFood = " + id);
        }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE idBill = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }
    }
}
