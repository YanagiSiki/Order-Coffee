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
    public partial class CustomerUpdateForm : Form
    {
        const int NINE = 9;
        public void UpdateDataGridView(DataGridView recordDataGridView, Model model, Label total) //更新DGV資訊
        {
            int index = 0;
            int totalTemporary = 0;
            recordDataGridView.Rows.Clear();
            for (index = 0; index < model.GetOrder().Count; index++)
            {
                if (model.IsCheckOrderNumberToMeal(model.GetOrder()[index].GetNumber()))
                {
                    recordDataGridView.Rows.Add("X",
                        model.CheckOrderNumberToMeal(model.GetOrder()[index].GetNumber()).GetMealName(),
                        model.CheckCategoryNumberToMeal(model.CheckOrderNumberToMeal(model.GetOrder()[index].GetNumber()).GetCategoryNumber()).GetCategoryName(),
                        model.CheckOrderNumberToMeal(model.GetOrder()[index].GetNumber()).GetMealPrice(),
                        model.GetOrder()[index].GetQuantity(),
                        model.CheckOrderNumberToMeal(model.GetOrder()[index].GetNumber()).GetMealPrice() * model.GetOrder()[index].GetQuantity());
                    totalTemporary += model.CheckOrderNumberToMeal(model.GetOrder()[index].GetNumber()).GetMealPrice() * model.GetOrder()[index].GetQuantity();

                }
                else
                    model.DeleteOrder(index);
            }
            total.Text = "Total ： " + totalTemporary;
        }

        public void UpdateAllButton(int number, Model model, Button[] allButtonList) //依據頁數不同以及tabpage來更新按鈕
        {
            int index = 0;
            List<Meals> temporaryMealsList = new List<Meals>();
            temporaryMealsList = model.CreateTemporaryList(number);
            for (index = 0; index < NINE; index++)
            {
                if (index + NINE * (model._thisPage - 1) < temporaryMealsList.Count)
                {
                    allButtonList[index].Text = temporaryMealsList[index + NINE * (model._thisPage - 1)].GetMealName() + "\n" + temporaryMealsList[index + NINE * (model._thisPage - 1)].GetMealPrice() + " NTD";
                    allButtonList[index].Visible = true;
                    allButtonList[index].BackgroundImage = Image.FromFile(temporaryMealsList[index + NINE * (model._thisPage - 1)].GetMealImage());
                    allButtonList[index].BackgroundImageLayout = ImageLayout.Stretch;
                    allButtonList[index].Tag = temporaryMealsList[index + NINE * (model._thisPage - 1)].GetNumber();
                }
                else
                    allButtonList[index].Visible = false;
            }
        }

        public void UpdateAllControlPage(TabControl tabControl1, Button[] allButtonList)//將處理好的button放到選取的page
        {
            int index = 0;
            for (index = 0; index < NINE; index++)
            {
                tabControl1.TabPages[tabControl1.SelectedIndex].Controls.Add(allButtonList[index]);
            }

        }
    }
}
