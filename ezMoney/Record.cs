using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ezMoney
{
    public class Record
    {
        DateTime _date;
        String _category;
        int _amount;

        //record constructor
        public Record(DateTime date, String category, int amount)
        {
            _date = date;
            _category = category;
            _amount = amount;
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public String Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
    }
}
