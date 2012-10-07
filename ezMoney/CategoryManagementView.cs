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
        TextBox _textBoxCategoryName;
        ListBox _listBoxCategories;
        CurrencyManager _currencyManager;
        Button _buttonAdd;
        ErrorProvider _errorProvider;

        public CategoryManagementView() {
            _categoryModel = new CategoryModel();
            _errorProvider = new ErrorProvider();
            _errorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
        }

        public TextBox TextBoxCategoryName
        {
            get { return _textBoxCategoryName; }
            set { _textBoxCategoryName = value; }
        }
        public Button ButtonAdd
        {
            get { return _buttonAdd; }
            set { _buttonAdd = value; }
        }

        public ListBox ListBoxCategories
        {
            get { return _listBoxCategories; }
            set { _listBoxCategories = value; }
        }

        public CurrencyManager CurrencyManager
        {
            get { return _currencyManager; }
            set { _currencyManager = value; }
        }
        //control events
        public void AddCategory(object sender, EventArgs args) {
            String categoryName = _textBoxCategoryName.Text;
            _categoryModel.AddCategory(categoryName);
            _textBoxCategoryName.Text = "";
            //reload view
            View();
        }
        public void CategoryNameChanged(object sender, EventArgs args)
        {
            String categoryName = _textBoxCategoryName.Text;
            if (categoryName == "" || _categoryModel.IsExist(categoryName))
            {
                _buttonAdd.Enabled = false;
                _errorProvider.SetError(_buttonAdd, "category name must has value and non-repeat.");
            }
            else
            {
                _errorProvider.Clear();
                _buttonAdd.Enabled = true;
            }
        }

        public List<String> GetCategoryList() {
            return _categoryModel.GetCategories();
        }
        public void View()
        {
            _currencyManager.Refresh();
        }
    }
}
