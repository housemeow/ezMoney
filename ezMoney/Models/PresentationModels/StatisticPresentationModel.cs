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
            _categoryModel = ezMoneyModel.CategoryModel;
            _recordModel = ezMoneyModel.RecordModel;
            _statisticModel = ezMoneyModel.StatisticModel;
            InitializeState();
        }

        //initalize initialize state
        public void InitializeState()
        {
            IsIncomeCheck = true;
            IsExpenseCheck = false;
            BindingList<Record> records = _recordModel.Records;
            Income = _statisticModel.GetIncome(records).ToString();
            Expense = _statisticModel.GetExpense(records).ToString();
            Balance = _statisticModel.GetBalance(records).ToString();
            StatisticList = _statisticModel.GetStatisticDataGridViewDataSource(IsIncomeCheck);
            //if you dont click any category, you will not see any detail records.
            RecordList = null;
        }

        //change radio button
        public void ChangeRadioButton(bool isIncome)
        {
            IsIncomeCheck = isIncome;
            IsExpenseCheck = !isIncome;
            StatisticList = _statisticModel.GetStatisticDataGridViewDataSource(IsIncomeCheck);
            //if you dont click any category, you will not see any detail records.
            RecordList = null;
        }

        //click data grid cell
        public BindingList<Record> ClickDataGridView(Category category)
        {
            RecordList = _recordModel.GetRecords(category, IsIncomeCheck);
            return RecordList;
        }

        //tab enter
        public void EnterTabPageStatistic()
        {
            InitializeState();
        }
    }
}
