using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class RecordView
    {
        EZMoneyModel _ezMoneyModel;
        RecordControlSet _recordControlSet;

        //constructor
        public RecordView(RecordControlSet recordControlSet, EZMoneyModel ezMoneyModel)
        {
            _ezMoneyModel = ezMoneyModel;
            _recordControlSet = recordControlSet;
            BindControlSetEvent();
            _recordControlSet.SetButtonAndErrorProviderState();
        }

        //bind control event
        public void BindControlSetEvent()
        {
            TextBox textBoxRecordAmount = _recordControlSet.GetTextBoxRecordAmount();
            textBoxRecordAmount.KeyPress += new KeyPressEventHandler(RecordAmountTextBoxKeyPress);
            textBoxRecordAmount.TextChanged += new EventHandler(RecordAmountTextBoxChanged);
            Button buttonRecord = _recordControlSet.GetButtonRecordAdd();
            buttonRecord.Click += new EventHandler(RecordButtonClick);
            buttonRecord.Enabled = false;
            _ezMoneyModel._recordListChangeEvent += RecordListChanged;
            _ezMoneyModel._categoryListChangedEvent += CategoryListChanged;
        }

        //event of recordAmountTextBoxChanged
        public void RecordAmountTextBoxChanged(object sender, EventArgs args)
        {
            _recordControlSet.SetButtonAndErrorProviderState();
        }

        //record amount textbox key press event
        public void RecordAmountTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Back)
            {//enable back key
                return;
            }else if ((Keys)e.KeyChar < Keys.D0 || (Keys)e.KeyChar > Keys.D9)
            {//cancel key message
                e.Handled = true;
            }
        }
        
        //record button click
        public void RecordButtonClick(object sender, EventArgs args)
        {
            _ezMoneyModel.AddRecord(_recordControlSet.GetRecord());
        }

        //list changed
        public void CategoryListChanged(object sender, EventArgs args)
        {
            CurrencyManager currencyManager = _recordControlSet.GetCurrencyManagerComboBox();
            currencyManager.Refresh();
            _recordControlSet.SetButtonAndErrorProviderState();
        }

        //record list changed
        public void RecordListChanged(object sender, EventArgs args)
        {
            CurrencyManager currencyManager = _recordControlSet.GetCurrencyManagerDataGridView();
            currencyManager.Refresh();
            _recordControlSet.SetButtonAndErrorProviderState();
        }
    }
}
