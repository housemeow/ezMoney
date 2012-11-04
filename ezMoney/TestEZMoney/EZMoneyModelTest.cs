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
        private TestContext testContextInstance;

        /// <summary>
        ///取得或設定提供目前測試回合的相關資訊與功能
        ///的測試內容。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

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
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE); ; // TODO: 初始化為適當值
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
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE); ; // TODO: 初始化為適當值
            Category workCategory = new Category(CATEGORY_NAME_WORK); ; // TODO: 初始化為適當值
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
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE); ; // TODO: 初始化為適當值
            Category workCategory = new Category(CATEGORY_NAME_WORK); ; // TODO: 初始化為適當值
            CategoryModel categoryModel = ezMoneyModel.GetCategoryModel();
            categoryModel.AddCategory(movieCategory);
            categoryModel.AddCategory(workCategory);
            Assert.AreEqual(0, categoryModel.GetCategoryIndex(movieCategory));
            Assert.AreEqual(1, categoryModel.GetCategoryIndex(workCategory));
        }

        /// <summary>
        ///GetInformationModel 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetInformationModel()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            InformationModel informationModel = ezMoneyModel.GetInformationModel();
            Assert.AreEqual(informationModel, ezMoneyModel.GetInformationModel());
        }

        /// <summary>
        ///GetRecordModel 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetRecordModel()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            RecordModel recordModel = ezMoneyModel.GetRecordModel();
            Assert.AreEqual(recordModel, ezMoneyModel.GetRecordModel());
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
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE); ; // TODO: 初始化為適當值
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
            StatisticModel statisticModel = ezMoneyModel.GetStatisticModel();
            Assert.AreEqual(statisticModel, ezMoneyModel.GetStatisticModel());
        }
    }
}