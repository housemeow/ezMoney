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

        public RecordView(RecordControlSet recordControlSet, EZMoneyModel ezMoneyModel)
        {
            _ezMoneyModel = ezMoneyModel;
            _recordControlSet = recordControlSet;
        }

        public void BindControlSetEvent()
        { 
            
        }
    }
}
