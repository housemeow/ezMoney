using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace ezMoney
{
    class RecordModel
    {
        public const String DATE_FORMAT = "yyyy/M/d";
        public const String RECORD_FILE_NAME = "record.txt";
        public const string EMPTY_LINE = "";
        private BindingList<Record> _records;
        private CategoryModel _categoryModel;

        //constructor
        public RecordModel(CategoryModel categoryModel)
        {
            _categoryModel = categoryModel;
            _records = new BindingList<Record>();
        }

        public BindingList<Record> Records
        {
            get
            {
                return _records;
            }
        }

        //add record to RecordList
        public void AddRecord(Record record)
        {
            _records.Add(record);
        }

        //add record to RecordList by Category and Date and Amount
        public void AddRecord(DateTime datetime, ref Category category, int amount)
        {
            AddRecord(new Record(datetime, category, amount));
        }

        //get records of category
        public BindingList<Record> GetRecords(Category category)
        {
            BindingList<Record> records = new BindingList<Record>();
            foreach (Record record in _records)
            {
                if (record.Category.Equals(category))
                {
                    records.Add(record);
                }
            }
            return records;
        }

        //get records of category with isPositive
        public BindingList<Record> GetRecords(Category category, bool isPositive)
        {
            BindingList<Record> records = GetRecords(category);
            records = GetRecords(records, isPositive);
            return records;
        }

        //get positive records
        public BindingList<Record> GetPositiveRecords(BindingList<Record> records)
        {
            BindingList<Record> positiveRecords = GetRecords(records, true);
            return positiveRecords;
        }

        //get negative records
        public BindingList<Record> GetNegativeRecords(BindingList<Record> records)
        {
            BindingList<Record> negativeRecords = GetRecords(records, false);
            return negativeRecords;
        }

        //remove records contain same category
        public void RemoveRecordsByCategory(Category category)
        {
            for (int i = 0; i < _records.Count; i++)
            {
                if (_records[i].Category.Equals(category))
                {
                    _records.RemoveAt(i--);
                }
            }
        }

        //get records with isPositive argument
        public BindingList<Record> GetRecords(BindingList<Record> records, bool isPositive)
        {
            BindingList<Record> newRecords = new BindingList<Record>();
            foreach (Record record in records)
            {
                if ((isPositive && record.Amount >= 0) || (!isPositive && record.Amount < 0))
                {
                    newRecords.Add(record);
                }
            }
            return newRecords;
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
            if (!File.Exists(RECORD_FILE_NAME))
            {
                return;
            }
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
                    Category category = _categoryModel.Categories[Convert.ToInt32(strings[1])];
                    int amount = Convert.ToInt32(strings[2]);
                    Record record = new Record(date, category, amount);
                    _records.Add(record);
                }
            }
            streamReader.Close();
        }
    }
}
