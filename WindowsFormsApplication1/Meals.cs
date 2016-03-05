using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Meals
    {
        int _number;
        string _mealName;
        int _mealPrice; //Unit Price
        string _mealDescription;
        string _mealImage;
        int _categoryNumber;        

        public Meals()
        {
            
        }

        public void SetMealName(string name)   //設定菜名
        {
            _mealName = name;
        }

        public string GetMealName()//取得菜名
        {
            return _mealName;
        }
        
        public void SetMealPrice(int price)//設定價錢
        {
            _mealPrice = price;
        }

        public int GetMealPrice()//取得價錢
        {
            return _mealPrice;
        }

        public void SetNumber(int number)//設定菜單編號
        {
            _number = number;
        }

        public int GetNumber()//取得菜單編號
        {
            return _number;
        }

        public void SetMealDescription(string description)//設定餐點介紹
        {
            _mealDescription = description;
        }

        public string GetMealDescription()//取得餐點介紹
        {
            return _mealDescription;
        }

        public void SetMealImage(string image)//設定餐點圖片
        {
            _mealImage = image;
        }

        public string GetMealImage()//取得菜名
        {
            return _mealImage;
        }

        public void SetCategoryNumber(int categoryNumber)//設定餐點圖片
        {
            _categoryNumber = categoryNumber;
        }

        public int GetCategoryNumber()//取得分類編號
        {
            return _categoryNumber;
        }
    }
}
