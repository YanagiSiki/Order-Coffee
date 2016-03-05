using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class RestaurantUpdateForm : Form
    {        
        public void UpdateCategoryGroupBox(TextBox categoryNameTextBox, Model model, ListBox categoryListBox, ListBox usingListBox)//更新CategoryGroupBox
        {
            categoryNameTextBox.Text = model.GetCategory()[categoryListBox.SelectedIndex].GetCategoryName();
            List<Meals> temporaryMealsList = new List<Meals>();
            temporaryMealsList = model.CreateTemporaryList(model.GetCategory()[categoryListBox.SelectedIndex].GetCategoryNumber());
            usingListBox.Items.Clear();
            int index;
            for (index = 0; index < temporaryMealsList.Count; index++)
            {
                usingListBox.Items.Add(temporaryMealsList[index].GetMealName());
            }
        }
    }
}
