using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class RestaurantSideForm : Form
    {
        const string MEAL = "meal";
        const string CATEGORY = "category";
        Model _model = new Model();
        const int INITIALIZE = 0;
        const int ADD = 1;
        const int DELETE = 2;
        const int EDIT = 3;
        int _mealFlag = 0;
        int _categoryFlag = 0;

        public RestaurantSideForm(Model model)
        {
            _model = model;
            InitializeComponent();
            ResetMealListBox();
            ResetCategoryListBox();
            _mealListBox.SelectedIndex = 0;
            _categoryListBox.SelectedIndex = 0;
            _model._changedEventHandler += ModelChanged;
        }

        public void ModelChanged(object sender, EventArgs e)//model改變後客戶端
        {
            //Console.WriteLine("*");
            ControlMealItem();
            ControlCategoryItem();
        }

        private void ResetMealListBox() //將MealListBox重製
        {            
            _mealListBox.Items.Clear();
            int index;
            for (index = 0; index < _model.GetMeal().Count; index++)
            {
                _mealListBox.Items.Add(_model.GetMeal()[index].GetMealName());
            }
        }

        private void ResetMealGroupBox() //清空MealGroupBox
        {
            _mealNameTextBox.Text = "";
            _mealPriceTextBox.Text = "";
            _mealImagePathTextBox.Text = "";
            _mealDescriptionTextBox.Text = "";
            _mealCategoryComboBox.Items.Clear();
            int index;
            for (index = 0; index < _model.GetCategory().Count; index++)
            {
                _mealCategoryComboBox.Items.Add(_model.GetCategory()[index].GetCategoryName());
            }
            _mealCategoryComboBox.SelectedIndex = 0;
        }

        private void MealListBoxSelectedIndexChangedEventHandler(object sender, EventArgs e)//MealListBox改變時觸發
        {            
            if (_mealListBox.SelectedIndex == -1 && _mealFlag != ADD) 
            {
                _mealFlag = INITIALIZE;
            }
            else if (_mealListBox.SelectedIndex != -1)
                _mealFlag = EDIT;
            ControlMealItem();
        }

        private void UpdateMealGroupBox() //更新MealGroupBox
        {
            _mealGroupBox.Text = MEAL;
            _mealNameTextBox.Text = _model.GetMeal()[_mealListBox.SelectedIndex].GetMealName();
            _mealPriceTextBox.Text = _model.GetMeal()[_mealListBox.SelectedIndex].GetMealPrice().ToString();
            _mealImagePathTextBox.Text = _model.GetMeal()[_mealListBox.SelectedIndex].GetMealImage();
            _mealDescriptionTextBox.Text = _model.GetMeal()[_mealListBox.SelectedIndex].GetMealDescription();
            _mealCategoryComboBox.Items.Clear();
            int index;
            for (index = 0; index < _model.GetCategory().Count; index++)
            {
                _mealCategoryComboBox.Items.Add(_model.GetCategory()[index].GetCategoryName());
                if (_model.GetCategory()[index].GetCategoryNumber() == _model.GetMeal()[_mealListBox.SelectedIndex].GetCategoryNumber())
                    _mealCategoryComboBox.SelectedIndex = index;
            }
        }

        private void SaveMealButtonClickEventHandler(object sender, EventArgs e)//save按下觸發
        {

            if (_mealFlag == ADD)
            {
                AddNewMeal();
                _mealFlag = INITIALIZE;
            }
            else if (_mealFlag == EDIT)
            {
                EditMeal();
                _mealFlag = INITIALIZE;
            }
            ControlMealItem();
            _model.ChangeModel();
        }

        private void AddNewMeal()//新增餐點
        {
            int temporary;
            if (_model.GetMeal().Count == 0)
                temporary = 0;
            else 
                temporary = _model.GetMeal()[_model.GetMeal().Count - 1].GetNumber() + 1;
            _model.AddAllMealList(_mealNameTextBox.Text, int.Parse(_mealPriceTextBox.Text), temporary, _mealDescriptionTextBox.Text, _mealImagePathTextBox.Text, _model.GetCategory()[_mealCategoryComboBox.SelectedIndex].GetCategoryNumber());            
        }

        private void EditMeal()//編輯餐點
        {
            _model.GetMeal()[_mealListBox.SelectedIndex].SetMealName(_mealNameTextBox.Text);
            _model.GetMeal()[_mealListBox.SelectedIndex].SetMealPrice(int.Parse(_mealPriceTextBox.Text));
            _model.GetMeal()[_mealListBox.SelectedIndex].SetMealImage(_mealImagePathTextBox.Text);
            _model.GetMeal()[_mealListBox.SelectedIndex].SetMealDescription(_mealDescriptionTextBox.Text);
            _model.GetMeal()[_mealListBox.SelectedIndex].SetCategoryNumber(_model.GetCategory()[_mealCategoryComboBox.SelectedIndex].GetCategoryNumber());
        }

        private void AddMealButtonClickEventHandler(object sender, EventArgs e)//Add按下觸發
        {
            _mealFlag = ADD;
            ControlMealItem();
            _model.ChangeModel();
        }

        private void BrowseButtonClickEventHandler(object sender, EventArgs e)//Browse按下觸發
        {
            _openImageDialog = new System.Windows.Forms.OpenFileDialog();
            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            _openImageDialog.InitialDirectory = projectPath;
            _openImageDialog.Multiselect = false;
            _openImageDialog.Filter = "Image|*.png;*.jpg;*.jpeg";
            DialogResult result = _openImageDialog.ShowDialog();
            if (result == DialogResult.OK)
            {                
                _mealImagePathTextBox.Text = _openImageDialog.FileName;                
            }            
        }

        private void DeleteMealButtonClickEventHandler(object sender, EventArgs e)//Delete按下觸發
        {
            _mealFlag = DELETE;
            _model.DeleteMeal(_mealListBox.SelectedIndex);
            ControlMealItem();
            _model.ChangeModel();
        }
        
        private void ControlMealItem()//選擇目前狀態
        {
            switch (_mealFlag)
            {
                case INITIALIZE:
                    _addMealButton.Enabled = true;
                    _deleteMealButton.Enabled = false;
                    _mealListBox.SelectedIndex = -1;
                    _saveMealButton.Enabled = false;
                    ResetMealListBox();
                    ResetMealGroupBox();
                    _mealGroupBox.Text = MEAL;
                    break;
                case ADD:
                    _addMealButton.Enabled = false;
                    _deleteMealButton.Enabled = false;
                    _mealListBox.SelectedIndex = -1;
                    _saveMealButton.Enabled = false;
                    ResetMealGroupBox();
                    _mealGroupBox.Text = "Add New Meal";     
                    break;
                case DELETE:
                    _addMealButton.Enabled = true;
                    _deleteMealButton.Enabled = false;
                    _mealListBox.SelectedIndex = -1;
                    _saveMealButton.Enabled = false;
                    ResetMealListBox();
                    ResetMealGroupBox();
                    _mealGroupBox.Text = MEAL;
                    break;
                case EDIT:
                    _addMealButton.Enabled = true;                    
                    _deleteMealButton.Enabled = !_model.IsMealOrdered(_mealListBox.SelectedIndex);                                                        
                    _saveMealButton.Enabled = false;
                    UpdateMealGroupBox();
                    _mealGroupBox.Text = MEAL;
                    break;
            }
        }

        private void MealTextChangedEventHandler(object sender, EventArgs e)//Text改變觸發
        {
            if (_mealNameTextBox.Text == "" || _mealPriceTextBox.Text == "" || _mealImagePathTextBox.Text == "" || _mealDescriptionTextBox.Text == "")            
                _saveMealButton.Enabled = false;            
            else if (_mealFlag != INITIALIZE) 
                _saveMealButton.Enabled = true;
        }
        /// <summary>
        /// ////////////////////////////////////////////////
        /// </summary>

        private void ResetCategoryGroupBox()//重製CategoryGroupBox
        {
            _categoryNameTextBox.Text = "";
            _usingListBox.Items.Clear();
        }

        private void ResetCategoryListBox()//重製CategoryListBox
        {
            _categoryListBox.Items.Clear();
            int index;
            for (index = 0; index < _model.GetCategory().Count; index++)
            {
                _categoryListBox.Items.Add(_model.GetCategory()[index].GetCategoryName());
            }            
        }

        private void UpdateCategoryGroupBox()//更新CategoryGroupBox
        {
            RestaurantUpdateForm restaurantUpdateForm = new RestaurantUpdateForm();
            restaurantUpdateForm.UpdateCategoryGroupBox(_categoryNameTextBox, _model, _categoryListBox, _usingListBox);            
        }

        private void ChangeCategoryListBoxSelectedIndexEventHandler(object sender, EventArgs e)//CategoryListBox改變觸發
        {
            if (_categoryListBox.SelectedIndex == -1 && _categoryFlag != ADD)
            {
                _categoryFlag = INITIALIZE;
            }
            else if (_categoryListBox.SelectedIndex != -1) 
                    _categoryFlag = EDIT;
            ControlCategoryItem();
        }

        private void SaveCategoryButtonClickEventHandler(object sender, EventArgs e) //Save按下觸發
        {
 
            if (_categoryFlag == ADD)
            {

                AddNewCategory();
                _categoryFlag = INITIALIZE;
            }
            else if (_categoryFlag == EDIT)
            {
                
                EditCategory();
                _categoryFlag = INITIALIZE;
            }
            ControlCategoryItem();
            _model.ChangeModel();
        }

        private void AddCategoryButtonClickEventHandler(object sender, EventArgs e)//Add按下觸發
        {            
            _categoryFlag = ADD;            
            ControlCategoryItem();
            _model.ChangeModel();
        }

        private void DeleteCategoryButtonClickEventHandler(object sender, EventArgs e)//刪除Category
        {
            _categoryFlag = INITIALIZE;
            _model.GetCategory().RemoveAt(_categoryListBox.SelectedIndex);
            ControlMealItem();
            _model.ChangeModel();
        }

        private void AddNewCategory()//新增分類
        {
            int temporary;
            if (_model.GetCategory().Count == 0)
                temporary = 0;
            else 
                temporary = _model.GetCategory()[_model.GetCategory().Count - 1].GetCategoryNumber() + 1;
            
            _model.AddAllCategoryList(_categoryNameTextBox.Text, temporary);
        }

        private void EditCategory()//編輯分類
        {
            _model.GetCategory()[_categoryListBox.SelectedIndex].SetCategoryName(_categoryNameTextBox.Text);
        }
        
        private void ControlCategoryItem()//選擇狀態
        {
            switch (_categoryFlag)
            {
                case INITIALIZE:
                    _addCategoryButton.Enabled = true;                    
                    _categoryListBox.SelectedIndex = -1;
                    _saveCategoryButton.Enabled = false;
                    _deleteCategoryButton.Enabled = false;
                    ResetCategoryGroupBox();
                    ResetCategoryListBox();
                    _categoryGroupBox.Text = CATEGORY;
                    break;
                case ADD:
                    _addCategoryButton.Enabled = false;                    
                    _categoryListBox.SelectedIndex = -1;
                    _saveCategoryButton.Enabled = false;
                    _deleteCategoryButton.Enabled = false;
                    ResetCategoryGroupBox();
                    _categoryGroupBox.Text = "Add New Category";
                    break;
                case DELETE:
                    _addCategoryButton.Enabled = true;                    
                    _categoryListBox.SelectedIndex = -1;
                    _saveCategoryButton.Enabled = false;
                    _deleteCategoryButton.Enabled = false;
                    ResetCategoryGroupBox();
                    ResetCategoryListBox();
                    break;
                case EDIT:
                    _addCategoryButton.Enabled = true;                                        
                    _saveCategoryButton.Enabled = false;
                    _deleteCategoryButton.Enabled = !_model.IsCategoryOrdered(_categoryListBox.SelectedIndex);
                    UpdateCategoryGroupBox();
                    _categoryGroupBox.Text = CATEGORY;
                    break;
            }
        }

        private void ChangeCategoryTextEventHandler(object sender, EventArgs e)//CategoryText改變觸發
        {
            if (_categoryNameTextBox.Text == "")            
                _saveCategoryButton.Enabled = false;            
            else if (_categoryFlag != INITIALIZE) 
                _saveCategoryButton.Enabled = true;
        }
    }
}
