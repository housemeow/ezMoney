using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using System.IO;


namespace TestEZMoney
{
    /// <summary>
    /// CodedUITest1 的摘要描述
    /// </summary>
    [CodedUITest]
    public class EZMoneyUITest
    {
        private const string FILE_PATH = "../../../bin/Debug/ezMoney.exe";
        private const string EZMONEY_TITLE = "Categories Management";

        #region 其他測試屬性

        // 您可以使用下列其他屬性撰寫測試:

        //在每項測試執行前先使用 TestInitialize 執行程式碼 
        [TestInitialize()]
        public void Initialize()
        {
            File.Delete("../../../bin/Debug/category.txt");
            File.Delete("../../../bin/Debug/record.txt");
            Robot.Initialize(FILE_PATH, EZMONEY_TITLE);
        }

        //在每項測試執行後使用 TestCleanup 執行程式碼
        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        #endregion

        #region CategoryTest
        //test category add
        [TestMethod]
        public void TestCategoryAdd()
        {
            Robot.AssertButtonEnable("buttonCategoryAdd", false);
            AddCategoryScript("Work");
            Robot.AssertListCount("listBoxCategories", 1);
            Robot.AssertListSelectedItem("listBoxCategories", "Work");
        }

        //script of adding category
        private static void AddCategoryScript(string categoryName)
        {
            Robot.ClickTabPage("Category");
            Robot.SetEdit("textBoxCategoryName", categoryName);
            Robot.ClickButton("buttonCategoryAdd");
        }

        //test select a category and visible all modification buttons
        [TestMethod]
        public void TestCategoryListSelect()
        {
            Robot.AssertButtonEnable("buttonCategoryAdd", false);
            AddCategoryScript("Work");
            Robot.ClickListItem("listBoxCategories", 0);
            Robot.AssertButtonEnable("buttonCategoryModify", true);
            Robot.AssertButtonEnable("buttonCategoryDelete", true);
            Robot.AssertButtonEnable("buttonCategoryCancel", true);
        }

        //test cancel button after select a category
        [TestMethod]
        public void TestCategoryCancelButton()
        {
            Robot.AssertButtonEnable("buttonCategoryAdd", false);
            AddCategoryScript("Work");
            Robot.ClickListItem("listBoxCategories", 0);
            Robot.AssertButtonEnable("buttonCategoryModify", true);
            Robot.AssertButtonEnable("buttonCategoryDelete", true);
            Robot.AssertButtonEnable("buttonCategoryCancel", true);
            Robot.ClickButton("buttonCategoryCancel");
            Robot.AssertButtonEnable("buttonCategoryModify", false);
            Robot.AssertButtonEnable("buttonCategoryDelete", false);
            Robot.AssertButtonEnable("buttonCategoryCancel", false);
        }

        //test modify category name
        [TestMethod]
        public void TestCategoryModifyButton()
        {
            AddCategoryScript("Work");
            Robot.ClickListItem("listBoxCategories", 0);
            Robot.SetEdit("textBoxCategoryName", "Play");
            Robot.ClickButton("buttonCategoryModify");
            Robot.ClickListItem("listBoxCategories", 0);
            Robot.AssertListSelectedItem("listBoxCategories", "Play");
        }

        //test delete category
        [TestMethod]
        public void TestCategoryDeleteButton()
        {
            AddCategoryScript("Work");
            //click delete but not submit
            Robot.ClickListItem("listBoxCategories", 0);
            Robot.AssertListCount("listBoxCategories", 1);
            Robot.ClickButton("buttonCategoryDelete");
            Robot.ClickMessageBoxButton("Delete Category", "否(N)");
            //delete category
            Robot.ClickListItem("listBoxCategories", 0);
            Robot.AssertListCount("listBoxCategories", 1);
            Robot.ClickButton("buttonCategoryDelete");
            Robot.ClickMessageBoxButton("Delete Category", "是(Y)");
            //assert
            Robot.AssertListCount("listBoxCategories", 0);
        }
        #endregion

        #region RecordTest
        //test add a record income or expense
        [TestMethod]
        public void TestRecordAdd()
        {
            AddCategoryScript("Work");
            AddCategoryScript("Play");
            AddCategoryScript("Entertainment");
            DateTime date = new DateTime(2012, 3, 14);
            AddRecordScript(date, "Work", true, 123);
            Robot.AssertGridViewCell("dataGridViewRecord", 0, 0, date.ToShortDateString());
            Robot.AssertGridViewCell("dataGridViewRecord", 0, 1, "Work");
            Robot.AssertGridViewCell("dataGridViewRecord", 0, 2, "123");

        }

        //script of adding category
        private static void AddRecordScript(DateTime date, string categoryName, bool isIncome, int amount)
        {
            Robot.ClickTabPage("Record");
            Robot.SetDateTimePicker("dateTimePickerRecord", date);
            Robot.SetComboBox("comboBoxCategory", categoryName);
            Robot.SetEdit("textBoxRecordAmount", amount.ToString());
            if (isIncome)
            {
                Robot.ClickRadio("radioButtonIncome");
            }
            else
            {
                Robot.ClickRadio("radioButtonExpense");
            }
            Robot.ClickButton("buttonRecordAdd");
        }

