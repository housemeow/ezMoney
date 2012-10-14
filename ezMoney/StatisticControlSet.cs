using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class StatisticControlSet
    {
        private RadioButton _radioButtonIncome;
        private RadioButton _radioButtonExpense;
        private DataGridView _dataGridViewStatistic;
        private TextBox _textBoxIncome;
        private TextBox _textBoxExpense;
        private TextBox _textBoxBalance;
        private DataGridView _dataGridViewDetail;
        
        //constructor
        public StatisticControlSet(
            RadioButton radioButtonIncome,
            RadioButton radioButtonExpense,
            DataGridView dataGridViewStatistic,
            TextBox textBoxIncome,
            TextBox textBoxExpense,
            TextBox textBoxBalance,
            DataGridView dataGridViewDetail)
        {
            _radioButtonIncome = radioButtonIncome;
            _radioButtonExpense = radioButtonExpense;
            _dataGridViewStatistic = dataGridViewStatistic;
            _textBoxIncome = textBoxIncome;
            _textBoxExpense = textBoxExpense;
            _textBoxBalance = textBoxBalance;
            _dataGridViewDetail = dataGridViewDetail;
        }
    }
}
