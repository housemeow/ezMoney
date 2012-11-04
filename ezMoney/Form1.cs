using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    public partial class EZMoneyForm : Form
    {
        //model
        EZMoneyModel _ezMoneyModel;
        //presentationModels
        CategoryPresentationModel _categoryPModel;
        RecordPresentationModel _recordPModel;

        //class constructor
        public EZMoneyForm()
        {
            InitializeComponent();
        }

        //form load event
        private void LoadFormView(object sender, EventArgs e)
        {
            _ezMoneyModel = new EZMoneyModel();
            _categoryPModel = new CategoryPresentationModel(_ezMoneyModel);
            _recordPModel = new RecordPresentationModel(_ezMoneyModel);
            InitCategoryView();
            InitRecordView();
            InitStatisticView();
        }

        //closing form
        private void ClosingFormCategoryManagementForm(object sender, FormClosingEventArgs e)
        {
            _ezMoneyModel.GetCategoryModel().WriteCategoryToFile();
            _ezMoneyModel.GetRecordModel().WriteRecordToFile();
        }

        #region CategoryView
        //refresh CategoryView state
        void RefreshCategoryView()
        {
            _textBoxCategoryName.Text = _categoryPModel.CategoryNameText;
            _buttonCategoryAdd.Enabled = _categoryPModel.IsAddEnable;
            _buttonCategoryModify.Enabled = _categoryPModel.IsModifyEnable;
            _buttonCategoryDelete.Enabled = _categoryPModel.IsDeleteEnable;
            _buttonCategoryCancel.Enabled = _categoryPModel.IsCancelEnable;
            _errorProviderCategory.SetError(_buttonCategoryAdd, _categoryPModel.ErrorProviderMessage);
            //if you want to visible/unvisible modification function, uncomment under line.
            //_tableLayoutPanelCategory.RowStyles[1].Height = _categoryPModel.IsSelectionMode? 40: 0;
        }

        //initialize categoryManagementView
        void InitCategoryView()
        {
            _listBoxCategories.DataSource = _ezMoneyModel.GetCategories();
            _listBoxCategories.SelectedIndex = -1;
            RefreshCategoryView();
        }

        //click add category button
        private void ClickAddCategory(object sender, EventArgs e)
        {
            _categoryPModel.Add(_textBoxCategoryName.Text);
            RefreshCategoryView();
        }

        //change category name event
        private void ChangeCategoryName(object sender, EventArgs e)
        {
            _categoryPModel.ChangeTextBox(_textBoxCategoryName.Text);
            RefreshCategoryView();
        }

        //change categoryListBox index
        private void ChangeCategoryListIndex(object sender, EventArgs e)
        {
            _categoryPModel.SelectCategory(_listBoxCategories.SelectedIndex);
            RefreshCategoryView();
        }

        //click modifyButton
        private void ClickCategoryModifyButton(object sender, EventArgs e)
        {
            _categoryPModel.Modify(_listBoxCategories.SelectedIndex, _textBoxCategoryName.Text);
            RefreshCategoryView();
        }

        //click delete button
        private void ClickCategoryDeleteButton(object sender, EventArgs e)
        {
            const string MSG_CONTENT = "Do you want to delete?";
            const string MSG_TITLE = "Delete Category";
            _categoryPModel.Delete(_listBoxCategories.SelectedIndex, MessageBox.Show(MSG_CONTENT, MSG_TITLE, MessageBoxButtons.YesNo));
            RefreshCategoryView();
        }

        //click cancel button
        private void ClickCategoryCancelButton(object sender, EventArgs e)
        {
            _categoryPModel.Cancel();
            _listBoxCategories.ClearSelected();
            RefreshCategoryView();
        }
        #endregion

        #region RecordView
        //initialize recordView
        void InitRecordView()
        {
            _comboBoxCategory.DataSource = _ezMoneyModel.GetCategories();
            _dataGridViewRecord.DataSource = _ezMoneyModel.GetRecords();
            _dataGridViewRecord.AutoGenerateColumns = true;
            RefreshRecordView();
        }

        //refresh record view
        void RefreshRecordView()
        {
            _dateTimePickerRecord.Value = _recordPModel.RecordDate;
            _comboBoxCategory.SelectedIndex = _recordPModel.CategoryIndex;
            _textBoxRecordAmount.Text = _recordPModel.Amount;
            _buttonRecordAdd.Enabled = _recordPModel.IsAddEnable;
            _buttonRecordModify.Enabled = _recordPModel.IsModifyEnable;
            _buttonRecordDelete.Enabled = _recordPModel.IsDeleteEnable;
            _buttonRecordCancel.Enabled = _recordPModel.IsCancelEnable;
            _radioButtonIncome.Checked = _recordPModel.IsIncomeCheck;
            _radioButtonExpanse.Checked = _recordPModel.IsExpenseCheck;
            _errorProviderRecord.SetError(_buttonRecordAdd, _recordPModel.ErrorProviderMessage);
            //if you want to visible/unvisible modification function, uncomment under line.
            //_tableLayoutPanelRecord.RowStyles[2].Height = _recordPModel.IsSelectionMode ? 40 : 0;
        }

        //change category comboboxIndex
        private void ChangeCategoryComboBoxIndex(object sender, EventArgs e)
        {
            _recordPModel.SelectCategory(_comboBoxCategory.SelectedIndex);
            RefreshRecordView();
        }

        //record amount textbox key press event
        private void PressRecordAmountTextBoxKey(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Back)
            {//enable back key
                return;
            }
            else if ((Keys)e.KeyChar < Keys.D0 || (Keys)e.KeyChar > Keys.D9)
            {//cancel key message
                e.Handled = true;
            }
        }

        //event of recordAmountTextBoxChanged
        private void ChangeRecordAmountTextBox(object sender, EventArgs e)
        {
            _recordPModel.ChangeAmount(_textBoxRecordAmount.Text);
            RefreshRecordView();
        }

        //add record button click
        private void ClickAddRecordButton(object sender, EventArgs e)
        {
            _recordPModel.Add(_dateTimePickerRecord.Value, _comboBoxCategory.SelectedIndex, _textBoxRecordAmount.Text);
            RefreshRecordView();
        }

        //click record modify button
        private void ClickRecordModify(object sender, EventArgs e)
        {
            _recordPModel.Modify(_dateTimePickerRecord.Value, _comboBoxCategory.SelectedIndex, _textBoxRecordAmount.Text);
            RefreshRecordView();
        }

        //click record delete button
        private void ClickRecordDelete(object sender, EventArgs e)
        {
            const string MSG_CONTENT = "Do you want to delete record?";
            const string MSG_TITLE = "Delete Record";
            _recordPModel.Delete(MessageBox.Show(MSG_CONTENT, MSG_TITLE,  MessageBoxButtons.YesNo));
            RefreshRecordView();
        }

        //click record cancel button
        private void ClickRecordCancel(object sender, EventArgs e)
        {
            _recordPModel.Cancel();
            RefreshRecordView();
        }

        //click record datagridView cell
        private void ClickDataGridViewRecordCell(object sender, DataGridViewCellEventArgs e)
        {
            _recordPModel.SelectRecord(e.RowIndex);
            RefreshRecordView();
        }

        //change Record radioButton
        private void ChangeRecordRadioButton(object sender, EventArgs e)
        {
            _recordPModel.ChangeIncomeCheck(_radioButtonIncome.Checked);
            RefreshRecordView();
        }
        #endregion

































        #region StatisticView
        //initialize statisticView
        void InitStatisticView()
        {
            InitDetailDataGridView();
            RecordModel recordModel = _ezMoneyModel.GetRecordModel();
            InitTextBoxValue(recordModel.GetRecords());
        }

        //init detail datagridview
        private void InitDetailDataGridView()
        {
            _dataGridViewDetail.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = "Date";
            dateColumn.HeaderText = "Date";
            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.DataPropertyName = "Amount";
            amountColumn.HeaderText = "Amount";
            _dataGridViewDetail.Columns.Add(dateColumn);
            _dataGridViewDetail.Columns.Add(amountColumn);
            _dataGridViewDetail.ReadOnly = true;
        }

        //show textBox value
        private void InitTextBoxValue(BindingList<Record> records)
        {
            StatisticModel statisticModel = _ezMoneyModel.GetStatisticModel();
            _textBoxIncome.Text = statisticModel.GetIncome(records).ToString();
            _textBoxExpense.Text = statisticModel.GetExpense(records).ToString();
            _textBoxBalance.Text = statisticModel.GetBalance(records).ToString();
        }

        //radio button checked change
        private void CheckChangeStatisticRadioButton(object sender, EventArgs e)
        {
            StatisticModel statisticModel = _ezMoneyModel.GetStatisticModel();
            _dataGridViewStatisticRecord.DataSource = statisticModel.GetStatisticDataGridViewDataSource(_radioButtonStatisticIncome.Checked);
        }

        //click datagridView's cell
        private void ClickDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Category category = (Category)_dataGridViewStatisticRecord.Rows[e.RowIndex].Cells[0].Value;
                RecordModel recordModel = _ezMoneyModel.GetRecordModel();
                _dataGridViewDetail.DataSource = recordModel.GetRecords(category, _radioButtonStatisticIncome.Checked);
            }
        }

        //enter tab page statistic
        private void EnterTabPageStatistic(object sender, EventArgs e)
        {
            RefreshStatistic();
        }

        //refresh view
        public void RefreshStatistic()
        {
            CheckChangeStatisticRadioButton(this, new EventArgs());
            RecordModel recordModel = _ezMoneyModel.GetRecordModel();
            InitTextBoxValue( recordModel.GetRecords());
        }
        #endregion
    }
}
