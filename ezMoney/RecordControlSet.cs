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
            int year, month, day;
            year = DateTimePickerRecord.Value.Year;
            month = DateTimePickerRecord.Value.Month;
            day = DateTimePickerRecord.Value.Day;
            DateTime dateTime = new DateTime(year, month, day);
            int money = GetMoney();
            String categoryName = ComboBoxCategory.SelectedValue.ToString();
            Record record = new Record(dateTime, new Category(categoryName), money);
            return record;
        }

        //set button enable and errorprovider
        public void SetButtonAndErrorProviderState()
        {
            String amountString = TextBoxRecordAmount.Text;
            int amount;
            bool isNum = int.TryParse(amountString, out amount);
            if (amountString == "")
            {
                ErrorProvider.SetError(ButtonRecordAdd, "must have number.");
                ButtonRecordAdd.Enabled = false;
            }
            else if (ComboBoxCategory.SelectedIndex == -1)
            {
                ErrorProvider.SetError(ButtonRecordAdd, "must select a category.");
                ButtonRecordAdd.Enabled = false;
            }
            else if (!isNum)
            {
                ErrorProvider.SetError(ButtonRecordAdd, "text is not a number.");
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
