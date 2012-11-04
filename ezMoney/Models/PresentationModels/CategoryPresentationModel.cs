using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class CategoryPresentationModel : CategoryPresentationModelProperty
    {
        private CategoryModel _categoryModel;
        private RecordModel _recordModel;

        public CategoryPresentationModel(EZMoneyModel ezMoneyModel)
        {
            _categoryModel = ezMoneyModel.GetCategoryModel();
            _recordModel = ezMoneyModel.GetRecordModel();
            InitializeState();
        }

        //initialize state
        public void InitializeState()
        {
            IsSelectionMode = false;
            IsModifyEnable = false;
            IsDeleteEnable = false;
            IsCancelEnable = false;
            String errorMessage = "";
            CategoryNameText = "";
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
                ErrorProviderMessage = "";
                Category category = _categoryModel.GetCategory(index);
                CategoryNameText = category.CategoryName;
            }
            else
            {
                InitializeState();
            }
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
        }

        //add category instruction
        public void Add(String categoryName)
        {
            _categoryModel.AddCategory(categoryName);
            InitializeState();
        }

        //modify category instruction
        public void Modify(int index, String categoryName)
        {
            //Category category = new Category(categoryName);
            if (!_categoryModel.IsExist(categoryName))
            {
                _categoryModel.GetCategories()[index].CategoryName = categoryName;
                _categoryModel.GetCategories()[index] = _categoryModel.GetCategories()[index];
            }
            InitializeState();
        }

        //delete category instruction
        public void Delete(int index, DialogResult dialogResult)
        {
            if (dialogResult == DialogResult.Yes)
            {
                Category category = _categoryModel.GetCategories()[index];
                _recordModel.RemoveRecordsByCategory(category);
                _categoryModel.GetCategories().RemoveAt(index);
            }
            InitializeState();
        }

        //cancel button click
        public void Cancel()
        {
            InitializeState();
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
                errorMessage = CATEGORY_NO_NAME_INFO;
                buttonEnable = false;
            }
            else
            {
                errorMessage = EMPTY_ERROR_MESSAGE;
                buttonEnable = true;
            }
            return buttonEnable;
        }
    }
}
