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
        public delegate void CategoryListLoadedEventHandler(List<Category> list, EventArgs args);
        public delegate void RecordListLoadedEventHandler(List<Record> list, EventArgs args);
        public delegate void CategoryListChangedEventHandler(List<Category> list, EventArgs args);
        public delegate void RecordListChangedEventHandler(List<Record> list, EventArgs args);
        //category list change event handler
        public event CategoryListChangedEventHandler _categoryListChangedEvent;
        //categories loaded event handler
        public event CategoryListLoadedEventHandler _categoryListLoadedEvent;
        //record list change event handler
        public event RecordListChangedEventHandler _recordListChangeEvent;
        //records loaded event handler
        public event RecordListLoadedEventHandler _recordListLoadedEvent;


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
            StreamWriter streamWriter = new StreamWriter(fileName);
            foreach (Category category in _categories)
            {
                streamWriter.WriteLine(category.CategoryName);
            }
            streamWriter.Close();
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
            CategoryListLoaded();
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

        //category is in categoies
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

        //read record from record.txt
        public void ReadRecordFromFile(String fileName)
        { 
            StreamReader streamReader = new StreamReader(fileName);
            while(!streamReader.EndOfStream)
            {
                String recordString = streamReader.ReadLine();
                if(recordString!=EMPTY_LINE)
                {
                    String[] strings = recordString.Split(new char[] { ' ' });
                    IFormatProvider culture = new System.Globalization.CultureInfo("zh-TW", true);
                    DateTime date = DateTime.ParseExact(strings[0], "yyyy/M/d", culture);
                    Category category = _categories[Convert.ToInt32(strings[1])];
                    int amount = Convert.ToInt32(strings[2]);
                    Record record = new Record(date, category, amount);
                    _records.Add(record);
                }
            }
            streamReader.Close();
            RecordListLoaded();
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

        //categories loaded
        private void CategoryListLoaded()
        {
            if (_categoryListLoadedEvent != null)
            {
                _categoryListLoadedEvent(_categories, new EventArgs());
            }
        }

        //records loaded
        private void RecordListLoaded()
        {
            if (_recordListLoadedEvent != null)
            {
                _recordListLoadedEvent(_records, new EventArgs());
            }
        }

        //get records of category
        public List<Record> GetRecords(Category category)
        {
            List<Record> records = new List<Record>();
            foreach (Record record in _records)
            {
                if (record.Category.Equals(category))
                {
                    records.Add(record);
                }
            }
            return records;
        }

        public List<Record> GetNegativeRecords(List<Record> records)
        {
            List<Record> negativeRecords = new List<Record>();
            foreach (Record record in records)
            {
                if (record.Amount < 0)
                {
                    negativeRecords.Add(record);
                }
            }
            return negativeRecords;
        }

        public List<Record> GetPositiveRecords(List<Record> records)
        {
            List<Record> positiveRecords = new List<Record>();
            foreach (Record record in records)
            {
                if (record.Amount >= 0)
                {
                    positiveRecords.Add(record);
                }
            }
            return positiveRecords;
        }
    }
}
