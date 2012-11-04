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
        private InformationModel _informationModel;

        //constructor
        public EZMoneyModel()
        {
            _categoryModel = new CategoryModel();
            _categoryModel.ReadCategoryFromFile();
            _recordModel = new RecordModel(_categoryModel);
            _recordModel.ReadRecordFromFile();
            _statisticModel = new StatisticModel(_categoryModel, _recordModel);
            _informationModel = new InformationModel(_categoryModel);
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

        public InformationModel GetInformationModel()
        {
            return _informationModel;
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

        public BindingList<Category> GetCategories()
        {
            return _categoryModel.GetCategories();
        }

        //add record to RecordList
        public void AddRecord(Record record)
        {
            _recordModel.AddRecord(record);
        }

        public BindingList<Record> GetRecords()
        {
            return _recordModel.GetRecords();
        }

        //get records of category
        public BindingList<Record> GetRecords(Category category)
        {
            return _recordModel.GetRecords(category);
        }
    }
}