        //test select a record and visible all modification buttons
        [TestMethod]
        public void TestRecordSelect()
        {
            AddCategoryScript("Work");
            AddCategoryScript("Play");
            AddCategoryScript("Entertainment");
            AddRecordScript(new DateTime(2012, 5, 26), "Entertainment", false, 450);
            AddRecordScript(new DateTime(2012, 1, 14), "Work", true, 330);
            AddRecordScript(new DateTime(2012, 5, 26), "Entertainment", false, 450);
            Robot.AssertButtonEnable("buttonRecordModify", false);
            Robot.AssertButtonEnable("buttonRecordDelete", false);
            Robot.AssertButtonEnable("buttonRecordCancel", false);
            Robot.ClickGridViewCell("dataGridViewRecord", 1);
            Robot.AssertButtonEnable("buttonRecordModify", true);
            Robot.AssertButtonEnable("buttonRecordDelete", true);
            Robot.AssertButtonEnable("buttonRecordCancel", true);
        }

        //test cancel button after select a record
        [TestMethod]
        public void TestRecordCancelButton()
        {
            AddCategoryScript("Work");
            AddCategoryScript("Play");
            AddCategoryScript("Entertainment");
            AddRecordScript(new DateTime(2012, 5, 26), "Entertainment", false, 450);
            AddRecordScript(new DateTime(2012, 1, 14), "Work", true, 330);
            AddRecordScript(new DateTime(2012, 5, 13), "Entertainment", false, 700);
            Robot.ClickGridViewCell("dataGridViewRecord", 1);
            Robot.AssertButtonEnable("buttonRecordModify", true);
            Robot.AssertButtonEnable("buttonRecordDelete", true);
            Robot.AssertButtonEnable("buttonRecordCancel", true);
            Robot.ClickButton("buttonRecordCancel");
            Robot.AssertButtonEnable("buttonRecordModify", false);
            Robot.AssertButtonEnable("buttonRecordDelete", false);
            Robot.AssertButtonEnable("buttonRecordCancel", false);
        }

        //test modify record datetime, category, and amount
        [TestMethod]
        public void TestRecordModifyButton()
        {
            AddCategoryScript("Work");
            AddCategoryScript("Play");
            AddRecordScript(new DateTime(2012, 5, 26), "Play", false, 450);
            Robot.ClickGridViewCell("dataGridViewRecord", 0);
            DateTime newDate = new DateTime(2012, 5, 13);
            Robot.SetDateTimePicker("dateTimePickerRecord", newDate);
            Robot.SetComboBox("comboBoxCategory", "Work");
            Robot.SetEdit("textBoxRecordAmount", "330");
            Robot.ClickRadio("radioButtonIncome");
            Robot.ClickButton("buttonRecordModify");
            Robot.AssertGridViewCell("dataGridViewRecord", 0, 0, newDate.ToShortDateString());
            Robot.AssertGridViewCell("dataGridViewRecord", 0, 1, "Work");
            Robot.AssertGridViewCell("dataGridViewRecord", 0, 2, "330");
        }

        //test delete record
        [TestMethod]
        public void TestRecordDeleteButton()
        {
            AddCategoryScript("Work");
            AddCategoryScript("Play");
            AddRecordScript(new DateTime(2012, 5, 26), "Play", false, 450);
            //click record delete but not submit
            Robot.ClickGridViewCell("dataGridViewRecord", 0);
            Robot.ClickButton("buttonRecordDelete");
            Robot.ClickMessageBoxButton("Delete Record", "否(N)");
            Robot.AssertGridViewRowCount("dataGridViewRecord", 1);
            //delete a record row
            Robot.ClickGridViewCell("dataGridViewRecord", 0);
            Robot.ClickButton("buttonRecordDelete");
            Robot.ClickMessageBoxButton("Delete Record", "是(Y)");
            Robot.AssertGridViewRowCount("dataGridViewRecord", 0);
        }
        #endregion

