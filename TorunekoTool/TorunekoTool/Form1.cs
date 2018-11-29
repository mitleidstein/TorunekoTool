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
        private List<List<DtoItem>> ItemList;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            int index = int.Parse(comboBox1.SelectedValue.ToString());
            int rowIndex = DgvMain.CurrentRow.Index;
            string itemName = DgvMain.Rows[rowIndex].Cells[1].Value.ToString();
            ResetItemName(index, rowIndex, itemName);
        }

        private void ResetItemName(int typeNum, int rowIndex, string itemName)
        {
            if (itemName != "")
            {
                ItemList[typeNum].Add(TableMakerList[typeNum].SearchItem(itemName));
                TableMakerList[typeNum].ResetItem(itemName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            ComboMaker = new TypeDataTableMaker();
            comboBox1.DataSource = ComboMaker.GetDataTable();
            comboBox1.DisplayMember = "TYPENAME";
            comboBox1.ValueMember = "TYPENUMBER";
            comboBox1.SelectedIndex = 0;

            TableMakerList = new List<ItemDataTableMaker>();

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                var table = new ItemDataTableMaker();
                table.CreateDataTable(i);
                TableMakerList.Add(table);
            }

            GetItemList();
            SetDgv();
        }

        private void SetDgv()
        {
            try
            {
                int index = int.Parse(comboBox1.SelectedValue.ToString());
                SetListBox(index);
                DgvMain.DataSource = TableMakerList[index].Table;
            }
            catch
            {
            }
        }

        private void GetItemList()
        {
            ItemList = new List<List<DtoItem>>();

            var dao = new DaoItem();
            dao.OpenConnection();

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {

                ItemList.Add(dao.GetItemList(new DtoItem()
                {
                    TypeNumber = i
                }));
            }

            dao.CloseConnection();
        }

        private void SetListBox(DtoItem item)
        {
            LsbItem.Items.Clear();

            int index = int.Parse(comboBox1.SelectedValue.ToString());

            foreach (var retItem in ItemList[index])
            {
                if (item.MoneyToBuy != null && item.MoneyToBuy != retItem.MoneyToBuy)
                {
                    continue;
                }

                if (item.MoneyToSell != null && item.MoneyToSell != retItem.MoneyToSell)
                {
                    continue;
                }

                LsbItem.Items.Add(retItem.ItemName);
            }

        }

        private void SetListBox(int type)
        {
            SetListBox(new DtoItem { TypeNumber = type });
        }

        private void SetListBox(DataGridViewRow row)
        {
            if (row == null)
            {
                return;
            }

            var item = new DtoItem();

            if (int.TryParse(comboBox1.SelectedValue.ToString(), out int typeNumber))
            {
                item.TypeNumber = typeNumber;
            }

            if (int.TryParse(row.Cells[2].Value.ToString(), out int moneyToBuy))
            {
                item.MoneyToBuy = moneyToBuy;
            }

            if (int.TryParse(row.Cells[3].Value.ToString(), out int moneyToSell))
            {
                item.MoneyToSell = moneyToSell;
            }

            SetListBox(item);
        }

        private void SetListBox()
        {
            var item = new DtoItem()
            {
                TypeNumber = int.Parse(comboBox1.SelectedValue.ToString())
            };


            if (TxbMoneyToBuy.Text != "")
            {
                item.MoneyToBuy = int.Parse(TxbMoneyToBuy.Text);
            }


            if (TxbMoneyToSell.Text != "")
            {
                item.MoneyToSell = int.Parse(TxbMoneyToSell.Text);
            }

            SetListBox(item);
        }

        private void DgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxbMoneyToBuy_TextChanged(object sender, EventArgs e)
        {
            SetListBox();
        }

        private void TxbMoneyToSell_TextChanged(object sender, EventArgs e)
        {
            SetListBox();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            SetDgv();
        }

        private void BtnDecide_Click(object sender, EventArgs e)
        {
            if (LsbItem.SelectedItem == null)
            {
                return;
            }


            int index = int.Parse(comboBox1.SelectedValue.ToString());

            foreach (var item in ItemList[index])
            {
                if (item.ItemName == LsbItem.SelectedItem.ToString())
                {
                    int rowIndex = DgvMain.CurrentRow.Index;
                    string unidentifiedName = DgvMain.Rows[rowIndex].Cells[0].Value.ToString();

                    //すでに値が入ってる場合
                    string itemName = DgvMain.Rows[rowIndex].Cells[1].Value.ToString();
                    ResetItemName(index, rowIndex, itemName);

                    UnidentifiedItem unItem = new UnidentifiedItem();
                    unItem.UnidentifiedName = unidentifiedName;
                    unItem.Item = item;
                    TableMakerList[index].SetItem(unItem);
                    ItemList[index].Remove(item);

                    DgvMain.CurrentCell = DgvMain.Rows[rowIndex].Cells[1];
                    SetListBox();
                    return;
                }
            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            int index = int.Parse(comboBox1.SelectedValue.ToString());

            int rowIndex = DgvMain.CurrentRow.Index;
            string unidentifiedName = DgvMain.Rows[rowIndex].Cells[0].Value.ToString();

            //すでに値が入ってる場合
            string itemName = DgvMain.Rows[rowIndex].Cells[1].Value.ToString();
            ResetItemName(index, rowIndex, itemName);

            var item = new UnidentifiedItem()
            {
                UnidentifiedName = unidentifiedName
            };

            if (TxbMoneyToBuy.Text != "")
            {
                item.MoneyToBuy = int.Parse(TxbMoneyToBuy.Text);
            }


            if (TxbMoneyToSell.Text != "")
            {
                item.MoneyToSell = int.Parse(TxbMoneyToSell.Text);
            }

            TableMakerList[index].SetItem(item);

            DgvMain.CurrentCell = DgvMain.Rows[rowIndex].Cells[1];

            TxbMoneyToBuy.Text = "";
            TxbMoneyToSell.Text = "";

            SetListBox(DgvMain.CurrentRow);
            return;
        }

        private void DgvMain_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = DgvMain.CurrentRow;
            if (row == null)
            {
                return;
            }
            if (row.Cells[2] != null) {
                TxbMoneyToBuy.Text = row.Cells[2].Value.ToString();
            }

            if (row.Cells[3] != null)
            {
                TxbMoneyToSell.Text = row.Cells[3].Value.ToString();
            }

            SetListBox(DgvMain.CurrentRow);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Initialize();
        }
    }
}
