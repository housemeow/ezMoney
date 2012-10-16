using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace ezMoney
{
    class StatisticView
    {
        private StatisticControlSet _statisticControlSet;
        private StatisticModel _statisticModel;
        private List<Statistic> _statistics;
        private List<Record> _recordsOfCategory;
        private EZMoneyModel _ezMoneyModel;
        public StatisticView(StatisticControlSet statisticControlSet, StatisticModel statisticModel, EZMoneyModel ezMoneyModel)
        {
            _statisticControlSet = statisticControlSet;
            _statisticModel = statisticModel;
            _ezMoneyModel = ezMoneyModel;
            BindControlSetEvent();
            InitControlSet();
            _ezMoneyModel._recordListChangeEvent += new EZMoneyModel.RecordListChangedEventHandler(RecordListChanged);
        }

        //bind control event
        private void BindControlSetEvent()
        {
            _statisticControlSet.RadioButtonIncome.CheckedChanged += new EventHandler(CheckChangeRadioButton);
            _statisticControlSet.RadioButtonExpense.CheckedChanged += new EventHandler(CheckChangeRadioButton);
            _statisticControlSet.DataGridViewStatistic.CellClick += new DataGridViewCellEventHandler(ClickDataGridViewCell);
        }

        //init control
        private void InitControlSet()
        {
            InitStatisticDataGridView();
            InitDetailDataGridView();
            _statisticControlSet.RadioButtonIncome.Checked = true;
            _statisticControlSet.TextBoxIncome.ReadOnly = true;
            _statisticControlSet.TextBoxExpense.ReadOnly = true;
            _statisticControlSet.TextBoxBalance.ReadOnly = true;
            InitTextBoxValue(_ezMoneyModel.GetRecords());
        }

        //show 
        private void InitTextBoxValue(List<Record> records)
        {
            _statisticControlSet.TextBoxIncome.Text = _statisticModel.GetIncome(records).ToString();
            _statisticControlSet.TextBoxExpense.Text = _statisticModel.GetExpense(records).ToString();
            _statisticControlSet.TextBoxBalance.Text = _statisticModel.GetBalance(records).ToString();
        }

        //init statistic datagridview
        private void InitStatisticDataGridView()
        {
            _statisticControlSet.DataGridViewStatistic.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Category";
            nameColumn.HeaderText = "Name";
            DataGridViewTextBoxColumn countColumn = new DataGridViewTextBoxColumn();
            countColumn.DataPropertyName = "Count";
            countColumn.HeaderText = "Count";
            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.DataPropertyName = "Amounts";
            amountColumn.HeaderText = "Amount";
            DataGridViewTextBoxColumn percentColumn = new DataGridViewTextBoxColumn();
            percentColumn.DataPropertyName = "Percent";
            percentColumn.HeaderText = "Percent";
            _statisticControlSet.DataGridViewStatistic.Columns.Add(nameColumn);
            _statisticControlSet.DataGridViewStatistic.Columns.Add(countColumn);
            _statisticControlSet.DataGridViewStatistic.Columns.Add(amountColumn);
            _statisticControlSet.DataGridViewStatistic.Columns.Add(percentColumn);
            _statisticControlSet.DataGridViewStatistic.DataSource = _statistics;
            _statisticControlSet.DataGridViewStatistic.ReadOnly = true;
        }

        //init detail datagridview
        private void InitDetailDataGridView()
        {
            _statisticControlSet.DataGridViewDetail.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = "Date";
            dateColumn.HeaderText = "Date";

            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.DataPropertyName = "Amount";
            amountColumn.HeaderText = "Amount";
            _statisticControlSet.DataGridViewDetail.Columns.Add(dateColumn);
            _statisticControlSet.DataGridViewDetail.Columns.Add(amountColumn);
            _statisticControlSet.DataGridViewDetail.DataSource = _recordsOfCategory;
            _statisticControlSet.DataGridViewDetail.ReadOnly = true;
        }


        //radio button checked change
        private void CheckChangeRadioButton(object sender, EventArgs e)
        {
            _statistics = _statisticControlSet.GetStatisticDataGridViewSource(_statisticModel, _ezMoneyModel);
            _statisticControlSet.DataGridViewStatistic.DataSource = _statistics;
        }

        //click datagridView's cell
        private void ClickDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            _recordsOfCategory = _statisticControlSet.GetRecords(e.RowIndex, _ezMoneyModel);
            _statisticControlSet.DataGridViewDetail.DataSource = _recordsOfCategory;
        }

        //record list changed
        private void RecordListChanged(List<Record> records, EventArgs e)
        {
            CheckChangeRadioButton(this, new EventArgs());
            InitTextBoxValue(records);
        }
    }
}
