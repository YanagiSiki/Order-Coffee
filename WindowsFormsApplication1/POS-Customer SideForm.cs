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
    public partial class POSCustomerSideForm : Form
    {
        const int NINE = 9;
        const int ONE_TWO_ZERO = 120;
        const int THREE = 3;
        Button[] _allButtonList = new Button[NINE];
        TabControl _tabControl1 = new TabControl();
        Model _model = new Model();
        public POSCustomerSideForm(Model model)
        {
            _model = model;
            InitializeComponent();
            InitializeTabControl();
            InitializeButton();
            _page.Text = _model.GoReturnPage();
            _previousButton.Enabled = false; //previous 
            _previousButton.Enabled = _model.ChangePagePreviousButton();
            _nextButton.Enabled = _model.ChangePageNextButton();            
            _tabControl1.SelectedIndex = 0;//初始化page的SelectedIndex
            UpdateAllButton(int.Parse(_tabControl1.TabPages[_tabControl1.SelectedIndex].Tag.ToString()));
            UpdateAllControlPage();
            _model._changedEventHandler += ModelChanged;
        }

        public void ModelChanged(object sender, EventArgs e)//model改變後客戶端
        {
            ResetAllControlPage();
            UpdateAllControlPage();
            _model.CalculateAllPage(int.Parse(_tabControl1.TabPages[_tabControl1.SelectedIndex].Tag.ToString()));
            UpdateAllButton(int.Parse(_tabControl1.TabPages[_tabControl1.SelectedIndex].Tag.ToString()));
            UpdateRecordDataGridView();
            _previousButton.Enabled = _model.ChangePagePreviousButton();
            _nextButton.Enabled = _model.ChangePageNextButton();      
            _page.Text = _model.GoReturnPage();
        }

        void ChangeTabControl1SelectedIndexEventHandler(object sender, EventArgs e)//選擇不同page觸發
        {
            if (_tabControl1.SelectedIndex == -1) 
                return;            
            UpdateAllControlPage();
            _model.CalculateAllPage(int.Parse(_tabControl1.TabPages[_tabControl1.SelectedIndex].Tag.ToString()));
            _model._thisPage = 1;
            _previousButton.Enabled = _model.ChangePagePreviousButton();
            _nextButton.Enabled = _model.ChangePageNextButton();      
            UpdateAllButton(int.Parse(_tabControl1.TabPages[_tabControl1.SelectedIndex].Tag.ToString()));
            _page.Text = _model.GoReturnPage();
        }

        private void UpdateAllControlPage()//將處理好的button放到選取的page
        {
            CustomerUpdateForm customerUpdateForm = new CustomerUpdateForm();
            customerUpdateForm.UpdateAllControlPage(_tabControl1, _allButtonList);          
        }

        private void InitializeTabControl()//初始化TabControl
        {
            _tabControl1.Location = new Point(10, 20);
            _tabControl1.Size = new Size(380, 320);
            _tabControl1.SelectedIndexChanged += ChangeTabControl1SelectedIndexEventHandler;
            _meals.Controls.Add(_tabControl1);
            ResetAllControlPage();
        }

        private void ResetAllControlPage()//把page砍掉重練
        {
            _tabControl1.TabPages.Clear();
            int index;
            for (index = 0; index < _model.GetCategory().Count; index++)
            {
                AddControlPageList(_model.GetCategory()[index].GetCategoryName(), _model.GetCategory()[index].GetCategoryNumber());
            }
            //tabControl1.SelectedIndex = 0;
        }

        private void AddControlPageList(string name, int number)//將新增的page放到Tabcontrol，包含加入tabPage.Tag、tabPage.Text
        {
            TabPage tabPage = new TabPage();
            tabPage.Tag = number;
            tabPage.Text = name;
            _tabControl1.TabPages.Add(tabPage);
        }

        private void InitializeButton()//將按鈕初始化，包含加入座標、名稱、tag
        {
            int index = 0;
            for (index = 0; index < NINE; index++)
            {
                _allButtonList[index] = new Button();
                _allButtonList[index].Name = "button" + index;
                _allButtonList[index].Location = new Point(ONE_TWO_ZERO * (index % THREE), 100 * (index / THREE));
                _allButtonList[index].Width = ONE_TWO_ZERO;
                _allButtonList[index].Height = 80;
                _allButtonList[index].Click += ClickPOSCustomerSideFormEventHandler;
                _allButtonList[index].MouseEnter += EnterPOSCustomerSideFormMouseEventHandler;
                _allButtonList[index].MouseLeave += LeavePOSCustomerSideFormMouseEventHandler;
                _allButtonList[index].Tag = index;
            }
        }

        private void LeavePOSCustomerSideFormMouseEventHandler(object sender, EventArgs e) //滑鼠游標移出物件後觸發
        {
            _description.Text = "";
        }

        private void EnterPOSCustomerSideFormMouseEventHandler(object sender, EventArgs e)//鼠標移入物件後觸發
        {
            Button button = (Button)sender;
            _description.Text = _model.CheckOrderNumberToMeal(int.Parse(button.Tag.ToString())).GetMealDescription();
        }

        public void ClickPOSCustomerSideFormEventHandler(object sender, EventArgs e)//按鈕後觸發按下
        {
            Button button = (Button)sender;
            _model.AddOrderMealToList(int.Parse(button.Tag.ToString()));
            UpdateRecordDataGridView();
            _model.ChangeModel();
        }

        private void GoPreviousButtonClickEventHandler(object sender, EventArgs e)//上一頁
        {
            _model.ReducePage();
            _previousButton.Enabled = _model.ChangePagePreviousButton();
            _nextButton.Enabled = _model.ChangePageNextButton();      
            UpdateAllButton(int.Parse(_tabControl1.TabPages[_tabControl1.SelectedIndex].Tag.ToString()));
            _page.Text = _model.GoReturnPage();
        }

        private void GoNextButtonClickEventHandler(object sender, EventArgs e)//下一頁
        {
            _model.AddPage();
            _previousButton.Enabled = _model.ChangePagePreviousButton();
            _nextButton.Enabled = _model.ChangePageNextButton();      
            UpdateAllButton(int.Parse(_tabControl1.TabPages[_tabControl1.SelectedIndex].Tag.ToString()));
            _page.Text = _model.GoReturnPage();
        }

        public void UpdateRecordDataGridView() //更新DGV資訊
        {
            CustomerUpdateForm customerUpdateForm = new CustomerUpdateForm();
            customerUpdateForm.UpdateDataGridView(_recordDataGridView, _model, _total);
        }

        public void UpdateAllButton(int number) //依據頁數不同以及tabpage來更新按鈕
        {
            CustomerUpdateForm customerUpdateForm = new CustomerUpdateForm();
            customerUpdateForm.UpdateAllButton(number, _model, _allButtonList);            
        }

        private void ClickRecordDataGridViewCellContentEventHandler(object sender, DataGridViewCellEventArgs e)//改變Qty後觸發
        {
            if (e.ColumnIndex == 0)
            {
                _model.DeleteOrder(e.RowIndex);
            }
            UpdateRecordDataGridView();
        }

        private void ChangeRecordDataGridViewCellValueEventHandler(object sender, DataGridViewCellEventArgs e)//當Qty數值改變時觸發
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                _model.GetOrder()[e.RowIndex].SetQuantity(int.Parse(_recordDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString()));
            }
            UpdateRecordDataGridView();
        }
    }
}

//參考資料 https://msdn.microsoft.com/zh-tw/library/bhkz42b3%28v=vs.110%29.aspx