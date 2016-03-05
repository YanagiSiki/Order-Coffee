using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{    
    public class InitializeModelData
    {
        const  string SIGN = "\\";
        const string TEXT = ".txt";
        const string IMAGE_TYPE = ".jpg";
        const int FOUR = 4;
        const int THREE = 3;
        const int TWO = 2;
        const string MEAL_FILE = "MealFile";
        const string CATEGORY_FILE = "CategoryFile";
        string _projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        const string ERROR = "The file could not be read:";
        List<Order> _yourOrderMealsList = new List<Order>();
        List<Meals> _allMealsList = new List<Meals>();
        List<Category> _allCategory = new List<Category>();
        public InitializeModelData(List<Order> yourOrderMealsList, List<Meals> allMealsList, List<Category> allCategory)
        {
            this._yourOrderMealsList = yourOrderMealsList;
            this._allMealsList = allMealsList;
            this._allCategory = allCategory;
            InitializeCategory();
            InitializeMeal();              
        }
        public void InitializeCategory()//初始化分類
        {
            List<string> fileData = new List<string>();
            fileData = ReadFile(CATEGORY_FILE);
            string categoryName;
            int categoryNumber;
            int index = 0;

            for (index = 0; index < fileData.Count / TWO; index++)
            {
                categoryName = fileData[TWO * index + 0];
                categoryNumber = int.Parse(fileData[TWO * index + 1]);
                AddAllCategoryList(categoryName, categoryNumber);
            }
        }

        public void AddAllCategoryList(string categoryName, int categoryNumber)//新增分類
        {
            Category categorys = new Category();
            categorys.SetCategoryName(categoryName);
            categorys.SetCategoryNumber(categoryNumber);
            _allCategory.Add(categorys);
        }

        public List<string> ReadFile(string fileName)//讀Meal檔
        {            
            List<string> fileData = new List<string>();
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(_projectPath + SIGN + fileName + TEXT, System.Text.Encoding.Default))//亂碼處理取自http://endlesslive.blogspot.tw/_two007/07/streamreader.html
                {
                    while (!sr.EndOfStream)     //參考自http://blog.xuite.net/autosun/study/3_two576568-%5BC%_two3%5D+%E6%AA%9_four%E6%A1%88%E8%AE%80%E5%AF%AB
                    {
                        String line = sr.ReadLine();
                        //Console.WriteLine(line);
                        fileData.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(ERROR);
                Console.WriteLine(e.Message);
            }
            return fileData;
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

        public void InitializeMeal() //菜單初始化
        {
            List<string> fileData = new List<string>();
            fileData = ReadFile(MEAL_FILE);
            string name;
            int price;
            string description;
            int categoryNumber;
            int index = 0;
            const string IMAGE_RELATIVE_PATH = "/Resources/";
            for (index = 0; index < fileData.Count / FOUR; index++)
            {
                name = fileData[FOUR * index + 0];
                price = int.Parse(fileData[FOUR * index + 1]);
                description = fileData[FOUR * index + TWO];
                categoryNumber = int.Parse(fileData[FOUR * index + THREE]);
                AddAllMealList(name, price, index, description, _projectPath + IMAGE_RELATIVE_PATH + index.ToString() + IMAGE_TYPE, categoryNumber);
            }
            
        }
        
    }
}
