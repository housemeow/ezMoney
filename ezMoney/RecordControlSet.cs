using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class RecordControlSet
    {
        DateTimePicker _dateTimePickerRecord;
        RadioButton _radioButtonIncome;
        RadioButton _radioButtonExpanse;
        ComboBox _comboBoxCategory;
        TextBox  _textBoxRecordMessage;
        Button _buttonRecordAdd;
        DataGridView _dataGridViewRecord;
        CurrencyManager _currencyManagerComboBox;
        CurrencyManager _currencyManagerDataGridView;

        //record control set constructor
        public RecordControlSet(DateTimePicker dateTimePickerRecord,
            RadioButton radioButtonIncome,
            RadioButton radioButtonExpanse,
            ComboBox comboBoxCategory,
            TextBox textBoxRecordMessage,
            Button buttonRecordAdd,
            DataGridView dataGridViewRecord,
            CurrencyManager currencyManagerComboBox,
            CurrencyManager currencyManagerDataGridView)
        {
            _dateTimePickerRecord = dateTimePickerRecord;
            _radioButtonIncome = radioButtonIncome;
            _radioButtonExpanse = radioButtonExpanse;
            _comboBoxCategory = comboBoxCategory;
            _textBoxRecordMessage = textBoxRecordMessage;
            _buttonRecordAdd = buttonRecordAdd;
            _dataGridViewRecord = dataGridViewRecord;
            _currencyManagerComboBox = currencyManagerComboBox;
            _currencyManagerDataGridView = currencyManagerDataGridView;
        }

        public DateTimePicker GetDateTimePickerRecord()
        {
            return _dateTimePickerRecord;
        }
        public RadioButton GetRadioButtonIncome()
        {
            return _radioButtonIncome;
        }
        public RadioButton GetRadioButtonExpanse()
        {
            return _radioButtonExpanse;
        }
        public ComboBox GetComboBoxCategory()
        {
            return _comboBoxCategory;
        }
        public TextBox GetTextBoxRecordMessage()
        {
            return _textBoxRecordMessage;
        }
        public CurrencyManager GetCurrencyManagerComboBox()
        {
            return _currencyManagerComboBox;
        }
        public CurrencyManager GetCurrencyManagerDataGridView()
        {
            return _currencyManagerDataGridView;
        }
    }
}
