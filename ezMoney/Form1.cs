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
        CategoryModel _categoryModel;
        CategoryManagementView _categoryManagementView;

        //class constructor
        public FormCategoryManagement()
        {
            InitializeComponent();
        }

        //form load event
        private void FormCategoryManagement_Load(object sender, EventArgs e)
        {
            InitCategoryManagementView();
        }

        //initialize categoryManagementView
        void InitCategoryManagementView()
        {
            _categoryModel = new CategoryModel();
            _listBoxCategories.DataSource = _categoryModel.GetCategories();
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[_categoryModel.GetCategories()];
            CategoryManagementControlSet controlSet = new CategoryManagementControlSet(_textBoxCategoryName, _listBoxCategories, currencyManager, _buttonAdd, _errorProviderAddButton);
            _categoryManagementView = new CategoryManagementView(controlSet, _categoryModel);
            _categoryManagementView.View();
        }
    }
}
