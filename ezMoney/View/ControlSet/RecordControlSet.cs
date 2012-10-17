using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class RecordControlSet : RecordControlProperty
    {
        //record control set constructor
        public RecordControlSet()
        {
        }

        //get money from moneytextbox
        public int GetMoney()
        {
            int money;
            if (RadioButtonIncome.Checked)
            {
                money = Convert.ToInt32(TextBoxRecordAmount.Text);
            }
            else
            {
                money = -Convert.ToInt32(TextBoxRecordAmount.Text);
            }
            return money;
        }

        //get record from datetimePicker, textBox, and combobox
        public Record GetRecord()
        {
            int year = DateTimePickerRecord.Value.Year;
            int month = DateTimePickerRecord.Value.Month;
            int day = DateTimePickerRecord.Value.Day;
            DateTime dateTime = new DateTime(year, month, day);
            int money = GetMoney();
            String categoryName = ComboBoxCategory.SelectedValue.ToString();
            Record record = new Record(dateTime, new Category(categoryName), money);
            return record;
        }

        //set button enable and errorprovider
        public void SetButtonAndErrorProviderState()
        {
            const String NO_NUMBER_INFO = "must have number.";
            const String NO_SELECT_CATEGORY_INFO = "must select a category.";
            const String TEXT_IS_NOT_NUMBER_INFO = "text is not a number.";
            const int NO_SELECT_COMBOX_ITEM = -1;
            String amountString = TextBoxRecordAmount.Text;
            int amount;
            bool isNum = int.TryParse(amountString, out amount);
            if (amountString == String.Empty)
            {
                ErrorProvider.SetError(ButtonRecordAdd, NO_NUMBER_INFO);
                ButtonRecordAdd.Enabled = false;
            }
            else if (ComboBoxCategory.SelectedIndex == NO_SELECT_COMBOX_ITEM)
            {
                ErrorProvider.SetError(ButtonRecordAdd, NO_SELECT_CATEGORY_INFO);
                ButtonRecordAdd.Enabled = false;
            }
            else if (!isNum)
            {
                ErrorProvider.SetError(ButtonRecordAdd, TEXT_IS_NOT_NUMBER_INFO);
                ButtonRecordAdd.Enabled = false;
            }
            else
            {
                ErrorProvider.Clear();
                ButtonRecordAdd.Enabled = true;
            }
        }
    }
}
