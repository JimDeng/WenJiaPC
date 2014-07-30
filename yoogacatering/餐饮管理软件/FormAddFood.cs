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
    public partial class FormAddFood : Form
    {
        public FormAddFood()
        {
            InitializeComponent();
        }

        private void tbCnName_TextChanged(object sender, EventArgs e)
        {
            if (tbCnName.Text != "")
            {
                string enName = Utils.Utils.GetChineseSpell(tbCnName.Text);
                tbEnName.Text = enName;
            }
        }

        private void lbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddFood();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddFood()
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
            Food food = new Food();
            food.canDiscount = "否";
            if (rbCanDiscount.Checked)
                food.canDiscount = "能";
            food.category = category;
            food.cnName = cnName;
            food.createTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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
                foreach (DataGridViewRow row in dvPlanInfo.Rows)
                {
                    PlanFood planFood = new PlanFood();
                    planFood.planFoodCount = Convert.ToInt32(row.Cells["foodcount"].Value);
                    planFood.planFoodid = Convert.ToInt32(row.Cells["foodid"].Value);
                    planFood.planFoodname = row.Cells["name"].Value.ToString();
                    planFood.planFoodPrice = float.Parse(row.Cells["foodprice"].Value.ToString());
                    planFood.planName = cnName;
                    planFood.planFoodUnit = row.Cells["foodUnit"].Value.ToString();
                    PlanFoodService planService = new PlanFoodService();
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
            food.updateTime = "";
            FoodService service = new FoodService();
            int id = service.AddFood(food);
            if (imagePath != "")
            {
                string savePath = @".\image\" + id + ".jpg";
                ImageUtil.MakeThumbnail(imagePath, savePath, 500, 350, "H");
            }
            MessageBox.Show("新增餐点信息成功");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void FormAddFood_Load(object sender, EventArgs e)
        {
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

        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void cbIsPlan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsPlan.Checked)
            {
                lbAddPlan.Visible = true;
            }
            else
            {
                lbAddPlan.Visible = false;
            }
        }

        private void cbKC_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKC.Checked)
            {
                nuKcCount.Enabled = true;
            }
            else
            {
                nuKcCount.Enabled = false;
            }
        }

        private void cbMaterials_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMaterials.Checked)
            {
                lbAddMaterials.Visible = true;
            }
            else
            {
                lbAddMaterials.Visible = false;
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
                    dvPlanInfo.Rows.Add(f.id,f.planFoodid,f.planFoodname,f.planFoodCount,f.planFoodPrice);
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
                    dvPlanInfo.Rows.Add(0,f.planFoodid, f.planFoodname, f.planFoodCount, f.planFoodPrice,f.planFoodUnit);
                }
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dvPlanInfo.SelectedRows[0].Cells["id"].Value);
                PlanFoodService service = new PlanFoodService();
                service.DelPlanFoodById(id);
                InitPlanFoodInfo();
            }
            catch { }

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
        
    }
}
