using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ezMoney
{
    class CategoryModel
    {
        //list changed event handler
        public delegate void CategoryListLoadedEventHandler(List<Category> list, EventArgs args);
        public delegate void CategoryListChangedEventHandler(List<Category> list, EventArgs args);
        //category list change event handler
        public event CategoryListChangedEventHandler _categoryListChangedEvent;
        //categories loaded event handler
        public event CategoryListLoadedEventHandler _categoryListLoadedEvent;

        const String CATEGORY_FILE_NAME = "category.txt";
        private const string EMPTY_LINE = "";
        private List<Category> _categories;
        
        //constructor
        public CategoryModel()
        {
            _categories = new List<Category>();
            ReadCategoryFromFile();
        }

        //write file to category
        public void WriteCategoryToFile()
        {
            StreamWriter streamWriter = new StreamWriter(CATEGORY_FILE_NAME);
            foreach (Category category in _categories)
            {
                streamWriter.WriteLine(category.CategoryName);
            }
            streamWriter.Close();
        }

        //read file from category.txt
        public void ReadCategoryFromFile()
        {
            if (File.Exists(CATEGORY_FILE_NAME))
            {
                StreamReader streamReader = new StreamReader(CATEGORY_FILE_NAME);
                while (!streamReader.EndOfStream)
                {
                    String categoryName = streamReader.ReadLine();
                    if (!categoryName.Equals(EMPTY_LINE))
                    {
                        Category category = new Category(categoryName);
                        _categories.Add(category);
                    }
                }
                streamReader.Close();
                CategoryListLoaded();
            }
        }

        //get category index from category name
        public int GetCategoryIndex(Category category)
        {
            int index = _categories.IndexOf(category);
            return index;
        }

        //add category to categoryList
        public void AddCategory(Category categoryName)
        {
            _categories.Add(categoryName);
            //trigger event
            ChangeCategoryList();
        }

        //category is in categoies
        public Boolean IsExist(Category categoryName)
        {
            return _categories.Contains(categoryName);
        }

        public List<Category> GetCategories()
        {
            return _categories;
        }

        //change category list trigger
        public void ChangeCategoryList()
        {
            if (_categoryListChangedEvent != null)
            {
                _categoryListChangedEvent(_categories, new EventArgs());
            }
        }

        //categories loaded
        private void CategoryListLoaded()
        {
            if (_categoryListLoadedEvent != null)
            {
                _categoryListLoadedEvent(_categories, new EventArgs());
            }
        }
    }
}
