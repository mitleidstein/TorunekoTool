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
            var toru = new ItemsToruneko3();
            return toru.GetUnidentifiedItemList(item.TypeNumber);
        }

        public override List<DtoType> GetTypeList()
        {
            var toru = new ItemsToruneko3();
            return toru.GetTypeList();
        }

        public override List<DtoItem> GetItemList(DtoItem item)
        {
            var toru = new ItemsToruneko3();

            return toru.GetItemList(item.TypeNumber);
        }

        public override void CloseConnection()
        {
        }

    }
}
