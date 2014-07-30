namespace yoogacatering
{
    partial class FormTabs
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
            this.components = new System.ComponentModel.Container();
            this.lbEnvs = new System.Windows.Forms.ListBox();
            this.ops = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.增加分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.增加餐桌ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvTabs = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opsTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTabName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ops.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTabs)).BeginInit();
            this.opsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEnvs
            // 
            this.lbEnvs.ContextMenuStrip = this.ops;
            this.lbEnvs.FormattingEnabled = true;
            this.lbEnvs.ItemHeight = 27;
            this.lbEnvs.Location = new System.Drawing.Point(29, 43);
            this.lbEnvs.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lbEnvs.Name = "lbEnvs";
            this.lbEnvs.Size = new System.Drawing.Size(206, 436);
            this.lbEnvs.TabIndex = 0;
            // 
            // ops
            // 
            this.ops.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ops.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加分类ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.增加餐桌ToolStripMenuItem});
            this.ops.Name = "ops";
            this.ops.Size = new System.Drawing.Size(145, 88);
            // 
            // 增加分类ToolStripMenuItem
            // 
            this.增加分类ToolStripMenuItem.Name = "增加分类ToolStripMenuItem";
            this.增加分类ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.增加分类ToolStripMenuItem.Text = "增加分类";
            this.增加分类ToolStripMenuItem.Click += new System.EventHandler(this.增加分类ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItem1.Text = "删除分类";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // 增加餐桌ToolStripMenuItem
            // 
            this.增加餐桌ToolStripMenuItem.Name = "增加餐桌ToolStripMenuItem";
            this.增加餐桌ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.增加餐桌ToolStripMenuItem.Text = "增加餐桌";
            this.增加餐桌ToolStripMenuItem.Click += new System.EventHandler(this.增加餐桌ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "就餐环境";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvTabs);
            this.groupBox1.Controls.Add(this.tbTabName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(258, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 467);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "餐桌信息";
            // 
            // dvTabs
            // 
            this.dvTabs.AllowUserToAddRows = false;
            this.dvTabs.AllowUserToDeleteRows = false;
            this.dvTabs.AllowUserToResizeRows = false;
            this.dvTabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvTabs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tabName,
            this.envName,
            this.createTime});
            this.dvTabs.ContextMenuStrip = this.opsTab;
            this.dvTabs.Location = new System.Drawing.Point(6, 71);
            this.dvTabs.Name = "dvTabs";
            this.dvTabs.ReadOnly = true;
            this.dvTabs.RowHeadersVisible = false;
            this.dvTabs.RowTemplate.Height = 23;
            this.dvTabs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvTabs.Size = new System.Drawing.Size(522, 390);
            this.dvTabs.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "编号";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 130;
            // 
            // tabName
            // 
            this.tabName.HeaderText = "餐桌名称";
            this.tabName.Name = "tabName";
            this.tabName.ReadOnly = true;
            this.tabName.Width = 130;
            // 
            // envName
            // 
            this.envName.HeaderText = "餐桌环境";
            this.envName.Name = "envName";
            this.envName.ReadOnly = true;
            this.envName.Width = 129;
            // 
            // createTime
            // 
            this.createTime.FillWeight = 150F;
            this.createTime.HeaderText = "创建时间";
            this.createTime.Name = "createTime";
            this.createTime.ReadOnly = true;
            this.createTime.Width = 130;
            // 
            // opsTab
            // 
            this.opsTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.opsTab.Name = "opsTab";
            this.opsTab.Size = new System.Drawing.Size(111, 30);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // tbTabName
            // 
            this.tbTabName.Location = new System.Drawing.Point(360, 20);
            this.tbTabName.Name = "tbTabName";
            this.tbTabName.Size = new System.Drawing.Size(154, 34);
            this.tbTabName.TabIndex = 1;
            this.tbTabName.TextChanged += new System.EventHandler(this.tbTabName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "搜索";
            // 
            // FormTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEnvs);
            this.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormTabs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐桌管理";
            this.Load += new System.EventHandler(this.FormTabs_Load);
            this.ops.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTabs)).EndInit();
            this.opsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEnvs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTabName;
        private System.Windows.Forms.DataGridView dvTabs;
        private System.Windows.Forms.ContextMenuStrip ops;
        private System.Windows.Forms.ToolStripMenuItem 增加分类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加餐桌ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip opsTab;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabName;
        private System.Windows.Forms.DataGridViewTextBoxColumn envName;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTime;
    }
}