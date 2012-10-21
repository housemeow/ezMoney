using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class CategoryViewProperty
    {
        TextBox _textBoxCategoryName;
        ListBox _listBoxCategories;
        CurrencyManager _currencyManager;
        Button _buttonAdd;
        ErrorProvider _errorProvider;

        public TextBox TextBoxCategoryName
        {
            get
            {
                return _textBoxCategoryName;
            }
            set
            {
                _textBoxCategoryName = value;
            }
        }

        public ListBox ListBoxCategories
        {
            get
            {
                return _listBoxCategories;
            }
            set
            {
                _listBoxCategories = value;
            }
        }

        public CurrencyManager CurrencyManager
        {
            get
            {
                return _currencyManager;
            }
            set
            {
                _currencyManager = value;
            }
        }

        public Button ButtonAdd
        {
            get
            {
                return _buttonAdd;
            }
            set
            {
                _buttonAdd = value;
            }
        }

        public ErrorProvider ErrorProvider
        {
            get
            {
                return _errorProvider;
            }
            set
            {
                _errorProvider = value;
            }
        }
    }
}
