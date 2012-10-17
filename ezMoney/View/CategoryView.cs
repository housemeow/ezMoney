using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class CategoryView
    {
        CategoryModel _categoryModel;
        CategoryControlSet _categoryManagementControlSet;

        //categoryManagementView constructor
        public CategoryView(CategoryControlSet categoryManagementConstrolSet, CategoryModel categoryModel)
        {
            _categoryManagementControlSet = categoryManagementConstrolSet;
            _categoryModel = categoryModel;
            BindControlSetEvent();
            InitControlSet();
            _categoryManagementControlSet.SetButtonAndErrorProviderState(_categoryModel);
        }

        //bind all control to categoryManagementView
        private void BindControlSetEvent()
        {
            TextBox textBoxCategoryName = _categoryManagementControlSet.TextBoxCategoryName;
            Button buttonAdd = _categoryManagementControlSet.ButtonAdd;
            textBoxCategoryName.TextChanged += new EventHandler(ChangeCategoryName);
            buttonAdd.Click += new EventHandler(AddCategory);
            _categoryModel._categoryListChangedEvent += ChangeCategoryList;
        }

        //initialize control
        public void InitControlSet()
        {
            Button buttonAdd = _categoryManagementControlSet.ButtonAdd;
            buttonAdd.Enabled = false;
        }

        //add category
        public void AddCategory(object sender, EventArgs args)
        {
            TextBox textBoxCategoryName = _categoryManagementControlSet.TextBoxCategoryName;
            String categoryName = textBoxCategoryName.Text;
            _categoryModel.AddCategory(new Category(categoryName));
            textBoxCategoryName.Text = String.Empty;
        }

        //change category name event
        public void ChangeCategoryName(object sender, EventArgs args)
        {
            _categoryManagementControlSet.SetButtonAndErrorProviderState(_categoryModel);
        }

        //list change
        public void ChangeCategoryList(object sender, EventArgs args)
        {
            CurrencyManager currencyManager = _categoryManagementControlSet.CurrencyManager;
            currencyManager.Refresh();
        }
    }
}
