using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            ExecuteReset();
        }

        private void ExecuteReset() {
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
            DtoType type = ComboMaker.GetType(comboBox1.SelectedIndex);
            this.BackColor = System.Drawing.Color.FromArgb(type.RColor, type.GColor, type.BColor);
            DgvMain.BackgroundColor = System.Drawing.Color.FromArgb(type.RColor, type.GColor, type.BColor);
        }

        private void BtnDecide_Click(object sender, EventArgs e)
        {
            ExecuteDecide();
        }

        private void ExecuteDecide()
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
                    DataGridViewRow row = DgvMain.CurrentRow;

                    string unidentifiedName = DgvMain.CurrentRow.Cells[0].Value.ToString();

                    //すでに値が入ってる場合
                    string itemName = row.Cells[1].Value.ToString();
                    ResetItemName(index, row.Index, itemName);

                    UnidentifiedItem unItem = new UnidentifiedItem();
                    unItem.UnidentifiedName = unidentifiedName;
                    unItem.Item = item;

                    if (row.Cells[2].Value != null && int.TryParse(row.Cells[2].Value.ToString(), out int resultBuy))
                    {
                        unItem.MoneyToBuy = resultBuy;
                    }

                    if (row.Cells[3].Value != null && int.TryParse(row.Cells[3].Value.ToString(), out int resultSell))
                    {
                        unItem.MoneyToSell = resultSell;
                    }

                    TableMakerList[index].SetItem(unItem);
                    ItemList[index].Remove(item);


                    SetListBox();

                    DgvMain.CurrentCell = DgvMain.Rows[rowIndex].Cells[0];
                    Console.Write("XXX" + DgvMain.Rows[rowIndex]);
                    return;
                }
            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            ExecuteSet();
        }

        private void ExecuteSet() {
            int index = int.Parse(comboBox1.SelectedValue.ToString());

            int rowIndex = DgvMain.CurrentRow.Index;
            DataGridViewRow row = DgvMain.CurrentRow;

            string unidentifiedName = row.Cells[0].Value.ToString();

            //すでに値が入ってる場合
            string itemName = row.Cells[1].Value.ToString();
            ResetItemName(index, rowIndex, itemName);

            var item = new UnidentifiedItem()
            {
                UnidentifiedName = unidentifiedName
            };

            if (TxbMoneyToBuy.Text != "")
            {
                item.MoneyToBuy = int.Parse(TxbMoneyToBuy.Text);
            }
            else if (row.Cells[2].Value != null && int.TryParse(row.Cells[2].Value.ToString(), out int resultBuy))
            {
                //すでに買値がグリッドビューに入っていた時
                item.MoneyToBuy = resultBuy;
            }

            if (TxbMoneyToSell.Text != "")
            {
                item.MoneyToSell = int.Parse(TxbMoneyToSell.Text);
            }
            else if (row.Cells[3].Value != null && int.TryParse(row.Cells[3].Value.ToString(), out int resultSell))
            {
                //すでに買値がグリッドビューに入っていた時
                item.MoneyToSell = resultSell;
            }

            TableMakerList[index].SetItem(item);

            DgvMain.CurrentCell = DgvMain.Rows[rowIndex].Cells[1];

            //TxbMoneyToBuy.Text = "";
            //TxbMoneyToSell.Text = "";

            SetListBox(DgvMain.Rows[rowIndex]);
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //Spaceが押下されたときアイテム種を変更
            if (e.KeyData == Keys.Space)
            {
                if (comboBox1.SelectedIndex == comboBox1.Items.Count - 1)
                {
                    comboBox1.SelectedIndex = 0;
                    SetDgv();
                }
                else
                {
                    comboBox1.SelectedIndex = comboBox1.SelectedIndex + 1;
                    SetDgv();
                }

                e.Handled = true;
            }
            else if (e.KeyData == Keys.D)
            {
                ExecuteDecide();
                e.Handled = true;
            }
            else if (e.KeyData == Keys.R)
            {
                ExecuteReset();
                e.Handled = true;
            }
            else if (e.KeyData == Keys.M)
            {
                ExecuteSet();
                e.Handled = true;
            }
            else if (e.KeyData == Keys.G)
            {
                DgvMain.Focus();
            }
            else if (e.KeyData == Keys.L)
            {
                LsbItem.Focus();
            }
            else if (!TxbMoneyToSell.Focused && IsPressedNumberOrBackSpace(e.KeyData))
            {
                TxbMoneyToBuy.Focus();
            }
        }

        private void TxbMoneyToBuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsPressedNumberOrBackSpace(e.KeyChar))
            {
                //押されたキーが 0～9でない場合は、テキストボックスに値が入らないようにする
                e.Handled = true;
            }
        }

        private void TxbMoneyToSell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsPressedNumberOrBackSpace(e.KeyChar))
            {
                //押されたキーが 0～9でない場合は、テキストボックスに値が入らないようにする
                e.Handled = true;
            }
        }

        /// <summary>
        /// 押されたキーが 0～9、バックスペースでないときはtrue
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private bool IsPressedNumberOrBackSpace(char key) {
            return (key < '0' || '9' < key) && key != '\b';
        }

        /// <summary>
        /// 押されたキーが 0～9、バックスペースでないときはtrue
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private bool IsPressedNumberOrBackSpace(Keys key) {
            IEnumerable<Keys> keyList = new List<Keys>() {
                Keys.D0, Keys.D1, Keys.D2, Keys.D3,
                Keys.D4, Keys.D5, Keys.D6,
                Keys.D7, Keys.D8, Keys.D9, Keys.Back
            };
            
            foreach (var k in keyList)
            {
                if (key == k) {
                    return true;
                }
            }

            return false;
        }

        private void LsbItem_DoubleClick(object sender, EventArgs e)
        {
            ExecuteDecide();
        }
    }
}
