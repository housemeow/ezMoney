using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ezMoney
{
    class RecordModel
    {
        //list changed event handler
        public delegate void RecordListLoadedEventHandler(List<Record> list, EventArgs args);
        public delegate void RecordListChangedEventHandler(List<Record> list, EventArgs args);
        //record list change event handler
        public event RecordListChangedEventHandler _recordListChangeEvent;
        //records loaded event handler
        public event RecordListLoadedEventHandler _recordListLoadedEvent;

        private const String DATE_FORMAT = "yyyy/M/d";
        private const String RECORD_FILE_NAME = "record.txt";
        private const string EMPTY_LINE = "";
        private List<Record> _records;
        private CategoryModel _categoryModel;

        //constructor
        public RecordModel(CategoryModel categoryModel)
        {
            _categoryModel = categoryModel;
            _records = new List<Record>();
            ReadRecordFromFile();
        }

        public List<Record> GetRecords()
        {
            return _records;
        }

        //add record to RecordList
        public void AddRecord(Record record)
        {
            _records.Add(record);
            ChangeRecordList();
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

        //change record list
        public void ChangeRecordList()
        {
            if (_recordListChangeEvent != null)
            {
                _recordListChangeEvent(_records, new EventArgs());
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

        //write record to record.txt
        public void WriteRecordToFile()
        {
            StreamWriter streamWriter = new StreamWriter(RECORD_FILE_NAME);
            foreach (Record record in _records)
            {
                streamWriter.Write(record.Date.ToString(DATE_FORMAT + " "));
                streamWriter.Write(_categoryModel.GetCategoryIndex(record.Category) + " ");
                streamWriter.WriteLine(record.Amount.ToString());
            }
            streamWriter.Close();
        }

        //read record from record.txt
        public void ReadRecordFromFile()
        {
            if (File.Exists(RECORD_FILE_NAME))
            {
                StreamReader streamReader = new StreamReader(RECORD_FILE_NAME);
                while (!streamReader.EndOfStream)
                {
                    String recordString = streamReader.ReadLine();
                    if (recordString != EMPTY_LINE)
                    {
                        const String ZH_TW = "zh-TW";
                        String[] strings = recordString.Split(new char[] { ' ' });
                        IFormatProvider culture = new System.Globalization.CultureInfo(ZH_TW, true);
                        DateTime date = DateTime.ParseExact(strings[0], DATE_FORMAT, culture);
                        Category category = _categoryModel.GetCategories()[Convert.ToInt32(strings[1])];
                        int amount = Convert.ToInt32(strings[2]);
                        Record record = new Record(date, category, amount);
                        _records.Add(record);
                    }
                }
                streamReader.Close();
                RecordListLoaded();
            }
        }
    }
}
