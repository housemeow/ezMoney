using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestEZMoney
{


    /// <summary>
    ///這是 StatisticModelTest 的測試類別，應該包含
    ///所有 StatisticModelTest 單元測試
    ///</summary>
    [TestClass()]
    public class StatisticModelTest
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
        ///GetExpenseStatistics 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetExpenseStatistics()
        {
            CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel); // TODO: 初始化為適當值
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Record movieRecord = new Record(date, categoryMovie, 1000);
            recordModel.AddRecord(movieRecord);
            movieRecord = new Record(date, categoryMovie, 1000);
            recordModel.AddRecord(movieRecord);
            movieRecord = new Record(date, categoryMovie, -1000);
            recordModel.AddRecord(movieRecord);
            Record workRecord = new Record(date, categoryWork, 1000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 2000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 3000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 4000);
            recordModel.AddRecord(workRecord);
            StatisticModel statisticModel = new StatisticModel(categoryModel, recordModel); // TODO: 初始化為適當值
            List<Statistic> statistics;
            statistics = statisticModel.GetExpenseStatistics();
            Assert.AreEqual(1, statistics.Count);
        }

        /// <summary>
        ///GetExpense 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetExpense()
        {
            CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel); // TODO: 初始化為適當值
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Record movieRecord = new Record(date, categoryMovie, -1000);
            recordModel.AddRecord(movieRecord);
            movieRecord = new Record(date, categoryMovie, -2000);
            recordModel.AddRecord(movieRecord);
            movieRecord = new Record(date, categoryMovie, -3000);
            recordModel.AddRecord(movieRecord);
            Record workRecord = new Record(date, categoryWork, 1000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 2000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 3000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 4000);
            recordModel.AddRecord(workRecord);
            StatisticModel statisticModel = new StatisticModel(categoryModel, recordModel); // TODO: 初始化為適當值
            int expense = statisticModel.GetExpense(recordModel.GetRecords());
            Assert.AreEqual(6000, expense);
        }

        /// <summary>
        ///GetBalance 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetBalance()
        {
            CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel); // TODO: 初始化為適當值
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Record movieRecord = new Record(date, categoryMovie, -1000);
            recordModel.AddRecord(movieRecord);
            movieRecord = new Record(date, categoryMovie, -2000);
            recordModel.AddRecord(movieRecord);
            movieRecord = new Record(date, categoryMovie, -3000);
            recordModel.AddRecord(movieRecord);
            Record workRecord = new Record(date, categoryWork, 1000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 2000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 3000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 4000);
            recordModel.AddRecord(workRecord);
            StatisticModel statisticModel = new StatisticModel(categoryModel, recordModel); // TODO: 初始化為適當值
            int balance = statisticModel.GetBalance(recordModel.GetRecords());
            Assert.AreEqual(4000, balance);
        }

        /// <summary>
        ///GetAmounts 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetAmounts()
        {
            CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel); // TODO: 初始化為適當值
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Record movieRecord = new Record(date, categoryMovie, -1000);
            recordModel.AddRecord(movieRecord);
            movieRecord = new Record(date, categoryMovie, -2000);
            recordModel.AddRecord(movieRecord);
            movieRecord = new Record(date, categoryMovie, -3000);
            recordModel.AddRecord(movieRecord);
            Record workRecord = new Record(date, categoryWork, 1000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 2000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 3000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 4000);
            recordModel.AddRecord(workRecord);
            StatisticModel statisticModel = new StatisticModel(categoryModel, recordModel); // TODO: 初始化為適當值
            int income = statisticModel.GetAmounts(recordModel.GetRecords(), true);
            Assert.AreEqual(10000, income);
            int expense = statisticModel.GetAmounts(recordModel.GetRecords(), false);
            Assert.AreEqual(-6000, expense);
        }

        /// <summary>
        ///SetPercent 的測試
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ezMoney.exe")]
        public void TestSetPercent()
        {
            CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryEntertainment = new Category(CATEGORY_NAME_ENTERTAINMENT);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryEntertainment);
            RecordModel recordModel = new RecordModel(categoryModel); // TODO: 初始化為適當值
            StatisticModel statisticModel = new StatisticModel(categoryModel, recordModel); // TODO: 初始化為適當值
            List<Statistic> statistics = new List<Statistic>(); // TODO: 初始化為適當值
            Statistic statisticMovie = new Statistic(categoryMovie);
            Statistic statisticEntertainment = new Statistic(categoryEntertainment);
            statisticMovie.Amounts = 1000;
            statistics.Add(statisticMovie);
            statisticEntertainment.Amounts = 3000;
            statistics.Add(statisticEntertainment);
            int amounts = 4000; // TODO: 初始化為適當值
            statisticModel.SetPercent(statistics, amounts);
            Assert.AreEqual("25%", statisticMovie.Percent);
            Assert.AreEqual("75%", statisticEntertainment.Percent);
        }

        /// <summary>
        ///GetStatisticDataGridViewDataSource 的測試
        ///</summary>
        [TestMethod()]
        public void TestStatisticDataGridViewDataSource()
        {
            CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel); // TODO: 初始化為適當值
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Record movieRecord = new Record(date, categoryMovie, -1000);
            recordModel.AddRecord(movieRecord);
            movieRecord = new Record(date, categoryMovie, -2000);
            recordModel.AddRecord(movieRecord);
            movieRecord = new Record(date, categoryMovie, -3000);
            recordModel.AddRecord(movieRecord);
            Record workRecord = new Record(date, categoryWork, 1000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 2000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 3000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 4000);
            recordModel.AddRecord(workRecord);
            StatisticModel statisticModel = new StatisticModel(categoryModel, recordModel); // TODO: 初始化為適當值
            List<Statistic> incomeStatistics = statisticModel.GetStatisticDataGridViewDataSource(true);
            List<Statistic> expenseStatistics = statisticModel.GetStatisticDataGridViewDataSource(false);
            Assert.AreEqual(1, incomeStatistics.Count);
            int incomeAmount = 0;
            foreach (Statistic statistic in incomeStatistics)
            {
                incomeAmount += statistic.Amounts;
            }
            Assert.AreEqual(10000, incomeAmount);
            int expenseAmount = 0;
            foreach (Statistic statistic in expenseStatistics)
            {
                expenseAmount += statistic.Amounts;
            }
            Assert.AreEqual(-6000, expenseAmount);
        }

        /// <summary>
        ///GetStatistic 的測試
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ezMoney.exe")]
        public void TestStatistic()
        {
            CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel); // TODO: 初始化為適當值
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Record workRecord = new Record(date, categoryWork, 1000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 2000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 3000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 4000);
            recordModel.AddRecord(workRecord);
            StatisticModel statisticModel = new StatisticModel(categoryModel, recordModel); // TODO: 初始化為適當值
            Statistic statistic = statisticModel.GetStatistic(categoryWork, true);
            Assert.AreEqual(10000, statistic.Amounts);
            Assert.AreEqual(categoryWork, statistic.Category);
            Assert.AreEqual(4, statistic.Count);
        }

        /// <summary>
        ///GetIncomeStatistics 的測試
        ///</summary>
        [TestMethod()]
        public void TestIncomeStatistics()
        {
            CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel); // TODO: 初始化為適當值
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Record movieRecord = new Record(date, categoryMovie, -1000);
            recordModel.AddRecord(movieRecord);
            movieRecord = new Record(date, categoryMovie, -2000);
            recordModel.AddRecord(movieRecord);
            movieRecord = new Record(date, categoryMovie, -3000);
            recordModel.AddRecord(movieRecord);
            Record workRecord = new Record(date, categoryWork, 1000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 2000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 3000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 4000);
            recordModel.AddRecord(workRecord);
            StatisticModel statisticModel = new StatisticModel(categoryModel, recordModel); // TODO: 初始化為適當值
            List<Statistic> statistics = statisticModel.GetIncomeStatistics();
            Assert.AreEqual(1, statistics.Count);
            int amount=0;
            foreach (Statistic statistic in statistics)
            {
                amount += statistic.Amounts;
            }
            Assert.AreEqual(10000, amount);
        }

        /// <summary>
        ///GetIncome 的測試
        ///</summary>
        [TestMethod()]
        public void TestIncome()
        {
            CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            RecordModel recordModel = new RecordModel(categoryModel); // TODO: 初始化為適當值
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(now.Year, now.Month, now.Day);
            Record movieRecord = new Record(date, categoryMovie, -1000);
            recordModel.AddRecord(movieRecord);
            movieRecord = new Record(date, categoryMovie, -2000);
            recordModel.AddRecord(movieRecord);
            movieRecord = new Record(date, categoryMovie, -3000);
            recordModel.AddRecord(movieRecord);
            Record workRecord = new Record(date, categoryWork, 1000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 2000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 3000);
            recordModel.AddRecord(workRecord);
            workRecord = new Record(date, categoryWork, 4000);
            recordModel.AddRecord(workRecord);
            StatisticModel statisticModel = new StatisticModel(categoryModel, recordModel); // TODO: 初始化為適當值
            int income = statisticModel.GetAmounts(recordModel.GetRecords(), true);
            Assert.AreEqual(10000, income);
        }
    }
}