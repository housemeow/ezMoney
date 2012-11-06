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
        StatisticPresentationModel _statisticPModel;

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
            _statisticPModel = new StatisticPresentationModel(_ezMoneyModel);
            InitCategoryView();
            InitRecordView();
            InitStatisticView();
        }

        //closing form
        private void ClosingFormCategoryManagementForm(object sender, FormClosingEventArgs e)
        {
            _ezMoneyModel.CategoryModel.WriteCategoryToFile();
            _ezMoneyModel.RecordModel.WriteRecordToFile();
        }

        #region CategoryView
        //initialize categoryManagementView
        void InitCategoryView()
        {
            _listBoxCategories.DataSource = _ezMoneyModel.GetCategories();
            _listBoxCategories.SelectedIndex = -1;
            RefreshCategoryView(_categoryPModel);
            _categoryPModel._updateEvent += RefreshCategoryView;
        }

        //refresh CategoryView state
        void RefreshCategoryView(CategoryPresentationModel categoryPModel)
        {
            _textBoxCategoryName.Text = _categoryPModel.CategoryNameText;
            _buttonCategoryAdd.Enabled = _categoryPModel.IsAddEnable;
            _buttonCategoryModify.Enabled = _categoryPModel.IsModifyEnable;
            _buttonCategoryModify.Visible = _categoryPModel.IsModifyEnable;
            _buttonCategoryDelete.Enabled = _categoryPModel.IsDeleteEnable;
            _buttonCategoryDelete.Visible = _categoryPModel.IsDeleteEnable;
            _buttonCategoryCancel.Enabled = _categoryPModel.IsCancelEnable;
            _buttonCategoryCancel.Visible = _categoryPModel.IsCancelEnable;
            _errorProviderCategory.SetError(_buttonCategoryAdd, _categoryPModel.ErrorProviderMessage);
            //if you want to visible/unvisible modification function, uncomment under line.
            //_tableLayoutPanelCategory.RowStyles[1].Height = _categoryPModel.IsSelectionMode? 40: 0;
        }

        //change category name event
        private void ChangeCategoryName(object sender, EventArgs e)
        {
            _categoryPModel.ChangeTextBox(_textBoxCategoryName.Text);
        }

        //change categoryListBox index
        private void ChangeCategoryListIndex(object sender, EventArgs e)
        {
            _categoryPModel.SelectCategory(_listBoxCategories.SelectedIndex);
        }

        //click add category button
        private void ClickAddCategory(object sender, EventArgs e)
        {
            _categoryPModel.Add(_textBoxCategoryName.Text);
        }

        //click modifyButton
        private void ClickCategoryModifyButton(object sender, EventArgs e)
        {
            _categoryPModel.Modify(_listBoxCategories.SelectedIndex, _textBoxCategoryName.Text);
        }

        //click delete button
        private void ClickCategoryDeleteButton(object sender, EventArgs e)
        {
            const string MSG_CONTENT = "Do you want to delete?";
            const string MSG_TITLE = "Delete Category";
            _categoryPModel.Delete(_listBoxCategories.SelectedIndex, MessageBox.Show(MSG_CONTENT, MSG_TITLE, MessageBoxButtons.YesNo));
        }

        //click cancel button
        private void ClickCategoryCancelButton(object sender, EventArgs e)
        {
            _listBoxCategories.ClearSelected();
            _categoryPModel.Cancel();
        }
        #endregion

        #region RecordView
        //initialize recordView
        void InitRecordView()
        {
            _comboBoxCategory.DataSource = _ezMoneyModel.GetCategories();
            _dataGridViewRecord.DataSource = _ezMoneyModel.GetRecords();
            _dataGridViewRecord.AutoGenerateColumns = true;
            RefreshRecordView(_recordPModel);
            _recordPModel._updateEvent += RefreshRecordView;
        }

        //refresh record view
        void RefreshRecordView(RecordPresentationModel recordPModel)
        {
            _dateTimePickerRecord.Value = _recordPModel.RecordDate;
            _comboBoxCategory.SelectedIndex = _recordPModel.CategoryIndex;
            _textBoxRecordAmount.Text = _recordPModel.Amount;
            _buttonRecordAdd.Enabled = _recordPModel.IsAddEnable;
            _buttonRecordModify.Enabled = _recordPModel.IsModifyEnable;
            _buttonRecordModify.Visible = _recordPModel.IsModifyEnable;
            _buttonRecordDelete.Enabled = _recordPModel.IsDeleteEnable;
            _buttonRecordDelete.Visible = _recordPModel.IsDeleteEnable;
            _buttonRecordCancel.Enabled = _recordPModel.IsCancelEnable;
            _buttonRecordCancel.Visible = _recordPModel.IsCancelEnable;
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
        }

        //click record datagridView cell
        private void ClickDataGridViewRecordCell(object sender, DataGridViewCellEventArgs e)
        {
            _recordPModel.SelectRecord(e.RowIndex);
        }

        //change Record radioButton
        private void ChangeRecordRadioButton(object sender, EventArgs e)
        {
            _recordPModel.ChangeIncomeCheck(_radioButtonIncome.Checked);
        }

        //add record button click
        private void ClickAddRecordButton(object sender, EventArgs e)
        {
            _recordPModel.Add(_dateTimePickerRecord.Value, _comboBoxCategory.SelectedIndex, _textBoxRecordAmount.Text);
        }

        //click record modify button
        private void ClickRecordModify(object sender, EventArgs e)
        {
            _recordPModel.Modify(_dateTimePickerRecord.Value, _comboBoxCategory.SelectedIndex, _textBoxRecordAmount.Text);
        }

        //click record delete button
        private void ClickRecordDelete(object sender, EventArgs e)
        {
            const string MSG_CONTENT = "Do you want to delete record?";
            const string MSG_TITLE = "Delete Record";
            _recordPModel.Delete(MessageBox.Show(MSG_CONTENT, MSG_TITLE, MessageBoxButtons.YesNo));
        }

        //click record cancel button
        private void ClickRecordCancel(object sender, EventArgs e)
        {
            _recordPModel.Cancel();
        }
        #endregion

        #region StatisticView
        //initialize statisticView
        void InitStatisticView()
        {
            InitDetailDataGridView();
            RefreshStatisticView();
        }

        //refresh Statistic View
        void RefreshStatisticView()
        {
            _radioButtonStatisticIncome.Checked = _statisticPModel.IsIncomeCheck;
            _radioButtonStatisticExpense.Checked = _statisticPModel.IsExpenseCheck;
            _textBoxIncome.Text = _statisticPModel.Income;
            _textBoxExpense.Text = _statisticPModel.Expense;
            _textBoxBalance.Text = _statisticPModel.Balance;
            _dataGridViewStatisticRecord.DataSource = _statisticPModel.StatisticList;
            _dataGridViewDetail.DataSource = _statisticPModel.RecordList;
        }

        //init detail datagridview
        private void InitDetailDataGridView()
        {
            const String DATE_STRING = "Date";
            const String AMOUNT_STRING = "Amount";
            _dataGridViewDetail.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = DATE_STRING;
            dateColumn.HeaderText = DATE_STRING;
            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.DataPropertyName = AMOUNT_STRING;
            amountColumn.HeaderText = AMOUNT_STRING;
            _dataGridViewDetail.Columns.Add(dateColumn);
            _dataGridViewDetail.Columns.Add(amountColumn);
            _dataGridViewDetail.ReadOnly = true;
        }

        //radio button checked change
        private void CheckChangeStatisticRadioButton(object sender, EventArgs e)
        {
            _statisticPModel.ChangeRadioButton(_radioButtonStatisticIncome.Checked);
            RefreshStatisticView();
        }

        //enter tab page statistic
        private void EnterTabPageStatistic(object sender, EventArgs e)
        {
            _statisticPModel.EnterTabPageStatistic();
            RefreshStatisticView();
        }

        //click datagridView's cell
        private void ClickDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Category category = (Category)_dataGridViewStatisticRecord.Rows[e.RowIndex].Cells[0].Value;
                _dataGridViewDetail.DataSource = _statisticPModel.ClickDataGridView(category);
            }
        }
        #endregion
    }
}
