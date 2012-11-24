using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ezMoney
{
    class StatisticPresentationModelProperty
    {
        bool _isIncomeCheck;
        bool _isExpenseCheck;
        String _income;
        String _expense;
        String _balance;
        BindingList<Statistic> _statisticList;
        BindingList<Record> _recordList;

        public String Expense
        {
            get
            {
                return _expense;
            }
            set
            {
                _expense = value;
            }
        }

        public bool IsIncomeCheck
        {
            get
            {
                return _isIncomeCheck;
            }
            set
            {
                _isIncomeCheck = value;
            }
        }

        public bool IsExpenseCheck
        {
            get
            {
                return _isExpenseCheck;
            }
            set
            {
                _isExpenseCheck = value;
            }
        }

        public String Income
        {
            get
            {
                return _income;
            }
            set
            {
                _income = value;
            }
        }

        public String Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        internal BindingList<Statistic> StatisticList
        {
            get
            {
                return _statisticList;
            }
            set
            {
                _statisticList = value;
            }
        }

        public BindingList<Record> RecordList
        {
            get
            {
                return _recordList;
            }
            set
            {
                _recordList = value;
            }
        }
    }
}
