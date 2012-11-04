using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;

namespace TestEZMoney
{
    
    
    /// <summary>
    ///這是 StatisticPresentationModelPropertyTest 的測試類別，應該包含
    ///所有 StatisticPresentationModelPropertyTest 單元測試
    ///</summary>
    [TestClass()]
    public class StatisticPresentationModelPropertyTest
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
        ///Balance 的測試
        ///</summary>
        [TestMethod()]
        public void TestBalance()
        {
            StatisticPresentationModelProperty statisticPModelProperty = new StatisticPresentationModelProperty(); // TODO: 初始化為適當值
            statisticPModelProperty.Balance = COMPARE_STRING;
            Assert.AreEqual(COMPARE_STRING, statisticPModelProperty.Balance);
        }

        /// <summary>
        ///Expense 的測試
        ///</summary>
        [TestMethod()]
        public void TestExpense()
        {
            StatisticPresentationModelProperty statisticPModelProperty = new StatisticPresentationModelProperty(); // TODO: 初始化為適當值
            statisticPModelProperty.Expense = COMPARE_STRING;
            Assert.AreEqual(COMPARE_STRING, statisticPModelProperty.Expense);
        }

        /// <summary>
        ///Income 的測試
        ///</summary>
        [TestMethod()]
        public void TestIncome()
        {
            StatisticPresentationModelProperty statisticPModelProperty = new StatisticPresentationModelProperty(); // TODO: 初始化為適當值
            statisticPModelProperty.Income = COMPARE_STRING;
            Assert.AreEqual(COMPARE_STRING, statisticPModelProperty.Income);
        }

        /// <summary>
        ///IsExpenseCheck 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsExpenseCheck()
        {
            StatisticPresentationModelProperty statisticPModelProperty = new StatisticPresentationModelProperty(); // TODO: 初始化為適當值
            statisticPModelProperty.IsExpenseCheck = true;
            Assert.AreEqual(true, statisticPModelProperty.IsExpenseCheck);
        }

        /// <summary>
        ///IsIncomeCheck 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsIncomeCheck()
        {
            StatisticPresentationModelProperty statisticPModelProperty = new StatisticPresentationModelProperty(); // TODO: 初始化為適當值
            statisticPModelProperty.IsIncomeCheck = true;
            Assert.AreEqual(true, statisticPModelProperty.IsIncomeCheck);
        }

        /// <summary>
        ///RecordList 的測試
        ///</summary>
        [TestMethod()]
        public void TestRecordList()
        {
            StatisticPresentationModelProperty statisticPModelProperty = new StatisticPresentationModelProperty(); // TODO: 初始化為適當值
            BindingList<Record> recordList = new BindingList<Record>();
            statisticPModelProperty.RecordList = recordList;
            Assert.AreEqual(recordList, statisticPModelProperty.RecordList);
        }

        /// <summary>
        ///StatisticList 的測試
        ///</summary>
        [TestMethod()]
        public void TestStatisticList()
        {
            StatisticPresentationModelProperty statisticPModelProperty = new StatisticPresentationModelProperty(); // TODO: 初始化為適當值
            BindingList<Statistic> statisticList = new BindingList<Statistic>();
            statisticPModelProperty.StatisticList = statisticList;
            Assert.AreEqual(statisticList, statisticPModelProperty.StatisticList);
        }
    }
}
