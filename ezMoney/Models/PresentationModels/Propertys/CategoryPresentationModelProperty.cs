using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ezMoney
{
    class CategoryPresentationModelProperty
    {
        //error provider information
        public const String CATEGORY_NO_NAME_INFO = "category name must have value.";
        public const String CATEGORY_REPEAT_INFO = "category name is repeat.";
        public const String EMPTY_ERROR_MESSAGE = "";
        private String _errorProviderMessage;
        //modification
        private bool _isSelectionMode;
        private bool _isModifyEnable;
        private bool _isDeleteEnable;
        private bool _isCancelEnable;
        private bool _isAddEnable;
        //view state
        private String _categoryNameText;

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

        public String CategoryNameText
        {
            get
            {
                return _categoryNameText;
            }
            set
            {
                _categoryNameText = value;
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
    }
}
