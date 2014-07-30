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
    public partial class FormTabs : Form
    {
        public FormTabs()
        {
            InitializeComponent();
        }
        private void lbEnvs_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitTabs();
        }

        private void InitTabs()
        {

            if (lbEnvs.Items.Count == 0)
                return;
            TabInfoService service = new TabInfoService();
            dvTabs.Rows.Clear();
            dvTabs.Columns[0].Width = 100;
            dvTabs.Columns[1].Width = 150;
            dvTabs.Columns[2].Width = 150;
            dvTabs.Columns[3].Width = 250;
            if (lbEnvs.SelectedIndex <= 0)
            {
                List<TabInfo> tabs = service.GetAllTabs();
                dvTabs.Rows.Clear();
                foreach (TabInfo tab in tabs)
                {
                    dvTabs.Rows.Add(tab.id, tab.tabName, tab.envName, tab.createTime);
                }
            }
            else
            {
                List<TabInfo> tabs = service.GetAllTabsByEnvName(lbEnvs.SelectedItem.ToString());
                foreach (TabInfo tab in tabs)
                {
                    dvTabs.Rows.Add(tab.id, tab.tabName, tab.envName, tab.createTime);
                }
            }
        }
        private void InitTabEnvs()
        {
            lbEnvs.Items.Clear();
            lbEnvs.Items.Add("所有");
            List<TableEnv> envs = TabEnvService.GetAllEnv();
            foreach (TableEnv env in envs)
            {
                lbEnvs.Items.Add(env.tabEnvName);
            }
        }
        private void 增加分类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddTabEnv fa = new FormAddTabEnv();
            if (fa.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InitTabEnvs();
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string envName = lbEnvs.SelectedItem.ToString();
            if (envName != "")
            {
                //MessageBox.Show(envName);
                TabInfoService service = new TabInfoService();
                List<TabInfo> tabs = service.GetAllTabsByEnvName(envName);
                if (tabs.Count > 0)
                {
                    DialogResult res = MessageBox.Show(envName + "有未删除的餐桌信息，确定要删除该餐桌环境吗？", "删除确认", MessageBoxButtons.OKCancel);
                    if (res == System.Windows.Forms.DialogResult.OK)
                    {
                        TabEnvService.DelTabEnv(envName);
                        InitTabEnvs();
                    }
                }
                else
                {
                    TabEnvService.DelTabEnv(envName);
                    InitTabEnvs();
                }
            }
        }

        private void 增加餐桌ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string envName = "";
            try
            {
                envName = lbEnvs.SelectedItem.ToString();
            }
            catch
            {
            }
            FormAddTab fa = new FormAddTab(envName);
            DialogResult res = fa.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                InitTabs();
            }

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dvTabs.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dvTabs.SelectedRows[0].Cells["ID"].Value);
                TabInfoService.DelTabInfo(id);
                InitTabs();
            }
            else
            {
                MessageBox.Show("请选中您要删除的餐桌记录");
            }
        }

        private void FormTabs_Load(object sender, EventArgs e)
        {
            InitTabEnvs();
            InitTabs();
        }

        private void tbTabName_TextChanged(object sender, EventArgs e)
        {
            dvTabs.Rows.Clear();
            TabInfoService service = new TabInfoService();
            List<TabInfo> tabs = service.GetAllTabsByNameLike(tbTabName.Text.Trim());
            foreach (TabInfo tab in tabs)
            {
                dvTabs.Rows.Add(tab.id, tab.tabName, tab.envName, tab.createTime);
            }
        }
    }
}
