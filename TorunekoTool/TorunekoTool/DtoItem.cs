using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorunekoTool
{
    public class DtoItem
    {
        public string ItemName{ get; set; }
        public string UnidentifiedName { get; set; }
        public int? MoneyToBuy { get; set; }
        public int? MoneyToSell { get; set; }
        public int TypeNumber { get; set; }
        public string Note { get; set; }
    }
}
