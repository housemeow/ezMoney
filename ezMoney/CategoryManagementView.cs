using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class CategoryManagementView
    {
        CategoryModel _categoryModel;
        CategoryManagementControlSet _categoryManagementControlSet;

        //categoryManagementView constructor
        public CategoryManagementView(CategoryManagementControlSet categoryManagementConstrolSet, CategoryModel categoryModel)
        {
            _categoryManagementControlSet = categoryManagementConstrolSet;
            _categoryModel = categoryModel;
            BindControlSetEvent();
        }

        //bind all control to categoryManagementView
        private void BindControlSetEvent()
        {
            TextBox textBoxCategoryName = _categoryManagementControlSet.GetTextBoxCategoryName();
            Button buttonAdd = _categoryManagementControlSet.GetButtonAdd();
            textBoxCategoryName.TextChanged += new EventHandler(CategoryNameChanged);
            buttonAdd.Click += new EventHandler(AddCategory);
        }

        //control events
        public void AddCategory(object sender, EventArgs args)
        {
            TextBox textBoxCategoryName = _categoryManagementControlSet.GetTextBoxCategoryName();
            String categoryName = textBoxCategoryName.Text;
            _categoryModel.AddCategory(categoryName);
            textBoxCategoryName.Text = "";
            //reload view
            View();
        }

        //change category name event
        public void CategoryNameChanged(object sender, EventArgs args)
        {
            _categoryManagementControlSet.SetButtonAndErrorProviderState(_categoryModel);
        }

        public List<String> GetCategoryList()
        {
            return _categoryModel.GetCategories();
        }

        //refresh view
        public void View()
        {
            CurrencyManager currencyManager = _categoryManagementControlSet.GetCurrencyManager();
            currencyManager.Refresh();
        }
    }
}
