using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TestEZMoney
{
    /// <summary>
    ///這是 RecordPresentationModelTest 的測試類別，應該包含
    ///所有 RecordPresentationModelTest 單元測試
    ///</summary>
    [TestClass()]
    public class RecordPresentationModelTest
    {
        const String CATEGORY_NAME_MOVIE = "Movie";
        const String CATEGORY_NAME_WORK = "Work";

        /// <summary>
        ///Add 的測試
        ///</summary>
        [TestMethod()]
        public void TestAdd()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            RecordPresentationModel recordPModel = new RecordPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            RecordModel recordModel = ezMoneyModel.RecordModel;
            CategoryModel categoryModel = ezMoneyModel.CategoryModel;
            recordModel.Records.Clear();
            categoryModel.Categories.Clear();
            Category category = new Category(CATEGORY_NAME_MOVIE);
            categoryModel.AddCategory(category);
            DateTime date = DateTime.Now; // TODO: 初始化為適當值
            int categoryIndex = 0; // TODO: 初始化為適當值
            string amount = string.Empty; // TODO: 初始化為適當值
            Assert.AreEqual(0, recordModel.Records.Count);
            recordPModel.Add(date, categoryIndex, amount);
            Assert.AreEqual(1, recordModel.Records.Count);
            recordPModel.IsIncomeCheck = false;
            recordPModel.IsExpenseCheck = true;
            recordPModel.Add(date, categoryIndex, amount);
            Assert.AreEqual(2, recordModel.Records.Count);
        }

        /// <summary>
        ///Cancel 的測試
        ///</summary>
        [TestMethod()]
        public void TestCancel()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            RecordPresentationModel recordPModel = new RecordPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            RecordModel recordModel = ezMoneyModel.RecordModel;
            CategoryModel categoryModel = ezMoneyModel.CategoryModel;
            recordModel.Records.Clear();
            categoryModel.Categories.Clear();
            Category category = new Category(CATEGORY_NAME_MOVIE);
            categoryModel.AddCategory(category);
            DateTime date = DateTime.Now; // TODO: 初始化為適當值
            Record record = new Record(date, category, 100);
            recordModel.AddRecord(record);
            recordPModel.SelectRecord(0);
            Assert.AreEqual(true, recordPModel.IsSelectionMode);
            recordPModel.Cancel();
            Assert.AreEqual(false, recordPModel.IsSelectionMode);
        }

        /// <summary>
        ///ChangeAmount 的測試
        ///</summary>
        [TestMethod()]
        public void TestChangeAmount()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            RecordPresentationModel recordPModel = new RecordPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            RecordModel recordModel = ezMoneyModel.RecordModel;
            CategoryModel categoryModel = ezMoneyModel.CategoryModel;
            recordModel.Records.Clear();
            categoryModel.Categories.Clear();
            Category category = new Category(CATEGORY_NAME_MOVIE);
            categoryModel.AddCategory(category);
            DateTime date = DateTime.Now; // TODO: 初始化為適當值
            Record record = new Record(date, category, 100);
            recordModel.AddRecord(record);
            recordPModel.SelectRecord(0);
            const String AMOUNT_ORIGIN = "100";
            const string AMOUNT_AFTER = "200";
            Assert.AreEqual(AMOUNT_ORIGIN, recordPModel.Amount);
            recordPModel.ChangeAmount(AMOUNT_AFTER);
            Assert.AreEqual(AMOUNT_AFTER, recordPModel.Amount);
            recordPModel.IsSelectionMode = false;
            recordPModel.ChangeAmount(AMOUNT_AFTER);
            Assert.AreEqual(AMOUNT_AFTER, recordPModel.Amount);
        }

        /// <summary>
        ///ChangeIncomeCheck 的測試
        ///</summary>
        [TestMethod()]
        public void TestChangeIncomeCheck()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            RecordPresentationModel recordPModel = new RecordPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            RecordModel recordModel = ezMoneyModel.RecordModel;
            CategoryModel categoryModel = ezMoneyModel.CategoryModel;
            recordPModel.InitializeState();
            Assert.AreEqual(true, recordPModel.IsIncomeCheck);
            recordPModel.ChangeIncomeCheck(false);
            Assert.AreEqual(false, recordPModel.IsIncomeCheck);
        }

        /// <summary>
        ///Delete 的測試
        ///</summary>
        [TestMethod()]
        public void TestDelete()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            RecordPresentationModel recordPModel = new RecordPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            RecordModel recordModel = ezMoneyModel.RecordModel;
            CategoryModel categoryModel = ezMoneyModel.CategoryModel;
            recordModel.Records.Clear();
            categoryModel.Categories.Clear();
            Category category = new Category(CATEGORY_NAME_MOVIE);
            categoryModel.AddCategory(category);
            DateTime date = DateTime.Now; // TODO: 初始化為適當值
            int categoryIndex = 0; // TODO: 初始化為適當值
            string amount = string.Empty; // TODO: 初始化為適當值
            recordPModel.Add(date, categoryIndex, amount);
            Assert.AreEqual(1, recordModel.Records.Count);
            recordPModel.Delete(DialogResult.No);
            Assert.AreEqual(1, recordModel.Records.Count);
            recordPModel.Delete(DialogResult.Yes);
            Assert.AreEqual(0, recordModel.Records.Count);
        }

        /// <summary>
        ///InitializeState 的測試
        ///</summary>
        [TestMethod()]
        public void TestInitializeState()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            RecordPresentationModel recordPModel = new RecordPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            RecordModel recordModel = ezMoneyModel.RecordModel;
            CategoryModel categoryModel = ezMoneyModel.CategoryModel;
            recordPModel.InitializeState();
            Assert.AreEqual(false, recordPModel.IsSelectionMode);
            Assert.AreEqual(false, recordPModel.IsModifyEnable);
            Assert.AreEqual(false, recordPModel.IsDeleteEnable);
            Assert.AreEqual(false, recordPModel.IsCancelEnable);
        }

        /// <summary>
        ///IsValidRecordAdd 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsValidRecordAdd()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            RecordPresentationModel recordPModel = new RecordPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            RecordModel recordModel = ezMoneyModel.RecordModel;
            CategoryModel categoryModel = ezMoneyModel.CategoryModel;
            recordPModel.InitializeState();
            const string AMOUNT = "100";
            const string NOT_NUMBER = "A";
            string errorMessage = string.Empty;
            Category category = new Category(CATEGORY_NAME_MOVIE);
            categoryModel.AddCategory(category);
            Assert.IsFalse(recordPModel.IsValidRecordAdd(-1, AMOUNT, ref errorMessage));
            Assert.AreEqual(RecordPresentationModel.NO_SELECT_CATEGORY_INFO, errorMessage);
            Assert.IsTrue(recordPModel.IsValidRecordAdd(0, AMOUNT, ref errorMessage));
            Assert.AreEqual(RecordPresentationModel.EMPTY_ERROR_MESSAGE, errorMessage);
            Assert.IsFalse(recordPModel.IsValidRecordAdd(0, NOT_NUMBER, ref errorMessage));
            Assert.AreEqual(RecordPresentationModel.TEXT_IS_NOT_NUMBER_INFO, errorMessage);
        }

        /// <summary>
        ///Modify 的測試
        ///</summary>
        [TestMethod()]
        public void TestModify()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            RecordPresentationModel recordPModel = new RecordPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            RecordModel recordModel = ezMoneyModel.RecordModel;
            CategoryModel categoryModel = ezMoneyModel.CategoryModel;
            recordModel.Records.Clear();
            categoryModel.Categories.Clear();
            Category category = new Category(CATEGORY_NAME_MOVIE);
            categoryModel.AddCategory(category);
            DateTime date = DateTime.Now; // TODO: 初始化為適當值
            int categoryIndex = 0; // TODO: 初始化為適當值
            string amount = string.Empty; // TODO: 初始化為適當值
            const string NEW_AMOUNT = "100";
            recordPModel.Add(date, categoryIndex, amount);
            Assert.AreEqual(1, recordModel.Records.Count);
            recordPModel.Modify(date, 0, NEW_AMOUNT);
            Assert.AreEqual(1, recordModel.Records.Count);
            Assert.AreEqual(NEW_AMOUNT, recordModel.Records[0].Amount.ToString());
            recordPModel.IsIncomeCheck = false;
            recordPModel.IsExpenseCheck = true;
            recordPModel.Modify(date, 0, NEW_AMOUNT);
            Assert.AreEqual(1, recordModel.Records.Count);
            Assert.AreEqual("-" + NEW_AMOUNT, recordModel.Records[0].Amount.ToString());
        }

        /// <summary>
        ///SelectCategory 的測試
        ///</summary>
        [TestMethod()]
        public void TestSelectCategory()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            RecordPresentationModel recordPModel = new RecordPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            RecordModel recordModel = ezMoneyModel.RecordModel;
            CategoryModel categoryModel = ezMoneyModel.CategoryModel;
            recordPModel.InitializeState();
            categoryModel.AddCategory(CATEGORY_NAME_WORK);
            recordPModel.SelectCategory(0);
            Assert.AreEqual(0, recordPModel.CategoryIndex);
        }

        /// <summary>
        ///SelectRecord 的測試
        ///</summary>
        [TestMethod()]
        public void TestSelectRecord()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            RecordPresentationModel recordPModel = new RecordPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            RecordModel recordModel = ezMoneyModel.RecordModel;
            CategoryModel categoryModel = ezMoneyModel.CategoryModel;
            recordPModel.InitializeState();
            Category category = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(category);
            DateTime date = DateTime.Now;
            recordModel.AddRecord(date, ref category, 100);
            recordModel.AddRecord(date, ref category, -100);
            recordPModel.SelectRecord(0);
            Assert.AreEqual(0, recordPModel.RecordIndex);
            recordPModel.SelectRecord(1);
            Assert.AreEqual(1, recordPModel.RecordIndex);
            recordPModel.SelectRecord(-1);
            Assert.IsFalse(recordPModel.IsSelectionMode);
        }

        /// <summary>
        ///RaiseUpdateEvent 的測試
        ///</summary>
        [TestMethod()]
        public void TestRaiseUpdateEvent()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            ezMoneyModel.GetCategories().Clear();
            ezMoneyModel.GetRecords().Clear();
            RecordPresentationModel recordPModel = new RecordPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            int raiseCount = 0;
            recordPModel._updateEvent += delegate(RecordPresentationModel localRecordPModel)
            {
                raiseCount++;
            };
            DateTime date = DateTime.Now;
            Category category = new Category(CATEGORY_NAME_MOVIE);
            ezMoneyModel.AddCategory(category);
            const String FIFTY = "50";
            recordPModel.Add(date, 0, FIFTY);
            Assert.AreEqual(1, raiseCount);
            recordPModel.Cancel();
            Assert.AreEqual(2, raiseCount);
        }

        /// <summary>
        ///SetErrorProvider 的測試
        ///</summary>
        [TestMethod()]
        public void TestSetErrorProvider()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            ezMoneyModel.GetCategories().Clear();
            ezMoneyModel.GetRecords().Clear();
            RecordPresentationModel recordPModel = new RecordPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            Category category = new Category(CATEGORY_NAME_WORK);
            ezMoneyModel.AddCategory(category);
            recordPModel.InitializeState();
            const String FIFTY = "50";
            recordPModel.ChangeAmount(FIFTY);
            recordPModel.SetErrorProvider();
            Assert.AreEqual(RecordPresentationModel.NO_SELECT_CATEGORY_INFO, recordPModel.ErrorProviderMessage);
            recordPModel.SelectCategory(0);
            Assert.AreEqual(RecordPresentationModel.EMPTY_ERROR_MESSAGE, recordPModel.ErrorProviderMessage);
        }
    }
}
