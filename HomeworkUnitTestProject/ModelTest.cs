using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System.IO;
using System.Collections.Generic;

namespace HomeworkUnitTestProject
{
    [TestClass]
    public class ModelTest
    {
        string _projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        Model _target = new Model();

        [TestMethod]
        public void InitializeModel()
        {
            Model model = new Model();
            _target = model;            
        }

        [TestMethod]
        public void AddMeal()
        {            
            Assert.AreEqual(9, _target.GetMeal().Count);
            _target.AddAllMealList("冰摩卡", 125, _target.GetMeal().Count,"冰摩卡 Iced Caffé Mocha",_projectPath + "/Resources/0.jpg", 0);
            Assert.AreEqual("冰摩卡", _target.GetMeal()[_target.GetMeal().Count - 1].GetMealName());
            Assert.AreEqual(125, _target.GetMeal()[_target.GetMeal().Count - 1].GetMealPrice());
            Assert.AreEqual("冰摩卡 Iced Caffé Mocha", _target.GetMeal()[_target.GetMeal().Count - 1].GetMealDescription());
            Assert.AreEqual(_projectPath + "/Resources/0.jpg", _target.GetMeal()[_target.GetMeal().Count - 1].GetMealImage());
            Assert.AreEqual(0, _target.GetMeal()[_target.GetMeal().Count - 1].GetCategoryNumber());
            Assert.AreEqual(10, _target.GetMeal().Count);
        }

        [TestMethod]
        public void AddCategory()
        {
            Assert.AreEqual(1, _target.GetCategory().Count);
            _target.AddAllCategoryList("星冰樂",1);
            Assert.AreEqual("星冰樂", _target.GetCategory()[_target.GetCategory().Count - 1].GetCategoryName());
            Assert.AreEqual(1, _target.GetCategory()[_target.GetCategory().Count - 1].GetCategoryNumber());
        }

        [TestMethod]
        public void AddOrder()
        {
            _target.AddOrderMealToList(0);
            Assert.AreEqual(_target.GetMeal()[0].GetNumber(), _target.GetOrder()[0].GetNumber());
            Assert.AreEqual(1, _target.GetOrder()[0].GetQuantity());
            _target.AddOrderMealToList(0);
            Assert.AreEqual(2, _target.GetOrder()[0].GetQuantity());
            _target.GetOrder()[0].SetQuantity(10);
            Assert.AreEqual(10, _target.GetOrder()[0].GetQuantity());
            _target.AddOrderMealToList(1);
            Assert.AreEqual(2, _target.GetOrder().Count);
        }
        [TestMethod]
        public void CalculatePage()
        {            
            _target.CalculateAllPage(0);
            Assert.AreEqual(1, _target._allPage);
            Assert.AreEqual("Page 1/1", _target.GoReturnPage());
            _target._allPage = 2;
            Assert.AreEqual(true, _target.ChangePageNextButton());
            Assert.AreEqual(false, _target.ChangePagePreviousButton());
            _target.AddPage();
            Assert.AreEqual(false, _target.ChangePageNextButton());
            Assert.AreEqual(true, _target.ChangePagePreviousButton());
            _target.ReducePage();
            Assert.AreEqual(true, _target.ChangePageNextButton());
            Assert.AreEqual(false, _target.ChangePagePreviousButton());
            _target.CalculateAllPage(0);
        }

        [TestMethod]
        public void CheckMealNumber()
        {
            Assert.AreEqual(true, _target.IsCheckOrderNumberToMeal(0));
            Assert.AreEqual(false, _target.IsCheckOrderNumberToMeal(10));
            Assert.AreEqual(_target.GetMeal()[0], _target.CheckOrderNumberToMeal(0));
        }

        [TestMethod]
        public void CheckCategoryNumber()
        {            
            Assert.AreEqual(_target.GetCategory()[0], _target.CheckCategoryNumberToMeal(0));            
        }
        [TestMethod]
        public void DeleteOrder()
        {
            _target.AddAllMealList("冰摩卡", 125, _target.GetMeal().Count, "冰摩卡 Iced Caffé Mocha", _projectPath + "/Resources/0.jpg", 0);         
            Assert.AreEqual(0, _target.GetOrder().Count);
            Assert.AreEqual(false, _target.IsMealOrdered(0));
            _target.AddOrderMealToList(0);
            _target.AddOrderMealToList(1);
            Assert.AreEqual(2, _target.GetOrder().Count);
            Assert.AreEqual(true, _target.IsMealOrdered(0));
            Assert.AreEqual(true, _target.IsMealOrdered(1));
            _target.DeleteOrder(0);
            Assert.AreEqual(1, _target.GetOrder().Count);
        }

        [TestMethod]
        public void DeleteCategory()
        {
            _target.AddAllCategoryList("星冰樂", 1);
            _target.AddAllMealList("摩卡星冰樂", 130, _target.GetMeal().Count, "摩卡星冰樂 Mocha Frappuccino® Blended Beverage", _projectPath + "/Resources/0.jpg", 1);            
            Assert.AreEqual(false, _target.IsCategoryOrdered(0));
            Assert.AreEqual(false, _target.IsCategoryOrdered(1));
            _target.AddOrderMealToList(0);
            _target.AddOrderMealToList(9);            
            Assert.AreEqual(true, _target.IsCategoryOrdered(0));
            Assert.AreEqual(true, _target.IsCategoryOrdered(1));
            _target.DeleteOrder(0);
            Assert.AreEqual(false, _target.IsCategoryOrdered(0));
            _target.DeleteCategory(0);            
        }
        [TestMethod]
        public void ReadFileException()
        {
            List<Order> _yourOrderMealsList = new List<Order>();
            List<Meals> _allMealsList = new List<Meals>();
            List<Category> _allCategory = new List<Category>();
            InitializeModelData initializeModelData = new InitializeModelData(_yourOrderMealsList, _allMealsList, _allCategory);
            initializeModelData.ReadFile("Not Exist File");
        }
        [TestMethod]
        public void ChangeModel()
        {
            _target.ChangeModel();
            _target._changedEventHandler += _target__changedEventHandler;
            _target.ChangeModel();
        }

        void _target__changedEventHandler(object sender, EventArgs e)
        {
            
        }

        
    }
}
