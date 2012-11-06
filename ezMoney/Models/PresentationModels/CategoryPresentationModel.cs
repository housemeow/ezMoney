using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class CategoryPresentationModel : CategoryPresentationModelProperty
    {
        public delegate void UpdateEventHandler(CategoryPresentationModel categoryPModel);
        public event UpdateEventHandler _updateEvent;
        //member
        private CategoryModel _categoryModel;
        private RecordModel _recordModel;

        //category presentation model constructor
        public CategoryPresentationModel(EZMoneyModel ezMoneyModel)
        {
            _categoryModel = ezMoneyModel.CategoryModel;
            _recordModel = ezMoneyModel.RecordModel;
            InitializeState();
        }

        //initialize state
        public void InitializeState()
        {
            IsSelectionMode = false;
            IsModifyEnable = false;
            IsDeleteEnable = false;
            IsCancelEnable = false;
            String errorMessage = String.Empty;
            CategoryNameText = String.Empty;
            bool isCanAdd = IsValidCategoryAdd(CategoryNameText, ref errorMessage);
            IsAddEnable = isCanAdd;
            ErrorProviderMessage = errorMessage;
        }

        //select a list item
        public void SelectCategory(int index)
        {
            if (index >= 0)
            {
                IsSelectionMode = true;
                IsAddEnable = false;
                IsModifyEnable = true;
                IsDeleteEnable = true;
                IsCancelEnable = true;
                ErrorProviderMessage = String.Empty;
                Category category = _categoryModel.GetCategory(index);
                CategoryNameText = category.CategoryName;
            }
            else
            {
                InitializeState();
            }
            RaiseUpdateEvent();
        }

        //text change and check if Category is error
        public void ChangeTextBox(String categoryName)
        {
            CategoryNameText = categoryName;
            String errorMessage = string.Empty;
            bool isCanAdd = IsValidCategoryAdd(CategoryNameText, ref errorMessage);
            if (IsSelectionMode)
            {
                IsAddEnable = false;
            }
            else
            {
                IsAddEnable = isCanAdd;
            }
            ErrorProviderMessage = errorMessage;
            RaiseUpdateEvent();
        }

        //add category instruction
        public void Add(String categoryName)
        {
            _categoryModel.AddCategory(categoryName);
            InitializeState();
            RaiseUpdateEvent();
        }

        //modify category instruction
        public void Modify(int index, String categoryName)
        {
            if (!_categoryModel.IsExist(categoryName))
            {
                _categoryModel.Categories[index].CategoryName = categoryName;
                _categoryModel.Categories[index] = _categoryModel.Categories[index];
            }
            InitializeState();
            RaiseUpdateEvent();
        }

        //delete category instruction
        public void Delete(int index, DialogResult dialogResult)
        {
            if (dialogResult == DialogResult.Yes)
            {
                Category category = _categoryModel.Categories[index];
                _recordModel.RemoveRecordsByCategory(category);
                _categoryModel.Categories.RemoveAt(index);
            }
            InitializeState();
            RaiseUpdateEvent();
        }

        //cancel button click
        public void Cancel()
        {
            InitializeState();
            RaiseUpdateEvent();
        }

        //check parameter of add category
        public bool IsValidCategoryAdd(String categoryName, ref String errorMessage)
        {
            bool buttonEnable = false;
            if (categoryName == String.Empty)
            {
                errorMessage = CATEGORY_NO_NAME_INFO;
                buttonEnable = false;
            }
            else if (_categoryModel.IsExist(categoryName))
            {
                errorMessage = CATEGORY_REPEAT_INFO;
                buttonEnable = false;
            }
            else
            {
                errorMessage = EMPTY_ERROR_MESSAGE;
                buttonEnable = true;
            }
            return buttonEnable;
        }

        //event raise
        public void RaiseUpdateEvent()
        {
            if (_updateEvent != null)
            {
                _updateEvent(this);
            }
        }
    }
}
