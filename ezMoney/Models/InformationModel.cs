using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ezMoney
{
    class InformationModel : Information
    {
        CategoryModel _categoryModel;

        //constructor
        public InformationModel(CategoryModel categoryModel)
        {
            _categoryModel = categoryModel;
        }

        //check parameter of add category
        public bool IsValidCategoryAdd(String categoryName, ref String errorMessage)
        {
            Category category = new Category(categoryName);
            bool buttonEnable = false;
            if (category.CategoryName == String.Empty)
            {
                errorMessage = CATEGORY_NO_NAME_INFO;
                buttonEnable = false;
            }
            else if (_categoryModel.IsExist(category))
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

        //check parameter of add record
        public bool IsValidRecordAdd(int categoryIndex, String amountString, ref String errorMessage)
        {
            bool buttonEnable = false;
            int amount;
            bool isNum = int.TryParse(amountString, out amount);
            if (amountString == String.Empty)
            {
                errorMessage = NO_NUMBER_INFO;
                buttonEnable = false;
            }
            else if (categoryIndex == NO_SELECT_COMBOBOX_ITEM)
            {
                errorMessage = NO_SELECT_CATEGORY_INFO;
                buttonEnable = false;
            }
            else if (!isNum)
            {
                errorMessage = TEXT_IS_NOT_NUMBER_INFO;
                buttonEnable = false;
            }
            else
            {
                errorMessage = EMPTY_ERROR_MESSAGE;
                buttonEnable = true;
            }
            return buttonEnable;
        }

        //get amount with income
        public int GetAmount(String amountString, bool isIncome)
        {
            int amount;
            if (isIncome)
            {
                amount = Convert.ToInt32(amountString);
            }
            else
            {
                amount = -Convert.ToInt32(amountString);
            }
            return amount;
        }
    }
}
