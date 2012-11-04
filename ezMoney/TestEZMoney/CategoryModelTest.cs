using ezMoney;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace TestEZMoney
{
    /// <summary>
    ///這是 CategoryModelTest 的測試類別，應該包含
    ///所有 CategoryModelTest 單元測試
    ///</summary>
    [TestClass()]
    public class CategoryModelTest
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
        //在執行類別中的所有測試之後，使用 ClassCleanup 執行程式碼
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            File.Delete(CategoryModel.CATEGORY_FILE_NAME);
        }
        #endregion

        /// <summary>
        ///AddCategory 的測試
        ///</summary>
        [TestMethod()]
        public void TestAddCategory()
        {
            CategoryModel categoryModel = new CategoryModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            Assert.AreEqual(1, categoryModel.GetCategories().Count);
            categoryModel.AddCategory(categoryWork);
            Assert.AreEqual(2, categoryModel.GetCategories().Count);
        }

        /// <summary>
        ///AddCategory 的測試
        ///</summary>
        [TestMethod()]
        public void TestAddCategory1()
        {
            CategoryModel categoryModel = new CategoryModel();
            categoryModel.AddCategory(CATEGORY_NAME_MOVIE);
            Assert.AreEqual(1, categoryModel.GetCategories().Count);
            categoryModel.AddCategory(CATEGORY_NAME_WORK);
            Assert.AreEqual(2, categoryModel.GetCategories().Count);
        }

        /// <summary>
        ///GetCategories 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetCategories()
        {
            CategoryModel categoryModel = new CategoryModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            Assert.AreEqual(categoryMovie, categoryModel.GetCategories()[0]);
            Assert.AreEqual(categoryWork, categoryModel.GetCategories()[1]);
        }

        /// <summary>
        ///GetCategory 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetCategory()
        {
            CategoryModel categoryModel = new CategoryModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            Assert.AreEqual(categoryMovie, categoryModel.GetCategory(0));
            Assert.AreEqual(categoryWork, categoryModel.GetCategory(1));
            Assert.AreEqual(new Category(string.Empty), categoryModel.GetCategory(2));
        }

        /// <summary>
        ///GetCategoryIndex 的測試
        ///</summary>
        [TestMethod()]
        public void TestGetCategoryIndex()
        {
            CategoryModel categoryModel = new CategoryModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            Assert.AreEqual(0, categoryModel.GetCategoryIndex(categoryMovie));
            Assert.AreEqual(1, categoryModel.GetCategoryIndex(categoryWork));
        }

        /// <summary>
        ///IsExist 的測試
        ///</summary>
        [TestMethod()]
        public void TestIsExist()
        {
            CategoryModel categoryModel = new CategoryModel();
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            Category categoryEntertainment = new Category(CATEGORY_NAME_ENTERTAINMENT);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            Assert.IsTrue(categoryModel.IsExist(categoryMovie));
            Assert.IsTrue(categoryModel.IsExist(categoryWork));
            Assert.IsFalse(categoryModel.IsExist(categoryEntertainment));
        }

        /// <summary>
        ///ReadCategoryFromFile 的測試
        ///</summary>
        [TestMethod()]
        public void TestReadCategoryFromFile()
        {
            CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            Category categoryEntertainment = new Category(CATEGORY_NAME_ENTERTAINMENT);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            categoryModel.AddCategory(categoryEntertainment);
            Assert.AreEqual(3, categoryModel.GetCategories().Count);
            categoryModel.WriteCategoryToFile();
            categoryModel = new CategoryModel();
            categoryModel.ReadCategoryFromFile();
            Assert.AreEqual(3, categoryModel.GetCategories().Count);
            Assert.AreEqual(categoryMovie, categoryModel.GetCategory(0));
            Assert.AreEqual(categoryWork, categoryModel.GetCategory(1));
            Assert.AreEqual(categoryEntertainment, categoryModel.GetCategory(2));
        }

        /// <summary>
        ///WriteCategoryToFile 的測試
        ///</summary>
        [TestMethod()]
        public void TestWriteCategoryToFile()
        {
            CategoryModel categoryModel = new CategoryModel(); // TODO: 初始化為適當值
            Category categoryMovie = new Category(CATEGORY_NAME_MOVIE);
            Category categoryWork = new Category(CATEGORY_NAME_WORK);
            Category categoryEntertainment = new Category(CATEGORY_NAME_ENTERTAINMENT);
            categoryModel.AddCategory(categoryMovie);
            categoryModel.AddCategory(categoryWork);
            categoryModel.AddCategory(categoryEntertainment);
            Assert.AreEqual(3, categoryModel.GetCategories().Count);
            categoryModel.WriteCategoryToFile();
            categoryModel = new CategoryModel();
            categoryModel.ReadCategoryFromFile();
            Assert.AreEqual(3, categoryModel.GetCategories().Count);
            Assert.AreEqual(categoryMovie, categoryModel.GetCategory(0));
            Assert.AreEqual(categoryWork, categoryModel.GetCategory(1));
            Assert.AreEqual(categoryEntertainment, categoryModel.GetCategory(2));
        }
    }
}