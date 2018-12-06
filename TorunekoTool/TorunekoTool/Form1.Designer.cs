namespace TorunekoTool
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
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnDecide = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMain
            // 
            this.DgvMain.AllowUserToAddRows = false;
            this.DgvMain.AllowUserToDeleteRows = false;
            this.DgvMain.AllowUserToResizeRows = false;
            this.DgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMain.Location = new System.Drawing.Point(21, 115);
            this.DgvMain.MultiSelect = false;
            this.DgvMain.Name = "DgvMain";
            this.DgvMain.ReadOnly = true;
            this.DgvMain.RowTemplate.Height = 24;
            this.DgvMain.Size = new System.Drawing.Size(971, 526);
            this.DgvMain.TabIndex = 0;
            this.DgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMain_CellContentClick);
            this.DgvMain.CurrentCellChanged += new System.EventHandler(this.DgvMain_CurrentCellChanged);
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(62, 29);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(201, 18);
            this.LblType.TabIndex = 1;
            this.LblType.Text = "種類（スペースキーで変更）";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(1080, 29);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(100, 18);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "アイテム候補";
            // 
            // LblMoneyToBuy
            // 
            this.LblMoneyToBuy.AutoSize = true;
            this.LblMoneyToBuy.Location = new System.Drawing.Point(1080, 441);
            this.LblMoneyToBuy.Name = "LblMoneyToBuy";
            this.LblMoneyToBuy.Size = new System.Drawing.Size(44, 18);
            this.LblMoneyToBuy.TabIndex = 3;
            this.LblMoneyToBuy.Text = "買値";
            // 
            // LblMoneyToSell
            // 
            this.LblMoneyToSell.AutoSize = true;
            this.LblMoneyToSell.Location = new System.Drawing.Point(1080, 522);
            this.LblMoneyToSell.Name = "LblMoneyToSell";
            this.LblMoneyToSell.Size = new System.Drawing.Size(44, 18);
            this.LblMoneyToSell.TabIndex = 4;
            this.LblMoneyToSell.Text = "売値";
            // 
            // LsbItem
            // 
            this.LsbItem.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LsbItem.FormattingEnabled = true;
            this.LsbItem.ItemHeight = 22;
            this.LsbItem.Location = new System.Drawing.Point(1042, 61);
            this.LsbItem.Name = "LsbItem";
            this.LsbItem.Size = new System.Drawing.Size(218, 290);
            this.LsbItem.TabIndex = 5;
            this.LsbItem.DoubleClick += new System.EventHandler(this.LsbItem_DoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // BtnSet
            // 
            this.BtnSet.Location = new System.Drawing.Point(1113, 609);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(147, 32);
            this.BtnSet.TabIndex = 9;
            this.BtnSet.Text = "価格決定(M)";
            this.BtnSet.UseVisualStyleBackColor = true;
            this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // TxbMoneyToBuy
            // 
            this.TxbMoneyToBuy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxbMoneyToBuy.Location = new System.Drawing.Point(1083, 477);
            this.TxbMoneyToBuy.Name = "TxbMoneyToBuy";
            this.TxbMoneyToBuy.Size = new System.Drawing.Size(100, 25);
            this.TxbMoneyToBuy.TabIndex = 10;
            this.TxbMoneyToBuy.TextChanged += new System.EventHandler(this.TxbMoneyToBuy_TextChanged);
            this.TxbMoneyToBuy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbMoneyToBuy_KeyPress);
            // 
            // TxbMoneyToSell
            // 
            this.TxbMoneyToSell.Location = new System.Drawing.Point(1083, 557);
            this.TxbMoneyToSell.Name = "TxbMoneyToSell";
            this.TxbMoneyToSell.Size = new System.Drawing.Size(100, 25);
            this.TxbMoneyToSell.TabIndex = 11;
            this.TxbMoneyToSell.TextChanged += new System.EventHandler(this.TxbMoneyToSell_TextChanged);
            this.TxbMoneyToSell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbMoneyToSell_KeyPress);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(1042, 370);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(106, 31);
            this.BtnReset.TabIndex = 12;
            this.BtnReset.Text = "リセット(R)";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnDecide
            // 
            this.BtnDecide.Location = new System.Drawing.Point(1165, 370);
            this.BtnDecide.Name = "BtnDecide";
            this.BtnDecide.Size = new System.Drawing.Size(95, 31);
            this.BtnDecide.TabIndex = 13;
            this.BtnDecide.Text = "決定(D)";
            this.BtnDecide.UseVisualStyleBackColor = true;
            this.BtnDecide.Click += new System.EventHandler(this.BtnDecide_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(563, 48);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(120, 30);
            this.BtnNew.TabIndex = 14;
            this.BtnNew.Text = "新しい冒険";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 670);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnDecide);
            this.Controls.Add(this.BtnReset);
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
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
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
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnDecide;
        private System.Windows.Forms.Button BtnNew;
    }
}

