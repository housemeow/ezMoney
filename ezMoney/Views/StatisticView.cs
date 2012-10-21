using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace ezMoney
{
    class StatisticView : StatisticViewProperty
    {
        List<Statistic> _statistics;
        List<Record> _recordsOfCategory;
        CategoryModel _categoryModel;
        RecordModel _recordModel;
        StatisticModel _statisticModel;

        //constructor
        public StatisticView(CategoryModel categoryModel, RecordModel recordModel, StatisticModel statisticModel)
        {
            _categoryModel = categoryModel;
            _recordModel = recordModel;
            _statisticModel = statisticModel;
        }

        //initialize controls and event
        public void Initialize()
        {
            BindControlSetEvent();
            InitControlSet();
        }

        //bind control event
        private void BindControlSetEvent()
        {
            RadioButtonIncome.CheckedChanged += new EventHandler(CheckChangeRadioButton);
            RadioButtonExpense.CheckedChanged += new EventHandler(CheckChangeRadioButton);
            DataGridViewStatistic.CellClick += new DataGridViewCellEventHandler(ClickDataGridViewCell);
        }

        //init control
        private void InitControlSet()
        {
            RadioButtonIncome.Checked = true;
            InitStatisticDataGridView();
            InitDetailDataGridView();
            TextBoxIncome.ReadOnly = true;
            TextBoxExpense.ReadOnly = true;
            TextBoxBalance.ReadOnly = true;
            InitTextBoxValue(_recordModel.GetRecords());
        }

        //show 
        private void InitTextBoxValue(List<Record> records)
        {
            TextBoxIncome.Text = _statisticModel.GetIncome(records).ToString();
            TextBoxExpense.Text = _statisticModel.GetExpense(records).ToString();
            TextBoxBalance.Text = _statisticModel.GetBalance(records).ToString();
        }

        //init statistic datagridview
        private void InitStatisticDataGridView()
        {
            DataGridViewStatistic.AutoGenerateColumns = true;
            DataGridViewStatistic.ReadOnly = true;
        }

        //init detail datagridview
        private void InitDetailDataGridView()
        {
            DataGridViewDetail.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = "Date";
            dateColumn.HeaderText = "Date";
            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.DataPropertyName = "Amount";
            amountColumn.HeaderText = "Amount";
            DataGridViewDetail.Columns.Add(dateColumn);
            DataGridViewDetail.Columns.Add(amountColumn);
            DataGridViewDetail.DataSource = _recordsOfCategory;
            DataGridViewDetail.ReadOnly = true;
        }

        //radio button checked change
        private void CheckChangeRadioButton(object sender, EventArgs e)
        {
            _statistics = _statisticModel.GetStatisticDataGridViewDataSource(RadioButtonIncome.Checked);
            DataGridViewStatistic.DataSource = _statistics;
        }

        //click datagridView's cell
        private void ClickDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Category category = (Category)DataGridViewStatistic.Rows[e.RowIndex].Cells[0].Value;
                _recordsOfCategory = _recordModel.GetRecords(category, RadioButtonIncome.Checked);
                DataGridViewDetail.DataSource = _recordsOfCategory;
            }
        }

        //refresh view
        public void Refresh()
        {
            CheckChangeRadioButton(this, new EventArgs());
            InitTextBoxValue(_recordModel.GetRecords());
        }
    }
}
