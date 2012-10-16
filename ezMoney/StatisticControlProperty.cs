using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class StatisticControlProperty
    {
        private RadioButton _radioButtonIncome;
        private RadioButton _radioButtonExpense;
        private DataGridView _dataGridViewStatistic;
        private TextBox _textBoxIncome;
        private TextBox _textBoxExpense;
        private TextBox _textBoxBalance;
        private DataGridView _dataGridViewDetail;

        public RadioButton RadioButtonIncome
        {
            get
            {
                return _radioButtonIncome;
            }
            set
            {
                _radioButtonIncome = value;
            }
        }

        public RadioButton RadioButtonExpense
        {
            get
            {
                return _radioButtonExpense;
            }
            set
            {
                _radioButtonExpense = value;
            }
        }

        public DataGridView DataGridViewStatistic
        {
            get
            {
                return _dataGridViewStatistic;
            }
            set
            {
                _dataGridViewStatistic = value;
            }
        }

        public TextBox TextBoxIncome
        {
            get
            {
                return _textBoxIncome;
            }
            set
            {
                _textBoxIncome = value;
            }
        }

        public TextBox TextBoxExpense
        {
            get
            {
                return _textBoxExpense;
            }
            set
            {
                _textBoxExpense = value;
            }
        }

        public TextBox TextBoxBalance
        {
            get
            {
                return _textBoxBalance;
            }
            set
            {
                _textBoxBalance = value;
            }
        }

        public DataGridView DataGridViewDetail
        {
            get
            {
                return _dataGridViewDetail;
            }
            set
            {
                _dataGridViewDetail = value;
            }
        }

    }
}
