using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ezMoney
{
    class StatisticModel
    {
        //get expense statistics
        public List<Statistic> GetExpenseStatistics(List<Category> categories, List<Record> records)
        {
            List<Statistic> expenseStatistics = new List<Statistic>();
            int amounts = 0;
            foreach (Category category in categories)
            {
                Statistic statistic = GetStatistic(category, records, false);
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
        public List<Statistic> GetIncomeStatistics(List<Category> categories, List<Record> records)
        {
            List<Statistic> incomeStatistics = new List<Statistic>();
            int amounts = 0;
            foreach (Category category in categories)
            {
                Statistic statistic = GetStatistic(category, records, true);
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
        private Statistic GetStatistic(Category category, List<Record> records, bool isPositive)
        {
            Statistic statistic = new Statistic(category);
            foreach (Record record in records)
            {
                if (record.Category.Equals(category))
                {
                    if ((isPositive && record.Amount >= 0) || (!isPositive && record.Amount < 0))
                    {
                        statistic.Count++;
                        statistic.Amounts += record.Amount;
                    }
                }
            }
            return statistic;
        }

        //set statistics percent
        private void SetPercent(List<Statistic> statistics, int amounts)
        {
            foreach (Statistic statistic in statistics)
            {
                double percent;
                percent = (double)Math.Abs(statistic.Amounts) / Math.Abs(amounts)*100;
                statistic.Percent = Convert.ToInt32(Math.Round(percent)).ToString() + "%";
            }
        }

        //get total income
        public int GetIncome(List<Record> records)
        {
            int income = 0;
            foreach (Record record in records)
            {
                if (record.Amount >= 0)
                {
                    income += record.Amount;
                }
            }
            return income;
        }

        //get total expense
        public int GetExpense(List<Record> records)
        {
            int expense = 0;
            foreach (Record record in records)
            {
                if (record.Amount < 0)
                {
                    expense += record.Amount;
                }
            }
            return expense;
        }

        //get balance
        public int GetBalance(List<Record> records)
        {
            int income = GetIncome(records);
            int expense = GetExpense(records);
            int balanse = income + expense;
            return balanse;
        }
    }
}
