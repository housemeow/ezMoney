﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class RecordPresentationModel : RecordPresentationModelProperty
    {
        private CategoryModel _categoryModel;
        private RecordModel _recordModel;

        //record presentation model constructor
        public RecordPresentationModel(EZMoneyModel ezMoneyModel)
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
            DateTime now = DateTime.Now;
            RecordDate = new DateTime(now.Year, now.Month, now.Day);
            CategoryIndex = -1;
            Amount = "";
            IsIncomeCheck = true;
            IsExpenseCheck = false;

            String errorMessage = "";
            bool isCanAdd = IsValidRecordAdd(CategoryIndex, Amount, ref errorMessage);
            IsAddEnable = isCanAdd;
            ErrorProviderMessage = errorMessage;
        }

        public void ChangeAmount(String amount)
        {
            Amount = amount;
            String errorMessage = "";
            bool isCanAdd = IsValidRecordAdd(CategoryIndex, Amount, ref errorMessage);
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

        //select a list item
        public void SelectCategory(int categoryIndex)
        {
            CategoryIndex = categoryIndex;
        }

        //change radiobutton
        public void ChangeIncomeCheck(bool incomeCheck)
        {
            IsIncomeCheck = incomeCheck;
            IsExpenseCheck = !incomeCheck;
        }

        //select a record
        public void SelectRecord(int recordIndex)
        {
            RecordIndex = recordIndex;
            if (recordIndex >= 0)
            {
                IsSelectionMode = true;
                IsAddEnable = false;
                IsModifyEnable = true;
                IsDeleteEnable = true;
                IsCancelEnable = true;
                ErrorProviderMessage = "";
                Record record = _recordModel.GetRecords()[recordIndex];
                CategoryIndex = _categoryModel.GetCategoryIndex(record.Category);
                if (record.Amount >= 0)
                {
                    Amount = record.Amount.ToString();
                    IsIncomeCheck = true;
                    IsExpenseCheck = false;
                }
                else
                {
                    Amount = (-record.Amount).ToString();
                    IsIncomeCheck = false;
                    IsExpenseCheck = true;
                }
                RecordDate = record.Date;
            }
            else
            {
                InitializeState();
            }
        }

        //add record
        public void Add(DateTime date, int categoryIndex, String amount)
        {
            Category category = _categoryModel.GetCategories()[categoryIndex];
            int money = 0;
            int.TryParse(amount, out money);
            if (!IsIncomeCheck)
            {
                money = -money;
            }
            _recordModel.AddRecord(new Record(date, category, money));
            InitializeState();
        }

        //modify record
        public void Modify(DateTime date, int categoryIndex, String amount)
        {
            if (categoryIndex >= 0)
            {
                Category category = _categoryModel.GetCategories()[categoryIndex];
                int money = 0;
                int.TryParse(amount, out money);
                Record record = _recordModel.GetRecords()[RecordIndex];
                record.Category = category;
                record.Date = date;
                if (IsIncomeCheck)
                {
                    record.Amount = money;
                }
                else
                {
                    record.Amount = -money;
                }
                _recordModel.GetRecords()[RecordIndex] = _recordModel.GetRecords()[RecordIndex];
            }
            InitializeState();
        }

        //delete record
        public void Delete(DialogResult dialogResult)
        {
            if (dialogResult == DialogResult.Yes)
            {
                _recordModel.GetRecords().RemoveAt(RecordIndex);
            }
            InitializeState();
        }

        //cancel record
        public void Cancel()
        {
            InitializeState();
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
    }
}