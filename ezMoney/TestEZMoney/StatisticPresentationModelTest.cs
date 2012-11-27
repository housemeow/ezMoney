using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;

namespace TestEZMoney
{
    /// <summary>
    ///這是 StatisticPresentationModelTest 的測試類別，應該包含
    ///所有 StatisticPresentationModelTest 單元測試
    ///</summary>
    [TestClass()]
    public class StatisticPresentationModelTest
    {
        const String CATEGORY_NAME_MOVIE = "Movie";
        const String CATEGORY_NAME_WORK = "Work";

        /// <summary>
        ///ChangeRadioButton 的測試
        ///</summary>
        [TestMethod()]
        public void TestChangeRadioButton()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            StatisticPresentationModel statisticPModel = new StatisticPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            statisticPModel.InitializeState();
            Assert.IsTrue(statisticPModel.IsIncomeCheck);
            Assert.IsFalse(statisticPModel.IsExpenseCheck);
            bool isIncome = false; // TODO: 初始化為適當值
            statisticPModel.ChangeRadioButton(isIncome);
            Assert.IsFalse(statisticPModel.IsIncomeCheck);
            Assert.IsTrue(statisticPModel.IsExpenseCheck);
        }

        /// <summary>
        ///ClickDataGridView 的測試
        ///</summary>
        [TestMethod()]
        public void TestClickDataGridView()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            StatisticPresentationModel statisticPModel = new StatisticPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            CategoryModel categoryModel = ezMoneyModel.CategoryModel;
            RecordModel recordModel = ezMoneyModel.RecordModel;
            Category category1 = new Category(CATEGORY_NAME_WORK);
            Category category2 = new Category(CATEGORY_NAME_MOVIE);
            categoryModel.AddCategory(category1);
            categoryModel.AddCategory(category2);
            DateTime date = DateTime.Now;
            Record record1 = new Record(date, category1, 100);
            Record record2 = new Record(date, category1, 200);
            Record record3 = new Record(date, category1, 300);
            Record record4 = new Record(date, category1, 400);
            Record record5 = new Record(date, category2, -100);
            Record record6 = new Record(date, category2, -200);
            Record record7 = new Record(date, category2, -300);
            recordModel.AddRecord(record1);
            recordModel.AddRecord(record2);
            recordModel.AddRecord(record3);
            recordModel.AddRecord(record4);
            recordModel.AddRecord(record5);
            recordModel.AddRecord(record6);
            recordModel.AddRecord(record7);
            statisticPModel.InitializeState();
            BindingList<Record> records = statisticPModel.ClickDataGridView(category1);
            Assert.AreEqual(4, statisticPModel.RecordList.Count);
            Assert.AreEqual(records, statisticPModel.RecordList);
            statisticPModel.ChangeRadioButton(false);
            statisticPModel.ClickDataGridView(category2);
            Assert.AreEqual(3, statisticPModel.RecordList.Count);
        }

        /// <summary>
        ///EnterTabPageStatistic 的測試
        ///</summary>
        [TestMethod()]
        public void TestEnterTabPageStatistic()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            StatisticPresentationModel statisticPModel = new StatisticPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            statisticPModel.InitializeState();
            Assert.IsTrue(statisticPModel.IsIncomeCheck);
            Assert.IsFalse(statisticPModel.IsExpenseCheck);
            const string ZERO = "0";
            Assert.AreEqual(ZERO, statisticPModel.Income);
            Assert.AreEqual(ZERO, statisticPModel.Expense);
            Assert.AreEqual(ZERO, statisticPModel.Balance);
            statisticPModel.EnterTabPageStatistic();
            Assert.AreEqual(ZERO, statisticPModel.Income);
            Assert.AreEqual(ZERO, statisticPModel.Expense);
            Assert.AreEqual(ZERO, statisticPModel.Balance);
        }

        /// <summary>
        ///InitializeState 的測試
        ///</summary>
        [TestMethod()]
        public void TestInitializeState()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            StatisticPresentationModel statisticPModel = new StatisticPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            statisticPModel.InitializeState();
            Assert.IsTrue(statisticPModel.IsIncomeCheck);
            Assert.IsFalse(statisticPModel.IsExpenseCheck);
            const string ZERO = "0";
            Assert.AreEqual(ZERO, statisticPModel.Income);
            Assert.AreEqual(ZERO, statisticPModel.Expense);
            Assert.AreEqual(ZERO, statisticPModel.Balance);
        }
    }
}
