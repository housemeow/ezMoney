using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace ezMoney
{
    class CategoryModel
    {
        public const String CATEGORY_FILE_NAME = "category.txt";
        private const string EMPTY_LINE = "";
        private BindingList<Category> _categories;

        //constructor
        public CategoryModel()
        {
            _categories = new BindingList<Category>();
        }

        public BindingList<Category> Categories
        {
            get
            {
                return _categories;
            }
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
            }
        }

        //get category by index
        public Category GetCategory(int index)
        {
            Category category;
            try
            {
                category = _categories[index];
            }
            catch (Exception)
            {
                category = new Category(String.Empty);
            }
            return category;
        }

        //get category index from category name
        public int GetCategoryIndex(Category category)
        {
            int index = _categories.IndexOf(category);
            return index;
        }

        //add category to categoryList
        public void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        //add category to categoryList by Categoryname
        public void AddCategory(String categoryName)
        {
            AddCategory(new Category(categoryName));
        }

        //category is in categoies
        public Boolean IsExist(Category category)
        {
            return _categories.Contains(category);
        }

        //category is in categories by category Name
        public Boolean IsExist(String categoryName)
        {
            return IsExist(new Category(categoryName));
        }
    }
}
