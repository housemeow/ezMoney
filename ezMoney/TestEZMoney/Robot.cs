using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using System.Windows.Forms;

namespace TestEZMoney
{
    /// <summary>
    /// A class that finds the specific GUI control by using AccessibleName
    /// </summary>
    class Robot
    {
        #region Private Constants
        /// <summary>
        /// The exception message that is thrown when the specific control is not found
        /// </summary>
        private const string CONTROL_NOT_FOUND_EXCEPTION = "The specific control is not found!!";

        /// <summary>
        /// The name of Microsoft Active Accessibility technology
        /// </summary>
        private const string MSAA_TECHNOLOGY = "MSAA";
        #endregion

        #region Static Fields
        private static Dictionary<string, UITestControl> _cache;
        private static ApplicationUnderTest _aut;
        private static UITestControl _root;
        #endregion

        #region Static Properties
        /// <summary>
        /// Gets the main window to search child control
        /// </summary>
        public static UITestControl MainWindow
        {
            get { return _root; }
        }
        #endregion

        #region Preparation and Clean Methods
        /// <summary>
        /// Initializes the Finder
        /// </summary>
        /// <param name="title">The title of the main window</param>
        /// <returns>The found main window</returns>
        /// <exception cref="Exception">If the main window is not found</exception>
        public static UITestControl Initialize(string path, string title)
        {
            Playback.PlaybackSettings.DelayBetweenActions = 0;
            Playback.PlaybackSettings.ThinkTimeMultiplier = 0.0d;
            Playback.PlaybackSettings.SkipSetPropertyVerification = true;
            Playback.PlaybackSettings.ShouldSearchFailFast = true;
            _aut = ApplicationUnderTest.Launch(path);

            _cache = new Dictionary<string, UITestControl>();
            WinWindow window = new WinWindow();
            window.SearchProperties.Add(WinWindow.PropertyNames.Name, title);
            CacheComponentFound(window, title);
            _root = window;
            return _root;
        }

        /// <summary>
        /// Clears all cached controls
        /// </summary>
        public static void CleanUp()
        {
            _cache.Clear();
            _root = null;
            _aut.Close();
        }
        #endregion

        #region Find Methods

        /// <summary>
        /// Finds the winControl and return the found control
        /// </summary>
        /// <param name="type">Control's type</param>
        /// <param name="name">The name for the  control</param>
        /// <param name="parent">This control belongs which parent control</param>
        /// <exception cref="Exception">If the control is not found</exception>
        private static WinControl FindWinControl(Type type, string name, UITestControl parent)
        {
            if (_cache.ContainsKey(name))
            {
                return (WinControl)_cache[name];
            }
            else
            {
                WinControl control = (WinControl)Activator.CreateInstance(type, new Object[] { parent });
                control.SearchProperties.Add(WinControl.PropertyNames.Name, name);
                CacheComponentFound(control, name);
                return control;
            }
        }

        /// <summary>
        /// Finds the specific control and caches the found control
        /// </summary>
        /// <param name="control">The specific control to find</param>
        /// <param name="name">The name for the specific control</param>
        /// <exception cref="Exception">If the control is not found</exception>
        private static void CacheComponentFound(UITestControl control, string name)
        {
            control.Find();
            if (!control.Exists)
            {
                throw new Exception(CONTROL_NOT_FOUND_EXCEPTION);
            }
            _cache.Add(name, control);
        }

        public static void ClickDisplayButton(string name)
        {
            ApplicationUnderTest messageBox = new ApplicationUnderTest();
            PropertyExpressionCollection properties = new PropertyExpressionCollection();
            properties.Add(UITestControl.PropertyNames.TechnologyName, MSAA_TECHNOLOGY);
            properties.Add(UITestControl.PropertyNames.ControlType, "Window");
        }
        #endregion

        /// <summary>
        /// Click a list of menuItems
        /// </summary>
        /// <param name="path">The menuItems' path</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void ClickMenuItem(string[] path)
        {
            foreach (string item in path)
            {
                Mouse.Click((WinMenuItem)Robot.FindWinControl(typeof(WinMenuItem), item, _root));
            }
        }

