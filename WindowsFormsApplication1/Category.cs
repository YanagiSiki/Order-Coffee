using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Category
    {
        int _categoryNumber;
        string _categoryName;

        public void SetCategoryNumber(int number)   //設定編號
        {
            _categoryNumber = number;
        }

        public int GetCategoryNumber()   //取得編號
        {
            return _categoryNumber;
        }

        public void SetCategoryName(string categoryName)   //設定分類名
        {
            _categoryName = categoryName;
        }

        public string GetCategoryName()   //取得分類名
        {
            return _categoryName;
        }
    }
}
