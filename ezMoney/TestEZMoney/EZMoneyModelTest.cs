using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;

namespace TestEZMoney
{
    /// <summary>
    ///這是 EZMoneyModelTest 的測試類別，應該包含
    ///所有 EZMoneyModelTest 單元測試
    ///</summary>
    [TestClass()]
    public class EZMoneyModelTest
    {
        const string CATEGORY_NAME_MOVIE = "Movie";
        const string CATEGORY_NAME_WORK = "Work";
        const string CATEGORY_NAME_ENTERTAINMENT = "Entertainment";

        #region 其他測試屬性
        //在執行每一項測試之後，使用 TestCleanup 執行程式碼
        [TestCleanup()]
        public void MyTestCleanup()
        {
            File.Delete(RecordModel.RECORD_FILE_NAME);
            File.Delete(CategoryModel.CATEGORY_FILE_NAME);
        }
        #endregion

        /// <summary>
        ///AddCategory 的測試
        ///</summary>
        [TestMethod()]
        public void TestAddCategory()
        {
            File.Delete(CategoryModel.CATEGORY_FILE_NAME);
            File.Delete(RecordModel.RECORD_FILE_NAME);
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE); // TODO: 初始化為適當值
            Assert.AreEqual(0, ezMoneyModel.GetCategories().Count);
            ezMoneyModel.AddCategory(movieCategory);
            Assert.AreEqual(1, ezMoneyModel.GetCategories().Count);
        }

