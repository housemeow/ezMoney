using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ezMoney
{
    class StatisticModel
    {
        CategoryModel _categoryModel;
        RecordModel _recordModel;

        //constructor
        public StatisticModel(CategoryModel categoryModel, RecordModel recordModel)
        {
            _categoryModel = categoryModel;
            _recordModel = recordModel;
        }

        //get expense statistics
        public List<Statistic> GetExpenseStatistics()
        {
            List<Statistic> expenseStatistics = new List<Statistic>();
            int amounts = 0;
            foreach (Category category in _categoryModel.GetCategories())
            {
                Statistic statistic = GetStatistic(category, false);
                if (statistic.Count != 0)
                {
                    expenseStatistics.Add(statistic);
                    amounts += statistic.Amounts;
                }
            }
            SetPercent(expenseStatistics, amounts);
            return expenseStatistics;
        }

        //get income statistics
        public List<Statistic> GetIncomeStatistics()
        {
            List<Statistic> incomeStatistics = new List<Statistic>();
            int amounts = 0;
            foreach (Category category in _categoryModel.GetCategories())
            {
                Statistic statistic = GetStatistic(category, true);
                if (statistic.Count != 0)
                {
                    incomeStatistics.Add(statistic);
                    amounts += statistic.Amounts;
                }
            }
            SetPercent(incomeStatistics, amounts);
            return incomeStatistics;
        }

        //get statistic from category and records
        public Statistic GetStatistic(Category category, bool isPositive)
        {
            Statistic statistic = new Statistic(category);
            foreach (Record record in _recordModel.GetRecords())
            {
                if (record.Category.Equals(category) && ((isPositive && record.Amount >= 0) || (!isPositive && record.Amount < 0)))
                {
                    statistic.Count++;
                    statistic.Amounts += record.Amount;
                }
            }
            return statistic;
        }

        //set statistics percent
        public void SetPercent(List<Statistic> statistics, int amounts)
        {
            foreach (Statistic statistic in statistics)
            {
                double percent;
                percent = (double)Math.Abs(statistic.Amounts) / Math.Abs(amounts) * 100;
                statistic.Percent = Convert.ToInt32(Math.Round(percent)).ToString() + "%";
            }
        }

        //get amounts with isIncome
        public int GetAmounts(List<Record> records, bool isIncome)
        {
            int amounts = 0;
            foreach (Record record in records)
            {
                if ((isIncome && record.Amount >= 0) || (!isIncome && record.Amount<0))
                {
                    amounts += record.Amount;
                }
            }
            return amounts;
        }

        //get total income
        public int GetIncome(List<Record> records)
        {
            int income = GetAmounts(records, true);
            return income;
        }

        //get total expense
        public int GetExpense(List<Record> records)
        {
<<<<<<< HEAD:ezMoney/Models/StatisticModel.cs
            int expense = GetAmounts(records, false);
=======
            int expense = -GetAmounts(records, false);
>>>>>>> TestProject:ezMoney/Models/StatisticModel.cs
            return expense;
        }

        //get balance
        public int GetBalance(List<Record> records)
        {
            int income = GetIncome(records);
            int expense = GetExpense(records);
            int balanse = income - expense;
            return balanse;
        }

        //get statistic datagridview datasource
        public List<Statistic> GetStatisticDataGridViewDataSource(bool isIncome)
        {
            if (isIncome)
            {
                return GetIncomeStatistics();
            }
            else
            {
                return GetExpenseStatistics();
            }
        }
    }
}
