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
        StatisticControlSet _statisticControlSet;
        List<Statistic> _statistics;
        List<Record> _recordsOfCategory;
        CategoryModel _categoryModel;
        RecordModel _recordModel;
        StatisticModel _statisticModel;

        //constructor
        public StatisticView(StatisticControlSet statisticControlSet, CategoryModel categoryModel, RecordModel recordModel, StatisticModel statisticModel)
        {
            _statisticControlSet = statisticControlSet;
            _categoryModel = categoryModel;
            _recordModel = recordModel;
            _statisticModel = statisticModel;
            BindControlSetEvent();
            InitControlSet();
            _recordModel._recordListChangeEvent += new RecordModel.RecordListChangedEventHandler(ChangeRecordList);
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
            _statisticControlSet.RadioButtonIncome.Checked = true;
            InitStatisticDataGridView();
            InitDetailDataGridView();
            _statisticControlSet.TextBoxIncome.ReadOnly = true;
            _statisticControlSet.TextBoxExpense.ReadOnly = true;
            _statisticControlSet.TextBoxBalance.ReadOnly = true;
            InitTextBoxValue(_recordModel.GetRecords());
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
            _statisticControlSet.DataGridViewStatistic.AutoGenerateColumns = true;
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
            _statistics = _statisticControlSet.GetStatisticDataGridViewDataSource(_statisticModel);
            _statisticControlSet.DataGridViewStatistic.DataSource = _statistics;
        }

        //click datagridView's cell
        private void ClickDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            _recordsOfCategory = _statisticControlSet.GetRecords(e.RowIndex, _recordModel);
            _statisticControlSet.DataGridViewDetail.DataSource = _recordsOfCategory;
        }

        //record list changed
        private void ChangeRecordList(List<Record> records, EventArgs e)
        {
            CheckChangeRadioButton(this, new EventArgs());
            InitTextBoxValue(records);
        }
    }
}
