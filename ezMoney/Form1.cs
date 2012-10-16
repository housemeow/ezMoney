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
        const String CATEGORY_FILE_NAME = "category.txt";
        const String RECORD_FILE_NAME = "record.txt";

        //view of categoryManagement
        EZMoneyModel _ezMoneyModel;
        CategoryManagementView _categoryManagementView;
        RecordView _recordView;
        StatisticView _statisticView;
        StatisticModel _statisticModel;

        //class constructor
        public FormCategoryManagement()
        {
            InitializeComponent();
        }

        //form load event
        private void LoadFormCategoryManagement(object sender, EventArgs e)
        {
            _ezMoneyModel = new EZMoneyModel();
            _ezMoneyModel.ReadCategoryFromFile(CATEGORY_FILE_NAME);
            _ezMoneyModel.ReadRecordFromFile(RECORD_FILE_NAME);
            _statisticModel = new StatisticModel();
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
            _categoryManagementView = new CategoryManagementView(controlSet, _ezMoneyModel);
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
            _recordView = new RecordView(controlSet, _ezMoneyModel);
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
            _statisticView = new StatisticView(statisticControlSet, _statisticModel, _ezMoneyModel);
        }

        //closing form
        private void ClosingFormCategoryManagementForm(object sender, FormClosingEventArgs e)
        {
            _ezMoneyModel.WriteCategoryToFile(CATEGORY_FILE_NAME);
            _ezMoneyModel.WriteRecordToFile(RECORD_FILE_NAME);
        }
    }
}
