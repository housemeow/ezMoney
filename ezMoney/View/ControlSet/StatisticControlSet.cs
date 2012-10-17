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
        public List<Statistic> GetStatisticDataGridViewDataSource(StatisticModel statisticModel)
        {
            List<Statistic> statistics = new List<Statistic>();
            if (RadioButtonIncome.Checked)
            {
                statistics = statisticModel.GetIncomeStatistics();
            }
            else if(RadioButtonExpense.Checked)
            {
                statistics = statisticModel.GetExpenseStatistics();
            }
            return statistics;
        }

        //get record from select statistic datagridview row
        public List<Record> GetRecords(int rowIndex, RecordModel recordModel)
        { 
            List<Record> records = new List<Record>();
            if (rowIndex >= 0)
            {
                Category category =(Category) DataGridViewStatistic.Rows[rowIndex].Cells[0].Value;
                records = recordModel.GetRecords(category);
            }
            return records;
        }
    }
}
