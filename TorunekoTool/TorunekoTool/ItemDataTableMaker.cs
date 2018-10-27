using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorunekoTool
{
    public class ItemDataTableMaker
    {
        public DataTable Table { get; private set; }
        private List<DtoItem> ItemList;

        public void CreateDataTable(int type) {
            Table = new DataTable();


            var column1 = new DataColumn("UNIDENTIFIEDNAME", typeof(string));
            var column2 = new DataColumn("NAME", typeof(string));
            var column3 = new DataColumn("MONEYTOBUY", typeof(int));
            var column4 = new DataColumn("MONEYTOSELL", typeof(int));
            var column5 = new DataColumn("NOTE", typeof(string));

            Table.Columns.Add(column1);
            Table.Columns.Add(column2);
            Table.Columns.Add(column3);
            Table.Columns.Add(column4);
            Table.Columns.Add(column5);

            DaoItem dao = new DaoItem();

            try
            {
                dao.OpenConnection();
                ItemList = dao.GetUnidentifiedItemList(
                    new DtoItem()
                    {
                        TypeNumber = type
                    });
            }
            finally
            {
                dao.CloseConnection();
            }

            SetDataTable();
        }

        private void SetDataTable() {
            Table.Clear();

            if (ItemList != null && ItemList.Count != 0)
            {
                foreach (var item in ItemList)
                {
                    Table.Rows.Add(
                        new object[]
                        {
                            item.UnidentifiedName, item.ItemName, item.MoneyToBuy, item.MoneyToSell, item.Note
                        });

                }
            }
        }

        public void SetItem(DtoItem item)
        {
            foreach (var unidetifiedItem in ItemList)
            {
                if (item.UnidentifiedName == unidetifiedItem.UnidentifiedName) {
                    unidetifiedItem.ItemName = item.ItemName;
                    unidetifiedItem.MoneyToBuy = item.MoneyToBuy;
                    unidetifiedItem.MoneyToSell = item.MoneyToSell;
                    unidetifiedItem.Note = item.Note;

                    SetDataTable();
                    return;
                }
            }
        }

    }
}
