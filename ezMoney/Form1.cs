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
    public partial class FormCategoryManagement : Form
    {
        //view of categoryManagement
        EZMoneyModel _ezMoneyModel;
        CategoryView _categoryManagementView;
        RecordView _recordView;
        StatisticView _statisticView;

        //class constructor
        public FormCategoryManagement()
        {
            InitializeComponent();
        }

        //form load event
        private void LoadFormCategoryManagement(object sender, EventArgs e)
        {
            _ezMoneyModel = new EZMoneyModel();
            InitCategoryManagementView();
            InitRecordView();
            InitStatisticView();
        }

        //initialize categoryManagementView
        void InitCategoryManagementView()
        {
            _listBoxCategories.DataSource = _ezMoneyModel.GetCategories();
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[_ezMoneyModel.GetCategories()];
            CategoryControlSet controlSet = new CategoryControlSet();
            controlSet.TextBoxCategoryName = _textBoxCategoryName;
            controlSet.ListBoxCategories = _listBoxCategories;
            controlSet.CurrencyManager = currencyManager;
            controlSet.ButtonAdd = _buttonCategoryAdd;
            controlSet.ErrorProvider = _errorProviderAddButton;
            _categoryManagementView = new CategoryView(controlSet, _ezMoneyModel.GetCategoryModel());
        }

        //initialize recordView
        void InitRecordView()
        {
            _comboBoxCategory.DataSource = _ezMoneyModel.GetCategories();
            CurrencyManager currencyManagerComboBox = (CurrencyManager)BindingContext[_ezMoneyModel.GetCategories()];
            CurrencyManager currencyManagerDataGridView = (CurrencyManager)BindingContext[_ezMoneyModel.GetRecords()];
            _dataGridViewRecord.DataSource = _ezMoneyModel.GetRecords();
            _dataGridViewRecord.AutoGenerateColumns = true;
            RecordControlSet controlSet = new RecordControlSet();
            controlSet.DateTimePickerRecord = _dateTimePickerRecord;
            controlSet.RadioButtonIncome = _radioButtonIncome;
            controlSet.RadioButtonExpanse = _radioButtonExpanse;
            controlSet.ComboBoxCategory = _comboBoxCategory;
            controlSet.TextBoxRecordAmount = _textBoxRecordAmount;
            controlSet.ButtonRecordAdd = _buttonRecordAdd;
            controlSet.DataGridViewRecord = _dataGridViewRecord;
            controlSet.CurrencyManagerComboBox = currencyManagerComboBox;
            controlSet.CurrencyManagerDataGridView = currencyManagerDataGridView;
            controlSet.ErrorProvider = _errorProviderRecord;
            _recordView = new RecordView(controlSet, _ezMoneyModel.GetCategoryModel(), _ezMoneyModel.GetRecordModel());
        }

        //initialize statisticView
        void InitStatisticView()
        {
            StatisticControlSet statisticControlSet = new StatisticControlSet();
            statisticControlSet.RadioButtonIncome = _radioButtonStatisticIncome;
            statisticControlSet.RadioButtonExpense = _radioButtonStatisticExpense;
            statisticControlSet.DataGridViewStatistic = _dataGridViewStatisticRecord;
            statisticControlSet.TextBoxIncome = _textBoxIncome;
            statisticControlSet.TextBoxExpense = _textBoxStatisticExpense;
            statisticControlSet.TextBoxBalance = _textBoxBalance;
            statisticControlSet.DataGridViewDetail = _dataGridViewDetail;
            _statisticView = new StatisticView(statisticControlSet, _ezMoneyModel.GetCategoryModel(), _ezMoneyModel.GetRecordModel(), _ezMoneyModel.GetStatisticModel());
        }

        //closing form
        private void ClosingFormCategoryManagementForm(object sender, FormClosingEventArgs e)
        {
            _ezMoneyModel.WriteCategoryToFile();
            _ezMoneyModel.WriteRecordToFile();
        }
    }
}
