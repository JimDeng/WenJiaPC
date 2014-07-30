using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using yoogacatering.Entity;
using yoogacatering.Service;

namespace yoogacatering
{
    public partial class FormAddCategory : Form
    {
        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void lbCancelAddCategory_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void lbAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = tbCategoryName.Text.Trim();
            if (categoryName == "")
            {
                MessageBox.Show("分类名称不能为空！");
            }
            else
            {
                FoodCategory category = new FoodCategory();
                category.categoryName = categoryName;
                category.categoryBelong = cbCategoryBelong.Text.Trim();
                FoodCategoryService service = new FoodCategoryService();
                service.AddCategory(category);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
