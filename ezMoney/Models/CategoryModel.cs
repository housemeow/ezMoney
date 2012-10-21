using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ezMoney
{
    class CategoryModel
    {
<<<<<<< HEAD:ezMoney/Models/CategoryModel.cs
        const String CATEGORY_FILE_NAME = "category.txt";
=======
        public const String CATEGORY_FILE_NAME = "category.txt";
>>>>>>> TestProject:ezMoney/Models/CategoryModel.cs
        private const string EMPTY_LINE = "";
        private List<Category> _categories;

        //constructor
        public CategoryModel()
        {
            _categories = new List<Category>();
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
        public void AddCategory(Category categoryName)
        {
            _categories.Add(categoryName);
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
    }
}
