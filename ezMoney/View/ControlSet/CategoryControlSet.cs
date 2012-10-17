using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class CategoryControlSet : CategoryControlProperty
    {
        //constructor of categoryManagementConstrolSet
        public CategoryControlSet()
        {
        }

        //enable/ disable button and ErrorProvider
        public void SetButtonAndErrorProviderState(CategoryModel model)
        {
            Category category = new Category(TextBoxCategoryName.Text);
            const String CATEGORY_NO_NAME_INFO = "category name must have value.";
            const String CATEGORY_REPEAT_INFO = "category name is repeat.";
            if (category.CategoryName == String.Empty)
            {
                ErrorProvider.SetError(ButtonAdd, CATEGORY_NO_NAME_INFO);
                ButtonAdd.Enabled = false;
            }
            else if (model.IsExist(category))
            {
                ErrorProvider.SetError(ButtonAdd, CATEGORY_REPEAT_INFO);
                ButtonAdd.Enabled = false;
            }
            else
            {
                ErrorProvider.Clear();
                ButtonAdd.Enabled = true;
            }
        }
    }
}
