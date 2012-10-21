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


        const string CATEGORY_NAME_MOVIE = "Movie";
        const string DISTINCT_CATEGORY_NAME = "movie";

        /// <summar>ya
        ///Equals 的測試
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
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
        public void GetHashCodeTest()
        {
            Category category1 = new Category(CATEGORY_NAME_MOVIE);
            Category category2 = new Category(CATEGORY_NAME_MOVIE);
            Assert.AreNotEqual(category1.GetHashCode(), category2.GetHashCode());
        }

        /// <summary>
        ///ToString 的測試
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            Category category = new Category(CATEGORY_NAME_MOVIE);
            Assert.AreEqual(CATEGORY_NAME_MOVIE, category.ToString());
        }

        /// <summary>
        ///CategoryName 的測試
        ///</summary>
        [TestMethod()]
        public void CategoryNameTest()
        {
            Category category = new Category(CATEGORY_NAME_MOVIE);
            Assert.AreEqual(CATEGORY_NAME_MOVIE, category.CategoryName);
            category.CategoryName = DISTINCT_CATEGORY_NAME;
            Assert.AreEqual(DISTINCT_CATEGORY_NAME, category.CategoryName);
        }
    }
}
