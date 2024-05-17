using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyCuaHang.DTO;

namespace QuanLyCuaHang.DataLayer
{
    public class TableDataLayer
    {
        private static TableDataLayer instance;

        public static TableDataLayer Instance
        {
            get { if (instance == null) instance = new TableDataLayer(); return TableDataLayer.instance; }
            private set { TableDataLayer.instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private TableDataLayer() { }

        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 });
        }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public IList<Table> GetListTable()
        {

            List<Table> list = new List<Table>();

            string query = "select * from TableFood";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                list.Add(table);
            }

            return list;
        }
    }
}