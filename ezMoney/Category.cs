using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ezMoney
{
    public class Category : IEquatable<Category>
    {
        String _categoryName;

        //category constructor
        public Category(String categoryName)
        {
            _categoryName = categoryName;
        }

        public String CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }

        //show to control
        public override String ToString()
        {
            return _categoryName;
        }

        //overide IEquatable Interface
        public override bool Equals(object obj)
        {
            return Equals(obj as Category);
        }
        //overide IEquatable Interface
        public bool Equals(Category category)
        {
            if (ReferenceEquals(category, null))
            {
                return false;
            }
            return category._categoryName == _categoryName;
        }
        //overide IEquatable Interface
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
