﻿using System;
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

                    item.UnidentifiedName = unidentifiedName;
                    TableMakerList[index].SetItem(item);
                    ItemList[index].Remove(item);

                    SetListBox();
                    DgvMain.CurrentCell = DgvMain.Rows[rowIndex].Cells[0];
                    return;
                }
            }

        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            int index = int.Parse(comboBox1.SelectedValue.ToString());

            int rowIndex = DgvMain.CurrentRow.Index;
            string unidentifiedName = DgvMain.Rows[rowIndex].Cells[0].Value.ToString();

            var item = new DtoItem()
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
