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
        ///GetExpenseStatistics 的測試
        ///</summary>
        [TestMethod()]
        public void GetExpenseStatisticsTest()
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
        public void GetExpenseTest()
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
        public void GetBalanceTest()
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
        public void GetAmountsTest()
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
        public void SetPercentTest()
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
        public void GetStatisticDataGridViewDataSourceTest()
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
        public void GetStatisticTest()
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
        public void GetIncomeStatisticsTest()
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
        public void GetIncomeTest()
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
