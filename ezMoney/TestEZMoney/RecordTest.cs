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

        #region 其他測試屬性
        // 
        //您可以在撰寫測試時，使用下列的其他屬性:
        //
        //在執行類別中的第一項測試之前，先使用 ClassInitialize 執行程式碼
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //在執行類別中的所有測試之後，使用 ClassCleanup 執行程式碼
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //在執行每一項測試之前，先使用 TestInitialize 執行程式碼
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //在執行每一項測試之後，使用 TestCleanup 執行程式碼
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///Amount 的測試
        ///</summary>
        [TestMethod()]
        public void AmountTest()
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
        public void CategoryTest()
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
        public void DateTest()
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
    }
}
