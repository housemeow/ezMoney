using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ezMoney
{
    //list changed event handler
    public delegate void CategoryListChangedEventHandler(List<String> list, EventArgs args);
    public delegate void RecordListChangedEventHandler(List<Record> list, EventArgs args);
    class EZMoneyModel
    {
        //category list change event handler
        public event CategoryListChangedEventHandler CategoryListChangedEvent;
        //record list change event handler
        public event RecordListChangedEventHandler RecordListChangeEvent;

        private List<String> _categories;
        private List<Record> _records;
        public EZMoneyModel()
        {
            _categories = new List<String>();
            _records = new List<Record>();
        }
        public void AddCategory(String categoryName)
        {
            _categories.Add(categoryName);
            //trigger event
            ChangeCategoryList();
        }
        public Boolean IsExist(String categoryName)
        {
            return _categories.Contains(categoryName);
        }
        public List<String> GetCategories()
        {
            return _categories;
        }
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
            if (CategoryListChangedEvent != null)
            {
                CategoryListChangedEvent(_categories, new EventArgs());
            }
        }

        //change record list
        public void ChangeRecordList()
        {
            if (RecordListChangeEvent != null)
            {
                RecordListChangeEvent(_records, new EventArgs());
            }
        }
    }
}
