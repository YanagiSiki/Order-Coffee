namespace WindowsFormsApplication1
{
    partial class StartForm
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
            this._customer = new System.Windows.Forms.Button();
            this._employee = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _customer
            // 
            this._customer.AccessibleName = "_customer";
            this._customer.Location = new System.Drawing.Point(30, 44);
            this._customer.Name = "_customer";
            this._customer.Size = new System.Drawing.Size(157, 80);
            this._customer.TabIndex = 0;
            this._customer.Text = "customer(frontend)";
            this._customer.UseVisualStyleBackColor = true;
            this._customer.Click += new System.EventHandler(this.ClickCustomerEventHandler);
            // 
            // _employee
            // 
            this._employee.AccessibleName = "_employee";
            this._employee.Location = new System.Drawing.Point(216, 44);
            this._employee.Name = "_employee";
            this._employee.Size = new System.Drawing.Size(157, 80);
            this._employee.TabIndex = 1;
            this._employee.Text = "employee(frontend)";
            this._employee.UseVisualStyleBackColor = true;
            this._employee.Click += new System.EventHandler(this.ClickEmployeeEventHandler);
            // 
            // _exitButton
            // 
            this._exitButton.AccessibleName = "_exitButton";
            this._exitButton.Location = new System.Drawing.Point(298, 144);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(75, 23);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ExitButtonClickEventHandler);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 179);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._employee);
            this.Controls.Add(this._customer);
            this.Name = "StartForm";
            this.Text = "StarUptForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _customer;
        private System.Windows.Forms.Button _employee;
        private System.Windows.Forms.Button _exitButton;
    }
}