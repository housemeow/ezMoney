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
        ///Record 建構函式 的測試
        ///</summary>
        [TestMethod()]
        public void RecordConstructorTest()
        {
            DateTime date = new DateTime(); // TODO: 初始化為適當值
            Category category = null; // TODO: 初始化為適當值
            int amount = 0; // TODO: 初始化為適當值
            Record target = new Record(date, category, amount);
            Assert.Inconclusive("TODO: 實作程式碼以驗證目標");
        }

        /// <summary>
        ///Amount 的測試
        ///</summary>
        [TestMethod()]
        public void AmountTest()
        {
            DateTime date = new DateTime(); // TODO: 初始化為適當值
            Category category = null; // TODO: 初始化為適當值
            int amount = 0; // TODO: 初始化為適當值
            Record target = new Record(date, category, amount); // TODO: 初始化為適當值
            int expected = 0; // TODO: 初始化為適當值
            int actual;
            target.Amount = expected;
            actual = target.Amount;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("驗證這個測試方法的正確性。");
        }

        /// <summary>
        ///Category 的測試
        ///</summary>
        [TestMethod()]
        public void CategoryTest()
        {
            DateTime date = new DateTime(); // TODO: 初始化為適當值
            Category category = null; // TODO: 初始化為適當值
            int amount = 0; // TODO: 初始化為適當值
            Record target = new Record(date, category, amount); // TODO: 初始化為適當值
            Category expected = null; // TODO: 初始化為適當值
            Category actual;
            target.Category = expected;
            actual = target.Category;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("驗證這個測試方法的正確性。");
        }

        /// <summary>
        ///Date 的測試
        ///</summary>
        [TestMethod()]
        public void DateTest()
        {
            DateTime date = new DateTime(); // TODO: 初始化為適當值
            Category category = null; // TODO: 初始化為適當值
            int amount = 0; // TODO: 初始化為適當值
            Record target = new Record(date, category, amount); // TODO: 初始化為適當值
            DateTime expected = new DateTime(); // TODO: 初始化為適當值
            DateTime actual;
            target.Date = expected;
            actual = target.Date;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("驗證這個測試方法的正確性。");
        }
    }
}
