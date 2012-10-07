﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class CategoryManagementControlSet
    {
        TextBox _textBoxCategoryName;
        ListBox _listBoxCategories;
        CurrencyManager _currencyManager;
        Button _buttonAdd;
        ErrorProvider _errorProvider;

        //constructor of categoryManagementConstrolSet
        public CategoryManagementControlSet(TextBox textBox, ListBox listBox, CurrencyManager currencyManager, Button button, ErrorProvider errorProvider)
        {
            _textBoxCategoryName = textBox;
            _listBoxCategories = listBox;
            _currencyManager = currencyManager;
            _buttonAdd = button;
            _errorProvider = errorProvider;
        }

        public TextBox GetTextBoxCategoryName()
        {
            return _textBoxCategoryName;
        }

        public ListBox GetListBoxCategories()
        {
            return _listBoxCategories;
        }

        public CurrencyManager GetCurrencyManager()
        {
            return _currencyManager;
        }

        public Button GetButtonAdd()
        {
            return _buttonAdd;
        }

        public ErrorProvider GetErrorProvider()
        {
            return _errorProvider;
        }

        //enable/ disable button and ErrorProvider
        public void SetButtonAndErrorProviderState(CategoryModel model)
        {
            String categoryName = _textBoxCategoryName.Text;
            if (categoryName == "")
            {
                _errorProvider.SetError(_buttonAdd, "category name must have value.");
                _buttonAdd.Enabled = false;
            }
            else if (model.IsExist(categoryName))
            {
                _errorProvider.SetError(_buttonAdd, "category name must has value and non-repeat.");
                _buttonAdd.Enabled = false;
            }
            else
            {
                _errorProvider.Clear();
                _buttonAdd.Enabled = true;
            }
        }
    }
}