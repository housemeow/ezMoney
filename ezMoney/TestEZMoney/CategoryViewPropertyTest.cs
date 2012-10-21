using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TestEZMoney
{
    
    
    /// <summary>
    ///這是 CategoryViewPropertyTest 的測試類別，應該包含
    ///所有 CategoryViewPropertyTest 單元測試
    ///</summary>
    [TestClass()]
    public class CategoryViewPropertyTest
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
        ///CategoryViewProperty 建構函式 的測試
        ///</summary>
        [TestMethod()]
        public void CategoryViewPropertyConstructorTest()
        {
            CategoryViewProperty target = new CategoryViewProperty();
            Assert.Inconclusive("TODO: 實作程式碼以驗證目標");
        }

        /// <summary>
        ///ButtonAdd 的測試
        ///</summary>
        [TestMethod()]
        public void ButtonAddTest()
        {
            CategoryViewProperty target = new CategoryViewProperty(); // TODO: 初始化為適當值
            Button expected = null; // TODO: 初始化為適當值
            Button actual;
            target.ButtonAdd = expected;
            actual = target.ButtonAdd;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("驗證這個測試方法的正確性。");
        }

        /// <summary>
        ///CurrencyManager 的測試
        ///</summary>
        [TestMethod()]
        public void CurrencyManagerTest()
        {
            CategoryViewProperty target = new CategoryViewProperty(); // TODO: 初始化為適當值
            CurrencyManager expected = null; // TODO: 初始化為適當值
            CurrencyManager actual;
            target.CurrencyManager = expected;
            actual = target.CurrencyManager;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("驗證這個測試方法的正確性。");
        }

        /// <summary>
        ///ErrorProvider 的測試
        ///</summary>
        [TestMethod()]
        public void ErrorProviderTest()
        {
            CategoryViewProperty target = new CategoryViewProperty(); // TODO: 初始化為適當值
            ErrorProvider expected = null; // TODO: 初始化為適當值
            ErrorProvider actual;
            target.ErrorProvider = expected;
            actual = target.ErrorProvider;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("驗證這個測試方法的正確性。");
        }

        /// <summary>
        ///ListBoxCategories 的測試
        ///</summary>
        [TestMethod()]
        public void ListBoxCategoriesTest()
        {
            CategoryViewProperty target = new CategoryViewProperty(); // TODO: 初始化為適當值
            ListBox expected = null; // TODO: 初始化為適當值
            ListBox actual;
            target.ListBoxCategories = expected;
            actual = target.ListBoxCategories;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("驗證這個測試方法的正確性。");
        }

        /// <summary>
        ///TextBoxCategoryName 的測試
        ///</summary>
        [TestMethod()]
        public void TextBoxCategoryNameTest()
        {
            CategoryViewProperty target = new CategoryViewProperty(); // TODO: 初始化為適當值
            TextBox expected = null; // TODO: 初始化為適當值
            TextBox actual;
            target.TextBoxCategoryName = expected;
            actual = target.TextBoxCategoryName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("驗證這個測試方法的正確性。");
        }
    }
}
