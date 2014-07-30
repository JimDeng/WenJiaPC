using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using yoogacatering.Service;
using yoogacatering.Entity;

namespace yoogacatering
{
    public partial class FormAddPlan : Form
    {
        public string planName { set; get; }
        public string foodUnit { set; get; }
        public PlanFood planFood { set; get; }
        public FormAddPlan(string planName)
        {
            InitializeComponent();
            this.planName = planName;
            planFood = new PlanFood();
        }

        private void FormAddPlan_Load(object sender, EventArgs e)
        {
            InitFood();
        }
        private void InitFood()
        {
            FoodService service = new FoodService();
            List<Food> foods = service.GetAllFood();
            foreach (Food food in foods)
            {
                dvFood.Rows.Add(food.foodid, food.cnName, food.enName, food.price, food.category,food.unit);
            }
        }

        private void tbSearchStr_TextChanged(object sender, EventArgs e)
        {
            dvFood.Rows.Clear();
            FoodService service = new FoodService();
            List<Food> foods = service.GetAllFoodByName(tbSearchStr.Text.Trim());
            foreach (Food food in foods)
            {
                dvFood.Rows.Add(food.foodid, food.cnName, food.enName, food.price, food.category, food.unit);
            }
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void lbAdd_Click(object sender, EventArgs e)
        {
            if (foodid == 0)
            {
                MessageBox.Show("未选择餐点");
            }
            else
            {
                planFood.planName = planName;
                planFood.planFoodid = foodid;
                planFood.planFoodname = tbCnName.Text.Trim();
                planFood.planFoodCount = (int)nuCount.Value;
                planFood.planFoodPrice = foodprice;
                planFood.planFoodUnit = foodUnit;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                //PlanFoodService service = new PlanFoodService();
                //try
                //{
                //    service.AddPlanFood(planFood);
                //    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }
        private int foodid = 0;
        private float foodprice = 0.0f;
        private void dvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            try
            {
                foodid = Convert.ToInt32(dvFood.Rows[index].Cells["id"].Value);
                string foodname = dvFood.Rows[index].Cells["cnname"].Value.ToString();
                tbCnName.Text = foodname;
                foodUnit = dvFood.Rows[index].Cells["foodunit"].Value.ToString();
                foodprice = float.Parse(dvFood.Rows[index].Cells["price"].Value.ToString());
                lbAdd.Visible = true;
            }
            catch
            {
                lbAdd.Visible = false;
            }
        }
    }
}