        #region StatisticTest
        //test income and expense radio button
        [TestMethod]
        public void TestStatisticRadioButton()
        {
            AddCategoryScript("Work");
            AddCategoryScript("Play");
            AddCategoryScript("Food");
            DateTime dateValentine = new DateTime(2012, 3, 14);
            DateTime dateChristmas = new DateTime(2012, 12, 25);
            AddRecordScript(dateValentine, "Play", false, 280);
            AddRecordScript(dateValentine, "Play", false, 300);
            AddRecordScript(dateValentine, "Play", false, 320);
            AddRecordScript(dateValentine, "Food", false, 200);
            AddRecordScript(dateChristmas, "Work", true, 1000);
            AddRecordScript(dateChristmas, "Work", true, 3000);
            AddRecordScript(dateValentine, "Food", false, 100);
            Robot.ClickTabPage("Statistic");
            Robot.ClickRadio("radioButtonStatisticIncome");
            Robot.AssertGridViewCell("dataGridViewStatisticRecord", 0, 0, "Work");
            Robot.AssertGridViewCell("dataGridViewStatisticRecord", 0, 1, "4000");
            Robot.AssertGridViewCell("dataGridViewStatisticRecord", 0, 2, "2");
            Robot.AssertGridViewCell("dataGridViewStatisticRecord", 0, 3, "100%");
            Robot.ClickRadio("radioButtonStatisticExpense");
            Robot.AssertGridViewCell("dataGridViewStatisticRecord", 0, 0, "Play");
            Robot.AssertGridViewCell("dataGridViewStatisticRecord", 0, 1, "-900");
            Robot.AssertGridViewCell("dataGridViewStatisticRecord", 0, 2, "3");
            Robot.AssertGridViewCell("dataGridViewStatisticRecord", 0, 3, "75%");
            Robot.AssertGridViewCell("dataGridViewStatisticRecord", 1, 0, "Food");
            Robot.AssertGridViewCell("dataGridViewStatisticRecord", 1, 1, "-300");
            Robot.AssertGridViewCell("dataGridViewStatisticRecord", 1, 2, "2");
            Robot.AssertGridViewCell("dataGridViewStatisticRecord", 1, 3, "25%");
        }

        //test select a row for showing a detail of specified category
        [TestMethod]
        public void TestRecordDetailView()
        {
            AddCategoryScript("Work");
            AddCategoryScript("Play");
            AddCategoryScript("Food");
            DateTime dateValentine = new DateTime(2012, 3, 14);
            DateTime dateChristmas = new DateTime(2012, 12, 25);
            AddRecordScript(dateValentine, "Play", false, 280);
            AddRecordScript(dateValentine, "Play", false, 300);
            AddRecordScript(dateValentine, "Play", false, 320);
            AddRecordScript(dateValentine, "Food", false, 200);
            AddRecordScript(dateChristmas, "Work", true, 1000);
            AddRecordScript(dateChristmas, "Work", true, 3000);
            AddRecordScript(dateChristmas, "Food", false, 100);
            Robot.ClickTabPage("Statistic");
            Robot.ClickRadio("radioButtonStatisticIncome");
            //test Work details
            Robot.ClickGridViewCell("dataGridViewStatisticRecord", 0);
            Robot.AssertGridViewCell("dataGridViewDetail", 0, 0, dateChristmas.ToShortDateString());
            Robot.AssertGridViewCell("dataGridViewDetail", 0, 1, "1000");
            Robot.AssertGridViewCell("dataGridViewDetail", 1, 0, dateChristmas.ToShortDateString());
            Robot.AssertGridViewCell("dataGridViewDetail", 1, 1, "3000");
            //test Play details
            Robot.ClickRadio("radioButtonStatisticExpense");
            Robot.ClickGridViewCell("dataGridViewStatisticRecord", 0);
            Robot.AssertGridViewCell("dataGridViewDetail", 0, 0, dateValentine.ToShortDateString());
            Robot.AssertGridViewCell("dataGridViewDetail", 0, 1, "-280");
            Robot.AssertGridViewCell("dataGridViewDetail", 1, 0, dateValentine.ToShortDateString());
            Robot.AssertGridViewCell("dataGridViewDetail", 1, 1, "-300");
            Robot.AssertGridViewCell("dataGridViewDetail", 2, 0, dateValentine.ToShortDateString());
            Robot.AssertGridViewCell("dataGridViewDetail", 2, 1, "-320");
            //test Food details
            Robot.ClickGridViewCell("dataGridViewStatisticRecord", 1);
            Robot.AssertGridViewCell("dataGridViewDetail", 0, 0, dateValentine.ToShortDateString());
            Robot.AssertGridViewCell("dataGridViewDetail", 0, 1, "-200");
            Robot.AssertGridViewCell("dataGridViewDetail", 1, 0, dateChristmas.ToShortDateString());
            Robot.AssertGridViewCell("dataGridViewDetail", 1, 1, "-100");
        }

        //test statistic textBox
        [TestMethod]
        public void TestRecordStatisticTextBox()
        {
            AddCategoryScript("Work");
            AddCategoryScript("Play");
            AddCategoryScript("Food");
            DateTime dateValentine = new DateTime(2012, 3, 14);
            DateTime dateChristmas = new DateTime(2012, 12, 25);
            AddRecordScript(dateValentine, "Play", false, 280);
            AddRecordScript(dateValentine, "Play", false, 300);
            AddRecordScript(dateValentine, "Play", false, 320);
            AddRecordScript(dateValentine, "Food", false, 200);
            AddRecordScript(dateChristmas, "Work", true, 1000);
            AddRecordScript(dateChristmas, "Work", true, 3000);
            AddRecordScript(dateValentine, "Food", false, 100);
            Robot.ClickTabPage("Statistic");
            Robot.AssertEdit("textBoxIncome", "4000");
            Robot.AssertEdit("textBoxExpense", "1200");
            Robot.AssertEdit("textBoxBalance", "2800");

        }
        #endregion
    }
}
