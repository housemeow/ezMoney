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
        TextBox _textBoxRecordAmount;
        Button _buttonRecordAdd;
        DataGridView _dataGridViewRecord;
        CurrencyManager _currencyManagerComboBox;
        CurrencyManager _currencyManagerDataGridView;
        ErrorProvider _errorProvider;

        //record control set constructor
        public RecordControlSet(DateTimePicker dateTimePickerRecord,
            RadioButton radioButtonIncome,
            RadioButton radioButtonExpanse,
            ComboBox comboBoxCategory,
            TextBox textBoxRecordMessage,
            Button buttonRecordAdd,
            DataGridView dataGridViewRecord,
            CurrencyManager currencyManagerComboBox,
            CurrencyManager currencyManagerDataGridView,
            ErrorProvider errorProvider)
        {
            _dateTimePickerRecord = dateTimePickerRecord;
            _radioButtonIncome = radioButtonIncome;
            _radioButtonExpanse = radioButtonExpanse;
            _comboBoxCategory = comboBoxCategory;
            _textBoxRecordAmount = textBoxRecordMessage;
            _buttonRecordAdd = buttonRecordAdd;
            _dataGridViewRecord = dataGridViewRecord;
            _currencyManagerComboBox = currencyManagerComboBox;
            _currencyManagerDataGridView = currencyManagerDataGridView;
            _errorProvider = errorProvider;
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
        public TextBox GetTextBoxRecordAmount()
        {
            return _textBoxRecordAmount;
        }
        public Button GetButtonRecordAdd()
        {
            return _buttonRecordAdd;
        }
        public DataGridView GetDataGridViewRecord()
        {
            return _dataGridViewRecord;
        }
        public CurrencyManager GetCurrencyManagerComboBox()
        {
            return _currencyManagerComboBox;
        }
        public CurrencyManager GetCurrencyManagerDataGridView()
        {
            return _currencyManagerDataGridView;
        }
        public ErrorProvider GetErrorProvider()
        {
            return _errorProvider;
        }

        //get money from moneytextbox
        public int GetMoney()
        {
            int money;
            if (_radioButtonIncome.Checked)
            {
                money = Convert.ToInt32(_textBoxRecordAmount.Text);
            }
            else
            {
                money = -Convert.ToInt32(_textBoxRecordAmount.Text);
            }
            return money;
        }

        //get record from datetimePicker, textBox, and combobox
        public Record GetRecord()
        {
            DateTime dateTime = _dateTimePickerRecord.Value;
            int money = GetMoney();
            String categoryName = _comboBoxCategory.SelectedValue.ToString();
            Record record = new Record(dateTime, new Category(categoryName), money);
            return record;
        }

        //set button enable and errorprovider
        public void SetButtonAndErrorProviderState()
        {
            String amountString = _textBoxRecordAmount.Text;
            int amount;
            bool isNum = int.TryParse(amountString, out amount);
            if (amountString == "")
            {
                _errorProvider.SetError(_buttonRecordAdd, "must have number.");
                _buttonRecordAdd.Enabled = false;
            }
            else if (_comboBoxCategory.SelectedIndex == -1)
            {
                _errorProvider.SetError(_buttonRecordAdd, "must select a category.");
                _buttonRecordAdd.Enabled = false;
            }
            else if (!isNum)
            {
                _errorProvider.SetError(_buttonRecordAdd, "text is not a number.");
                _buttonRecordAdd.Enabled = false;
            }else
            {
                _errorProvider.Clear();
                _buttonRecordAdd.Enabled = true;
            }
        }
    }
}
