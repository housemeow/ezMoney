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
        EZMoneyModel _categoryModel;
        CategoryManagementView _categoryManagementView;

        //class constructor
        public FormCategoryManagement()
        {
            InitializeComponent();
        }

        //form load event
        private void FormCategoryManagement_Load(object sender, EventArgs e)
        {
            _categoryModel = new EZMoneyModel();
            InitCategoryManagementView();
            InitRecordView();
        }

        //initialize categoryManagementView
        void InitCategoryManagementView()
        {
            _listBoxCategories.DataSource = _categoryModel.GetCategories();
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[_categoryModel.GetCategories()];
            CategoryManagementControlSet controlSet = new CategoryManagementControlSet(_textBoxCategoryName, _listBoxCategories, currencyManager, _buttonCategoryAdd, _errorProviderAddButton);
            _categoryManagementView = new CategoryManagementView(controlSet, _categoryModel);
        }
        //initialize recordView
        void InitRecordView()
        {
            _comboBoxCategory.DataSource = _categoryModel.GetCategories();
            CurrencyManager currencyManagerComboBox = (CurrencyManager)BindingContext[_categoryModel.GetCategories()];
            CurrencyManager currencyManagerDataGridView = (CurrencyManager)BindingContext[_categoryModel.GetRecords()];

        }
    }
}
