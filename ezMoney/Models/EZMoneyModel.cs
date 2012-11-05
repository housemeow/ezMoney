using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace ezMoney
{
    class EZMoneyModel
    {
        private CategoryModel _categoryModel;
        private RecordModel _recordModel;
        private StatisticModel _statisticModel;

        //constructor
        public EZMoneyModel()
        {
            _categoryModel = new CategoryModel();
            _categoryModel.ReadCategoryFromFile();
            _recordModel = new RecordModel(_categoryModel);
            _recordModel.ReadRecordFromFile();
            _statisticModel = new StatisticModel(_categoryModel, _recordModel);
        }

        internal CategoryModel CategoryModel
        {
            get
            {
                return _categoryModel;
            }
        }

        internal RecordModel RecordModel
        {
            get
            {
                return _recordModel;
            }
        }

        internal StatisticModel StatisticModel
        {
            get
            {
                return _statisticModel;
            }
        }

        //get categories from category model
        public BindingList<Category> GetCategories()
        {
            return _categoryModel.Categories;
        }

        //get records from record model
        public BindingList<Record> GetRecords()
        {
            return _recordModel.Records;
        }

        //get category index from category name
        public int GetCategoryIndex(Category category)
        {
            return _categoryModel.GetCategoryIndex(category);
        }

        //add category to categoryList
        public void AddCategory(Category categoryName)
        {
            _categoryModel.AddCategory(categoryName);
        }

        //add record to RecordList
        public void AddRecord(Record record)
        {
            _recordModel.AddRecord(record);
        }

        //get records of category
        public BindingList<Record> GetRecords(Category category)
        {
            return _recordModel.GetRecords(category);
        }
    }
}
