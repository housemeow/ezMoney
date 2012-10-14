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
        CategoryManagementView _categoryManagementView;
        RecordView _recordView;

        //class constructor
        public FormCategoryManagement()
        {
            InitializeComponent();
        }

        //form load event
        private void FormCategoryManagement_Load(object sender, EventArgs e)
        {
            _ezMoneyModel = new EZMoneyModel();
            _ezMoneyModel.ReadCategoryFromFile("category.txt");
            _ezMoneyModel.ReadRecordFromFile("record.txt");
            InitCategoryManagementView();
            InitRecordView();
        }

        //initialize categoryManagementView
        void InitCategoryManagementView()
        {
            _listBoxCategories.DataSource = _ezMoneyModel.GetCategories();
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[_ezMoneyModel.GetCategories()];
            CategoryControlSet controlSet = new CategoryControlSet(_textBoxCategoryName, _listBoxCategories, currencyManager, _buttonCategoryAdd, _errorProviderAddButton);
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
            RecordControlSet controlSet = new RecordControlSet(
                _dateTimePickerRecord,
                _radioButtonIncome,
                _radioButtonExpanse,
                _comboBoxCategory,
                _textBoxRecordAmount,
                _buttonRecordAdd,
                _dataGridViewRecord,
                currencyManagerComboBox,
                currencyManagerDataGridView,
                _errorProviderRecord);
            _recordView = new RecordView(controlSet, _ezMoneyModel);
        }

        private void FormCategoryManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            _ezMoneyModel.WriteCategoryToFile("category.txt");
            _ezMoneyModel.WriteRecordToFile("record.txt");
        }
    }
}
