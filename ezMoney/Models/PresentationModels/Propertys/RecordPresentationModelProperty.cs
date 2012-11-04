using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ezMoney
{
    class RecordPresentationModelProperty
    {
        //error provider information
        public const String EMPTY_ERROR_MESSAGE = "";
        public const String NO_NUMBER_INFO = "must have number.";
        public const String NO_SELECT_CATEGORY_INFO = "must select a category.";
        public const String TEXT_IS_NOT_NUMBER_INFO = "text is not a number.";
        public const int NO_SELECT_COMBOBOX_ITEM = -1;
        private String _errorProviderMessage;
        //modification
        private bool _isSelectionMode;
        private bool _isModifyEnable;
        private bool _isDeleteEnable;
        private bool _isCancelEnable;
        private bool _isAddEnable;
        //view state
        private DateTime _recordDate;
        private String _amount;
        private int _categoryIndex;
        private int _recordIndex;
        private bool _isIncomeCheck;
        private bool _isExpenseCheck;

        public bool IsIncomeCheck
        {
            get
            {
                return _isIncomeCheck;
            }
            set
            {
                _isIncomeCheck = value;
            }
        }

        public bool IsExpenseCheck
        {
            get
            {
                return _isExpenseCheck;
            }
            set
            {
                _isExpenseCheck = value;
            }
        }

        public int RecordIndex
        {
            get
            {
                return _recordIndex;
            }
            set
            {
                _recordIndex = value;
            }
        }

        public String ErrorProviderMessage
        {
            get
            {
                return _errorProviderMessage;
            }
            set
            {
                _errorProviderMessage = value;
            }
        }

        public bool IsSelectionMode
        {
            get
            {
                return _isSelectionMode;
            }
            set
            {
                _isSelectionMode = value;
            }
        }

        public bool IsModifyEnable
        {
            get
            {
                return _isModifyEnable;
            }
            set
            {
                _isModifyEnable = value;
            }
        }

        public bool IsDeleteEnable
        {
            get
            {
                return _isDeleteEnable;
            }
            set
            {
                _isDeleteEnable = value;
            }
        }

        public bool IsCancelEnable
        {
            get
            {
                return _isCancelEnable;
            }
            set
            {
                _isCancelEnable = value;
            }
        }

        public bool IsAddEnable
        {
            get
            {
                return _isAddEnable;
            }
            set
            {
                _isAddEnable = value;
            }
        }

        public DateTime RecordDate
        {
            get
            {
                return _recordDate;
            }
            set
            {
                _recordDate = value;
            }
        }

        public int CategoryIndex
        {
            get
            {
                return _categoryIndex;
            }
            set
            {
                _categoryIndex = value;
            }
        }

        public String Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
    }
}
