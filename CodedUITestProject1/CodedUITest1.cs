using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using System.IO;
using DataGridViewNumericUpDownElements;



namespace CodedUITestProject1
{
    /// <summary>
    /// CodedUITest1 的摘要描述
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        string _projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        const string TEST_FILE_PATH = "\\WindowsFormsApplication1\\bin\\Debug\\WindowsFormsApplication1.exe";
        private string FILE_PATH = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))) + TEST_FILE_PATH;
        private const string FORM_TITLE = "StartForm";
        const string IMAGE_RELATIVE_PATH = "/Resources/";
        

        [TestInitialize()]
        public void Initialize()
        {

            Robot.Initialize(FILE_PATH, FORM_TITLE);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }


        #region 其他測試屬性

        // 您可以使用下列其他屬性撰寫測試: 

        ////在每項測試執行前先使用 TestInitialize 執行程式碼 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // 若要為這個測試產生程式碼，請在捷徑功能表上選取 [產生自動程式碼 UI 測試的程式碼]，並選取其中一個功能表項目。
        //}

        ////在每項測試執行後使用 TestCleanup 執行程式碼
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // 若要為這個測試產生程式碼，請在捷徑功能表上選取 [產生自動程式碼 UI 測試的程式碼]，並選取其中一個功能表項目。
        //}

        #endregion
        [TestMethod]
        public void TestOpenStartForm() 
        {
            Robot.FindWindow("StartForm");
            Robot.ClickButton("_customer");
            Robot.AssertButtonEnable("_customer", false);
            Robot.ClickButton("_employee");
            Robot.AssertButtonEnable("_employee", false);
            //Robot.ClickButton("_exitButton", "StartForm");
        }

        //Customer

        [TestMethod]
        public void TestPOSCustomerSideFormOrderMeal()
        {
            Robot.FindWindow("StartForm");
            Robot.ClickButton("_customer");

            Robot.FindWindow("POSCustomerSideForm");
            //點餐
            Robot.ClickButton("卡布奇諾" + "\n" + "75" + " NTD");
            Robot.ClickButton("冰那堤" + "\n" + "80" + " NTD");
            Robot.ClickButton("冰美式咖啡" + "\n" + "115" + " NTD");
            Robot.ClickButton("卡布奇諾" + "\n" + "75" + " NTD");
            //確認價錢
            Robot.AssertText("_total", "Total ： 345");
            //增加數量
            Robot.ClickNumericUpDownButtonInDataGridView("_recordDataGridView", 0, 4, Robot.NumericDirect.UP, 1);
            Robot.AssertDataGridViewByIndex("_recordDataGridView", "1", new string [] { "X", "卡布奇諾", "咖啡", "75", "3", "225" });
            Robot.AssertText("_total", "Total ： 420");
            //下一頁、上一頁
            Robot.ClickButton("_nextButton");
            Robot.ClickButton("_previousButton");
            //刪除數量
            Robot.ClickNumericUpDownButtonInDataGridView("_recordDataGridView", 0, 4, Robot.NumericDirect.DOWN, 1);
            Robot.AssertText("_total", "Total ： 345");
            //刪除餐點
            Robot.ClickNumericUpDownButtonInDataGridView("_recordDataGridView", 0, 4, Robot.NumericDirect.UP, 1);
            Robot.ClickDeleteButtonInDataGridView("_recordDataGridView", 1);
            Robot.AssertText("_total", "Total ： 340");

            //Tabpage
            Robot.ClickTabControl("台灣在地茶");
            Robot.ClickButton("紅玉紅茶" + "\n" + "160" + " NTD");
            Robot.AssertText("_total", "Total ： 500");

        }
        

        //Restaurant

        [TestMethod]
        public void TestRestaurantSideFormAddMeal()
        {
            Robot.FindWindow("StartForm");
            Robot.ClickButton("_employee");
            Robot.FindWindow("RestaurantSideForm");
            Robot.AssertEdit("_mealNameTextBox", "卡布奇諾");
            Robot.AssertEdit("_mealPriceTextBox", "75");
            Robot.AssertEdit("_mealCategoryComboBox", "咖啡");            
            Robot.AssertEdit("_mealDescriptionTextBox", "卡布奇諾 Cappuccino");

            Robot.ClickButton("_addMealButton");
            //新增Meal
            Robot.AssertEdit("_mealNameTextBox", "");
            Robot.AssertEdit("_mealPriceTextBox", "");
            Robot.AssertEdit("_mealCategoryComboBox", "咖啡");
            Robot.AssertEdit("_mealImagePathTextBox", "");
            Robot.AssertEdit("_mealDescriptionTextBox", "");

            Robot.SetEdit("_mealNameTextBox", "New Meal");
            Robot.SetEdit("_mealPriceTextBox", "1000");
            Robot.SetEdit("_mealImagePathTextBox", _projectPath + IMAGE_RELATIVE_PATH + "0" + ".jpg");
            Robot.SetEdit("_mealDescriptionTextBox", "This is a New Meal");
            //save
            Robot.ClickButton("_saveMealButton");
            Robot.AssertDataListItem("_mealListBox", 28);
        }


        [TestMethod]
        public void TestRestaurantSideFormDeleteMeal()
        {
            Robot.FindWindow("StartForm");
            Robot.ClickButton("_employee");

            Robot.FindWindow("RestaurantSideForm");
            Robot.AssertDataListItem("_mealListBox", 27);
            //點選List
            Robot.ClickDataListItem("_mealListBox", "2");
            //刪除Meal
            Robot.ClickButton("_deleteMealButton");

            //確認Listbox
            Robot.AssertDataListItem("_mealListBox", 26);

        }

        [TestMethod]
        public void TestRestaurantSideFormAddCategory()
        {
            Robot.FindWindow("StartForm");
            Robot.ClickButton("_employee");

            Robot.FindWindow("RestaurantSideForm");
            Robot.ClickTabControl("Category Manager");
            //新增分類
            Robot.ClickButton("_addCategoryButton");
            Robot.SetEdit("_categoryNameTextBox", "New Meal");
            //save
            Robot.ClickButton("_saveCategoryButton");
            Robot.AssertDataListItem("_categoryListBox", 4);

        }

        [TestMethod]
        public void TestRestaurantSideFormDeleteCategory()
        {
            Robot.FindWindow("StartForm");
            Robot.ClickButton("_employee");

            Robot.FindWindow("RestaurantSideForm");
            Robot.ClickTabControl("Category Manager");
            //點選List
            Robot.ClickDataListItem("_categoryListBox", "2");
            //刪除分類
            Robot.ClickButton("_deleteCategoryButton");

            //確認Listbox
            Robot.AssertDataListItem("_categoryListBox", 2);            
        }
    }
}
