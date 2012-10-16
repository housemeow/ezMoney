using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ezMoney
{
    class Statistic
    {
        private Category _category;
        private int _amounts;
        private int _count;
        private String _percent;

        //constructor
        public Statistic(Category category)
        {
            _category = category;
            _amounts = 0;
            _count = 0;
            _percent = "0%";
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

        public int Amounts
        {
            get
            {
                return _amounts;
            }
            set
            {
                _amounts = value;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        public String Percent
        {
            get
            {
                return _percent;
            }
            set
            {
                _percent = value;
            }
        }
    }
}
