using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using yoogacatering.Entity;
using yoogacatering.Service;
using yoogacatering.Utils;

namespace yoogacatering
{
    public partial class FormUpdateFood : Form
    {
        private int foodid { set; get; }
        public FormUpdateFood(int foodid)
        {
            InitializeComponent();
            this.foodid = foodid;
            InitCategory();
        }

        private void InitCategory()
        {
            FoodCategoryService service = new FoodCategoryService();
            List<FoodCategory> categorys = service.GetAllCategory();
            foreach (FoodCategory c in categorys)
            {
                cbCategory.Items.Add(c.categoryName);
            }
            cbCategory.SelectedIndex = 0;
        }
        private void lbUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateFood();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateFood()
        {
            string cnName = tbCnName.Text.Trim();
            string enName = tbEnName.Text.Trim();
            float price = 0.0f;
            try
            {
                price = float.Parse(tbPrice.Text.Trim());
            }
            catch
            {
                MessageBox.Show("价格必须是数字");
                return;
            }
            string unit = cbUnit.Text;
            string category = cbCategory.Text;
            if (cnName == "" || enName == "" || unit == "")
            {
                MessageBox.Show("餐点名称和单位不能为空");
                return;
            }
            
            FoodService service = new FoodService();
            Food food = service.GetFoodById(foodid);
            food.canDiscount = "否";
            if (rbCanDiscount.Checked)
                food.canDiscount = "能";
            food.category = category;
            food.cnName = cnName;
            food.updateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            food.delTime = "";
            food.des = tbDes.Text.Trim();
            food.enName = enName;
            food.imageUpdateTime = "";
            food.isHot = "否";
            food.isPlan = "否";
            if (cbIsPlan.Checked)
            {
                food.isPlan = "是";
                // 添加套餐详情
                PlanFoodService planService = new PlanFoodService();
                planService.DelPlanFoodByPlanName(cnName);
                foreach (DataGridViewRow row in dvPlanInfo.Rows)
                {
                    PlanFood planFood = new PlanFood();
                    planFood.planFoodCount = Convert.ToInt32(row.Cells["foodcount"].Value);
                    planFood.planFoodid = Convert.ToInt32(row.Cells["gvfoodid"].Value);
                    planFood.planFoodname = row.Cells["name"].Value.ToString();
                    planFood.planFoodPrice = float.Parse(row.Cells["foodprice"].Value.ToString());
                    planFood.planFoodUnit = row.Cells["foodUnit"].Value.ToString();
                    planFood.planName = cnName;
                    planService.AddPlanFood(planFood);
                }
            }
            food.needKC = "否";
            if (cbKC.Checked)
            {
                food.needKC = "是";

                // 添加库存信息
            }
            food.needMaterials = "否";
            if (cbMaterials.Checked)
            {
                food.needMaterials = "是";

                // 添加原材料信息
            }
            food.price = price;
            food.status = "库存";
            food.unit = unit;
            service.UpdateFood(food);
            if (imagePath != "")
            {
                string savePath = @".\image\" + foodid + ".jpg";
                ImageUtil.MakeThumbnail(imagePath, savePath, 500, 350, "H");
            }
            MessageBox.Show("修改餐点信息成功");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void tbCnName_TextChanged(object sender, EventArgs e)
        {
            if (tbCnName.Text != "")
            {
                string enName = Utils.Utils.GetChineseSpell(tbCnName.Text);
                tbEnName.Text = enName;
            }
        }
        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void FormUpdateFood_Load(object sender, EventArgs e)
        {
            FoodService service = new FoodService();
            Food food = service.GetFoodById(foodid);
            if (food != null)
            {
                tbCnName.Text = food.cnName;
                tbEnName.Text = food.enName;
                tbPrice.Text = food.price+"";
                cbUnit.Text = food.unit;
                cbCategory.Text = food.category;
                if (food.canDiscount.Equals("能"))
                {
                    rbCanDiscount.Checked = true;
                }
                else 
                {
                    rbNoDiscount.Checked = true;
                }

                string savePath = @".\image\" + foodid + ".jpg";
                try
                {
                    pbImage.BackgroundImage = Image.FromFile(savePath);
                }
                catch
                {
 
                }
                if (food.isPlan.Equals("是"))
                {
                    cbIsPlan.Checked = true;
                    InitPlanFoodInfo();

                }
                else
                {
                    cbIsPlan.Checked = false;
                }
            }
        }
        private void InitPlanFoodInfo()
        {
            dvPlanInfo.Rows.Clear();
            if (tbCnName.Text != "")
            {
                PlanFoodService service = new PlanFoodService();
                List<PlanFood> planFoods = service.GetPlanFood(tbCnName.Text.Trim());
                foreach (PlanFood f in planFoods)
                {
                    dvPlanInfo.Rows.Add(f.id, f.planFoodid, f.planFoodname, f.planFoodCount, f.planFoodPrice,f.planFoodUnit);
                }
            }
        }

        private void lbAddPlan_Click(object sender, EventArgs e)
        {
            if (tbCnName.Text != "")
            {
                FormAddPlan fa = new FormAddPlan(tbCnName.Text.Trim());
                DialogResult res = fa.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    PlanFood f = fa.planFood;
                    dvPlanInfo.Rows.Add(0, f.planFoodid, f.planFoodname, f.planFoodCount, f.planFoodPrice,f.planFoodUnit);
                }
            }
        }
        private string imagePath = "";
        private void lbUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog oDig = new OpenFileDialog();
            //oDig.Filter = "图片(*.jpg)|(*.*)";
            if (oDig.ShowDialog() == DialogResult.OK)
            {
                imagePath = oDig.FileName;
                pbImage.BackgroundImage = new Bitmap(imagePath);
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dvPlanInfo.Rows.Remove(dvPlanInfo.SelectedRows[0]);
            }
            catch
            { }
        }
    }
}
