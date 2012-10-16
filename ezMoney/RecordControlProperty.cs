using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ezMoney
{
    class RecordControlProperty
    {
        DateTimePicker _dateTimePickerRecord;
        RadioButton _radioButtonIncome;
        RadioButton _radioButtonExpanse;
        ComboBox _comboBoxCategory;
        TextBox _textBoxRecordAmount;
        Button _buttonRecordAdd;
        DataGridView _dataGridViewRecord;
        CurrencyManager _currencyManagerComboBox;
        CurrencyManager _currencyManagerDataGridView;
        ErrorProvider _errorProvider;

        public DateTimePicker DateTimePickerRecord
        {
            get { return _dateTimePickerRecord; }
            set { _dateTimePickerRecord = value; }
        }

        public RadioButton RadioButtonIncome
        {
            get { return _radioButtonIncome; }
            set { _radioButtonIncome = value; }
        }

        public RadioButton RadioButtonExpanse
        {
            get { return _radioButtonExpanse; }
            set { _radioButtonExpanse = value; }
        }

        public ComboBox ComboBoxCategory
        {
            get { return _comboBoxCategory; }
            set { _comboBoxCategory = value; }
        }

        public TextBox TextBoxRecordAmount
        {
            get { return _textBoxRecordAmount; }
            set { _textBoxRecordAmount = value; }
        }

        public Button ButtonRecordAdd
        {
            get { return _buttonRecordAdd; }
            set { _buttonRecordAdd = value; }
        }

        public DataGridView DataGridViewRecord
        {
            get { return _dataGridViewRecord; }
            set { _dataGridViewRecord = value; }
        }

        public CurrencyManager CurrencyManagerComboBox
        {
            get { return _currencyManagerComboBox; }
            set { _currencyManagerComboBox = value; }
        }

        public CurrencyManager CurrencyManagerDataGridView
        {
            get { return _currencyManagerDataGridView; }
            set { _currencyManagerDataGridView = value; }
        }

        public ErrorProvider ErrorProvider
        {
            get { return _errorProvider; }
            set { _errorProvider = value; }
        }
    }
}
