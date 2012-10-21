using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestEZMoney
{
    
    
    /// <summary>
    ///這是 StatisticTest 的測試類別，應該包含
    ///所有 StatisticTest 單元測試
    ///</summary>
    [TestClass()]
    public class StatisticTest
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
        ///Amounts 的測試
        ///</summary>
        [TestMethod()]
        public void AmountsTest()
        {
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE); // TODO: 初始化為適當值
            Statistic statistic = new Statistic(movieCategory); // TODO: 初始化為適當值
            Assert.AreEqual(0, statistic.Amounts);
            statistic.Amounts = 1000;
            Assert.AreEqual(1000, statistic.Amounts);
            statistic.Amounts = -1000;
            Assert.AreEqual(-1000, statistic.Amounts);
        }

        /// <summary>
        ///Category 的測試
        ///</summary>
        [TestMethod()]
        public void CategoryTest()
        {
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE); // TODO: 初始化為適當值
            Category workCategory = new Category(CATEGORY_NAME_WORK); // TODO: 初始化為適當值
            Statistic statistic = new Statistic(movieCategory); // TODO: 初始化為適當值
            Assert.AreEqual(movieCategory, statistic.Category);
            statistic.Category = workCategory;
            Assert.AreEqual(workCategory, statistic.Category);
            Assert.AreNotEqual(movieCategory, statistic.Category);
        }

        /// <summary>
        ///Count 的測試
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE); // TODO: 初始化為適當值
            Statistic statistic = new Statistic(movieCategory); // TODO: 初始化為適當值
            Assert.AreEqual(0, statistic.Count);
            statistic.Count = 1;
            Assert.AreEqual(1, statistic.Count);
        }

        /// <summary>
        ///Percent 的測試
        ///</summary>
        [TestMethod()]
        public void PercentTest()
        {
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE); // TODO: 初始化為適當值
            Statistic statistic = new Statistic(movieCategory); // TODO: 初始化為適當值
            Assert.AreEqual("0%", statistic.Percent);
            statistic.Percent = "100%";
            Assert.AreEqual("100%", statistic.Percent);
        }
    }
}
