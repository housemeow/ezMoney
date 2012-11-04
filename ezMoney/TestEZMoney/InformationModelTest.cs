using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestEZMoney
{
    /// <summary>
    ///這是 InformationModelTest 的測試類別，應該包含
    ///所有 InformationModelTest 單元測試
    ///</summary>
    [TestClass()]
    public class InformationModelTest
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
        ///IsValidRecordAdd 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsValidRecordAdd()
        {
            CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            Category movieCategory = new Category(CATEGORY_NAME_MOVIE);
            Category workCategory = new Category(CATEGORY_NAME_WORK);
            Category entertainmentCategory = new Category(CATEGORY_NAME_ENTERTAINMENT);
            categoryModel.AddCategory(movieCategory);
            categoryModel.AddCategory(workCategory);
            InformationModel informationModel = new InformationModel(categoryModel); // TODO: 初始化為適當值
            int categoryIndex;
            string amountString; // TODO: 初始化為適當值
            string errorMessage = string.Empty; // TODO: 初始化為適當值
            bool buttonEnable;
            categoryIndex = categoryModel.GetCategoryIndex(workCategory);
            amountString = "";
            buttonEnable = informationModel.IsValidRecordAdd(categoryIndex, amountString, ref errorMessage);
            Assert.AreEqual(false, buttonEnable);
            Assert.AreEqual(InformationModelProperty.NO_NUMBER_INFO, errorMessage);
            categoryIndex = -1;
            amountString = "111";
            buttonEnable = informationModel.IsValidRecordAdd(categoryIndex, amountString, ref errorMessage);
            Assert.AreEqual(false, buttonEnable);
            Assert.AreEqual(InformationModelProperty.NO_SELECT_CATEGORY_INFO, errorMessage);
            categoryIndex = categoryModel.GetCategoryIndex(workCategory);
            amountString = "xyz";
            buttonEnable = informationModel.IsValidRecordAdd(categoryIndex, amountString, ref errorMessage);
            Assert.AreEqual(false, buttonEnable);
            Assert.AreEqual(InformationModelProperty.TEXT_IS_NOT_NUMBER_INFO, errorMessage);
            categoryIndex = categoryModel.GetCategoryIndex(workCategory);
            amountString = "100";
            buttonEnable = informationModel.IsValidRecordAdd(categoryIndex, amountString, ref errorMessage);
            Assert.AreEqual(true, buttonEnable);
            Assert.AreEqual(InformationModelProperty.EMPTY_ERROR_MESSAGE, errorMessage);
        }

        /// <summary>
        ///IsValidCategoryAdd 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsValidCategoryAdd()
        {
            //CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            //InformationModel informationModel = new InformationModel(categoryModel); // TODO: 初始化為適當值
            //Category movieCategory = new Category(CATEGORY_NAME_MOVIE);
            //Category workCategory = new Category(CATEGORY_NAME_WORK);
            //Category entertainmentCategory = new Category(CATEGORY_NAME_ENTERTAINMENT);
            //categoryModel.AddCategory(movieCategory);
            //categoryModel.AddCategory(workCategory);
            //string errorMessage = string.Empty; // TODO: 初始化為適當值
            //bool buttonEnable;
            //buttonEnable = informationModel.IsValidCategoryAdd(string.Empty, ref errorMessage);
            //Assert.AreEqual(InformationModelProperty.CATEGORY_NO_NAME_INFO, errorMessage);
            //Assert.AreEqual(false, buttonEnable);
            //buttonEnable = informationModel.IsValidCategoryAdd(CATEGORY_NAME_MOVIE, ref errorMessage);
            //Assert.AreEqual(InformationModelProperty.CATEGORY_NO_NAME_INFO, errorMessage);
            //Assert.AreEqual(false, buttonEnable);
            //buttonEnable = informationModel.IsValidCategoryAdd(CATEGORY_NAME_ENTERTAINMENT, ref errorMessage);
            //Assert.AreEqual(InformationModelProperty.EMPTY_ERROR_MESSAGE, errorMessage);
            //Assert.AreEqual(true, buttonEnable);
        }

        /// <summary>
        ///GetAmount 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetAmount()
        {
            CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            InformationModel informationModel = new InformationModel(categoryModel); // TODO: 初始化為適當值
            string amountString = string.Empty; // TODO: 初始化為適當值
            int amount;
            amountString = "100";
            amount = informationModel.GetAmount(amountString, true);
            Assert.AreEqual(100, amount);
            amountString = "100";
            amount = informationModel.GetAmount(amountString, false);
            Assert.AreEqual(-100, amount);
        }
    }
}
