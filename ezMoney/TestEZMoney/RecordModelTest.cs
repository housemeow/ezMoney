using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;

namespace TestEZMoney
{
    /// <summary>
    ///這是 RecordModelTest 的測試類別，應該包含
    ///所有 RecordModelTest 單元測試
    ///</summary>
    [TestClass()]
    public class RecordModelTest
    {
        private TestContext testContextInstance;
        const string CATEGORY_NAME_MOVIE = "Movie";
        const string CATEGORY_NAME_WORK = "Work";
        const string CATEGORY_NAME_ENTERTAINMENT = "Entertainment";

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

        #region 其他測試屬性
        //在執行每一項測試之後，使用 TestCleanup 執行程式碼
        [TestCleanup()]
        public void MyTestCleanup()
        {
            File.Delete(RecordModel.RECORD_FILE_NAME);
        }
        #endregion

        /// <summary>
        ///AddRecord 的測試
        ///</summary>
        [TestMethod()]
        public void TestAddRecord()
        {
            CategoryModel categoryModel = new CategoryModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel);
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Record recordMoviePositive = new Record(date, categoryMovie, 100);
            Record recordMovieNegative = new Record(date, categoryMovie, -100);
            Record recordWorkPositive = new Record(date, categoryWork, 100);
            Record recordWorkNegative = new Record(date, categoryWork, -100);
            recordModel.AddRecord(recordMoviePositive);
            Assert.AreEqual(1, recordModel.GetRecords().Count);
            recordModel.AddRecord(recordMovieNegative);
            Assert.AreEqual(2, recordModel.GetRecords().Count);
            recordModel.AddRecord(recordWorkPositive);
            Assert.AreEqual(3, recordModel.GetRecords().Count);
            recordModel.AddRecord(recordWorkNegative);
            Assert.AreEqual(4, recordModel.GetRecords().Count);
        }

        /// <summary>
        ///GetNegativeRecords 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetNegativeRecords()
        {
            CategoryModel categoryModel = new CategoryModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel);
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
            BindingList<Record> negativeRecords = recordModel.GetNegativeRecords(recordModel.GetRecords());
            Assert.AreEqual(2, negativeRecords.Count);
        }

        /// <summary>
        ///GetPositiveRecords 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetPositiveRecords()
        {
            CategoryModel categoryModel = new CategoryModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel);
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
            BindingList<Record> positiveRecords = recordModel.GetPositiveRecords(recordModel.GetRecords());
            Assert.AreEqual(2, positiveRecords.Count);
        }

        /// <summary>
        ///GetRecords 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetRecordsFromCategoryAndPositive()
        {
            CategoryModel categoryModel = new CategoryModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel);
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
            BindingList<Record> positiveRecords;
            positiveRecords = recordModel.GetRecords(categoryMovie, true);
            Assert.AreEqual(1, positiveRecords.Count);
            positiveRecords = recordModel.GetRecords(categoryWork, true);
            Assert.AreEqual(1, positiveRecords.Count);
            BindingList<Record> negativeRecords;
            negativeRecords = recordModel.GetRecords(categoryMovie, true);
            Assert.AreEqual(1, negativeRecords.Count);
            negativeRecords = recordModel.GetRecords(categoryWork, true);
            Assert.AreEqual(1, negativeRecords.Count);
        }

        /// <summary>
        ///GetRecords 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetRecords()
        {
            CategoryModel categoryModel = new CategoryModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel);
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
            BindingList<Record> records = recordModel.GetRecords();
            Assert.AreEqual(records, recordModel.GetRecords());
        }

        /// <summary>
        ///GetRecords 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetRecordsByCategory()
        {
            CategoryModel categoryModel = new CategoryModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel);
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Record recordMoviePositive = new Record(date, categoryMovie, 100);
            Record recordMovieNegative = new Record(date, categoryMovie, -100);
            Record recordWorkPositive = new Record(date, categoryWork, 100);
            Record recordWorkNegative = new Record(date, categoryWork, -100);
            recordModel.AddRecord(recordMoviePositive);
            recordModel.AddRecord(recordMovieNegative);
            recordModel.AddRecord(recordMovieNegative);
            recordModel.AddRecord(recordWorkPositive);
            recordModel.AddRecord(recordWorkPositive);
            recordModel.AddRecord(recordWorkPositive);
            recordModel.AddRecord(recordWorkNegative);
            recordModel.AddRecord(recordWorkNegative);
            recordModel.AddRecord(recordWorkNegative);
            recordModel.AddRecord(recordWorkNegative);
            BindingList<Record> movieRecords;
            movieRecords = recordModel.GetRecords(categoryMovie);
            Assert.AreEqual(3, movieRecords.Count);
            BindingList<Record> workRecords;
            workRecords = recordModel.GetRecords(categoryWork);
            Assert.AreEqual(7, workRecords.Count);
        }

        /// <summary>
        ///GetRecords 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetRecordsWithCategoryAndPositive()
        {
            CategoryModel categoryModel = new CategoryModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel);
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Record recordMoviePositive = new Record(date, categoryMovie, 100);
            Record recordMovieNegative = new Record(date, categoryMovie, -100);
            Record recordWorkPositive = new Record(date, categoryWork, 100);
            Record recordWorkNegative = new Record(date, categoryWork, -100);
            recordModel.AddRecord(recordMoviePositive);
            recordModel.AddRecord(recordMovieNegative);
            recordModel.AddRecord(recordMovieNegative);
            recordModel.AddRecord(recordWorkPositive);
            recordModel.AddRecord(recordWorkPositive);
            recordModel.AddRecord(recordWorkPositive);
            recordModel.AddRecord(recordWorkNegative);
            recordModel.AddRecord(recordWorkNegative);
            recordModel.AddRecord(recordWorkNegative);
            recordModel.AddRecord(recordWorkNegative);
            BindingList<Record> positiveMovieRecords;
            positiveMovieRecords = recordModel.GetRecords(categoryMovie, true);
            Assert.AreEqual(1, positiveMovieRecords.Count);
            BindingList<Record> negativeMovieRecords;
            negativeMovieRecords = recordModel.GetRecords(categoryMovie, false);
            Assert.AreEqual(2, negativeMovieRecords.Count);
            BindingList<Record> positiveWorkRecords;
            positiveWorkRecords = recordModel.GetRecords(categoryWork, true);
            Assert.AreEqual(3, positiveWorkRecords.Count);
            BindingList<Record> negativeWorkRecords;
            negativeWorkRecords = recordModel.GetRecords(categoryWork, false);
            Assert.AreEqual(4, negativeWorkRecords.Count);
        }

        /// <summary>
        ///ReadRecordFromFile 的測試
        ///</summary>
        [TestMethod()]
        public void TestReadRecordFromFile()
        {
            CategoryModel categoryModel = new CategoryModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel);
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
            BindingList<Record> records = recordModel.GetRecords();
            recordModel.WriteRecordToFile();
            recordModel = new RecordModel(categoryModel);
            recordModel.ReadRecordFromFile();
            Assert.AreEqual(records.Count, recordModel.GetRecords().Count);
        }

        /// <summary>
        ///WriteRecordToFile 的測試
        ///</summary>
        [TestMethod()]
        public void TestWriteRecordToFile()
        {
            CategoryModel categoryModel = new CategoryModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel);
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
            BindingList<Record> records = recordModel.GetRecords();
            recordModel.WriteRecordToFile();
            recordModel = new RecordModel(categoryModel);
            recordModel.ReadRecordFromFile();
            Assert.AreEqual(records.Count, recordModel.GetRecords().Count);
        }
    }
}
