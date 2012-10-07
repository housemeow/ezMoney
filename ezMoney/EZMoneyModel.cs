using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ezMoney
{
    //list changed event handler
    public delegate void CategoryListChangedEventHandler(List<Category> list, EventArgs args);
    public delegate void RecordListChangedEventHandler(List<Record> list, EventArgs args);
    class EZMoneyModel
    {
        //category list change event handler
        public event CategoryListChangedEventHandler _categoryListChangedEvent;
        //record list change event handler
        public event RecordListChangedEventHandler _recordListChangeEvent;

        private List<Category> _categories;
        private List<Record> _records;
        //constructor
        public EZMoneyModel()
        {
            _categories = new List<Category>();
            _records = new List<Record>();
        }
        //add category to categoryList
        public void AddCategory(Category categoryName)
        {
            _categories.Add(categoryName);
            //trigger event
            ChangeCategoryList();
        }
        public Boolean IsExist(Category categoryName)
        {
            return _categories.Contains(categoryName);
        }
        public List<Category> GetCategories()
        {
            return _categories;
        }
        //add record to RecordList
        public void AddRecord(Record record)
        {
            _records.Add(record);
            ChangeRecordList();
        }

        public List<Record> GetRecords()
        {
            return _records;
        }

        //change category list trigger
        public void ChangeCategoryList()
        {
            if (_categoryListChangedEvent != null)
            {
                _categoryListChangedEvent(_categories, new EventArgs());
            }
        }

        //change record list
        public void ChangeRecordList()
        {
            if (_recordListChangeEvent != null)
            {
                _recordListChangeEvent(_records, new EventArgs());
            }
        }
    }
}
