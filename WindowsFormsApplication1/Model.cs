using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public class Model
    {
        const string PAGE = "Page ";
        const string SIGN = "/";
        public delegate void ModelChangedEventHandler(object sender, EventArgs e);
        public event ModelChangedEventHandler _changedEventHandler;        
        const int TEN = 10;
        List<Order> _yourOrderMealsList = new List<Order>();
        List<Meals> _allMealsList = new List<Meals>();
        List<Category> _allCategory = new List<Category>();
        public int _allPage = 0;
        public int _thisPage = 1;               

        public Model()
        {
            InitializeModelData initializeModelData = new InitializeModelData(_yourOrderMealsList, _allMealsList, _allCategory);            
            _thisPage = 1;
            CalculateAllPage(0);           
        }

        public void AddAllMealList(string name, int price, int number, string description, string image, int categoryNumber) //增加餐點
        {            
            Meals meals = new Meals();
            meals.SetMealName(name);
            meals.SetMealPrice(price);
            meals.SetNumber(number);
            meals.SetMealDescription(description);
            meals.SetMealImage(image);
            meals.SetCategoryNumber(categoryNumber);
            _allMealsList.Add(meals);
        }

        public void AddAllCategoryList(string categoryName, int categoryNumber)//新增分類
        {
            Category categorys = new Category();
            categorys.SetCategoryName(categoryName);
            categorys.SetCategoryNumber(categoryNumber);
            _allCategory.Add(categorys);
        }

        public void AddOrderMealToList(int number) //點菜
        {
            int index;
            for (index = 0; index < _yourOrderMealsList.Count; index++)
            {
                if (_yourOrderMealsList[index].GetNumber() == number)
                {
                    _yourOrderMealsList[index].AddQuantity();
                    break;
                }
            }
            if (index == _yourOrderMealsList.Count)
            {
                Order order = new Order();
                order.SetNumber(number);
                order.AddQuantity();
                _yourOrderMealsList.Add(order);
            }
        }        

        public void CalculateAllPage(int categoryNumber)//計算總頁數
        {
            _allPage = CreateTemporaryList(categoryNumber).Count / TEN + 1;
        }
        
        public string GoReturnPage() //回傳頁數，顯示於label
        {
            return PAGE + _thisPage + SIGN + _allPage;
        }

        public bool ChangePageNextButton() //換頁時Button的變化
        {
            if (_thisPage == _allPage)
                return false;
            else
                return true;            
        }

        public bool ChangePagePreviousButton() //換頁時Button的變化
        {
            if (_thisPage == 1)
                return false;
            else
                return true;
        }

        public void AddPage() //下一頁
        { 
            _thisPage++;
        }

        public void ReducePage() //上一頁
        {
            _thisPage--;
        }

        public Meals CheckOrderNumberToMeal(int orderNumber) //根據Order的號碼取得Meal物件
        {
            int index = 0;

            for (index = 0; index < _allMealsList.Count; index++)
            {

                if (orderNumber == _allMealsList[index].GetNumber())
                    break;
            }            
            return _allMealsList[index];
        }

        public bool IsCheckOrderNumberToMeal(int orderNumber) //根據Order編號取得Meal物件前，先確定菜單是否有被刪掉
        {
            int index = 0;

            for (index = 0; index < _allMealsList.Count; index++)
            {

                if (orderNumber == _allMealsList[index].GetNumber())
                    break;
            }
            if (index == _allMealsList.Count)
            {
                return false;
            }
            return true;
        }

        public Category CheckCategoryNumberToMeal(int number) //根據Order編號取得Category物件
        {
            int index = 0;

            for (index = 0; index < _allCategory.Count; index++)
            {

                if (number == _allCategory[index].GetCategoryNumber())
                    break;
            }

            return _allCategory[index];
        }
       
        public void DeleteOrder(int number) //取消點餐
        {
            _yourOrderMealsList.RemoveAt(number);
        }

        public void DeleteCategory(int number) //刪除分類
        {
            _allCategory.RemoveAt(number);
        }

        public void DeleteMeal(int number) //刪除餐點
        {
            _allMealsList.RemoveAt(number);
        }

        public bool IsCategoryOrdered(int number) //分類是否正在使用中
        {
            int index;
            for (index = 0; index < _yourOrderMealsList.Count; index++) 
            {
                if (CheckOrderNumberToMeal(_yourOrderMealsList[index].GetNumber()).GetCategoryNumber() == number) 
                {
                    return true;
                }
            }
                return false;
        }

        public bool IsMealOrdered(int number) //餐點是否正在使用中
        {
            int index;
            for (index = 0; index < _yourOrderMealsList.Count; index++)
            {
                if (_yourOrderMealsList[index].GetNumber() == _allMealsList[number].GetNumber())
                {
                    return true;
                }
            }
            return false;
        }

        public List<Meals> CreateTemporaryList(int category) //取得Temporary Meals資料
        {
            int index = 0;
            List<Meals> temporaryMealsList = new List<Meals>();
            for (index = 0; index < _allMealsList.Count; index++)
            {
                if (_allMealsList[index].GetCategoryNumber() == category)
                    temporaryMealsList.Add(_allMealsList[index]);
            }
            return temporaryMealsList;
        }       

        public List<Order> GetOrder() //取得整筆Order資料
        {
            return _yourOrderMealsList;
        }

        public List<Meals> GetMeal() //取得整筆Meals資料
        {
            return _allMealsList;
        }

        public List<Category> GetCategory() //取得整筆Category資料
        {
            return _allCategory;
        }

        public void ChangeModel() //model改變時觸發
        {
            if (_changedEventHandler != null)
                _changedEventHandler(this, new EventArgs());
        }
    }
}
