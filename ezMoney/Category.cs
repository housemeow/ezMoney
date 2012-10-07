using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ezMoney
{
    public class Category
    {
        String _categoryName;

        public String CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }
        //category constructor
        public Category(String categoryName)
        {
            _categoryName = categoryName;
        }

        public String GetCategoryName()
        {
            return _categoryName;
        }
    }
}
