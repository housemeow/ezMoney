using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestEZMoney
{
    /// <summary>
    ///這是 RecordTest 的測試類別，應該包含
    ///所有 RecordTest 單元測試
    ///</summary>
    [TestClass()]
    public class RecordTest
    {
        private TestContext testContextInstance;
        const string TEST_FILE_NAME = "category.txt";
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

        /// <summary>
        ///Amount 的測試
        ///</summary>
        [TestMethod()]
        public void TestAmount()
        {
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day); // TODO: 初始化為適當值
            Category category = new Category(CATEGORY_NAME_MOVIE); // TODO: 初始化為適當值
            int amount = 0; // TODO: 初始化為適當值
            Record record = new Record(date, category, amount); // TODO: 初始化為適當值
            Assert.AreEqual(0, record.Amount);
            record.Amount = 100;
            Assert.AreEqual(100, record.Amount);
            record.Amount = -100;
            Assert.AreEqual(-100, record.Amount);
        }

        /// <summary>
        ///Category 的測試
        ///</summary>
        [TestMethod()]
        public void TestCategory()
        {
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            int amount = 0; // TODO: 初始化為適當值
            Record record = new Record(date, categoryMovie, amount);
            Assert.AreEqual(categoryMovie, record.Category);
            Assert.AreNotEqual(categoryWork, record.Category);
            record.Category = categoryWork;
            Assert.AreEqual(categoryWork, record.Category);
            Assert.AreNotEqual(categoryMovie, record.Category);
        }

        /// <summary>
        ///Date 的測試
        ///</summary>
        [TestMethod()]
        public void TestDate()
        {
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            DateTime differentDate = date.AddYears(100);
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            int amount = 0; // TODO: 初始化為適當值
            Record record = new Record(date, categoryMovie, amount);
            Assert.AreEqual(date, record.Date);
            Assert.AreNotEqual(differentDate, record.Date);
            record.Date = differentDate;
            Assert.AreEqual(differentDate, record.Date);
            Assert.AreNotEqual(date, record.Date);
        }

        /// <summary>
        ///Equals 的測試
        ///</summary>
        [TestMethod()]
        public void TestEquals()
        {
            DateTime date = new DateTime(); // TODO: 初始化為適當值
            Category category = new Category(CATEGORY_NAME_WORK); // TODO: 初始化為適當值
            int amount = 0; // TODO: 初始化為適當值
            Record record = new Record(date, category, amount); // TODO: 初始化為適當值
            object obj = new Record(date, category, amount); // TODO: 初始化為適當值
            Assert.IsTrue(record.Equals(obj));
        }

        /// <summary>
        ///Equals 的測試
        ///</summary>
        [TestMethod()]
        public void TestEqualsByRecord()
        {
            DateTime date = DateTime.Now; // TODO: 初始化為適當值
            Category category = new Category(CATEGORY_NAME_WORK); // TODO: 初始化為適當值
            int amount = 0; // TODO: 初始化為適當值
            Record record1 = new Record(date, category, amount); // TODO: 初始化為適當值
            Record record2 = new Record(date, category, amount); // TODO: 初始化為適當值
            Record record3 = new Record(date, category, 2222); // TODO: 初始化為適當值
            Assert.IsTrue(record1.Equals(record2));
            Assert.IsTrue(record1.Equals(record1));
            Assert.IsFalse(record1.Equals(record3));
            Assert.IsFalse(record1.Equals(null));
        }

        /// <summary>
        ///GetHashCode 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetHashCode()
        {
            DateTime date = new DateTime(); // TODO: 初始化為適當值
            Category category = null; // TODO: 初始化為適當值
            int amount = 0; // TODO: 初始化為適當值
            Record record1 = new Record(date, category, amount); // TODO: 初始化為適當值
            Record record2 = new Record(date, category, amount); // TODO: 初始化為適當值
            Assert.AreNotEqual(record1.GetHashCode(), record2.GetHashCode());
        }
    }
}
