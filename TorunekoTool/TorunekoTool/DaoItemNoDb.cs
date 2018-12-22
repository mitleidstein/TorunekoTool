using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorunekoTool
{
    public class DaoItemNoDb : DaoItem
    {
        public override void OpenConnection()
        {
        }

        public override List<UnidentifiedItem> GetUnidentifiedItemList(DtoItem item)
        {
            var unidentifiedItems = new List<UnidentifiedItem>();
            return unidentifiedItems;
        }

        public override List<DtoType> GetTypeList()
        {
            var typeList = new List<DtoType>();
            return typeList;
        }

        public override List<DtoItem> GetItemList(DtoItem item)
        {
            var itemList = new List<DtoItem>();

            return itemList;
        }

        public override List<DtoItem> SearchItem(DtoItem item)
        {
            var itemList = new List<DtoItem>();

            
            return itemList;
        }

        public override int GetTypeNumber()
        {
            return 0;
        }

        public override void CloseConnection()
        {
        }

    }
}
