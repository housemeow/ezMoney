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
        //class constructor
        public FormCategoryManagement()
        {
            InitializeComponent();
        }

        //view of categoryManagement
        CategoryModel _categoryModel;
        CategoryManagementView _categoryManagementView;

        //form load event
        private void FormCategoryManagement_Load(object sender, EventArgs e)
        {
            _categoryModel = new CategoryModel();
            _categoryManagementView = new CategoryManagementView();
            BindControls();
            BindControlsEvent();
            _categoryManagementView.View();
        }
        //bind control
        private void BindControls() {
            _categoryManagementView.ButtonAdd = _buttonAdd;
            _categoryManagementView.TextBoxCategoryName = _textBoxCategoryName;
            _categoryManagementView.ListBoxCategories = _listBoxCategories;
            _listBoxCategories.DataSource = _categoryManagementView.GetCategoryList();
            //make listbox items sync to category list
            _categoryManagementView.CurrencyManager = (CurrencyManager)BindingContext[_categoryManagementView.GetCategoryList()];
        }

        //bind all control to categoryManagementView
        private void BindControlsEvent() {
            _textBoxCategoryName.TextChanged += new EventHandler(_categoryManagementView.CategoryNameChanged);
            _buttonAdd.Click += new EventHandler(_categoryManagementView.AddCategory);
        }
    }
}
