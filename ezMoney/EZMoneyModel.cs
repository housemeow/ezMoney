using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ezMoney
{
    class EZMoneyModel
    {
        //list changed event handler
        public delegate void CategoryListChangedEventHandler(List<Category> list, EventArgs args);
        public delegate void RecordListChangedEventHandler(List<Record> list, EventArgs args);
        //category list change event handler
        public event CategoryListChangedEventHandler _categoryListChangedEvent;
        //record list change event handler
        public event RecordListChangedEventHandler _recordListChangeEvent;

        private const string EMPTY_LINE = "";

        private List<Category> _categories;
        private List<Record> _records;

        //constructor
        public EZMoneyModel()
        {
            _categories = new List<Category>();
            _records = new List<Record>();
        }

        //write file to category
        public void WriteCategoryToFile(String fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            foreach (Category category in _categories)
            {
                sw.WriteLine(category.CategoryName);
            }
            sw.Close();
        }

        //read file from category.txt
        public void ReadCategoryFromFile(String fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);
            while (!streamReader.EndOfStream)
            {
                String categoryName = streamReader.ReadLine();
                if (!categoryName.Equals(EMPTY_LINE))
                {
                    Category category = new Category(categoryName);
                    _categories.Add(category);
                }
            }
            streamReader.Close();
        }
        //get category index from category name
        public int GetCategoryIndex(Category category)
        {
            int index = _categories.IndexOf(category);
            return index;
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

        //write record to record.txt
        public void WriteRecordToFile(String fileName)
        {
            StreamWriter streamWriter = new StreamWriter(fileName);
            foreach (Record record in _records)
            {
                streamWriter.Write(record.Date.ToString("yyyy/M/d "));
                streamWriter.Write(GetCategoryIndex(record.Category) + " ");
                streamWriter.WriteLine(record.Amount.ToString());
            }
            streamWriter.Close();
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
