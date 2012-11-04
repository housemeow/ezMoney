using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ezMoney
{
    public class Record: IEquatable<Record>
    {
        DateTime _date;
        Category _category;
        int _amount;

        //record constructor
        public Record(DateTime date, Category category, int amount)
        {
            DateTime newDateTime = new DateTime(date.Year, date.Month, date.Day);
            _date = newDateTime;
            _category = category;
            _amount = amount;
        }

        //iEqualable interface equals
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        //Record equals
        public bool Equals(Record record)
        { 
            if(ReferenceEquals(record, null))
            {
                return false;   
            }
            return Date==record.Date && Category ==record.Category && Amount == record.Amount;
        }

        //get hash code
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }    

        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        public Category Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        public int Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
    }
}
