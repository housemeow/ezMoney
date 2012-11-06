using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TestEZMoney
{
    /// <summary>
    ///這是 CategoryPresentationModelTest 的測試類別，應該包含
    ///所有 CategoryPresentationModelTest 單元測試
    ///</summary>
    [TestClass()]
    public class CategoryPresentationModelTest
    {
        private TestContext testContextInstance;
        const String CATEGORY_NAME_MOVIE = "Movie";
        const String CATEGORY_NAME_WORK = "Work";

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
        ///Add 的測試
        ///</summary>
        [TestMethod()]
        public void TestAdd()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            ezMoneyModel.GetCategories().Clear();
            ezMoneyModel.GetRecords().Clear();
            CategoryPresentationModel categoryPModel = new CategoryPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            Assert.AreEqual(0, ezMoneyModel.GetCategories().Count);
            categoryPModel.Add(CATEGORY_NAME_WORK);
            Assert.AreEqual(1, ezMoneyModel.GetCategories().Count);
        }

        /// <summary>
        ///Cancel 的測試
        ///</summary>
        [TestMethod()]
        public void TestCancel()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            ezMoneyModel.GetCategories().Clear();
            ezMoneyModel.GetRecords().Clear();
            CategoryPresentationModel categoryPModel = new CategoryPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            categoryPModel.SelectCategory(0);
            Assert.IsTrue(categoryPModel.IsSelectionMode);
            categoryPModel.Cancel();
            Assert.IsFalse(categoryPModel.IsSelectionMode);
        }

        /// <summary>
        ///ChangeTextBox 的測試
        ///</summary>
        [TestMethod()]
        public void TestChangeTextBox()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            ezMoneyModel.GetCategories().Clear();
            ezMoneyModel.GetRecords().Clear();
            CategoryPresentationModel categoryPModel = new CategoryPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            categoryPModel.ChangeTextBox(CATEGORY_NAME_MOVIE);
            Assert.AreEqual(CATEGORY_NAME_MOVIE, categoryPModel.CategoryNameText);
            Category category = new Category(CATEGORY_NAME_MOVIE);
            ezMoneyModel.AddCategory(category);
            categoryPModel.SelectCategory(0);
            categoryPModel.ChangeTextBox(CATEGORY_NAME_MOVIE);
            Assert.AreEqual(false, categoryPModel.IsAddEnable);
        }

        /// <summary>
        ///Delete 的測試
        ///</summary>
        [TestMethod()]
        public void TestDelete()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            ezMoneyModel.GetCategories().Clear();
            ezMoneyModel.GetRecords().Clear();
            CategoryPresentationModel categoryPModel = new CategoryPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            categoryPModel.Add(CATEGORY_NAME_MOVIE);
            categoryPModel.Add(CATEGORY_NAME_WORK);
            Assert.AreEqual(2, ezMoneyModel.GetCategories().Count);
            categoryPModel.Delete(1, DialogResult.No);// (CATEGORY_NAME_WORK);
            Assert.AreEqual(2, ezMoneyModel.GetCategories().Count);
            categoryPModel.Delete(1, DialogResult.Yes);// (CATEGORY_NAME_WORK);
            Assert.AreEqual(1, ezMoneyModel.GetCategories().Count);
        }

        /// <summary>
        ///InitializeState 的測試
        ///</summary>
        [TestMethod()]
        public void TestInitializeState()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            ezMoneyModel.GetCategories().Clear();
            ezMoneyModel.GetRecords().Clear();
            CategoryPresentationModel categoryPModel = new CategoryPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            categoryPModel.InitializeState();
            Assert.AreEqual(false, categoryPModel.IsSelectionMode);
            Assert.AreEqual(false, categoryPModel.IsModifyEnable);
            Assert.AreEqual(false, categoryPModel.IsDeleteEnable);
            Assert.AreEqual(false, categoryPModel.IsCancelEnable);
            Assert.AreEqual(String.Empty, categoryPModel.CategoryNameText);
            Assert.AreEqual(false, categoryPModel.IsAddEnable);
        }

        /// <summary>
        ///IsValidCategoryAdd 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsValidCategoryAdd()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            ezMoneyModel.GetCategories().Clear();
            ezMoneyModel.GetRecords().Clear();
            CategoryPresentationModel categoryPModel = new CategoryPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            categoryPModel.InitializeState();
            string errorMessage = string.Empty;
            Assert.IsTrue(categoryPModel.IsValidCategoryAdd(CATEGORY_NAME_WORK, ref errorMessage));
            Assert.AreEqual(String.Empty, errorMessage);
            Assert.IsFalse(categoryPModel.IsValidCategoryAdd(String.Empty, ref errorMessage));
            Assert.AreEqual(CategoryPresentationModel.CATEGORY_NO_NAME_INFO, errorMessage);
            Category category = new Category(CATEGORY_NAME_WORK);
            ezMoneyModel.AddCategory(category);
            Assert.IsFalse(categoryPModel.IsValidCategoryAdd(CATEGORY_NAME_WORK, ref errorMessage));
            Assert.AreEqual(CategoryPresentationModel.CATEGORY_REPEAT_INFO, errorMessage);
        }

        /// <summary>
        ///Modify 的測試
        ///</summary>
        [TestMethod()]
        public void TestModify()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            ezMoneyModel.GetCategories().Clear();
            ezMoneyModel.GetRecords().Clear();
            CategoryPresentationModel categoryPModel = new CategoryPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            categoryPModel.InitializeState();
            Category category = new Category(CATEGORY_NAME_WORK);
            ezMoneyModel.AddCategory(category);
            Assert.AreEqual(CATEGORY_NAME_WORK, ezMoneyModel.GetCategories()[0].CategoryName);
            categoryPModel.Modify(0, CATEGORY_NAME_MOVIE);
            Assert.AreEqual(CATEGORY_NAME_MOVIE, ezMoneyModel.GetCategories()[0].CategoryName);
        }

        /// <summary>
        ///SelectCategory 的測試
        ///</summary>
        [TestMethod()]
        public void TestSelectCategory()
        {
            EZMoneyModel ezMoneyModel = new EZMoneyModel(); // TODO: 初始化為適當值
            ezMoneyModel.GetCategories().Clear();
            ezMoneyModel.GetRecords().Clear();
            CategoryPresentationModel categoryPModel = new CategoryPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            categoryPModel.InitializeState();
            categoryPModel.SelectCategory(-1);
            Assert.AreEqual(false, categoryPModel.IsSelectionMode);
            Assert.AreEqual(false, categoryPModel.IsModifyEnable);
            Assert.AreEqual(false, categoryPModel.IsDeleteEnable);
            Assert.AreEqual(false, categoryPModel.IsCancelEnable);
            Category category = new Category(CATEGORY_NAME_WORK);
            ezMoneyModel.AddCategory(category);
            categoryPModel.SelectCategory(0);
            Assert.AreEqual(true, categoryPModel.IsSelectionMode);
            Assert.AreEqual(true, categoryPModel.IsModifyEnable);
            Assert.AreEqual(true, categoryPModel.IsDeleteEnable);
            Assert.AreEqual(true, categoryPModel.IsCancelEnable);
            Assert.AreEqual(CATEGORY_NAME_WORK, categoryPModel.CategoryNameText);
            Assert.AreEqual(false, categoryPModel.IsAddEnable);
        }

        /// <summary>
        ///RaiseUpdateEvent 的測試
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ezMoney.exe")]
        public void TestRaiseUpdateEvent()
        {
            int raiseCount = 0;
            EZMoneyModel ezMoneyModel = new EZMoneyModel();
            ezMoneyModel.GetCategories().Clear();
            ezMoneyModel.GetRecords().Clear();
            CategoryPresentationModel categoryPModel = new CategoryPresentationModel(ezMoneyModel); // TODO: 初始化為適當值
            categoryPModel._updateEvent += delegate(CategoryPresentationModel localCategoryPModel)
            {
                raiseCount++;
            };
            categoryPModel.Add(CATEGORY_NAME_WORK);
            Assert.AreEqual(1, raiseCount);
            categoryPModel.Cancel();
            Assert.AreEqual(2, raiseCount);
        }
    }
}
