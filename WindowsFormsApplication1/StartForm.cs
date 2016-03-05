using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class StartForm : Form
    {

        Model _model = new Model();
        public StartForm()
        {
            InitializeComponent();
        }

        private void ClickCustomerEventHandler(object sender, EventArgs e)//開啟顧客點餐系統
        {
            POSCustomerSideForm customerForm = new POSCustomerSideForm(_model);
            customerForm.FormClosed += CloseCustomerFormEventHandler;
            customerForm.Show();
            _customer.Enabled = false;
        }

        void CloseCustomerFormEventHandler(object sender, FormClosedEventArgs e)//關閉顧客點餐系統
        {
            Form smellForm = (Form)sender;
            if (smellForm.Name == "POSCustomerSideForm")
            _customer.Enabled = true;
        }

        private void ClickEmployeeEventHandler(object sender, EventArgs e)//開啟餐廳員工系統
        {
            RestaurantSideForm restaurantForm = new RestaurantSideForm(_model);
            restaurantForm.FormClosed += CloseRestaurantFormFormEventHandler;
            restaurantForm.Show();
            _employee.Enabled = false;
        }

        void CloseRestaurantFormFormEventHandler(object sender, FormClosedEventArgs e)//關閉餐廳員工系統
        {
            Form smellForm = (Form)sender;
            if (smellForm.Name == "PDSRestaurantSideForm")
                _employee.Enabled = true;
        }

        private void ExitButtonClickEventHandler(object sender, EventArgs e)//系統關閉
        {
            this.Close();
        }
    }
}