        /// <summary>
        ///AddRecord 的測試
        ///</summary>
        [TestMethod()]
        public void TestAddRecord()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE);// TODO: 初始化為適當值
            Record record = new Record(date, movieCategory, 1000); // TODO: 初始化為適當值
            Assert.AreEqual(0, ezMoneyModel.GetRecords().Count);
            ezMoneyModel.AddRecord(record);
            Assert.AreEqual(1, ezMoneyModel.GetRecords().Count);
        }

        /// <summary>
        ///GetCategories 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetCategories()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE); ; // TODO: 初始化為適當值
            Assert.AreEqual(0, ezMoneyModel.GetCategories().Count);
            ezMoneyModel.AddCategory(movieCategory);
            Assert.AreEqual(1, ezMoneyModel.GetCategories().Count);
        }

        /// <summary>
        ///GetCategoryIndex 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetCategoryIndex()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE); // TODO: 初始化為適當值
            Category workCategory = new Category(CATEGORY_NAME_WORK); // TODO: 初始化為適當值
            ezMoneyModel.AddCategory(movieCategory);
            ezMoneyModel.AddCategory(workCategory);
            Assert.AreEqual(0, ezMoneyModel.GetCategoryIndex(movieCategory));
            Assert.AreEqual(1, ezMoneyModel.GetCategoryIndex(workCategory));
        }

        /// <summary>
        ///GetCategoryModel 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetCategoryModel()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE);// TODO: 初始化為適當值
            Category workCategory = new Category(CATEGORY_NAME_WORK); // TODO: 初始化為適當值
            CategoryModel categoryModel = ezMoneyModel.CategoryModel;
            categoryModel.AddCategory(movieCategory);
            categoryModel.AddCategory(workCategory);
            Assert.AreEqual(0, categoryModel.GetCategoryIndex(movieCategory));
            Assert.AreEqual(1, categoryModel.GetCategoryIndex(workCategory));
        }

        /// <summary>
        ///GetRecordModel 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetRecordModel()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            RecordModel recordModel = ezMoneyModel.RecordModel;
            Assert.AreEqual(recordModel, ezMoneyModel.RecordModel);
        }

        /// <summary>
        ///GetRecords 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetRecords()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            BindingList<Record> records = ezMoneyModel.GetRecords(); // TODO: 初始化為適當值
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE); // TODO: 初始化為適當值
            Record record = new Record(date, movieCategory, 1000); // TODO: 初始化為適當值
            Assert.AreEqual(0, records.Count);
            ezMoneyModel.AddRecord(record);
            Assert.AreEqual(1, records.Count);
            ezMoneyModel.AddRecord(record);
            Assert.AreEqual(2, records.Count);
            ezMoneyModel.AddRecord(record);
            Assert.AreEqual(3, records.Count);
        }

        /// <summary>
        ///GetRecords 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetRecordsFromCategory()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE);
            Category workCategory = new Category(CATEGORY_NAME_WORK);
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Record movieRecord1 = new Record(date, movieCategory, 1000); // TODO: 初始化為適當值
            Record movieRecord2 = new Record(date, movieCategory, 1000); // TODO: 初始化為適當值
            Record workRecord1 = new Record(date, workCategory, 1000); // TODO: 初始化為適當值
            Record workRecord2 = new Record(date, workCategory, 1000); // TODO: 初始化為適當值
            Record workRecord3 = new Record(date, workCategory, 1000); // TODO: 初始化為適當值
            ezMoneyModel.AddRecord(movieRecord1);
            ezMoneyModel.AddRecord(movieRecord2);
            ezMoneyModel.AddRecord(workRecord1);
            ezMoneyModel.AddRecord(workRecord2);
            ezMoneyModel.AddRecord(workRecord3);
            BindingList<Record> movieRecords = ezMoneyModel.GetRecords(movieCategory); // TODO: 初始化為適當值
            Assert.AreEqual(2, movieRecords.Count);
            BindingList<Record> workRecords = ezMoneyModel.GetRecords(workCategory); // TODO: 初始化為適當值
            Assert.AreEqual(3, workRecords.Count);
        }

        /// <summary>
        ///GetStatisticModel 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetStatisticModel()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            StatisticModel statisticModel = ezMoneyModel.StatisticModel;
            Assert.AreEqual(statisticModel, ezMoneyModel.StatisticModel);
        }

        /// <summary>
        ///WriteCategoryToFile 的測試
        ///</summary>
        [TestMethod()]
        public void TestWriteCategoryToFile()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel();
            //CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            Category categoryEntertainment = new Category(CATEGORY_NAME_ENTERTAINMENT);
            ezMoneyModel.AddCategory(categoryMovie);
            ezMoneyModel.AddCategory(categoryWork);
            ezMoneyModel.AddCategory(categoryEntertainment);
            ezMoneyModel.WriteCategoryToFile();
            ezMoneyModel = new EZMoneyModel();
            CategoryModel categoryModel = ezMoneyModel.CategoryModel;
            categoryModel.Categories.Clear();
            categoryModel.ReadCategoryFromFile();
            Assert.AreEqual(3, categoryModel.Categories.Count);
            Assert.AreEqual(categoryMovie, categoryModel.GetCategory(0));
            Assert.AreEqual(categoryWork, categoryModel.GetCategory(1));
            Assert.AreEqual(categoryEntertainment, categoryModel.GetCategory(2));
        }

        /// <summary>
        ///WriteRecordToFile 的測試
        ///</summary>
        [TestMethod()]
        public void TestWriteRecordToFile()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            ezMoneyModel.AddCategory(categoryMovie);
            ezMoneyModel.AddCategory(categoryWork);
            RecordModel recordModel = ezMoneyModel.RecordModel;
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Record recordMoviePositive = new Record(date, categoryMovie, 100);
            Record recordMovieNegative = new Record(date, categoryMovie, -100);
            Record recordWorkPositive = new Record(date, categoryWork, 100);
            Record recordWorkNegative = new Record(date, categoryWork, -100);
            recordModel.AddRecord(recordMoviePositive);
            recordModel.AddRecord(recordMovieNegative);
            recordModel.AddRecord(recordWorkPositive);
            recordModel.AddRecord(recordWorkNegative);
            BindingList<Record> records = recordModel.Records;
            ezMoneyModel.WriteRecordToFile();
            recordModel = new RecordModel(ezMoneyModel.CategoryModel);
            recordModel.ReadRecordFromFile();
            Assert.AreEqual(records.Count, recordModel.Records.Count);
        }
    }
}