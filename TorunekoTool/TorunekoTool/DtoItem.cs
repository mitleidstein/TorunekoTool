namespace TorunekoTool
{
    public class DtoItem
    {
        public string ItemName { get; set; }
        public int? MoneyToBuy { get; set; }
        public int? MoneyToSell { get; set; }
        public int TypeNumber { get; set; }
        public string Note { get; set; }

        public DtoItem()
        {
        }

        public DtoItem(string itemName, int typeNum, int moneyToBuy, int moneyToSell, string note)
        {
            ItemName = itemName;
            MoneyToBuy = moneyToBuy;
            MoneyToSell = moneyToSell;
            TypeNumber = typeNum;
            Note = note;
        }
    }
}