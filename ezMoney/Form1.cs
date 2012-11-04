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
        //currencyManager of list
        CurrencyManager _currencyManagerCategoryList;
        CurrencyManager _currencyManagerRecordList;

        //class constructor
        public EZMoneyForm()
        {
            InitializeComponent();
        }

        //form load event
        private void LoadFormView(object sender, EventArgs e)
        {
            _ezMoneyModel = new EZMoneyModel();
            _currencyManagerCategoryList = (CurrencyManager)BindingContext[_ezMoneyModel.GetCategories()];
            _currencyManagerRecordList = (CurrencyManager)BindingContext[_ezMoneyModel.GetRecords()];
            InitCategoryView();
            InitRecordView();
            InitStatisticView();
        }

        //initialize categoryManagementView
        void InitCategoryView()
        {
            _listBoxCategories.DataSource = _ezMoneyModel.GetCategories();
            SetCategoryButtonAndErrorProviderState(_ezMoneyModel.GetInformationModel());
        }

        //initialize recordView
        void InitRecordView()
        {
            _comboBoxCategory.DataSource = _ezMoneyModel.GetCategories();
            _dataGridViewRecord.DataSource = _ezMoneyModel.GetRecords();
            _dataGridViewRecord.AutoGenerateColumns = true;
            SetRecordButtonAndErrorProviderState(_ezMoneyModel.GetInformationModel());
        }

        //initialize statisticView
        void InitStatisticView()
        {
            InitStatisticDataGridView();
            InitDetailDataGridView();
            RecordModel recordModel = _ezMoneyModel.GetRecordModel();
            InitTextBoxValue(recordModel.GetRecords());
        }

        //show textBox value
        private void InitTextBoxValue(BindingList<Record> records)
        {
            StatisticModel statisticModel = _ezMoneyModel.GetStatisticModel();
            _textBoxIncome.Text = statisticModel.GetIncome(records).ToString();
            _textBoxExpense.Text = statisticModel.GetExpense(records).ToString();
            _textBoxBalance.Text = statisticModel.GetBalance(records).ToString();
        }

        //init statistic datagridview
        private void InitStatisticDataGridView()
        {
            _dataGridViewStatisticRecord.AutoGenerateColumns = true;
            _dataGridViewStatisticRecord.ReadOnly = true;
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

        //radio button checked change
        private void CheckChangeRadioButton(object sender, EventArgs e)
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

        //init control
        private void InitControlSet()
        {
            _radioButtonIncome.Checked = true;
            InitStatisticDataGridView();
            InitDetailDataGridView();
            _textBoxIncome.ReadOnly = true;
            _textBoxExpense.ReadOnly = true;
            _textBoxBalance.ReadOnly = true;
            RecordModel recordModel = _ezMoneyModel.GetRecordModel();
            InitTextBoxValue(recordModel.GetRecords());
        }

        //closing form
        private void ClosingFormCategoryManagementForm(object sender, FormClosingEventArgs e)
        {
            _ezMoneyModel.GetCategoryModel().WriteCategoryToFile();
            _ezMoneyModel.GetRecordModel().WriteRecordToFile();
        }

        //enter tab page statistic
        private void EnterTabPageStatistic(object sender, EventArgs e)
        {
            RefreshStatistic();
        }

        //refresh view
        public void RefreshStatistic()
        {
            CheckChangeRadioButton(this, new EventArgs());
            RecordModel recordModel = _ezMoneyModel.GetRecordModel();
            InitTextBoxValue( recordModel.GetRecords());
        }

        //add category
        private void AddCategory(object sender, EventArgs e)
        {
            CategoryModel categoryModel = _ezMoneyModel.GetCategoryModel();
            categoryModel.AddCategory(_textBoxCategoryName.Text);////
            _currencyManagerCategoryList.Refresh();
            _textBoxCategoryName.Text = String.Empty;
        }

        //change category name event
        private void ChangeCategoryName(object sender, EventArgs e)
        {
            InformationModel informationModel = _ezMoneyModel.GetInformationModel();
            SetCategoryButtonAndErrorProviderState(informationModel);
        }

        //enable/ disable button and ErrorProvider
        private void SetCategoryButtonAndErrorProviderState(InformationModel informationModel)
        {
            String errorMessage = String.Empty;
            bool buttonEnable = informationModel.IsValidCategoryAdd(_textBoxCategoryName.Text, ref errorMessage);
            _buttonCategoryAdd.Enabled = buttonEnable;
            _errorProviderAddButton.SetError(_buttonCategoryAdd, errorMessage);
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
            SetRecordButtonAndErrorProviderState(_ezMoneyModel.GetInformationModel());
        }

        //record button click
        private void ClickRecordButton(object sender, EventArgs e)
        {
            InformationModel informationModel = _ezMoneyModel.GetInformationModel();
            RecordModel recordModel = _ezMoneyModel.GetRecordModel();
            int money = informationModel.GetAmount(_textBoxRecordAmount.Text, _radioButtonIncome.Checked);
            Record record = new Record(_dateTimePickerRecord.Value, new Category(_comboBoxCategory.Text), money);///////
            recordModel.AddRecord(record);
            _currencyManagerRecordList.Refresh();
            _textBoxRecordAmount.Text = "";
            SetRecordButtonAndErrorProviderState(informationModel);
        }

        //set button enable and errorprovider
        private void SetRecordButtonAndErrorProviderState(InformationModel informationModel)
        {
            String errorMessage = String.Empty;
            bool buttonEnable = informationModel.IsValidRecordAdd(_comboBoxCategory.SelectedIndex, _textBoxRecordAmount.Text, ref errorMessage);
            _errorProviderRecord.SetError(_buttonRecordAdd, errorMessage);
            _buttonRecordAdd.Enabled = buttonEnable;
        }
    }
}
