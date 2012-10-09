namespace ezMoney
{
    partial class FormCategoryManagement
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
            this._tableLayoutPanelCategoryManagement = new System.Windows.Forms.TableLayoutPanel();
            this._categoryNameLabel = new System.Windows.Forms.Label();
            this._textBoxCategoryName = new System.Windows.Forms.TextBox();
            this._buttonCategoryAdd = new System.Windows.Forms.Button();
            this._listBoxCategories = new System.Windows.Forms.ListBox();
            this._errorProviderAddButton = new System.Windows.Forms.ErrorProvider(this.components);
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabPageCategoryManagement = new System.Windows.Forms.TabPage();
            this._tabPageRecord = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._radioButtonIncome = new System.Windows.Forms.RadioButton();
            this._radioButtonExpanse = new System.Windows.Forms.RadioButton();
            this._dateTimePickerRecord = new System.Windows.Forms.DateTimePicker();
            this._comboBoxCategory = new System.Windows.Forms.ComboBox();
            this._textBoxRecordAmount = new System.Windows.Forms.TextBox();
            this._buttonRecordAdd = new System.Windows.Forms.Button();
            this._dataGridViewRecord = new System.Windows.Forms.DataGridView();
            this._errorProviderRecord = new System.Windows.Forms.ErrorProvider(this.components);
            this._tableLayoutPanelCategoryManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProviderAddButton)).BeginInit();
            this._tabControl.SuspendLayout();
            this._tabPageCategoryManagement.SuspendLayout();
            this._tabPageRecord.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProviderRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // _tableLayoutPanelCategoryManagement
            // 
            this._tableLayoutPanelCategoryManagement.ColumnCount = 3;
            this._tableLayoutPanelCategoryManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanelCategoryManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this._tableLayoutPanelCategoryManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._tableLayoutPanelCategoryManagement.Controls.Add(this._categoryNameLabel, 0, 0);
            this._tableLayoutPanelCategoryManagement.Controls.Add(this._textBoxCategoryName, 1, 0);
            this._tableLayoutPanelCategoryManagement.Controls.Add(this._buttonCategoryAdd, 2, 0);
            this._tableLayoutPanelCategoryManagement.Controls.Add(this._listBoxCategories, 0, 1);
            this._tableLayoutPanelCategoryManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelCategoryManagement.Location = new System.Drawing.Point(3, 3);
            this._tableLayoutPanelCategoryManagement.Name = "_tableLayoutPanelCategoryManagement";
            this._tableLayoutPanelCategoryManagement.RowCount = 2;
            this._tableLayoutPanelCategoryManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this._tableLayoutPanelCategoryManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelCategoryManagement.Size = new System.Drawing.Size(364, 380);
            this._tableLayoutPanelCategoryManagement.TabIndex = 0;
            // 
            // _categoryNameLabel
            // 
            this._categoryNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._categoryNameLabel.AutoSize = true;
            this._categoryNameLabel.Location = new System.Drawing.Point(21, 34);
            this._categoryNameLabel.Name = "_categoryNameLabel";
            this._categoryNameLabel.Size = new System.Drawing.Size(48, 12);
            this._categoryNameLabel.TabIndex = 0;
            this._categoryNameLabel.Text = "Category";
            // 
            // _textBoxCategoryName
            // 
            this._textBoxCategoryName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._textBoxCategoryName.Location = new System.Drawing.Point(94, 29);
            this._textBoxCategoryName.Name = "_textBoxCategoryName";
            this._textBoxCategoryName.Size = new System.Drawing.Size(157, 22);
            this._textBoxCategoryName.TabIndex = 1;
            // 
            // _buttonCategoryAdd
            // 
            this._buttonCategoryAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._buttonCategoryAdd.Location = new System.Drawing.Point(271, 28);
            this._buttonCategoryAdd.Name = "_buttonCategoryAdd";
            this._buttonCategoryAdd.Size = new System.Drawing.Size(75, 23);
            this._buttonCategoryAdd.TabIndex = 2;
            this._buttonCategoryAdd.Text = "Add";
            this._buttonCategoryAdd.UseVisualStyleBackColor = true;
            // 
            // _listBoxCategories
            // 
            this._tableLayoutPanelCategoryManagement.SetColumnSpan(this._listBoxCategories, 3);
            this._listBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listBoxCategories.FormattingEnabled = true;
            this._listBoxCategories.ItemHeight = 12;
            this._listBoxCategories.Location = new System.Drawing.Point(3, 83);
            this._listBoxCategories.Name = "_listBoxCategories";
            this._listBoxCategories.Size = new System.Drawing.Size(358, 294);
            this._listBoxCategories.TabIndex = 3;
            // 
            // _errorProviderAddButton
            // 
            this._errorProviderAddButton.ContainerControl = this;
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._tabPageCategoryManagement);
            this._tabControl.Controls.Add(this._tabPageRecord);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.Location = new System.Drawing.Point(0, 0);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(378, 412);
            this._tabControl.TabIndex = 1;
            // 
            // _tabPageCategoryManagement
            // 
            this._tabPageCategoryManagement.Controls.Add(this._tableLayoutPanelCategoryManagement);
            this._tabPageCategoryManagement.Location = new System.Drawing.Point(4, 22);
            this._tabPageCategoryManagement.Name = "_tabPageCategoryManagement";
            this._tabPageCategoryManagement.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageCategoryManagement.Size = new System.Drawing.Size(370, 386);
            this._tabPageCategoryManagement.TabIndex = 0;
            this._tabPageCategoryManagement.Text = "Category";
            this._tabPageCategoryManagement.UseVisualStyleBackColor = true;
            // 
            // _tabPageRecord
            // 
            this._tabPageRecord.Controls.Add(this.tableLayoutPanel1);
            this._tabPageRecord.Location = new System.Drawing.Point(4, 22);
            this._tabPageRecord.Name = "_tabPageRecord";
            this._tabPageRecord.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageRecord.Size = new System.Drawing.Size(370, 386);
            this._tabPageRecord.TabIndex = 1;
            this._tabPageRecord.Text = "Record";
            this._tabPageRecord.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this._radioButtonIncome, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._radioButtonExpanse, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this._dateTimePickerRecord, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._comboBoxCategory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._textBoxRecordAmount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._buttonRecordAdd, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this._dataGridViewRecord, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 380);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _radioButtonIncome
            // 
            this._radioButtonIncome.AutoSize = true;
            this._radioButtonIncome.Checked = true;
            this._radioButtonIncome.Location = new System.Drawing.Point(185, 3);
            this._radioButtonIncome.Name = "_radioButtonIncome";
            this._radioButtonIncome.Size = new System.Drawing.Size(58, 16);
            this._radioButtonIncome.TabIndex = 1;
            this._radioButtonIncome.TabStop = true;
            this._radioButtonIncome.Text = "Income";
            this._radioButtonIncome.UseVisualStyleBackColor = true;
            // 
            // _radioButtonExpanse
            // 
            this._radioButtonExpanse.AutoSize = true;
            this._radioButtonExpanse.Location = new System.Drawing.Point(276, 3);
            this._radioButtonExpanse.Name = "_radioButtonExpanse";
            this._radioButtonExpanse.Size = new System.Drawing.Size(62, 16);
            this._radioButtonExpanse.TabIndex = 2;
            this._radioButtonExpanse.Text = "Expanse";
            this._radioButtonExpanse.UseVisualStyleBackColor = true;
            // 
            // _dateTimePickerRecord
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._dateTimePickerRecord, 2);
            this._dateTimePickerRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dateTimePickerRecord.Location = new System.Drawing.Point(3, 3);
            this._dateTimePickerRecord.Name = "_dateTimePickerRecord";
            this._dateTimePickerRecord.Size = new System.Drawing.Size(176, 22);
            this._dateTimePickerRecord.TabIndex = 0;
            // 
            // _comboBoxCategory
            // 
            this._comboBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this._comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxCategory.FormattingEnabled = true;
            this._comboBoxCategory.Location = new System.Drawing.Point(3, 43);
            this._comboBoxCategory.Name = "_comboBoxCategory";
            this._comboBoxCategory.Size = new System.Drawing.Size(85, 20);
            this._comboBoxCategory.TabIndex = 3;
            // 
            // _textBoxRecordAmount
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._textBoxRecordAmount, 2);
            this._textBoxRecordAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textBoxRecordAmount.Location = new System.Drawing.Point(94, 43);
            this._textBoxRecordAmount.Name = "_textBoxRecordAmount";
            this._textBoxRecordAmount.Size = new System.Drawing.Size(176, 22);
            this._textBoxRecordAmount.TabIndex = 4;
            // 
            // _buttonRecordAdd
            // 
            this._buttonRecordAdd.Location = new System.Drawing.Point(276, 43);
            this._buttonRecordAdd.Name = "_buttonRecordAdd";
            this._buttonRecordAdd.Size = new System.Drawing.Size(68, 23);
            this._buttonRecordAdd.TabIndex = 5;
            this._buttonRecordAdd.Text = "Enter";
            this._buttonRecordAdd.UseVisualStyleBackColor = true;
            // 
            // _dataGridViewRecord
            // 
            this._dataGridViewRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this._dataGridViewRecord, 4);
            this._dataGridViewRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewRecord.Location = new System.Drawing.Point(3, 83);
            this._dataGridViewRecord.Name = "_dataGridViewRecord";
            this._dataGridViewRecord.RowTemplate.Height = 24;
            this._dataGridViewRecord.Size = new System.Drawing.Size(358, 294);
            this._dataGridViewRecord.TabIndex = 6;
            // 
            // _errorProviderRecord
            // 
            this._errorProviderRecord.ContainerControl = this;
            // 
            // FormCategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 412);
            this.Controls.Add(this._tabControl);
            this.Name = "FormCategoryManagement";
            this.Text = "Categories Management";
            this.Load += new System.EventHandler(this.FormCategoryManagement_Load);
            this._tableLayoutPanelCategoryManagement.ResumeLayout(false);
            this._tableLayoutPanelCategoryManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProviderAddButton)).EndInit();
            this._tabControl.ResumeLayout(false);
            this._tabPageCategoryManagement.ResumeLayout(false);
            this._tabPageRecord.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProviderRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelCategoryManagement;
        private System.Windows.Forms.Label _categoryNameLabel;
        private System.Windows.Forms.TextBox _textBoxCategoryName;
        private System.Windows.Forms.Button _buttonCategoryAdd;
        private System.Windows.Forms.ListBox _listBoxCategories;
        private System.Windows.Forms.ErrorProvider _errorProviderAddButton;
        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _tabPageCategoryManagement;
        private System.Windows.Forms.TabPage _tabPageRecord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton _radioButtonExpanse;
        private System.Windows.Forms.DateTimePicker _dateTimePickerRecord;
        private System.Windows.Forms.ComboBox _comboBoxCategory;
        private System.Windows.Forms.TextBox _textBoxRecordAmount;
        private System.Windows.Forms.Button _buttonRecordAdd;
        private System.Windows.Forms.DataGridView _dataGridViewRecord;
        private System.Windows.Forms.RadioButton _radioButtonIncome;
        private System.Windows.Forms.ErrorProvider _errorProviderRecord;
    }
}

