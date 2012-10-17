using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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
            _recordModel = new RecordModel(_categoryModel);
            _statisticModel = new StatisticModel(_categoryModel, _recordModel);
        }

        public CategoryModel GetCategoryModel()
        {
            return _categoryModel;
        }

        public RecordModel GetRecordModel()
        {
            return _recordModel;
        }

        public StatisticModel GetStatisticModel()
        {
            return _statisticModel;
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

        public List<Category> GetCategories()
        {
            return _categoryModel.GetCategories();
        }

        //add record to RecordList
        public void AddRecord(Record record)
        {
            _recordModel.AddRecord(record);
        }

        public List<Record> GetRecords()
        {
            return _recordModel.GetRecords();
        }

        //get records of category
        public List<Record> GetRecords(Category category)
        {
            return _recordModel.GetRecords(category);
        }

        //write file to category
        public void WriteCategoryToFile()
        {
            _categoryModel.WriteCategoryToFile();
        }

        //write record to record.txt
        public void WriteRecordToFile()
        {
            _recordModel.WriteRecordToFile();
        }
    }
}
