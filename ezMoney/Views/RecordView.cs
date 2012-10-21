using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class RecordView : RecordViewProperty
    {
        CategoryModel _categoryModel;
        RecordModel _recordModel;
        InformationModel _informationModel;

        //constructor
        public RecordView(CategoryModel categoryModel, RecordModel recordModel, InformationModel informationModel)
        {
            _categoryModel = categoryModel;
            _recordModel = recordModel;
            _informationModel = informationModel;
        }

        //initialize controls and event
        public void Initialize()
        {
            BindControlSetEvent();
            SetButtonAndErrorProviderState(_informationModel);
        }

        //bind control event
        public void BindControlSetEvent()
        {
            TextBox textBoxRecordAmount = TextBoxRecordAmount;
            textBoxRecordAmount.KeyPress += new KeyPressEventHandler(PressRecordAmountTextBoxKey);
            textBoxRecordAmount.TextChanged += new EventHandler(ChangeRecordAmountTextBox);
            Button buttonRecord = ButtonRecordAdd;
            buttonRecord.Click += new EventHandler(ClickRecordButton);
            buttonRecord.Enabled = false;
        }

        //event of recordAmountTextBoxChanged
        public void ChangeRecordAmountTextBox(object sender, EventArgs args)
        {
            SetButtonAndErrorProviderState(_informationModel);
        }

        //record amount textbox key press event
        public void PressRecordAmountTextBoxKey(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Back)
            {//enable back key
                return;
            }
            else if ((Keys)e.KeyChar < Keys.D0 || (Keys)e.KeyChar > Keys.D9)
            {//cancel key message
                e.Handled = true;
            }
        }

        //record button click
        public void ClickRecordButton(object sender, EventArgs args)
        {
            Record record = new Record(DateTimePickerRecord.Value, new Category(ComboBoxCategory.Text), GetMoney());
            _recordModel.AddRecord(record);
            CurrencyManagerRecordList.Refresh();
            TextBoxRecordAmount.Text = "";
            SetButtonAndErrorProviderState(_informationModel);
        }

        //set button enable and errorprovider
        public void SetButtonAndErrorProviderState(InformationModel informationModel)
        {
            String errorMessage = String.Empty;
            bool buttonEnable = informationModel.IsValidRecordAdd(ComboBoxCategory.SelectedIndex, TextBoxRecordAmount.Text, ref errorMessage);
            ErrorProvider.SetError(ButtonRecordAdd, errorMessage);
            ButtonRecordAdd.Enabled = buttonEnable;
        }

        //get money from moneytextbox
        public int GetMoney()
        {
            int money = _informationModel.GetAmount(TextBoxRecordAmount.Text, RadioButtonIncome.Checked); ;
            return money;
        }
    }
}
