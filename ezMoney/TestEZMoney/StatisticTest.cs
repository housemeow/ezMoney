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

        /// <summary>
        ///Amounts 的測試
        ///</summary>
        [TestMethod()]
        public void TestAmounts()
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
        public void TestCategory()
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
        public void TestCount()
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
        public void TestPercent()
        {
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE); // TODO: 初始化為適當值
            Statistic statistic = new Statistic(movieCategory); // TODO: 初始化為適當值
            Assert.AreEqual("0%", statistic.Percent);
            statistic.Percent = "100%";
            Assert.AreEqual("100%", statistic.Percent);
        }
    }
}