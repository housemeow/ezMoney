using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ezMoney
{
    //list changed event handler
    public delegate void ListChangedEventHandler(List<String> list, EventArgs args);
    class EZMoneyModel
    {
        public event ListChangedEventHandler ListChangedEvent;

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
            ChangeList();
        }
        public Boolean IsExist(String categoryName)
        {
            return _categories.Contains(categoryName);
        }
        public List<String> GetCategories()
        {
            return _categories;
        }
        public List<Record> GetRecords()
        {
            return _records;
        }

        //change list trigger
        public void ChangeList()
        {
            if (ListChangedEvent != null)
            {
                ListChangedEvent(_categories, new EventArgs());
            }
        }
    }
}
