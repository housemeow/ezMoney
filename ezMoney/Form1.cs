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
        //view of categoryManagement
        EZMoneyModel _ezMoneyModel;
        CategoryView _categoryView;
        RecordView _recordView;
        StatisticView _statisticView;
        //currencyManager of list
        CurrencyManager _currencyManagerCategoryList;
        CurrencyManager _currencyManagerRecordList;

        //class constructor
        public EZMoneyForm()
        {
            InitializeComponent();
        }

        //form load event
        private void LoadFormCategoryManagement(object sender, EventArgs e)
        {
            _ezMoneyModel = new EZMoneyModel();
            _currencyManagerCategoryList = (CurrencyManager)BindingContext[_ezMoneyModel.GetCategories()];
            _currencyManagerRecordList = (CurrencyManager)BindingContext[_ezMoneyModel.GetRecords()];
            InitCategoryManagementView();
            InitRecordView();
            InitStatisticView();
        }

        //initialize categoryManagementView
        void InitCategoryManagementView()
        {
            _listBoxCategories.DataSource = _ezMoneyModel.GetCategories();
            _categoryView = new CategoryView(_ezMoneyModel.GetCategoryModel(), _ezMoneyModel.GetInformationModel());
            _categoryView.TextBoxCategoryName = _textBoxCategoryName;
            _categoryView.ListBoxCategories = _listBoxCategories;
            _categoryView.CurrencyManager = _currencyManagerCategoryList;
            _categoryView.ButtonAdd = _buttonCategoryAdd;
            _categoryView.ErrorProvider = _errorProviderAddButton;
            _categoryView.Initialize();
        }

        //initialize recordView
        void InitRecordView()
        {
            _comboBoxCategory.DataSource = _ezMoneyModel.GetCategories();
            _dataGridViewRecord.DataSource = _ezMoneyModel.GetRecords();
            _dataGridViewRecord.AutoGenerateColumns = true;
            _recordView = new RecordView(_ezMoneyModel.GetCategoryModel(), _ezMoneyModel.GetRecordModel(), _ezMoneyModel.GetInformationModel());
            _recordView.DateTimePickerRecord = _dateTimePickerRecord;
            _recordView.RadioButtonIncome = _radioButtonIncome;
            _recordView.RadioButtonExpanse = _radioButtonExpanse;
            _recordView.ComboBoxCategory = _comboBoxCategory;
            _recordView.TextBoxRecordAmount = _textBoxRecordAmount;
            _recordView.ButtonRecordAdd = _buttonRecordAdd;
            _recordView.DataGridViewRecord = _dataGridViewRecord;
            _recordView.CurrencyManagerCategoryList = _currencyManagerCategoryList;
            _recordView.CurrencyManagerRecordList = _currencyManagerRecordList;
            _recordView.ErrorProvider = _errorProviderRecord;
            _recordView.Initialize();
        }

        //initialize statisticView
        void InitStatisticView()
        {
            _statisticView = new StatisticView(_ezMoneyModel.GetCategoryModel(), _ezMoneyModel.GetRecordModel(), _ezMoneyModel.GetStatisticModel());
            _statisticView.RadioButtonIncome = _radioButtonStatisticIncome;
            _statisticView.RadioButtonExpense = _radioButtonStatisticExpense;
            _statisticView.DataGridViewStatistic = _dataGridViewStatisticRecord;
            _statisticView.TextBoxIncome = _textBoxIncome;
            _statisticView.TextBoxExpense = _textBoxStatisticExpense;
            _statisticView.TextBoxBalance = _textBoxBalance;
            _statisticView.DataGridViewDetail = _dataGridViewDetail;
            _statisticView.Initialize();
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
            _statisticView.Refresh();
        }
    }
}
