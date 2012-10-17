using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class RecordView
    {
        //EZMoneyModel _ezMoneyModel;
        CategoryModel _categoryModel;
        RecordModel _recordModel;
        RecordControlSet _recordControlSet;

        //constructor
        public RecordView(RecordControlSet recordControlSet, CategoryModel categoryModel, RecordModel recordModel)
        {
            _categoryModel = categoryModel;
            _recordModel = recordModel;
            _recordControlSet = recordControlSet;
            BindControlSetEvent();
            _recordControlSet.SetButtonAndErrorProviderState();
        }

        //bind control event
        public void BindControlSetEvent()
        {
            TextBox textBoxRecordAmount = _recordControlSet.TextBoxRecordAmount;
            textBoxRecordAmount.KeyPress += new KeyPressEventHandler(PressRecordAmountTextBoxKey);
            textBoxRecordAmount.TextChanged += new EventHandler(ChangeRecordAmountTextBox);
            Button buttonRecord = _recordControlSet.ButtonRecordAdd;
            buttonRecord.Click += new EventHandler(ClickRecordButton);
            buttonRecord.Enabled = false;
            _recordModel._recordListChangeEvent += ChangeRecordList;
            _categoryModel._categoryListChangedEvent += ChangeCategoryList;
        }

        //event of recordAmountTextBoxChanged
        public void ChangeRecordAmountTextBox(object sender, EventArgs args)
        {
            _recordControlSet.SetButtonAndErrorProviderState();
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
            _recordModel.AddRecord(_recordControlSet.GetRecord());
        }

        //list changed
        public void ChangeCategoryList(object sender, EventArgs args)
        {
            CurrencyManager currencyManager = _recordControlSet.CurrencyManagerComboBox;
            currencyManager.Refresh();
            _recordControlSet.SetButtonAndErrorProviderState();
        }

        //record list changed
        public void ChangeRecordList(object sender, EventArgs args)
        {
            CurrencyManager currencyManager = _recordControlSet.CurrencyManagerDataGridView;
            currencyManager.Refresh();
            _recordControlSet.SetButtonAndErrorProviderState();
        }
    }
}