        /// <summary>
        /// Click the specific button
        /// </summary>
        /// <param name="name">The button's name</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void ClickButton(string name)
        {
            WinButton button = (WinButton)Robot.FindWinControl(typeof(WinButton), name, _root);
            Mouse.Click(button);
        }

        /// <summary>
        /// Click the specific list item
        /// </summary>
        /// <param name="name">The list's name</param>
        /// <param name="index">The index of list</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void ClickListItem(string name, int index)
        {
            WinList listBox = (WinList)Robot.FindWinControl(typeof(WinList), name, _root);
            Mouse.Click(listBox.Items[index]);
        }

        /// <summary>
        /// Click the specific gridview cell
        /// </summary>
        /// <param name="name">The gridview's name</param>
        /// <param name="index">The index of list</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void ClickGridViewCell(string name, int index)
        {
            WinTable gridView = (WinTable)Robot.FindWinControl(typeof(WinTable), name, _root);
            Mouse.Click(gridView.RowHeaders[index]);
        }

        /// <summary>
        /// Click the specific tab control
        /// </summary>
        /// <param name="name">The tabPage's name</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void ClickTabPage(string name)
        {
            WinTabPage tabPage = (WinTabPage)Robot.FindWinControl(typeof(WinTabPage), name, _root);
            Mouse.Click(tabPage);
        }

        /// <summary>
        /// Click the specific radioButton
        /// </summary>
        /// <param name="name">The radioButton's name</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void ClickRadio(string name)
        {
            Mouse.Click((WinRadioButton)Robot.FindWinControl(typeof(WinRadioButton), name, _root));
        }

        /// <summary>
        /// Click the specific messagebox button
        /// </summary>
        /// <param name="buttonName">The messagebox button's name</param>
        /// <param name="title">The messagebox's title</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void ClickMessageBoxButton(string title, string buttonName)
        {
            ApplicationUnderTest messageBox = new ApplicationUnderTest();
            PropertyExpressionCollection properties = new PropertyExpressionCollection();
            properties.Add(UITestControl.PropertyNames.TechnologyName, MSAA_TECHNOLOGY);
            properties.Add(UITestControl.PropertyNames.ControlType, "Window");
            properties.Add(UITestControl.PropertyNames.Name, title);
            messageBox.SearchProperties.AddRange(properties);
            messageBox.Find();
            UITestControl button = new UITestControl(messageBox);
            PropertyExpressionCollection properties2 = new PropertyExpressionCollection();
            properties2.Add(UITestControl.PropertyNames.TechnologyName, MSAA_TECHNOLOGY);
            properties2.Add(UITestControl.PropertyNames.ControlType, "Button");
            properties2.Add(UITestControl.PropertyNames.Name, buttonName);
            button.SearchProperties.AddRange(properties2);
            button.Find();
            Mouse.Click(button);
        }

        /// <summary>
        /// Set the specific edit a key
        /// </summary>
        /// <param name="name">The edit's name</param>
        /// <param name="key">The value you want to set</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void SetEdit(string name, string keys)
        {
            WinEdit edit = (WinEdit)Robot.FindWinControl(typeof(WinEdit), name, _root);
            if (edit.Text != keys)
                edit.Text = keys;
        }

        /// <summary>
        /// Set the specific date time picker a key
        /// </summary>
        /// <param name="name">The edit's name</param>
        /// <param name="key">The value you want to set</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void SetDateTimePicker(string name, DateTime dateTime)
        {
            WinDateTimePicker picker = (WinDateTimePicker)Robot.FindWinControl(typeof(WinDateTimePicker), name, _root);
            picker.DateTime = dateTime;
        }

        /// <summary>
        /// Set a target to the specific comboBox
        /// </summary>
        /// <param name="name">The comboBox's name</param>
        /// <param name="targetName">The value you want to select</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void SetComboBox(string name, string targetName)
        {
            WinComboBox comboBox = (WinComboBox)Robot.FindWinControl(typeof(WinComboBox), name, _root);
            if (comboBox.SelectedItem != targetName)
                comboBox.SelectedItem = targetName;
        }

