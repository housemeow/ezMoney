using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class StatisticControlSet:StatisticControlProperty
    {
        //get statistic datagridview datasource
        public List<Statistic> GetStatisticDataGridViewDataSource(StatisticModel statisticModel, EZMoneyModel ezMoneyModel)
        {
            List<Statistic> statistics = new List<Statistic>();
            if (RadioButtonIncome.Checked)
            {
                statistics = statisticModel.GetIncomeStatistics(ezMoneyModel.GetCategories(), ezMoneyModel.GetRecords());
            }
            else if(RadioButtonExpense.Checked)
            {
                statistics = statisticModel.GetExpenseStatistics(ezMoneyModel.GetCategories(), ezMoneyModel.GetRecords());
            }
            return statistics;
        }

        //get record from select statistic datagridview row
        public List<Record> GetRecords(int rowIndex, EZMoneyModel ezMoneyModel)
        { 
            List<Record> records = new List<Record>();
            if (rowIndex >= 0)
            {
                Category category =(Category) DataGridViewStatistic.Rows[rowIndex].Cells[0].Value;
                records = ezMoneyModel.GetRecords(category);
            }
            return records;
        }
    }
}
