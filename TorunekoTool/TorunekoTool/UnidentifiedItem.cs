using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorunekoTool
{
    public class UnidentifiedItem
    {
        public string UnidentifiedName { get; set; }
        public DtoItem Item { get; set; }
        public int? MoneyToBuy { get; set; }
        public int? MoneyToSell { get; set; }
        public int TypeNumber { get; set; }

        public UnidentifiedItem ()
        {
        }

        public UnidentifiedItem(string unidentifiedName, int typeNumber)
        {
            UnidentifiedName = unidentifiedName;
            TypeNumber = TypeNumber;
        }
    }
}
