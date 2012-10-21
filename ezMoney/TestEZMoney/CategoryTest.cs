using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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


        /// <summary>
        ///Category 建構函式 的測試
        ///</summary>
        [TestMethod()]
        public void CategoryConstructorTest()
        {
            string categoryName = string.Empty; // TODO: 初始化為適當值
            Category target = new Category(categoryName);
            Assert.Inconclusive("TODO: 實作程式碼以驗證目標");
        }

        /// <summary>
        ///Equals 的測試
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            string categoryName = string.Empty; // TODO: 初始化為適當值
            Category target = new Category(categoryName); // TODO: 初始化為適當值
            Category category = null; // TODO: 初始化為適當值
            bool expected = false; // TODO: 初始化為適當值
            bool actual;
            actual = target.Equals(category);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("驗證這個測試方法的正確性。");
        }

        /// <summary>
        ///Equals 的測試
        ///</summary>
        [TestMethod()]
        public void EqualsTest1()
        {
            string categoryName = string.Empty; // TODO: 初始化為適當值
            Category target = new Category(categoryName); // TODO: 初始化為適當值
            object obj = null; // TODO: 初始化為適當值
            bool expected = false; // TODO: 初始化為適當值
            bool actual;
            actual = target.Equals(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("驗證這個測試方法的正確性。");
        }

        /// <summary>
        ///GetHashCode 的測試
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest()
        {
            string categoryName = string.Empty; // TODO: 初始化為適當值
            Category target = new Category(categoryName); // TODO: 初始化為適當值
            int expected = 0; // TODO: 初始化為適當值
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("驗證這個測試方法的正確性。");
        }

        /// <summary>
        ///ToString 的測試
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            string categoryName = string.Empty; // TODO: 初始化為適當值
            Category target = new Category(categoryName); // TODO: 初始化為適當值
            string expected = string.Empty; // TODO: 初始化為適當值
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("驗證這個測試方法的正確性。");
        }

        /// <summary>
        ///CategoryName 的測試
        ///</summary>
        [TestMethod()]
        public void CategoryNameTest()
        {
            string categoryName = string.Empty; // TODO: 初始化為適當值
            Category target = new Category(categoryName); // TODO: 初始化為適當值
            string expected = string.Empty; // TODO: 初始化為適當值
            string actual;
            target.CategoryName = expected;
            actual = target.CategoryName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("驗證這個測試方法的正確性。");
        }
    }
}