        /// <summary>
        /// Set the specific checkBox isChecked
        /// </summary>
        /// <param name="name">The checkBox's name</param>
        /// <param name="isChecked">true if you checked</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void SetCheckBox(string name, bool isChecked)
        {
            WinCheckBox checkBox = (WinCheckBox)Robot.FindWinControl(typeof(WinCheckBox), name, _root);
            if (checkBox.Checked != isChecked)
                checkBox.Checked = isChecked;
        }

        /// <summary>
        /// Assert the specific edit's text
        /// </summary>
        /// <param name="name">The edit's name</param>
        /// <param name="assertValue">expected value you want to assert</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void AssertEdit(string name, string assertValue)
        {
            WinEdit edit = (WinEdit)Robot.FindWinControl(typeof(WinEdit), name, _root);
            Assert.AreEqual(edit.Text, assertValue);
        }

        /// <summary>
        /// Assert the specific list's count
        /// </summary>
        /// <param name="name">The list's name</param>
        /// <param name="expectedValue">expected value you want to assert</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void AssertListCount(string name, int expectedValue)
        {
            WinList list = (WinList)Robot.FindWinControl(typeof(WinList), name, _root);
            Assert.AreEqual(list.Items.Count, expectedValue);
        }

        /// <summary>
        /// Assert the specific selected item of list
        /// </summary>
        /// <param name="name">The list's name</param>
        /// <param name="expectedValue">expected value you want to assert</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void AssertListSelectedItem(string name, string expectedValue)
        {
            WinList list = (WinList)Robot.FindWinControl(typeof(WinList), name, _root);
            Assert.AreEqual(list.SelectedItemsAsString, expectedValue);
        }

        /// <summary>
        /// Assert the specific data grid view's cell
        /// </summary>
        /// <param name="name">The data grid view's name</param>
        /// <param name="rowIndex">row index</param>
        /// <param name="columnIndex">column index</param>
        /// <param name="expectedValue">expected value you want to assert</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void AssertGridViewCell(string name, int rowIndex, int columnIndex, string expectedValue)
        {
            WinTable gridView = (WinTable)Robot.FindWinControl(typeof(WinTable), name, _root);
            WinRow row = (WinRow)gridView.Rows[rowIndex];
            WinCell cell = (WinCell)row.Cells[columnIndex];
            Assert.AreEqual(expectedValue, cell.GetProperty("Value").ToString());
        }

        /// <summary>
        /// Assert the specific data grid view row count
        /// </summary>
        /// <param name="name">The data grid view's name</param>
        /// <param name="expectedValue">expected value you want to assert</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void AssertGridViewRowCount(string name, int expectedValue)
        {
            WinTable gridView = (WinTable)Robot.FindWinControl(typeof(WinTable), name, _root);
            Assert.AreEqual(expectedValue, gridView.Rows.Count);
        }

        /// <summary>
        /// Assert the specific button's enable
        /// </summary>
        /// <param name="name">The button's name</param>
        /// <param name="assertValue">expected value you want to assert</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void AssertButtonEnable(string name, bool assertValue)
        {
            try
            {
                WinButton list = (WinButton)Robot.FindWinControl(typeof(WinButton), name, _root);
                if (!assertValue)
                {
                    Assert.Fail();
                }
            }
            catch (Exception)
            {
                if (assertValue)
                {
                    Assert.Fail();
                }
            }
        }

        /// <summary>
        /// Assert the specific window is exist and close the window
        /// </summary>
        /// <param name="name">The window's title name</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void AssertWindow(string name)
        {
            const string KEY_TEXT = "\n";
            WinWindow window = (WinWindow)Robot.FindWinControl(typeof(WinWindow), name, null);
            Keyboard.SendKeys(window, KEY_TEXT);
        }

        /// <summary>
        /// Assert the specific text's displayText
        /// </summary>
        /// <param name="name">The text's name</param>
        /// <param name="assertValue">expected value you want to assert</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void AssertText(string name, string assertValue)
        {
            WinText text = (WinText)Robot.FindWinControl(typeof(WinText), name, _root);
            Assert.AreEqual(text.DisplayText, assertValue);
        }
    }
}
