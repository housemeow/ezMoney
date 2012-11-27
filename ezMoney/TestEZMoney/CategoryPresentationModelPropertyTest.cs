using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestEZMoney
{
    /// <summary>
    ///這是 CategoryPresentationModelPropertyTest 的測試類別，應該包含
    ///所有 CategoryPresentationModelPropertyTest 單元測試
    ///</summary>
    [TestClass()]
    public class CategoryPresentationModelPropertyTest
    {
        const string COMPARE_STRING = "abc";

        /// <summary>
        ///CategoryNameText 的測試
        ///</summary>
        [TestMethod()]
        public void TestCategoryNameText()
        {
            CategoryPresentationModelProperty categoryPModelProperty = new CategoryPresentationModelProperty(); // TODO: 初始化為適當值
            categoryPModelProperty.CategoryNameText = COMPARE_STRING;
            Assert.AreEqual(COMPARE_STRING, categoryPModelProperty.CategoryNameText);
        }

        /// <summary>
        ///ErrorProviderMessage 的測試
        ///</summary>
        [TestMethod()]
        public void TestErrorProviderMessage()
        {
            CategoryPresentationModelProperty categoryPModelProperty = new CategoryPresentationModelProperty(); // TODO: 初始化為適當值
            categoryPModelProperty.ErrorProviderMessage = COMPARE_STRING;
            Assert.AreEqual(COMPARE_STRING, categoryPModelProperty.ErrorProviderMessage);
        }

        /// <summary>
        ///IsAddEnable 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsAddEnable()
        {
            CategoryPresentationModelProperty categoryPModelProperty = new CategoryPresentationModelProperty(); // TODO: 初始化為適當值
            categoryPModelProperty.IsAddEnable = true;
            Assert.AreEqual(true, categoryPModelProperty.IsAddEnable);
        }

        /// <summary>
        ///IsCancelEnable 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsCancelEnable()
        {
            CategoryPresentationModelProperty categoryPModelProperty = new CategoryPresentationModelProperty(); // TODO: 初始化為適當值
            categoryPModelProperty.IsCancelEnable = true;
            Assert.AreEqual(true, categoryPModelProperty.IsCancelEnable);
        }

        /// <summary>
        ///IsDeleteEnable 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsDeleteEnable()
        {
            CategoryPresentationModelProperty categoryPModelProperty = new CategoryPresentationModelProperty(); // TODO: 初始化為適當值
            categoryPModelProperty.IsDeleteEnable = true;
            Assert.AreEqual(true, categoryPModelProperty.IsDeleteEnable);
        }

        /// <summary>
        ///IsModifyEnable 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsModifyEnable()
        {
            CategoryPresentationModelProperty categoryPModelProperty = new CategoryPresentationModelProperty(); // TODO: 初始化為適當值
            categoryPModelProperty.IsModifyEnable = true;
            Assert.AreEqual(true, categoryPModelProperty.IsModifyEnable);
        }

        /// <summary>
        ///IsSelectionMode 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsSelectionMode()
        {
            CategoryPresentationModelProperty categoryPModelProperty = new CategoryPresentationModelProperty(); // TODO: 初始化為適當值
            categoryPModelProperty.IsSelectionMode = true;
            Assert.AreEqual(true, categoryPModelProperty.IsSelectionMode);
        }
    }
}
