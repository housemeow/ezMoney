using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestEZMoney
{
    /// <summary>
    ///這是 CategoryTest 的測試類別，應該包含
    ///所有 CategoryTest 單元測試
    ///</summary>
    [TestClass()]
    public class CategoryTest
    {
        private TestContext testContextInstance;
        const string CATEGORY_NAME_MOVIE = "Movie";
        const string DISTINCT_CATEGORY_NAME = "movie";

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

        /// <summar>ya
        ///Equals 的測試
        ///</summary>
        [TestMethod()]
        public void TestEquals()
        {
            Category category1, category2;
            category1 = new Category(CATEGORY_NAME_MOVIE);
            category2 = new Category(CATEGORY_NAME_MOVIE);
            Assert.AreEqual<Category>(category1, category2);
            Assert.AreNotEqual(new Category(DISTINCT_CATEGORY_NAME), category1);
            Assert.AreEqual<Category>(category1, category2);
            Assert.IsFalse(category1.Equals(null));
        }

        /// <summary>
        ///GetHashCode 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetHashCode()
        {
            Category category1 = new Category(CATEGORY_NAME_MOVIE);
            Category category2 = new Category(CATEGORY_NAME_MOVIE);
            Assert.AreNotEqual(category1.GetHashCode(), category2.GetHashCode());
        }

        /// <summary>
        ///ToString 的測試
        ///</summary>
        [TestMethod()]
        public void TestToString()
        {
            Category category = new Category(CATEGORY_NAME_MOVIE);
            Assert.AreEqual(CATEGORY_NAME_MOVIE, category.ToString());
        }

        /// <summary>
        ///CategoryName 的測試
        ///</summary>
        [TestMethod()]
        public void TestCategoryName()
        {
            Category category = new Category(CATEGORY_NAME_MOVIE);
            Assert.AreEqual(CATEGORY_NAME_MOVIE, category.CategoryName);
            category.CategoryName = DISTINCT_CATEGORY_NAME;
            Assert.AreEqual(DISTINCT_CATEGORY_NAME, category.CategoryName);
        }
    }
}
