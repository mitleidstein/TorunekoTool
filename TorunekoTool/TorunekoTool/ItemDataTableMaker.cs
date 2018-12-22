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
        private List<UnidentifiedItem> UnidentifiedList;
        private List<DtoItem> ItemList;

        public void CreateDataTable(int type) {
            Table = new DataTable();


            var column1 = new DataColumn("未識別名", typeof(string));
            var column2 = new DataColumn("アイテム名", typeof(string));
            var column3 = new DataColumn("買値", typeof(int));
            var column4 = new DataColumn("売値", typeof(int));
            var column5 = new DataColumn("説明", typeof(string));

            Table.Columns.Add(column1);
            Table.Columns.Add(column2);
            Table.Columns.Add(column3);
            Table.Columns.Add(column4);
            Table.Columns.Add(column5);

            DaoItem dao = new DaoItemNoDb();

            try
            {
                dao.OpenConnection();
                UnidentifiedList = dao.GetUnidentifiedItemList(
                    new DtoItem()
                    {
                        TypeNumber = type
                    });
                ItemList = dao.GetItemList(
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

            if (UnidentifiedList != null && UnidentifiedList.Count != 0)
            {
                foreach (var item in UnidentifiedList)
                {
                    string itemName = "";
                    string note = "";
                    if (item.Item != null)
                    {
                        itemName = item.Item.ItemName;
                        note = item.Item.Note;
                    }

                    Table.Rows.Add(
                        new object[]
                        {
                            item.UnidentifiedName, itemName, item.MoneyToBuy, item.MoneyToSell, note
                        });

                }
            }
        }

        public void SetItem(UnidentifiedItem argItem)
        {
            foreach (var unidentifiedItem in UnidentifiedList)
            {
                if (argItem.UnidentifiedName == unidentifiedItem.UnidentifiedName) {
                    unidentifiedItem.Item = argItem.Item;
                    unidentifiedItem.MoneyToBuy = argItem.MoneyToBuy;
                    unidentifiedItem.MoneyToSell = argItem.MoneyToSell;

                    SetDataTable();
                    return;
                }
            }
        }

        public DtoItem SearchItem(string itemName)
        {
            foreach (DtoItem item in ItemList)
            {
                if (item.ItemName == itemName)
                {
                    DtoItem retItem = new DtoItem()
                    {
                        ItemName = item.ItemName,
                        MoneyToBuy = item.MoneyToBuy,
                        MoneyToSell = item.MoneyToSell,
                        Note = item.Note
                    };
                    return retItem;
                }
            }
            return null;
        }

        public bool ResetItem(string itemName)
        {
            foreach (var unItem in UnidentifiedList)
            {
                if (unItem.Item != null && unItem.Item.ItemName == itemName)
                {
                    unItem.Item = null;
                    SetDataTable();
                    return true;
                }
            }
            return false;
        }
    }
}
