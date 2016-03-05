using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Order
    {
        int _number;
        int _quantity;
        public void SetNumber(int number) //設定菜單編號
        {
            _number = number;
        }

        public int GetNumber()//取得菜單編號
        {
            return _number;
        }

        public void AddQuantity() //數量+1
        {
            _quantity++;
        }

        public void SetQuantity(int quantity) //數量+1
        {
            _quantity = quantity;
        }

        public int GetQuantity() //取得數量
        {
            return _quantity;
        }
    }
}
