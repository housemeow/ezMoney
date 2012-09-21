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
        public FormCategoryManagement()
        {
            InitializeComponent();
        }
        CategoriesManagementView _categoryManagementView;
        private void FormCategoryManagement_Load(object sender, EventArgs e)
        {
            _categoryManagementView = new CategoriesManagementView();
            ControlsBind();
            ControlsEventBind();
            _categoryManagementView.View();
        }
        private void ControlsBind() {
            _categoryManagementView.ButtonAdd = buttonAdd;
            _categoryManagementView.TextBoxCategoryName = textBoxCategoryName;
            _categoryManagementView.ListBoxCategories = listBoxCategories;
            listBoxCategories.DataSource = _categoryManagementView.GetCategoryList();
            //make listbox items sync to category list
            _categoryManagementView.CurrencyManager =
                (CurrencyManager)BindingContext[_categoryManagementView.GetCategoryList()];
        }
        private void ControlsEventBind() {
            textBoxCategoryName.TextChanged += new EventHandler(_categoryManagementView.CategoryNameChanged);
            buttonAdd.Click += new EventHandler(_categoryManagementView.AddCategory);
        }
    }
}
