using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestEZMoney
{    
    /// <summary>
    ///這是 RecordPresentationModelPropertyTest 的測試類別，應該包含
    ///所有 RecordPresentationModelPropertyTest 單元測試
    ///</summary>
    [TestClass()]
    public class RecordPresentationModelPropertyTest
    {
        private TestContext testContextInstance;
        const string COMPARE_STRING = "abc";

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
        ///ErrorProviderMessage 的測試
        ///</summary>
        [TestMethod()]
        public void TestErrorProviderMessage()
        {
            RecordPresentationModelProperty recordPModelProperty = new RecordPresentationModelProperty(); // TODO: 初始化為適當值
            recordPModelProperty.ErrorProviderMessage = COMPARE_STRING;
            Assert.AreEqual(COMPARE_STRING, recordPModelProperty.ErrorProviderMessage);
        }

        /// <summary>
        ///IsCancelEnable 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsCancelEnable()
        {
            RecordPresentationModelProperty recordPModelProperty = new RecordPresentationModelProperty(); // TODO: 初始化為適當值
            recordPModelProperty.IsCancelEnable = true;
            Assert.AreEqual(true, recordPModelProperty.IsCancelEnable);
        }

        /// <summary>
        ///Amount 的測試
        ///</summary>
        [TestMethod()]
        public void TestAmount()
        {
            RecordPresentationModelProperty recordPModelProperty = new RecordPresentationModelProperty(); // TODO: 初始化為適當值
            recordPModelProperty.Amount = COMPARE_STRING;
            Assert.AreEqual(COMPARE_STRING, recordPModelProperty.Amount);
        }

        /// <summary>
        ///CategoryIndex 的測試
        ///</summary>
        [TestMethod()]
        public void TestCategoryIndex()
        {
            RecordPresentationModelProperty recordPModelProperty = new RecordPresentationModelProperty(); // TODO: 初始化為適當值
            recordPModelProperty.CategoryIndex = 1;
            Assert.AreEqual(1, recordPModelProperty.CategoryIndex);
        }

        /// <summary>
        ///IsAddEnable 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsAddEnable()
        {
            RecordPresentationModelProperty recordPModelProperty = new RecordPresentationModelProperty(); // TODO: 初始化為適當值
            recordPModelProperty.IsAddEnable = true;
            Assert.AreEqual(true, recordPModelProperty.IsAddEnable);
        }

        /// <summary>
        ///IsDeleteEnable 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsDeleteEnable()
        {
            RecordPresentationModelProperty recordPModelProperty = new RecordPresentationModelProperty(); // TODO: 初始化為適當值
            recordPModelProperty.IsDeleteEnable = true;
            Assert.AreEqual(true, recordPModelProperty.IsDeleteEnable);
        }

        /// <summary>
        ///IsExpenseCheck 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsExpenseCheck()
        {
            RecordPresentationModelProperty recordPModelProperty = new RecordPresentationModelProperty(); // TODO: 初始化為適當值
            recordPModelProperty.IsExpenseCheck = true;
            Assert.AreEqual(true, recordPModelProperty.IsExpenseCheck);
        }

        /// <summary>
        ///IsIncomeCheck 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsIncomeCheck()
        {
            RecordPresentationModelProperty recordPModelProperty = new RecordPresentationModelProperty(); // TODO: 初始化為適當值
            recordPModelProperty.IsIncomeCheck = true;
            Assert.AreEqual(true, recordPModelProperty.IsIncomeCheck);
        }

        /// <summary>
        ///IsModifyEnable 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsModifyEnable()
        {
            RecordPresentationModelProperty recordPModelProperty = new RecordPresentationModelProperty(); // TODO: 初始化為適當值
            recordPModelProperty.IsModifyEnable = true;
            Assert.AreEqual(true, recordPModelProperty.IsModifyEnable);
        }

        /// <summary>
        ///IsSelectionMode 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsSelectionMode()
        {
            RecordPresentationModelProperty recordPModelProperty = new RecordPresentationModelProperty(); // TODO: 初始化為適當值
            recordPModelProperty.IsSelectionMode = true;
            Assert.AreEqual(true, recordPModelProperty.IsSelectionMode);
        }

        /// <summary>
        ///RecordDate 的測試
        ///</summary>
        [TestMethod()]
        public void TestRecordDate()
        {
            RecordPresentationModelProperty recordPModelProperty = new RecordPresentationModelProperty(); // TODO: 初始化為適當值
            DateTime datetime = DateTime.Now;
            recordPModelProperty.RecordDate = datetime;
            Assert.AreEqual(datetime, recordPModelProperty.RecordDate);
        }

        /// <summary>
        ///RecordIndex 的測試
        ///</summary>
        [TestMethod()]
        public void TestRecordIndex()
        {
            RecordPresentationModelProperty recordPModelProperty = new RecordPresentationModelProperty(); // TODO: 初始化為適當值
            recordPModelProperty.RecordIndex = 1;
            Assert.AreEqual(1, recordPModelProperty.RecordIndex);
        }
    }
}
