using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class CategoryManagementView
    {
        EZMoneyModel _ezMoneyModel;
        CategoryControlSet _categoryManagementControlSet;

        //categoryManagementView constructor
        public CategoryManagementView(CategoryControlSet categoryManagementConstrolSet, EZMoneyModel ezMoneyModel)
        {
            _categoryManagementControlSet = categoryManagementConstrolSet;
            _ezMoneyModel = ezMoneyModel;
            BindControlSetEvent();
            InitControlSet();
            _categoryManagementControlSet.SetButtonAndErrorProviderState(_ezMoneyModel);
        }

        //bind all control to categoryManagementView
        private void BindControlSetEvent()
        {
            TextBox textBoxCategoryName = _categoryManagementControlSet.GetTextBoxCategoryName();
            Button buttonAdd = _categoryManagementControlSet.GetButtonAdd();
            textBoxCategoryName.TextChanged += new EventHandler(CategoryNameChanged);
            buttonAdd.Click += new EventHandler(AddCategory);
            _ezMoneyModel._categoryListChangedEvent += CategoryListChanged;
        }

        //initialize control
        public void InitControlSet()
        {
            Button buttonAdd = _categoryManagementControlSet.GetButtonAdd();
            buttonAdd.Enabled = false;
        }

        //add category
        public void AddCategory(object sender, EventArgs args)
        {
            TextBox textBoxCategoryName = _categoryManagementControlSet.GetTextBoxCategoryName();
            String categoryName = textBoxCategoryName.Text;
            _ezMoneyModel.AddCategory(new Category(categoryName));
            textBoxCategoryName.Text = "";
        }

        //change category name event
        public void CategoryNameChanged(object sender, EventArgs args)
        {
            _categoryManagementControlSet.SetButtonAndErrorProviderState(_ezMoneyModel);
        }

        //list change
        public void CategoryListChanged(object sender, EventArgs args)
        {
            CurrencyManager currencyManager = _categoryManagementControlSet.GetCurrencyManager();
            currencyManager.Refresh();
        }
    }
}
