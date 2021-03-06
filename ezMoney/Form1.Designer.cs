﻿namespace ezMoney
{
    partial class EZMoneyForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._tableLayoutPanelCategory = new System.Windows.Forms.TableLayoutPanel();
            this._categoryNameLabel = new System.Windows.Forms.Label();
            this._textBoxCategoryName = new System.Windows.Forms.TextBox();
            this._buttonCategoryAdd = new System.Windows.Forms.Button();
            this._listBoxCategories = new System.Windows.Forms.ListBox();
            this._buttonCategoryModify = new System.Windows.Forms.Button();
            this._buttonCategoryDelete = new System.Windows.Forms.Button();
            this._buttonCategoryCancel = new System.Windows.Forms.Button();
            this._errorProviderCategory = new System.Windows.Forms.ErrorProvider(this.components);
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabPageCategory = new System.Windows.Forms.TabPage();
            this._tabPageRecord = new System.Windows.Forms.TabPage();
            this._tableLayoutPanelRecord = new System.Windows.Forms.TableLayoutPanel();
            this._radioButtonIncome = new System.Windows.Forms.RadioButton();
            this._radioButtonExpense = new System.Windows.Forms.RadioButton();
            this._dateTimePickerRecord = new System.Windows.Forms.DateTimePicker();
            this._comboBoxCategory = new System.Windows.Forms.ComboBox();
            this._textBoxRecordAmount = new System.Windows.Forms.TextBox();
            this._buttonRecordAdd = new System.Windows.Forms.Button();
            this._dataGridViewRecord = new System.Windows.Forms.DataGridView();
            this._buttonRecordModify = new System.Windows.Forms.Button();
            this._buttonRecordDelete = new System.Windows.Forms.Button();
            this._buttonRecordCancel = new System.Windows.Forms.Button();
            this._tabPageStatistic = new System.Windows.Forms.TabPage();
            this._tableLayoutPanelStatistic = new System.Windows.Forms.TableLayoutPanel();
            this._labelStatisticIncome = new System.Windows.Forms.Label();
            this._labelStatisticExpense = new System.Windows.Forms.Label();
            this._labelBalance = new System.Windows.Forms.Label();
            this._labelStatisticDetail = new System.Windows.Forms.Label();
            this._radioButtonStatisticIncome = new System.Windows.Forms.RadioButton();
            this._radioButtonStatisticExpense = new System.Windows.Forms.RadioButton();
            this._textBoxIncome = new System.Windows.Forms.TextBox();
            this._textBoxExpense = new System.Windows.Forms.TextBox();
            this._textBoxBalance = new System.Windows.Forms.TextBox();
            this._dataGridViewStatisticRecord = new System.Windows.Forms.DataGridView();
            this._dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this._errorProviderRecord = new System.Windows.Forms.ErrorProvider(this.components);
            this._tableLayoutPanelCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProviderCategory)).BeginInit();
            this._tabControl.SuspendLayout();
            this._tabPageCategory.SuspendLayout();
            this._tabPageRecord.SuspendLayout();
            this._tableLayoutPanelRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewRecord)).BeginInit();
            this._tabPageStatistic.SuspendLayout();
            this._tableLayoutPanelStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewStatisticRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProviderRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // _tableLayoutPanelCategory
            // 
            this._tableLayoutPanelCategory.ColumnCount = 3;
            this._tableLayoutPanelCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanelCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this._tableLayoutPanelCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._tableLayoutPanelCategory.Controls.Add(this._categoryNameLabel, 0, 0);
            this._tableLayoutPanelCategory.Controls.Add(this._textBoxCategoryName, 1, 0);
            this._tableLayoutPanelCategory.Controls.Add(this._buttonCategoryAdd, 2, 0);
            this._tableLayoutPanelCategory.Controls.Add(this._listBoxCategories, 0, 2);
            this._tableLayoutPanelCategory.Controls.Add(this._buttonCategoryModify, 0, 1);
            this._tableLayoutPanelCategory.Controls.Add(this._buttonCategoryDelete, 1, 1);
            this._tableLayoutPanelCategory.Controls.Add(this._buttonCategoryCancel, 2, 1);
            this._tableLayoutPanelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelCategory.Location = new System.Drawing.Point(3, 3);
            this._tableLayoutPanelCategory.Name = "_tableLayoutPanelCategory";
            this._tableLayoutPanelCategory.RowCount = 3;
            this._tableLayoutPanelCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._tableLayoutPanelCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._tableLayoutPanelCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelCategory.Size = new System.Drawing.Size(364, 380);
            this._tableLayoutPanelCategory.TabIndex = 0;
            // 
            // _categoryNameLabel
            // 
            this._categoryNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._categoryNameLabel.AutoSize = true;
            this._categoryNameLabel.Location = new System.Drawing.Point(21, 14);
            this._categoryNameLabel.Name = "_categoryNameLabel";
            this._categoryNameLabel.Size = new System.Drawing.Size(48, 12);
            this._categoryNameLabel.TabIndex = 0;
            this._categoryNameLabel.Text = "Category";
            // 
            // _textBoxCategoryName
            // 
            this._textBoxCategoryName.AccessibleName = "textBoxCategoryName";
            this._textBoxCategoryName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._textBoxCategoryName.Location = new System.Drawing.Point(94, 9);
            this._textBoxCategoryName.Name = "_textBoxCategoryName";
            this._textBoxCategoryName.Size = new System.Drawing.Size(157, 22);
            this._textBoxCategoryName.TabIndex = 1;
            this._textBoxCategoryName.TextChanged += new System.EventHandler(this.ChangeCategoryName);
            // 
            // _buttonCategoryAdd
            // 
            this._buttonCategoryAdd.AccessibleName = "buttonCategoryAdd";
            this._buttonCategoryAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._buttonCategoryAdd.Enabled = false;
            this._buttonCategoryAdd.Location = new System.Drawing.Point(271, 8);
            this._buttonCategoryAdd.Name = "_buttonCategoryAdd";
            this._buttonCategoryAdd.Size = new System.Drawing.Size(75, 23);
            this._buttonCategoryAdd.TabIndex = 2;
            this._buttonCategoryAdd.Text = "Add";
            this._buttonCategoryAdd.UseVisualStyleBackColor = true;
            this._buttonCategoryAdd.Click += new System.EventHandler(this.ClickAddCategory);
            // 
            // _listBoxCategories
            // 
            this._listBoxCategories.AccessibleName = "listBoxCategories";
            this._tableLayoutPanelCategory.SetColumnSpan(this._listBoxCategories, 3);
            this._listBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listBoxCategories.FormattingEnabled = true;
            this._listBoxCategories.ItemHeight = 12;
            this._listBoxCategories.Location = new System.Drawing.Point(3, 83);
            this._listBoxCategories.Name = "_listBoxCategories";
            this._listBoxCategories.Size = new System.Drawing.Size(358, 294);
            this._listBoxCategories.TabIndex = 3;
            this._listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.ChangeCategoryListIndex);
            // 
            // _buttonCategoryModify
            // 
            this._buttonCategoryModify.AccessibleName = "buttonCategoryModify";
            this._buttonCategoryModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._buttonCategoryModify.Location = new System.Drawing.Point(8, 43);
            this._buttonCategoryModify.Name = "_buttonCategoryModify";
            this._buttonCategoryModify.Size = new System.Drawing.Size(75, 34);
            this._buttonCategoryModify.TabIndex = 4;
            this._buttonCategoryModify.Text = "Modify";
            this._buttonCategoryModify.UseVisualStyleBackColor = true;
            this._buttonCategoryModify.Click += new System.EventHandler(this.ClickCategoryModifyButton);
            // 
            // _buttonCategoryDelete
            // 
            this._buttonCategoryDelete.AccessibleName = "buttonCategoryDelete";
            this._buttonCategoryDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._buttonCategoryDelete.Location = new System.Drawing.Point(135, 43);
            this._buttonCategoryDelete.Name = "_buttonCategoryDelete";
            this._buttonCategoryDelete.Size = new System.Drawing.Size(75, 34);
            this._buttonCategoryDelete.TabIndex = 5;
            this._buttonCategoryDelete.Text = "Delete";
            this._buttonCategoryDelete.UseVisualStyleBackColor = true;
            this._buttonCategoryDelete.Click += new System.EventHandler(this.ClickCategoryDeleteButton);
            // 
            // _buttonCategoryCancel
            // 
            this._buttonCategoryCancel.AccessibleName = "buttonCategoryCancel";
            this._buttonCategoryCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._buttonCategoryCancel.Location = new System.Drawing.Point(271, 43);
            this._buttonCategoryCancel.Name = "_buttonCategoryCancel";
            this._buttonCategoryCancel.Size = new System.Drawing.Size(75, 34);
            this._buttonCategoryCancel.TabIndex = 6;
            this._buttonCategoryCancel.Text = "Cancel";
            this._buttonCategoryCancel.UseVisualStyleBackColor = true;
            this._buttonCategoryCancel.Click += new System.EventHandler(this.ClickCategoryCancelButton);
            // 
            // _errorProviderCategory
            // 
            this._errorProviderCategory.ContainerControl = this;
            // 
            // _tabControl
            // 
            this._tabControl.AccessibleName = "tabControl";
            this._tabControl.Controls.Add(this._tabPageCategory);
            this._tabControl.Controls.Add(this._tabPageRecord);
            this._tabControl.Controls.Add(this._tabPageStatistic);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.Location = new System.Drawing.Point(0, 0);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(378, 412);
            this._tabControl.TabIndex = 1;
            // 
            // _tabPageCategory
            // 
            this._tabPageCategory.Controls.Add(this._tableLayoutPanelCategory);
            this._tabPageCategory.Location = new System.Drawing.Point(4, 22);
            this._tabPageCategory.Name = "_tabPageCategory";
            this._tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageCategory.Size = new System.Drawing.Size(370, 386);
            this._tabPageCategory.TabIndex = 0;
            this._tabPageCategory.Text = "Category";
            this._tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // _tabPageRecord
            // 
            this._tabPageRecord.AccessibleName = "";
            this._tabPageRecord.Controls.Add(this._tableLayoutPanelRecord);
            this._tabPageRecord.Location = new System.Drawing.Point(4, 22);
            this._tabPageRecord.Name = "_tabPageRecord";
            this._tabPageRecord.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageRecord.Size = new System.Drawing.Size(370, 386);
            this._tabPageRecord.TabIndex = 1;
            this._tabPageRecord.Text = "Record";
            this._tabPageRecord.UseVisualStyleBackColor = true;
            // 
            // _tableLayoutPanelRecord
            // 
            this._tableLayoutPanelRecord.ColumnCount = 4;
            this._tableLayoutPanelRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanelRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanelRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanelRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanelRecord.Controls.Add(this._radioButtonIncome, 2, 0);
            this._tableLayoutPanelRecord.Controls.Add(this._radioButtonExpense, 3, 0);
            this._tableLayoutPanelRecord.Controls.Add(this._dateTimePickerRecord, 0, 0);
            this._tableLayoutPanelRecord.Controls.Add(this._comboBoxCategory, 0, 1);
            this._tableLayoutPanelRecord.Controls.Add(this._textBoxRecordAmount, 1, 1);
            this._tableLayoutPanelRecord.Controls.Add(this._buttonRecordAdd, 3, 1);
            this._tableLayoutPanelRecord.Controls.Add(this._dataGridViewRecord, 0, 3);
            this._tableLayoutPanelRecord.Controls.Add(this._buttonRecordModify, 0, 2);
            this._tableLayoutPanelRecord.Controls.Add(this._buttonRecordDelete, 1, 2);
            this._tableLayoutPanelRecord.Controls.Add(this._buttonRecordCancel, 2, 2);
            this._tableLayoutPanelRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelRecord.Location = new System.Drawing.Point(3, 3);
            this._tableLayoutPanelRecord.Name = "_tableLayoutPanelRecord";
            this._tableLayoutPanelRecord.RowCount = 4;
            this._tableLayoutPanelRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._tableLayoutPanelRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._tableLayoutPanelRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._tableLayoutPanelRecord.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanelRecord.Size = new System.Drawing.Size(364, 380);
            this._tableLayoutPanelRecord.TabIndex = 0;
            // 
            // _radioButtonIncome
            // 
            this._radioButtonIncome.AccessibleName = "radioButtonIncome";
            this._radioButtonIncome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._radioButtonIncome.AutoSize = true;
            this._radioButtonIncome.Checked = true;
            this._radioButtonIncome.Location = new System.Drawing.Point(185, 12);
            this._radioButtonIncome.Name = "_radioButtonIncome";
            this._radioButtonIncome.Size = new System.Drawing.Size(58, 16);
            this._radioButtonIncome.TabIndex = 1;
            this._radioButtonIncome.TabStop = true;
            this._radioButtonIncome.Text = "Income";
            this._radioButtonIncome.UseVisualStyleBackColor = true;
            this._radioButtonIncome.CheckedChanged += new System.EventHandler(this.ChangeRecordRadioButton);
            // 
            // _radioButtonExpense
            // 
            this._radioButtonExpense.AccessibleName = "radioButtonExpense";
            this._radioButtonExpense.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._radioButtonExpense.AutoSize = true;
            this._radioButtonExpense.Location = new System.Drawing.Point(276, 12);
            this._radioButtonExpense.Name = "_radioButtonExpense";
            this._radioButtonExpense.Size = new System.Drawing.Size(62, 16);
            this._radioButtonExpense.TabIndex = 2;
            this._radioButtonExpense.Text = "Expense";
            this._radioButtonExpense.UseVisualStyleBackColor = true;
            this._radioButtonExpense.CheckedChanged += new System.EventHandler(this.ChangeRecordRadioButton);
            // 
            // _dateTimePickerRecord
            // 
            this._dateTimePickerRecord.AccessibleName = "dateTimePickerRecord";
            this._dateTimePickerRecord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._tableLayoutPanelRecord.SetColumnSpan(this._dateTimePickerRecord, 2);
            this._dateTimePickerRecord.Location = new System.Drawing.Point(3, 9);
            this._dateTimePickerRecord.Name = "_dateTimePickerRecord";
            this._dateTimePickerRecord.Size = new System.Drawing.Size(176, 22);
            this._dateTimePickerRecord.TabIndex = 0;
            this._dateTimePickerRecord.ValueChanged += new System.EventHandler(this.ChangeDateTimePickerRecordValue);
            // 
            // _comboBoxCategory
            // 
            this._comboBoxCategory.AccessibleName = "comboBoxCategory";
            this._comboBoxCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxCategory.FormattingEnabled = true;
            this._comboBoxCategory.Location = new System.Drawing.Point(3, 50);
            this._comboBoxCategory.Name = "_comboBoxCategory";
            this._comboBoxCategory.Size = new System.Drawing.Size(85, 20);
            this._comboBoxCategory.TabIndex = 3;
            this._comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ChangeCategoryComboBoxIndex);
            // 
            // _textBoxRecordAmount
            // 
            this._textBoxRecordAmount.AccessibleName = "textBoxRecordAmount";
            this._textBoxRecordAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._tableLayoutPanelRecord.SetColumnSpan(this._textBoxRecordAmount, 2);
            this._textBoxRecordAmount.Location = new System.Drawing.Point(94, 49);
            this._textBoxRecordAmount.Name = "_textBoxRecordAmount";
            this._textBoxRecordAmount.Size = new System.Drawing.Size(176, 22);
            this._textBoxRecordAmount.TabIndex = 4;
            this._textBoxRecordAmount.TextChanged += new System.EventHandler(this.ChangeRecordAmountTextBox);
            this._textBoxRecordAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressRecordAmountTextBoxKey);
            // 
            // _buttonRecordAdd
            // 
            this._buttonRecordAdd.AccessibleName = "buttonRecordAdd";
            this._buttonRecordAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._buttonRecordAdd.Enabled = false;
            this._buttonRecordAdd.Location = new System.Drawing.Point(276, 48);
            this._buttonRecordAdd.Name = "_buttonRecordAdd";
            this._buttonRecordAdd.Size = new System.Drawing.Size(68, 23);
            this._buttonRecordAdd.TabIndex = 5;
            this._buttonRecordAdd.Text = "Enter";
            this._buttonRecordAdd.UseVisualStyleBackColor = true;
            this._buttonRecordAdd.Click += new System.EventHandler(this.ClickAddRecordButton);
            // 
            // _dataGridViewRecord
            // 
            this._dataGridViewRecord.AccessibleName = "dataGridViewRecord";
            this._dataGridViewRecord.AllowUserToAddRows = false;
            this._dataGridViewRecord.AllowUserToDeleteRows = false;
            this._dataGridViewRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._tableLayoutPanelRecord.SetColumnSpan(this._dataGridViewRecord, 4);
            this._dataGridViewRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewRecord.Location = new System.Drawing.Point(3, 123);
            this._dataGridViewRecord.MultiSelect = false;
            this._dataGridViewRecord.Name = "_dataGridViewRecord";
            this._dataGridViewRecord.ReadOnly = true;
            this._dataGridViewRecord.RowTemplate.Height = 24;
            this._dataGridViewRecord.Size = new System.Drawing.Size(358, 294);
            this._dataGridViewRecord.TabIndex = 6;
            this._dataGridViewRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDataGridViewRecordCell);
            // 
            // _buttonRecordModify
            // 
            this._buttonRecordModify.AccessibleName = "buttonRecordModify";
            this._buttonRecordModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._buttonRecordModify.Location = new System.Drawing.Point(8, 83);
            this._buttonRecordModify.Name = "_buttonRecordModify";
            this._buttonRecordModify.Size = new System.Drawing.Size(75, 34);
            this._buttonRecordModify.TabIndex = 7;
            this._buttonRecordModify.Text = "Modify";
            this._buttonRecordModify.UseVisualStyleBackColor = true;
            this._buttonRecordModify.Click += new System.EventHandler(this.ClickRecordModify);
            // 
            // _buttonRecordDelete
            // 
            this._buttonRecordDelete.AccessibleName = "buttonRecordDelete";
            this._buttonRecordDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._buttonRecordDelete.Location = new System.Drawing.Point(99, 83);
            this._buttonRecordDelete.Name = "_buttonRecordDelete";
            this._buttonRecordDelete.Size = new System.Drawing.Size(75, 34);
            this._buttonRecordDelete.TabIndex = 8;
            this._buttonRecordDelete.Text = "Delete";
            this._buttonRecordDelete.UseVisualStyleBackColor = true;
            this._buttonRecordDelete.Click += new System.EventHandler(this.ClickRecordDelete);
            // 
            // _buttonRecordCancel
            // 
            this._buttonRecordCancel.AccessibleName = "buttonRecordCancel";
            this._buttonRecordCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._buttonRecordCancel.Location = new System.Drawing.Point(190, 83);
            this._buttonRecordCancel.Name = "_buttonRecordCancel";
            this._buttonRecordCancel.Size = new System.Drawing.Size(75, 34);
            this._buttonRecordCancel.TabIndex = 9;
            this._buttonRecordCancel.Text = "Cancel";
            this._buttonRecordCancel.UseVisualStyleBackColor = true;
            this._buttonRecordCancel.Click += new System.EventHandler(this.ClickRecordCancel);
            // 
            // _tabPageStatistic
            // 
            this._tabPageStatistic.Controls.Add(this._tableLayoutPanelStatistic);
            this._tabPageStatistic.Location = new System.Drawing.Point(4, 22);
            this._tabPageStatistic.Name = "_tabPageStatistic";
            this._tabPageStatistic.Size = new System.Drawing.Size(370, 386);
            this._tabPageStatistic.TabIndex = 2;
            this._tabPageStatistic.Text = "Statistic";
            this._tabPageStatistic.UseVisualStyleBackColor = true;
            this._tabPageStatistic.Enter += new System.EventHandler(this.EnterTabPageStatistic);
            // 
            // _tableLayoutPanelStatistic
            // 
            this._tableLayoutPanelStatistic.ColumnCount = 6;
            this._tableLayoutPanelStatistic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanelStatistic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanelStatistic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanelStatistic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanelStatistic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanelStatistic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanelStatistic.Controls.Add(this._labelStatisticIncome, 0, 2);
            this._tableLayoutPanelStatistic.Controls.Add(this._labelStatisticExpense, 2, 2);
            this._tableLayoutPanelStatistic.Controls.Add(this._labelBalance, 4, 2);
            this._tableLayoutPanelStatistic.Controls.Add(this._labelStatisticDetail, 0, 3);
            this._tableLayoutPanelStatistic.Controls.Add(this._radioButtonStatisticIncome, 0, 0);
            this._tableLayoutPanelStatistic.Controls.Add(this._radioButtonStatisticExpense, 2, 0);
            this._tableLayoutPanelStatistic.Controls.Add(this._textBoxIncome, 1, 2);
            this._tableLayoutPanelStatistic.Controls.Add(this._textBoxExpense, 3, 2);
            this._tableLayoutPanelStatistic.Controls.Add(this._textBoxBalance, 5, 2);
            this._tableLayoutPanelStatistic.Controls.Add(this._dataGridViewStatisticRecord, 0, 1);
            this._tableLayoutPanelStatistic.Controls.Add(this._dataGridViewDetail, 0, 4);
            this._tableLayoutPanelStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelStatistic.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanelStatistic.Name = "_tableLayoutPanelStatistic";
            this._tableLayoutPanelStatistic.RowCount = 5;
            this._tableLayoutPanelStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._tableLayoutPanelStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._tableLayoutPanelStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._tableLayoutPanelStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelStatistic.Size = new System.Drawing.Size(370, 386);
            this._tableLayoutPanelStatistic.TabIndex = 0;
            // 
            // _labelStatisticIncome
            // 
            this._labelStatisticIncome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._labelStatisticIncome.AutoSize = true;
            this._labelStatisticIncome.Location = new System.Drawing.Point(3, 187);
            this._labelStatisticIncome.Name = "_labelStatisticIncome";
            this._labelStatisticIncome.Size = new System.Drawing.Size(43, 12);
            this._labelStatisticIncome.TabIndex = 0;
            this._labelStatisticIncome.Text = "Income:";
            this._labelStatisticIncome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _labelStatisticExpense
            // 
            this._labelStatisticExpense.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._labelStatisticExpense.AutoSize = true;
            this._labelStatisticExpense.Location = new System.Drawing.Point(125, 187);
            this._labelStatisticExpense.Name = "_labelStatisticExpense";
            this._labelStatisticExpense.Size = new System.Drawing.Size(47, 12);
            this._labelStatisticExpense.TabIndex = 1;
            this._labelStatisticExpense.Text = "Expense:";
            // 
            // _labelBalance
            // 
            this._labelBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._labelBalance.AutoSize = true;
            this._labelBalance.Location = new System.Drawing.Point(247, 187);
            this._labelBalance.Name = "_labelBalance";
            this._labelBalance.Size = new System.Drawing.Size(45, 12);
            this._labelBalance.TabIndex = 2;
            this._labelBalance.Text = "Balance:";
            // 
            // _labelStatisticDetail
            // 
            this._labelStatisticDetail.AutoSize = true;
            this._tableLayoutPanelStatistic.SetColumnSpan(this._labelStatisticDetail, 6);
            this._labelStatisticDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelStatisticDetail.Location = new System.Drawing.Point(3, 213);
            this._labelStatisticDetail.Name = "_labelStatisticDetail";
            this._labelStatisticDetail.Size = new System.Drawing.Size(364, 12);
            this._labelStatisticDetail.TabIndex = 3;
            this._labelStatisticDetail.Text = "The detail of the category:";
            // 
            // _radioButtonStatisticIncome
            // 
            this._radioButtonStatisticIncome.AccessibleName = "radioButtonStatisticIncome";
            this._radioButtonStatisticIncome.AutoSize = true;
            this._radioButtonStatisticIncome.Checked = true;
            this._tableLayoutPanelStatistic.SetColumnSpan(this._radioButtonStatisticIncome, 2);
            this._radioButtonStatisticIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this._radioButtonStatisticIncome.Location = new System.Drawing.Point(3, 3);
            this._radioButtonStatisticIncome.Name = "_radioButtonStatisticIncome";
            this._radioButtonStatisticIncome.Size = new System.Drawing.Size(116, 34);
            this._radioButtonStatisticIncome.TabIndex = 4;
            this._radioButtonStatisticIncome.TabStop = true;
            this._radioButtonStatisticIncome.Text = "Income";
            this._radioButtonStatisticIncome.UseVisualStyleBackColor = true;
            this._radioButtonStatisticIncome.CheckedChanged += new System.EventHandler(this.CheckChangeStatisticRadioButton);
            // 
            // _radioButtonStatisticExpense
            // 
            this._radioButtonStatisticExpense.AccessibleName = "radioButtonStatisticExpense";
            this._radioButtonStatisticExpense.AutoSize = true;
            this._tableLayoutPanelStatistic.SetColumnSpan(this._radioButtonStatisticExpense, 2);
            this._radioButtonStatisticExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this._radioButtonStatisticExpense.Location = new System.Drawing.Point(125, 3);
            this._radioButtonStatisticExpense.Name = "_radioButtonStatisticExpense";
            this._radioButtonStatisticExpense.Size = new System.Drawing.Size(116, 34);
            this._radioButtonStatisticExpense.TabIndex = 5;
            this._radioButtonStatisticExpense.Text = "Expense";
            this._radioButtonStatisticExpense.UseVisualStyleBackColor = true;
            this._radioButtonStatisticExpense.CheckedChanged += new System.EventHandler(this.CheckChangeStatisticRadioButton);
            // 
            // _textBoxIncome
            // 
            this._textBoxIncome.AccessibleName = "textBoxIncome";
            this._textBoxIncome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._textBoxIncome.Location = new System.Drawing.Point(64, 182);
            this._textBoxIncome.Name = "_textBoxIncome";
            this._textBoxIncome.ReadOnly = true;
            this._textBoxIncome.Size = new System.Drawing.Size(55, 22);
            this._textBoxIncome.TabIndex = 6;
            // 
            // _textBoxExpense
            // 
            this._textBoxExpense.AccessibleName = "textBoxExpense";
            this._textBoxExpense.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._textBoxExpense.Location = new System.Drawing.Point(186, 182);
            this._textBoxExpense.Name = "_textBoxExpense";
            this._textBoxExpense.ReadOnly = true;
            this._textBoxExpense.Size = new System.Drawing.Size(55, 22);
            this._textBoxExpense.TabIndex = 7;
            // 
            // _textBoxBalance
            // 
            this._textBoxBalance.AccessibleName = "textBoxBalance";
            this._textBoxBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._textBoxBalance.Location = new System.Drawing.Point(308, 182);
            this._textBoxBalance.Name = "_textBoxBalance";
            this._textBoxBalance.ReadOnly = true;
            this._textBoxBalance.Size = new System.Drawing.Size(59, 22);
            this._textBoxBalance.TabIndex = 8;
            // 
            // _dataGridViewStatisticRecord
            // 
            this._dataGridViewStatisticRecord.AccessibleName = "dataGridViewStatisticRecord";
            this._dataGridViewStatisticRecord.AllowUserToAddRows = false;
            this._dataGridViewStatisticRecord.AllowUserToDeleteRows = false;
            this._dataGridViewStatisticRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._tableLayoutPanelStatistic.SetColumnSpan(this._dataGridViewStatisticRecord, 6);
            this._dataGridViewStatisticRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewStatisticRecord.Location = new System.Drawing.Point(3, 43);
            this._dataGridViewStatisticRecord.MultiSelect = false;
            this._dataGridViewStatisticRecord.Name = "_dataGridViewStatisticRecord";
            this._dataGridViewStatisticRecord.ReadOnly = true;
            this._dataGridViewStatisticRecord.RowTemplate.Height = 24;
            this._dataGridViewStatisticRecord.Size = new System.Drawing.Size(364, 127);
            this._dataGridViewStatisticRecord.TabIndex = 9;
            this._dataGridViewStatisticRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDataGridViewCell);
            // 
            // _dataGridViewDetail
            // 
            this._dataGridViewDetail.AccessibleName = "dataGridViewDetail";
            this._dataGridViewDetail.AllowUserToAddRows = false;
            this._dataGridViewDetail.AllowUserToDeleteRows = false;
            this._dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._tableLayoutPanelStatistic.SetColumnSpan(this._dataGridViewDetail, 6);
            this._dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewDetail.Location = new System.Drawing.Point(3, 256);
            this._dataGridViewDetail.Name = "_dataGridViewDetail";
            this._dataGridViewDetail.ReadOnly = true;
            this._dataGridViewDetail.RowTemplate.Height = 24;
            this._dataGridViewDetail.Size = new System.Drawing.Size(364, 127);
            this._dataGridViewDetail.TabIndex = 10;
            // 
            // _errorProviderRecord
            // 
            this._errorProviderRecord.ContainerControl = this;
            // 
            // EZMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 412);
            this.Controls.Add(this._tabControl);
            this.Name = "EZMoneyForm";
            this.Text = "Categories Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingFormCategoryManagementForm);
            this.Load += new System.EventHandler(this.LoadFormView);
            this._tableLayoutPanelCategory.ResumeLayout(false);
            this._tableLayoutPanelCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProviderCategory)).EndInit();
            this._tabControl.ResumeLayout(false);
            this._tabPageCategory.ResumeLayout(false);
            this._tabPageRecord.ResumeLayout(false);
            this._tableLayoutPanelRecord.ResumeLayout(false);
            this._tableLayoutPanelRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewRecord)).EndInit();
            this._tabPageStatistic.ResumeLayout(false);
            this._tableLayoutPanelStatistic.ResumeLayout(false);
            this._tableLayoutPanelStatistic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewStatisticRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProviderRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelCategory;
        private System.Windows.Forms.Label _categoryNameLabel;
        private System.Windows.Forms.TextBox _textBoxCategoryName;
        private System.Windows.Forms.Button _buttonCategoryAdd;
        private System.Windows.Forms.ListBox _listBoxCategories;
        private System.Windows.Forms.ErrorProvider _errorProviderCategory;
        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _tabPageCategory;
        private System.Windows.Forms.TabPage _tabPageRecord;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelRecord;
        private System.Windows.Forms.RadioButton _radioButtonExpense;
        private System.Windows.Forms.DateTimePicker _dateTimePickerRecord;
        private System.Windows.Forms.ComboBox _comboBoxCategory;
        private System.Windows.Forms.TextBox _textBoxRecordAmount;
        private System.Windows.Forms.Button _buttonRecordAdd;
        private System.Windows.Forms.DataGridView _dataGridViewRecord;
        private System.Windows.Forms.RadioButton _radioButtonIncome;
        private System.Windows.Forms.ErrorProvider _errorProviderRecord;
        private System.Windows.Forms.TabPage _tabPageStatistic;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelStatistic;
        private System.Windows.Forms.Label _labelStatisticIncome;
        private System.Windows.Forms.Label _labelStatisticExpense;
        private System.Windows.Forms.Label _labelBalance;
        private System.Windows.Forms.Label _labelStatisticDetail;
        private System.Windows.Forms.RadioButton _radioButtonStatisticIncome;
        private System.Windows.Forms.RadioButton _radioButtonStatisticExpense;
        private System.Windows.Forms.TextBox _textBoxIncome;
        private System.Windows.Forms.TextBox _textBoxExpense;
        private System.Windows.Forms.TextBox _textBoxBalance;
        private System.Windows.Forms.DataGridView _dataGridViewStatisticRecord;
        private System.Windows.Forms.DataGridView _dataGridViewDetail;
        private System.Windows.Forms.Button _buttonCategoryModify;
        private System.Windows.Forms.Button _buttonCategoryDelete;
        private System.Windows.Forms.Button _buttonCategoryCancel;
        private System.Windows.Forms.Button _buttonRecordModify;
        private System.Windows.Forms.Button _buttonRecordDelete;
        private System.Windows.Forms.Button _buttonRecordCancel;
    }
}

