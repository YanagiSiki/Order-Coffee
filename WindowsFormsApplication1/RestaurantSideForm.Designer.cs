namespace WindowsFormsApplication1
{
    partial class RestaurantSideForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._tabControl1 = new System.Windows.Forms.TabControl();
            this._tabPage1 = new System.Windows.Forms.TabPage();
            this._deleteMealButton = new System.Windows.Forms.Button();
            this._addMealButton = new System.Windows.Forms.Button();
            this._mealGroupBox = new System.Windows.Forms.GroupBox();
            this._browseButton = new System.Windows.Forms.Button();
            this._saveMealButton = new System.Windows.Forms.Button();
            this._mealCategoryComboBox = new System.Windows.Forms.ComboBox();
            this._mealDescriptionTextBox = new System.Windows.Forms.TextBox();
            this._mealImagePathTextBox = new System.Windows.Forms.TextBox();
            this._mealPriceTextBox = new System.Windows.Forms.TextBox();
            this._mealNameTextBox = new System.Windows.Forms.TextBox();
            this._mealDescriptionLabel = new System.Windows.Forms.Label();
            this._mealImagePathLabel = new System.Windows.Forms.Label();
            this._mealCategoryLabel = new System.Windows.Forms.Label();
            this._mealPriceLabel = new System.Windows.Forms.Label();
            this._mealNameLabel = new System.Windows.Forms.Label();
            this._mealListBox = new System.Windows.Forms.ListBox();
            this._tabPage2 = new System.Windows.Forms.TabPage();
            this._deleteCategoryButton = new System.Windows.Forms.Button();
            this._categoryGroupBox = new System.Windows.Forms.GroupBox();
            this._saveCategoryButton = new System.Windows.Forms.Button();
            this._usingListBox = new System.Windows.Forms.ListBox();
            this._categoryNameTextBox = new System.Windows.Forms.TextBox();
            this._label2 = new System.Windows.Forms.Label();
            this._categoryNameLabel = new System.Windows.Forms.Label();
            this._addCategoryButton = new System.Windows.Forms.Button();
            this._categoryListBox = new System.Windows.Forms.ListBox();
            this._openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this._tabControl1.SuspendLayout();
            this._tabPage1.SuspendLayout();
            this._mealGroupBox.SuspendLayout();
            this._tabPage2.SuspendLayout();
            this._categoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tabControl1
            // 
            this._tabControl1.AccessibleName = "_tabControl1";
            this._tabControl1.Controls.Add(this._tabPage1);
            this._tabControl1.Controls.Add(this._tabPage2);
            this._tabControl1.Location = new System.Drawing.Point(12, 12);
            this._tabControl1.Name = "_tabControl1";
            this._tabControl1.SelectedIndex = 0;
            this._tabControl1.Size = new System.Drawing.Size(681, 371);
            this._tabControl1.TabIndex = 0;
            // 
            // _tabPage1
            // 
            this._tabPage1.AccessibleName = "_tabPage1";
            this._tabPage1.Controls.Add(this._deleteMealButton);
            this._tabPage1.Controls.Add(this._addMealButton);
            this._tabPage1.Controls.Add(this._mealGroupBox);
            this._tabPage1.Controls.Add(this._mealListBox);
            this._tabPage1.Location = new System.Drawing.Point(4, 22);
            this._tabPage1.Name = "_tabPage1";
            this._tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage1.Size = new System.Drawing.Size(673, 345);
            this._tabPage1.TabIndex = 0;
            this._tabPage1.Text = "Meal Manager";
            this._tabPage1.UseVisualStyleBackColor = true;
            // 
            // _deleteMealButton
            // 
            this._deleteMealButton.AccessibleName = "_deleteMealButton";
            this._deleteMealButton.Location = new System.Drawing.Point(96, 305);
            this._deleteMealButton.Name = "_deleteMealButton";
            this._deleteMealButton.Size = new System.Drawing.Size(75, 23);
            this._deleteMealButton.TabIndex = 3;
            this._deleteMealButton.Text = "Delete";
            this._deleteMealButton.UseVisualStyleBackColor = true;
            this._deleteMealButton.Click += new System.EventHandler(this.DeleteMealButtonClickEventHandler);
            // 
            // _addMealButton
            // 
            this._addMealButton.AccessibleName = "_addMealButton";
            this._addMealButton.Location = new System.Drawing.Point(15, 305);
            this._addMealButton.Name = "_addMealButton";
            this._addMealButton.Size = new System.Drawing.Size(75, 23);
            this._addMealButton.TabIndex = 2;
            this._addMealButton.Text = "Add";
            this._addMealButton.UseVisualStyleBackColor = true;
            this._addMealButton.Click += new System.EventHandler(this.AddMealButtonClickEventHandler);
            // 
            // _mealGroupBox
            // 
            this._mealGroupBox.Controls.Add(this._browseButton);
            this._mealGroupBox.Controls.Add(this._saveMealButton);
            this._mealGroupBox.Controls.Add(this._mealCategoryComboBox);
            this._mealGroupBox.Controls.Add(this._mealDescriptionTextBox);
            this._mealGroupBox.Controls.Add(this._mealImagePathTextBox);
            this._mealGroupBox.Controls.Add(this._mealPriceTextBox);
            this._mealGroupBox.Controls.Add(this._mealNameTextBox);
            this._mealGroupBox.Controls.Add(this._mealDescriptionLabel);
            this._mealGroupBox.Controls.Add(this._mealImagePathLabel);
            this._mealGroupBox.Controls.Add(this._mealCategoryLabel);
            this._mealGroupBox.Controls.Add(this._mealPriceLabel);
            this._mealGroupBox.Controls.Add(this._mealNameLabel);
            this._mealGroupBox.Location = new System.Drawing.Point(192, 7);
            this._mealGroupBox.Name = "_mealGroupBox";
            this._mealGroupBox.Size = new System.Drawing.Size(475, 332);
            this._mealGroupBox.TabIndex = 1;
            this._mealGroupBox.TabStop = false;
            this._mealGroupBox.Text = "Meal";
            // 
            // _browseButton
            // 
            this._browseButton.AccessibleName = "_browseButton";
            this._browseButton.Location = new System.Drawing.Point(382, 134);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(75, 23);
            this._browseButton.TabIndex = 7;
            this._browseButton.Text = "Browse";
            this._browseButton.UseVisualStyleBackColor = true;
            this._browseButton.Click += new System.EventHandler(this.BrowseButtonClickEventHandler);
            // 
            // _saveMealButton
            // 
            this._saveMealButton.AccessibleName = "_saveMealButton";
            this._saveMealButton.Location = new System.Drawing.Point(382, 298);
            this._saveMealButton.Name = "_saveMealButton";
            this._saveMealButton.Size = new System.Drawing.Size(75, 23);
            this._saveMealButton.TabIndex = 6;
            this._saveMealButton.Text = "Save";
            this._saveMealButton.UseVisualStyleBackColor = true;
            this._saveMealButton.Click += new System.EventHandler(this.SaveMealButtonClickEventHandler);
            // 
            // _mealCategoryComboBox
            // 
            this._mealCategoryComboBox.AccessibleName = "_mealCategoryComboBox";
            this._mealCategoryComboBox.FormattingEnabled = true;
            this._mealCategoryComboBox.Location = new System.Drawing.Point(310, 68);
            this._mealCategoryComboBox.Name = "_mealCategoryComboBox";
            this._mealCategoryComboBox.Size = new System.Drawing.Size(121, 20);
            this._mealCategoryComboBox.TabIndex = 5;
            // 
            // _mealDescriptionTextBox
            // 
            this._mealDescriptionTextBox.AccessibleDescription = "_mealDescriptionTextBox";
            this._mealDescriptionTextBox.AccessibleName = "_mealDescriptionTextBox";
            this._mealDescriptionTextBox.Location = new System.Drawing.Point(19, 198);
            this._mealDescriptionTextBox.Multiline = true;
            this._mealDescriptionTextBox.Name = "_mealDescriptionTextBox";
            this._mealDescriptionTextBox.Size = new System.Drawing.Size(450, 94);
            this._mealDescriptionTextBox.TabIndex = 4;
            this._mealDescriptionTextBox.TextChanged += new System.EventHandler(this.MealTextChangedEventHandler);
            // 
            // _mealImagePathTextBox
            // 
            this._mealImagePathTextBox.AccessibleName = "_mealImagePathTextBox";
            this._mealImagePathTextBox.Location = new System.Drawing.Point(19, 136);
            this._mealImagePathTextBox.Name = "_mealImagePathTextBox";
            this._mealImagePathTextBox.Size = new System.Drawing.Size(357, 22);
            this._mealImagePathTextBox.TabIndex = 3;
            this._mealImagePathTextBox.TextChanged += new System.EventHandler(this.MealTextChangedEventHandler);
            // 
            // _mealPriceTextBox
            // 
            this._mealPriceTextBox.AccessibleName = "_mealPriceTextBox";
            this._mealPriceTextBox.Location = new System.Drawing.Point(75, 66);
            this._mealPriceTextBox.Name = "_mealPriceTextBox";
            this._mealPriceTextBox.Size = new System.Drawing.Size(70, 22);
            this._mealPriceTextBox.TabIndex = 2;
            this._mealPriceTextBox.TextChanged += new System.EventHandler(this.MealTextChangedEventHandler);
            // 
            // _mealNameTextBox
            // 
            this._mealNameTextBox.AccessibleName = "_mealNameTextBox";
            this._mealNameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this._mealNameTextBox.Location = new System.Drawing.Point(75, 21);
            this._mealNameTextBox.Name = "_mealNameTextBox";
            this._mealNameTextBox.Size = new System.Drawing.Size(100, 22);
            this._mealNameTextBox.TabIndex = 1;
            this._mealNameTextBox.TextChanged += new System.EventHandler(this.MealTextChangedEventHandler);
            // 
            // _mealDescriptionLabel
            // 
            this._mealDescriptionLabel.Location = new System.Drawing.Point(6, 178);
            this._mealDescriptionLabel.Name = "_mealDescriptionLabel";
            this._mealDescriptionLabel.Size = new System.Drawing.Size(97, 17);
            this._mealDescriptionLabel.TabIndex = 0;
            this._mealDescriptionLabel.Text = "Meal Description";
            // 
            // _mealImagePathLabel
            // 
            this._mealImagePathLabel.Location = new System.Drawing.Point(6, 116);
            this._mealImagePathLabel.Name = "_mealImagePathLabel";
            this._mealImagePathLabel.Size = new System.Drawing.Size(97, 17);
            this._mealImagePathLabel.TabIndex = 0;
            this._mealImagePathLabel.Text = "Meal Image Path(*)";
            // 
            // _mealCategoryLabel
            // 
            this._mealCategoryLabel.Location = new System.Drawing.Point(221, 71);
            this._mealCategoryLabel.Name = "_mealCategoryLabel";
            this._mealCategoryLabel.Size = new System.Drawing.Size(97, 20);
            this._mealCategoryLabel.TabIndex = 0;
            this._mealCategoryLabel.Text = "MealCategory(*)";
            // 
            // _mealPriceLabel
            // 
            this._mealPriceLabel.Location = new System.Drawing.Point(6, 71);
            this._mealPriceLabel.Name = "_mealPriceLabel";
            this._mealPriceLabel.Size = new System.Drawing.Size(97, 20);
            this._mealPriceLabel.TabIndex = 0;
            this._mealPriceLabel.Text = "MealPrice(*)";
            // 
            // _mealNameLabel
            // 
            this._mealNameLabel.Location = new System.Drawing.Point(6, 26);
            this._mealNameLabel.Name = "_mealNameLabel";
            this._mealNameLabel.Size = new System.Drawing.Size(97, 17);
            this._mealNameLabel.TabIndex = 0;
            this._mealNameLabel.Text = "MealName(*)";
            // 
            // _mealListBox
            // 
            this._mealListBox.AccessibleName = "_mealListBox";
            this._mealListBox.FormattingEnabled = true;
            this._mealListBox.ItemHeight = 12;
            this._mealListBox.Location = new System.Drawing.Point(6, 7);
            this._mealListBox.Name = "_mealListBox";
            this._mealListBox.Size = new System.Drawing.Size(180, 292);
            this._mealListBox.TabIndex = 0;
            this._mealListBox.SelectedIndexChanged += new System.EventHandler(this.MealListBoxSelectedIndexChangedEventHandler);
            // 
            // _tabPage2
            // 
            this._tabPage2.AccessibleName = "_tabPage2";
            this._tabPage2.Controls.Add(this._deleteCategoryButton);
            this._tabPage2.Controls.Add(this._categoryGroupBox);
            this._tabPage2.Controls.Add(this._addCategoryButton);
            this._tabPage2.Controls.Add(this._categoryListBox);
            this._tabPage2.Location = new System.Drawing.Point(4, 22);
            this._tabPage2.Name = "_tabPage2";
            this._tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage2.Size = new System.Drawing.Size(673, 345);
            this._tabPage2.TabIndex = 1;
            this._tabPage2.Text = "Category Manager";
            this._tabPage2.UseVisualStyleBackColor = true;
            // 
            // _deleteCategoryButton
            // 
            this._deleteCategoryButton.AccessibleName = "_deleteCategoryButton";
            this._deleteCategoryButton.Location = new System.Drawing.Point(97, 306);
            this._deleteCategoryButton.Name = "_deleteCategoryButton";
            this._deleteCategoryButton.Size = new System.Drawing.Size(75, 23);
            this._deleteCategoryButton.TabIndex = 4;
            this._deleteCategoryButton.Text = "Delete";
            this._deleteCategoryButton.UseVisualStyleBackColor = true;
            this._deleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButtonClickEventHandler);
            // 
            // _categoryGroupBox
            // 
            this._categoryGroupBox.Controls.Add(this._saveCategoryButton);
            this._categoryGroupBox.Controls.Add(this._usingListBox);
            this._categoryGroupBox.Controls.Add(this._categoryNameTextBox);
            this._categoryGroupBox.Controls.Add(this._label2);
            this._categoryGroupBox.Controls.Add(this._categoryNameLabel);
            this._categoryGroupBox.Location = new System.Drawing.Point(192, 7);
            this._categoryGroupBox.Name = "_categoryGroupBox";
            this._categoryGroupBox.Size = new System.Drawing.Size(475, 332);
            this._categoryGroupBox.TabIndex = 3;
            this._categoryGroupBox.TabStop = false;
            this._categoryGroupBox.Text = "Category";
            // 
            // _saveCategoryButton
            // 
            this._saveCategoryButton.AccessibleName = "_saveCategoryButton";
            this._saveCategoryButton.Location = new System.Drawing.Point(382, 298);
            this._saveCategoryButton.Name = "_saveCategoryButton";
            this._saveCategoryButton.Size = new System.Drawing.Size(75, 23);
            this._saveCategoryButton.TabIndex = 5;
            this._saveCategoryButton.Text = "Save";
            this._saveCategoryButton.UseVisualStyleBackColor = true;
            this._saveCategoryButton.Click += new System.EventHandler(this.SaveCategoryButtonClickEventHandler);
            // 
            // _usingListBox
            // 
            this._usingListBox.AccessibleName = "_usingListBox";
            this._usingListBox.FormattingEnabled = true;
            this._usingListBox.ItemHeight = 12;
            this._usingListBox.Location = new System.Drawing.Point(19, 126);
            this._usingListBox.Name = "_usingListBox";
            this._usingListBox.Size = new System.Drawing.Size(450, 160);
            this._usingListBox.TabIndex = 4;
            // 
            // _categoryNameTextBox
            // 
            this._categoryNameTextBox.AccessibleName = "_categoryNameTextBox";
            this._categoryNameTextBox.Location = new System.Drawing.Point(93, 27);
            this._categoryNameTextBox.Name = "_categoryNameTextBox";
            this._categoryNameTextBox.Size = new System.Drawing.Size(100, 22);
            this._categoryNameTextBox.TabIndex = 2;
            this._categoryNameTextBox.TextChanged += new System.EventHandler(this.ChangeCategoryTextEventHandler);
            // 
            // _label2
            // 
            this._label2.Location = new System.Drawing.Point(6, 101);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(160, 22);
            this._label2.TabIndex = 1;
            this._label2.Text = "Meal(s) Using this Category";
            // 
            // _categoryNameLabel
            // 
            this._categoryNameLabel.Location = new System.Drawing.Point(6, 35);
            this._categoryNameLabel.Name = "_categoryNameLabel";
            this._categoryNameLabel.Size = new System.Drawing.Size(83, 29);
            this._categoryNameLabel.TabIndex = 0;
            this._categoryNameLabel.Text = "Category Name ";
            // 
            // _addCategoryButton
            // 
            this._addCategoryButton.AccessibleName = "_addCategoryButton";
            this._addCategoryButton.Location = new System.Drawing.Point(15, 305);
            this._addCategoryButton.Name = "_addCategoryButton";
            this._addCategoryButton.Size = new System.Drawing.Size(75, 23);
            this._addCategoryButton.TabIndex = 1;
            this._addCategoryButton.Text = "Add";
            this._addCategoryButton.UseVisualStyleBackColor = true;
            this._addCategoryButton.Click += new System.EventHandler(this.AddCategoryButtonClickEventHandler);
            // 
            // _categoryListBox
            // 
            this._categoryListBox.AccessibleName = "_categoryListBox";
            this._categoryListBox.FormattingEnabled = true;
            this._categoryListBox.ItemHeight = 12;
            this._categoryListBox.Location = new System.Drawing.Point(6, 7);
            this._categoryListBox.Name = "_categoryListBox";
            this._categoryListBox.Size = new System.Drawing.Size(180, 292);
            this._categoryListBox.TabIndex = 0;
            this._categoryListBox.SelectedIndexChanged += new System.EventHandler(this.ChangeCategoryListBoxSelectedIndexEventHandler);
            // 
            // _openImageDialog
            // 
            this._openImageDialog.FileName = "openFileDialog1";
            // 
            // RestaurantSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 395);
            this.Controls.Add(this._tabControl1);
            this.Name = "RestaurantSideForm";
            this.Text = "PDS-Restaurant SideForm";
            this._tabControl1.ResumeLayout(false);
            this._tabPage1.ResumeLayout(false);
            this._mealGroupBox.ResumeLayout(false);
            this._mealGroupBox.PerformLayout();
            this._tabPage2.ResumeLayout(false);
            this._categoryGroupBox.ResumeLayout(false);
            this._categoryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabControl1;
        private System.Windows.Forms.TabPage _tabPage1;
        private System.Windows.Forms.TabPage _tabPage2;
        private System.Windows.Forms.GroupBox _mealGroupBox;
        private System.Windows.Forms.ListBox _mealListBox;
        private System.Windows.Forms.Button _deleteMealButton;
        private System.Windows.Forms.Button _addMealButton;
        private System.Windows.Forms.Label _mealNameLabel;
        private System.Windows.Forms.Label _mealCategoryLabel;
        private System.Windows.Forms.Label _mealPriceLabel;
        private System.Windows.Forms.Label _mealDescriptionLabel;
        private System.Windows.Forms.Label _mealImagePathLabel;
        private System.Windows.Forms.ComboBox _mealCategoryComboBox;
        private System.Windows.Forms.TextBox _mealDescriptionTextBox;
        private System.Windows.Forms.TextBox _mealImagePathTextBox;
        private System.Windows.Forms.TextBox _mealPriceTextBox;
        private System.Windows.Forms.TextBox _mealNameTextBox;
        private System.Windows.Forms.Button _saveMealButton;
        private System.Windows.Forms.Button _browseButton;
        private System.Windows.Forms.OpenFileDialog _openImageDialog;
        private System.Windows.Forms.ListBox _categoryListBox;
        private System.Windows.Forms.Button _addCategoryButton;
        private System.Windows.Forms.GroupBox _categoryGroupBox;
        private System.Windows.Forms.TextBox _categoryNameTextBox;
        private System.Windows.Forms.Label _label2;
        private System.Windows.Forms.Label _categoryNameLabel;
        private System.Windows.Forms.ListBox _usingListBox;
        private System.Windows.Forms.Button _saveCategoryButton;
        private System.Windows.Forms.Button _deleteCategoryButton;



    }
}