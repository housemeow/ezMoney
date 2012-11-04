using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ezMoney
{
    class StatisticPresentationModel : StatisticPresentationModelProperty
    {
        CategoryModel _categoryModel;
        RecordModel _recordModel;
        StatisticModel _statisticModel;

        //constructor of statistic presentation model
        public StatisticPresentationModel(EZMoneyModel ezMoneyModel)
        {
            _categoryModel = ezMoneyModel.GetCategoryModel();
            _recordModel = ezMoneyModel.GetRecordModel();
            _statisticModel = ezMoneyModel.GetStatisticModel();
            InitializeState();
        }

        //initalize initialize state
        public void InitializeState()
        {
            IsIncomeCheck = true;
            IsExpenseCheck = false;
            BindingList<Record> records = _recordModel.GetRecords();
            Income = _statisticModel.GetIncome(records).ToString();
            Expense = _statisticModel.GetExpense(records).ToString();
            Balance = _statisticModel.GetBalance(records).ToString();
            StatisticList = _statisticModel.GetStatisticDataGridViewDataSource(IsIncomeCheck);
            RecordList = null;//_recordModel.GetRecords(category, IncomeCheck);
        }

        //change radio button
        public void ChangeRadioButton(bool isIncome)
        {
            IsIncomeCheck = isIncome;
            IsExpenseCheck = !isIncome;
            StatisticList = _statisticModel.GetStatisticDataGridViewDataSource(IsIncomeCheck);
            RecordList = null;//_recordModel.GetRecords(category, IncomeCheck);
        }

        //click data grid cell
        public void ClickDataGridView(Category category)
        {
            RecordList = _recordModel.GetRecords(category, IsIncomeCheck);
        }

        //tab enter
        public void EnterTabPageStatistic()
        {
            InitializeState();
        }
    }
}
