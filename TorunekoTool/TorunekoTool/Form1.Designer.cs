﻿namespace TorunekoTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvMain = new System.Windows.Forms.DataGridView();
            this.LblType = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblMoneyToBuy = new System.Windows.Forms.Label();
            this.LblMoneyToSell = new System.Windows.Forms.Label();
            this.LsbItem = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnSet = new System.Windows.Forms.Button();
            this.TxbMoneyToBuy = new System.Windows.Forms.TextBox();
            this.TxbMoneyToSell = new System.Windows.Forms.TextBox();
            this.BtnSwitch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMain
            // 
            this.DgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMain.Location = new System.Drawing.Point(12, 169);
            this.DgvMain.Name = "DgvMain";
            this.DgvMain.RowTemplate.Height = 27;
            this.DgvMain.Size = new System.Drawing.Size(458, 260);
            this.DgvMain.TabIndex = 0;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(62, 29);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(44, 18);
            this.LblType.TabIndex = 1;
            this.LblType.Text = "種類";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(547, 29);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(100, 18);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "アイテム候補";
            // 
            // LblMoneyToBuy
            // 
            this.LblMoneyToBuy.AutoSize = true;
            this.LblMoneyToBuy.Location = new System.Drawing.Point(547, 179);
            this.LblMoneyToBuy.Name = "LblMoneyToBuy";
            this.LblMoneyToBuy.Size = new System.Drawing.Size(44, 18);
            this.LblMoneyToBuy.TabIndex = 3;
            this.LblMoneyToBuy.Text = "買値";
            // 
            // LblMoneyToSell
            // 
            this.LblMoneyToSell.AutoSize = true;
            this.LblMoneyToSell.Location = new System.Drawing.Point(547, 270);
            this.LblMoneyToSell.Name = "LblMoneyToSell";
            this.LblMoneyToSell.Size = new System.Drawing.Size(44, 18);
            this.LblMoneyToSell.TabIndex = 4;
            this.LblMoneyToSell.Text = "売値";
            // 
            // LsbItem
            // 
            this.LsbItem.FormattingEnabled = true;
            this.LsbItem.ItemHeight = 18;
            this.LsbItem.Location = new System.Drawing.Point(550, 61);
            this.LsbItem.Name = "LsbItem";
            this.LsbItem.Size = new System.Drawing.Size(120, 94);
            this.LsbItem.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 6;
            // 
            // BtnSet
            // 
            this.BtnSet.Location = new System.Drawing.Point(572, 370);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(75, 32);
            this.BtnSet.TabIndex = 9;
            this.BtnSet.Text = "決定";
            this.BtnSet.UseVisualStyleBackColor = true;
            // 
            // TxbMoneyToBuy
            // 
            this.TxbMoneyToBuy.Location = new System.Drawing.Point(550, 215);
            this.TxbMoneyToBuy.Name = "TxbMoneyToBuy";
            this.TxbMoneyToBuy.Size = new System.Drawing.Size(100, 25);
            this.TxbMoneyToBuy.TabIndex = 10;
            // 
            // TxbMoneyToSell
            // 
            this.TxbMoneyToSell.Location = new System.Drawing.Point(550, 305);
            this.TxbMoneyToSell.Name = "TxbMoneyToSell";
            this.TxbMoneyToSell.Size = new System.Drawing.Size(100, 25);
            this.TxbMoneyToSell.TabIndex = 11;
            // 
            // BtnSwitch
            // 
            this.BtnSwitch.Location = new System.Drawing.Point(278, 49);
            this.BtnSwitch.Name = "BtnSwitch";
            this.BtnSwitch.Size = new System.Drawing.Size(76, 31);
            this.BtnSwitch.TabIndex = 12;
            this.BtnSwitch.Text = "切替";
            this.BtnSwitch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSwitch);
            this.Controls.Add(this.TxbMoneyToSell);
            this.Controls.Add(this.TxbMoneyToBuy);
            this.Controls.Add(this.BtnSet);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LsbItem);
            this.Controls.Add(this.LblMoneyToSell);
            this.Controls.Add(this.LblMoneyToBuy);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.DgvMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMain;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblMoneyToBuy;
        private System.Windows.Forms.Label LblMoneyToSell;
        private System.Windows.Forms.ListBox LsbItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.TextBox TxbMoneyToBuy;
        private System.Windows.Forms.TextBox TxbMoneyToSell;
        private System.Windows.Forms.Button BtnSwitch;
    }
}
