namespace WindowsFormsApplication1
{
    partial class POSCustomerSideForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._meals = new System.Windows.Forms.GroupBox();
            this._description = new System.Windows.Forms.RichTextBox();
            this._page = new System.Windows.Forms.Label();
            this._previousButton = new System.Windows.Forms.Button();
            this._nextButton = new System.Windows.Forms.Button();
            this._recordDataGridView = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._total = new System.Windows.Forms.Label();
            this._meals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._recordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _meals
            // 
            this._meals.AccessibleName = "_meals";
            this._meals.Controls.Add(this._description);
            this._meals.Controls.Add(this._page);
            this._meals.Controls.Add(this._previousButton);
            this._meals.Controls.Add(this._nextButton);
            this._meals.Dock = System.Windows.Forms.DockStyle.Left;
            this._meals.Location = new System.Drawing.Point(0, 0);
            this._meals.Name = "_meals";
            this._meals.Size = new System.Drawing.Size(395, 485);
            this._meals.TabIndex = 1;
            this._meals.TabStop = false;
            this._meals.Text = "meals";
            // 
            // _description
            // 
            this._description.AccessibleName = "_description";
            this._description.Location = new System.Drawing.Point(37, 351);
            this._description.Name = "_description";
            this._description.ReadOnly = true;
            this._description.Size = new System.Drawing.Size(336, 58);
            this._description.TabIndex = 18;
            this._description.Text = "";
            // 
            // _page
            // 
            this._page.AutoSize = true;
            this._page.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._page.Location = new System.Drawing.Point(35, 428);
            this._page.Name = "_page";
            this._page.Size = new System.Drawing.Size(0, 12);
            this._page.TabIndex = 17;
            // 
            // _previousButton
            // 
            this._previousButton.AccessibleName = "_previousButton";
            this._previousButton.Location = new System.Drawing.Point(198, 428);
            this._previousButton.Name = "_previousButton";
            this._previousButton.Size = new System.Drawing.Size(75, 23);
            this._previousButton.TabIndex = 16;
            this._previousButton.Text = "Previous";
            this._previousButton.UseVisualStyleBackColor = true;
            this._previousButton.Click += new System.EventHandler(this.GoPreviousButtonClickEventHandler);
            // 
            // _nextButton
            // 
            this._nextButton.AccessibleName = "_nextButton";
            this._nextButton.Location = new System.Drawing.Point(298, 428);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(75, 23);
            this._nextButton.TabIndex = 15;
            this._nextButton.Text = "Next";
            this._nextButton.UseVisualStyleBackColor = true;
            this._nextButton.Click += new System.EventHandler(this.GoNextButtonClickEventHandler);
            // 
            // _recordDataGridView
            // 
            this._recordDataGridView.AccessibleName = "_recordDataGridView";
            this._recordDataGridView.AllowUserToAddRows = false;
            this._recordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._recordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._recordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.MealName,
            this.Catagory,
            this.MealPrice,
            this.Qty,
            this.SubTotal});
            this._recordDataGridView.Location = new System.Drawing.Point(411, 13);
            this._recordDataGridView.Name = "_recordDataGridView";
            this._recordDataGridView.RowHeadersVisible = false;
            this._recordDataGridView.RowTemplate.Height = 24;
            this._recordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._recordDataGridView.Size = new System.Drawing.Size(362, 396);
            this._recordDataGridView.TabIndex = 9;
            this._recordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickRecordDataGridViewCellContentEventHandler);
            this._recordDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangeRecordDataGridViewCellValueEventHandler);
            // 
            // Delete
            // 
            this.Delete.FillWeight = 76.14214F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Text = "X";
            // 
            // MealName
            // 
            this.MealName.FillWeight = 110F;
            this.MealName.HeaderText = "MealName";
            this.MealName.Name = "MealName";
            this.MealName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Catagory
            // 
            this.Catagory.HeaderText = "Catagory";
            this.Catagory.Name = "Catagory";
            // 
            // MealPrice
            // 
            this.MealPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MealPrice.FillWeight = 105.9645F;
            this.MealPrice.HeaderText = "MealPrice";
            this.MealPrice.Name = "MealPrice";
            this.MealPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MealPrice.Width = 69;
            // 
            // Qty
            // 
            this.Qty.FillWeight = 105.9645F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Qty.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Qty.Name = "Qty";
            this.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SubTotal
            // 
            this.SubTotal.FillWeight = 105.9645F;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _total
            // 
            this._total.AccessibleName = "_total";
            this._total.AutoSize = true;
            this._total.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._total.ForeColor = System.Drawing.Color.Red;
            this._total.Location = new System.Drawing.Point(454, 432);
            this._total.Name = "_total";
            this._total.Size = new System.Drawing.Size(50, 19);
            this._total.TabIndex = 10;
            this._total.Text = "_total";
            // 
            // POSCustomerSideForm
            // 
            this.AccessibleName = "POSCustomerSideForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 485);
            this.Controls.Add(this._total);
            this.Controls.Add(this._recordDataGridView);
            this.Controls.Add(this._meals);
            this.Name = "POSCustomerSideForm";
            this.Text = "POSCustomerSideForm";
            this._meals.ResumeLayout(false);
            this._meals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._recordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _meals;
        private System.Windows.Forms.DataGridView _recordDataGridView;
        private System.Windows.Forms.Label _total;
        private System.Windows.Forms.Button _previousButton;
        private System.Windows.Forms.Button _nextButton;
        private System.Windows.Forms.Label _page;
        private System.Windows.Forms.RichTextBox _description;
        private System.Windows.Forms.DataGridViewButtonColumn _delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _category;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mealPrice;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn _quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealPrice;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}

