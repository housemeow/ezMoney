using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ezMoney
{
    class CategoryView : CategoryViewProperty
    {
        CategoryModel _categoryModel;
        InformationModel _informationModel;

        //categoryManagementView constructor
        public CategoryView(CategoryModel categoryModel, InformationModel informationModel)
        {
            _categoryModel = categoryModel;
            _informationModel = informationModel;
        }

        //initialize controls and event
        public void Initialize()
        {
            BindControlSetEvent();
            InitControls();
            SetButtonAndErrorProviderState(_informationModel);
        }

        //bind all control to categoryView
        private void BindControlSetEvent()
        {
            TextBox textBoxCategoryName = TextBoxCategoryName;
            Button buttonAdd = ButtonAdd;
            textBoxCategoryName.TextChanged += new EventHandler(ChangeCategoryName);
            buttonAdd.Click += new EventHandler(AddCategory);
        }

        //initialize control
        public void InitControls()
        {
            Button buttonAdd = ButtonAdd;
            buttonAdd.Enabled = false;
        }

        //add category
        public void AddCategory(object sender, EventArgs args)
        {
            TextBox textBoxCategoryName = TextBoxCategoryName;
            String categoryName = textBoxCategoryName.Text;
            _categoryModel.AddCategory(new Category(categoryName));
            CurrencyManager.Refresh();
            textBoxCategoryName.Text = String.Empty;
        }

        //change category name event
        public void ChangeCategoryName(object sender, EventArgs args)
        {
            SetButtonAndErrorProviderState(_informationModel);
        }

        //enable/ disable button and ErrorProvider
        public void SetButtonAndErrorProviderState(InformationModel informationModel)
        {
            String errorMessage = String.Empty;
            bool buttonEnable = informationModel.IsValidCategoryAdd(TextBoxCategoryName.Text, ref errorMessage);
            ButtonAdd.Enabled = buttonEnable;
            ErrorProvider.SetError(ButtonAdd, errorMessage);
        }
    }
}
