using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ezMoney
{
    class RecordModel
    {
<<<<<<< HEAD:ezMoney/Models/RecordModel.cs
        private const String DATE_FORMAT = "yyyy/M/d";
        private const String RECORD_FILE_NAME = "record.txt";
        private const string EMPTY_LINE = "";
=======
        public const String DATE_FORMAT = "yyyy/M/d";
        public const String RECORD_FILE_NAME = "record.txt";
        public const string EMPTY_LINE = "";
>>>>>>> TestProject:ezMoney/Models/RecordModel.cs
        private List<Record> _records;
        private CategoryModel _categoryModel;

        //constructor
        public RecordModel(CategoryModel categoryModel)
        {
            _categoryModel = categoryModel;
            _records = new List<Record>();
        }

        public List<Record> GetRecords()
        {
            return _records;
        }

        //add record to RecordList
        public void AddRecord(Record record)
        {
            _records.Add(record);
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

        //get records of category with isPositive
        public List<Record> GetRecords(Category category, bool isPositive)
        {
            List<Record> records = GetRecords(category);
            records = GetRecords(records, isPositive);
            return records;
        }

        //get positive records
        public List<Record> GetPositiveRecords(List<Record> records)
        { 
            List<Record> positiveRecords = GetRecords(records, true);
            return positiveRecords;
        }

        //get negative records
        public List<Record> GetNegativeRecords(List<Record> records)
        {
            List<Record> negativeRecords = GetRecords(records, false);
            return negativeRecords;
        }

        //get records with isPositive argument
        public List<Record> GetRecords(List<Record> records, bool isPositive)
        {
            List<Record> newRecords = new List<Record>();
            foreach (Record record in records)
            { 
                if((isPositive && record.Amount>=0) || (!isPositive && record.Amount<0))
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
            }
        }
    }
}
