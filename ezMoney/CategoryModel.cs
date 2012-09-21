using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ezMoney
{
    class CategoryModel
    {
        private List<String> _categories;
        public CategoryModel() {
            _categories = new List<String>();
        }
        public void AddCategory(String categoryName) {
            _categories.Add(categoryName);
        }
        public Boolean IsExist(String categoryName) {
            return _categories.Contains(categoryName);
        }
        public List<String> GetCategories() {
            return _categories;
        }
    }
}
