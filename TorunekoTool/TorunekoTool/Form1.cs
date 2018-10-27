using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorunekoTool
{
    public partial class Form1 : Form
    {
        private List<ItemDataTableMaker> TableMakerList;
        private TypeDataTableMaker ComboMaker;
        private List<DtoItem> ItemList;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            SetDgv();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboMaker = new TypeDataTableMaker();
            comboBox1.DataSource = ComboMaker.GetDataTable();
            comboBox1.DisplayMember = "TYPENAME";
            comboBox1.ValueMember = "TYPENUMBER";

            TableMakerList = new List<ItemDataTableMaker>();

            for (int i=0; i<comboBox1.Items.Count; i++) {
                var table = new ItemDataTableMaker();
                table.CreateDataTable(i);
                TableMakerList.Add(table);
            }

            SetDgv();
        }

        private void SetDgv()
        {
            int index = int.Parse(comboBox1.SelectedValue.ToString());
            DgvMain.DataSource = TableMakerList[index].Table;
            
            SetListBox(index);
        }

        private void SetListBox(DtoItem item) {
            LsbItem.Items.Clear();

            var dao = new DaoItem();
            dao.OpenConnection();
            ItemList = dao.GetItemList(item);

            foreach (var retItem in ItemList) {
                LsbItem.Items.Add(retItem.ItemName);
            }

            dao.CloseConnection();
        }

        private void SetListBox(int type)
        {
            SetListBox(new DtoItem { TypeNumber = type });
        }

        private void DgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1) {
                return;
            }


        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            var item = new DtoItem() {
                TypeNumber = int.Parse(comboBox1.SelectedValue.ToString())
            };


            if (TxbMoneyToBuy.Text != "") {
                item.MoneyToBuy = int.Parse(TxbMoneyToBuy.Text);
            }


            if (TxbMoneyToSell.Text != "")
            {
                item.MoneyToSell = int.Parse(TxbMoneyToSell.Text);
            }

            TableMakerList[index].SetItem(item);

            DgvMain.CurrentCell = DgvMain.Rows[rowIndex].Cells[0];

            TxbMoneyToBuy.Text = "";
            TxbMoneyToSell.Text = "";
            return;
        }

        private void DgvMain_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DgvMain.CurrentRow == null) {
                return;
            }

            var item = new DtoItem();

            if (int.TryParse(comboBox1.SelectedValue.ToString(), out int typeNumber))
            {
                item.TypeNumber = typeNumber;
            }

            if (int.TryParse(DgvMain.CurrentRow.Cells[2].Value.ToString(), out int moneyToBuy))
            {
                item.MoneyToBuy = moneyToBuy;
            }

            if (int.TryParse(DgvMain.CurrentRow.Cells[3].Value.ToString(), out int moneyToSell))
            {
                item.MoneyToSell = moneyToSell;
            }

            SetListBox(item);
        }
    }
}
