namespace yoogacatering
{
    partial class FormCheckout
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbBillkey = new System.Windows.Forms.Label();
            this.lbTabName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbBill = new System.Windows.Forms.GroupBox();
            this.dvBill = new System.Windows.Forms.DataGridView();
            this.foodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.give = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbMark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbZL = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbSHMoney = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbPre = new System.Windows.Forms.TextBox();
            this.cbDiscount = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbPaymethod = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbPreMoney = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbDisMoney = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbActMoney = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbBillmoney = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cbCardType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lvCardName = new System.Windows.Forms.Label();
            this.lbCardPhone = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbReturnBal = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lbCheckout = new System.Windows.Forms.Label();
            this.lbPreCheckout = new System.Windows.Forms.Label();
            this.lbRunBill = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.gbCardInfo = new System.Windows.Forms.GroupBox();
            this.gbBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBill)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.gbCardInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "账单编号：";
            // 
            // lbBillkey
            // 
            this.lbBillkey.AutoSize = true;
            this.lbBillkey.Location = new System.Drawing.Point(153, 17);
            this.lbBillkey.Name = "lbBillkey";
            this.lbBillkey.Size = new System.Drawing.Size(155, 25);
            this.lbBillkey.TabIndex = 1;
            this.lbBillkey.Text = "2010071400001";
            // 
            // lbTabName
            // 
            this.lbTabName.AutoSize = true;
            this.lbTabName.Location = new System.Drawing.Point(575, 17);
            this.lbTabName.Name = "lbTabName";
            this.lbTabName.Size = new System.Drawing.Size(36, 25);
            this.lbTabName.TabIndex = 3;
            this.lbTabName.Text = "A1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "餐桌号：";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(21, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(811, 3);
            this.label4.TabIndex = 4;
            // 
            // gbBill
            // 
            this.gbBill.Controls.Add(this.dvBill);
            this.gbBill.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.gbBill.Location = new System.Drawing.Point(21, 129);
            this.gbBill.Name = "gbBill";
            this.gbBill.Size = new System.Drawing.Size(410, 352);
            this.gbBill.TabIndex = 5;
            this.gbBill.TabStop = false;
            this.gbBill.Text = "账单详情";
            // 
            // dvBill
            // 
            this.dvBill.AllowUserToAddRows = false;
            this.dvBill.AllowUserToDeleteRows = false;
            this.dvBill.AllowUserToResizeRows = false;
            this.dvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodname,
            this.foodcount,
            this.foodprice,
            this.give});
            this.dvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBill.Location = new System.Drawing.Point(3, 25);
            this.dvBill.Name = "dvBill";
            this.dvBill.ReadOnly = true;
            this.dvBill.RowHeadersVisible = false;
            this.dvBill.RowTemplate.Height = 23;
            this.dvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvBill.Size = new System.Drawing.Size(404, 324);
            this.dvBill.TabIndex = 0;
            // 
            // foodname
            // 
            this.foodname.HeaderText = "餐点名称";
            this.foodname.Name = "foodname";
            this.foodname.ReadOnly = true;
            // 
            // foodcount
            // 
            this.foodcount.HeaderText = "数量";
            this.foodcount.Name = "foodcount";
            this.foodcount.ReadOnly = true;
            // 
            // foodprice
            // 
            this.foodprice.HeaderText = "单价";
            this.foodprice.Name = "foodprice";
            this.foodprice.ReadOnly = true;
            // 
            // give
            // 
            this.give.HeaderText = "赠送";
            this.give.Name = "give";
            this.give.ReadOnly = true;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.tbMark);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.tbZL);
            this.gbInfo.Controls.Add(this.label21);
            this.gbInfo.Controls.Add(this.tbSHMoney);
            this.gbInfo.Controls.Add(this.label18);
            this.gbInfo.Controls.Add(this.tbPre);
            this.gbInfo.Controls.Add(this.cbDiscount);
            this.gbInfo.Controls.Add(this.label20);
            this.gbInfo.Controls.Add(this.label19);
            this.gbInfo.Controls.Add(this.cbPaymethod);
            this.gbInfo.Controls.Add(this.label17);
            this.gbInfo.Controls.Add(this.lbPreMoney);
            this.gbInfo.Controls.Add(this.label16);
            this.gbInfo.Controls.Add(this.lbDisMoney);
            this.gbInfo.Controls.Add(this.label12);
            this.gbInfo.Controls.Add(this.lbActMoney);
            this.gbInfo.Controls.Add(this.label14);
            this.gbInfo.Controls.Add(this.lbBillmoney);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.gbInfo.Location = new System.Drawing.Point(462, 129);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(367, 352);
            this.gbInfo.TabIndex = 6;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "账单详情";
            // 
            // tbMark
            // 
            this.tbMark.Location = new System.Drawing.Point(122, 233);
            this.tbMark.Name = "tbMark";
            this.tbMark.Size = new System.Drawing.Size(218, 29);
            this.tbMark.TabIndex = 29;
            this.tbMark.Text = "无";
            this.tbMark.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "备注信息";
            // 
            // tbZL
            // 
            this.tbZL.Location = new System.Drawing.Point(277, 284);
            this.tbZL.Name = "tbZL";
            this.tbZL.ReadOnly = true;
            this.tbZL.Size = new System.Drawing.Size(63, 29);
            this.tbZL.TabIndex = 27;
            this.tbZL.Text = "0";
            this.tbZL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(214, 292);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 21);
            this.label21.TabIndex = 26;
            this.label21.Text = "找零";
            // 
            // tbSHMoney
            // 
            this.tbSHMoney.Location = new System.Drawing.Point(122, 284);
            this.tbSHMoney.Name = "tbSHMoney";
            this.tbSHMoney.Size = new System.Drawing.Size(63, 29);
            this.tbSHMoney.TabIndex = 25;
            this.tbSHMoney.Text = "0";
            this.tbSHMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSHMoney.TextChanged += new System.EventHandler(this.tbSHMoney_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 292);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 21);
            this.label18.TabIndex = 24;
            this.label18.Text = "实收金额";
            // 
            // tbPre
            // 
            this.tbPre.Location = new System.Drawing.Point(122, 182);
            this.tbPre.Name = "tbPre";
            this.tbPre.Size = new System.Drawing.Size(218, 29);
            this.tbPre.TabIndex = 23;
            this.tbPre.Text = "0";
            this.tbPre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPre.TextChanged += new System.EventHandler(this.tbPre_TextChanged);
            // 
            // cbDiscount
            // 
            this.cbDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscount.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbDiscount.FormattingEnabled = true;
            this.cbDiscount.Location = new System.Drawing.Point(262, 131);
            this.cbDiscount.Name = "cbDiscount";
            this.cbDiscount.Size = new System.Drawing.Size(78, 29);
            this.cbDiscount.TabIndex = 22;
            this.cbDiscount.SelectedIndexChanged += new System.EventHandler(this.cbDiscount_SelectedIndexChanged);
            this.cbDiscount.SelectionChangeCommitted += new System.EventHandler(this.cbDiscount_SelectionChangeCommitted);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(214, 139);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 21);
            this.label20.TabIndex = 21;
            this.label20.Text = "折扣";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 190);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 21);
            this.label19.TabIndex = 19;
            this.label19.Text = "全单优惠";
            // 
            // cbPaymethod
            // 
            this.cbPaymethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymethod.FormattingEnabled = true;
            this.cbPaymethod.Items.AddRange(new object[] {
            "现金",
            "刷卡"});
            this.cbPaymethod.Location = new System.Drawing.Point(122, 131);
            this.cbPaymethod.Name = "cbPaymethod";
            this.cbPaymethod.Size = new System.Drawing.Size(63, 29);
            this.cbPaymethod.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 21);
            this.label17.TabIndex = 17;
            this.label17.Text = "收款方式";
            // 
            // lbPreMoney
            // 
            this.lbPreMoney.AutoSize = true;
            this.lbPreMoney.Location = new System.Drawing.Point(303, 37);
            this.lbPreMoney.Name = "lbPreMoney";
            this.lbPreMoney.Size = new System.Drawing.Size(37, 21);
            this.lbPreMoney.TabIndex = 16;
            this.lbPreMoney.Text = "108";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(214, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 21);
            this.label16.TabIndex = 15;
            this.label16.Text = "赠送金额";
            // 
            // lbDisMoney
            // 
            this.lbDisMoney.AutoSize = true;
            this.lbDisMoney.Location = new System.Drawing.Point(122, 88);
            this.lbDisMoney.Name = "lbDisMoney";
            this.lbDisMoney.Size = new System.Drawing.Size(37, 21);
            this.lbDisMoney.TabIndex = 14;
            this.lbDisMoney.Text = "108";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "可打折金额";
            // 
            // lbActMoney
            // 
            this.lbActMoney.AutoSize = true;
            this.lbActMoney.ForeColor = System.Drawing.Color.Red;
            this.lbActMoney.Location = new System.Drawing.Point(303, 88);
            this.lbActMoney.Name = "lbActMoney";
            this.lbActMoney.Size = new System.Drawing.Size(37, 21);
            this.lbActMoney.TabIndex = 12;
            this.lbActMoney.Text = "108";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(214, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 21);
            this.label14.TabIndex = 11;
            this.label14.Text = "应收金额";
            // 
            // lbBillmoney
            // 
            this.lbBillmoney.AutoSize = true;
            this.lbBillmoney.Location = new System.Drawing.Point(122, 37);
            this.lbBillmoney.Name = "lbBillmoney";
            this.lbBillmoney.Size = new System.Drawing.Size(37, 21);
            this.lbBillmoney.TabIndex = 1;
            this.lbBillmoney.Text = "108";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "账单金额";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(21, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(811, 3);
            this.label8.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(39, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 25);
            this.label23.TabIndex = 7;
            this.label23.Text = "VIP卡:";
            this.label23.Visible = false;
            // 
            // cbCardType
            // 
            this.cbCardType.FormattingEnabled = true;
            this.cbCardType.Location = new System.Drawing.Point(128, 80);
            this.cbCardType.Name = "cbCardType";
            this.cbCardType.Size = new System.Drawing.Size(103, 33);
            this.cbCardType.TabIndex = 12;
            this.cbCardType.Text = "积分卡";
            this.cbCardType.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button1.Location = new System.Drawing.Point(243, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "读卡";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label9.Location = new System.Drawing.Point(9, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "持卡人:";
            // 
            // lvCardName
            // 
            this.lvCardName.AutoSize = true;
            this.lvCardName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lvCardName.Location = new System.Drawing.Point(63, 14);
            this.lvCardName.Name = "lvCardName";
            this.lvCardName.Size = new System.Drawing.Size(32, 17);
            this.lvCardName.TabIndex = 15;
            this.lvCardName.Text = "小明";
            // 
            // lbCardPhone
            // 
            this.lbCardPhone.AutoSize = true;
            this.lbCardPhone.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lbCardPhone.Location = new System.Drawing.Point(63, 35);
            this.lbCardPhone.Name = "lbCardPhone";
            this.lbCardPhone.Size = new System.Drawing.Size(85, 17);
            this.lbCardPhone.TabIndex = 17;
            this.lbCardPhone.Text = "14657864567";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label24.Location = new System.Drawing.Point(9, 35);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 17);
            this.label24.TabIndex = 16;
            this.label24.Text = "手机号：";
            // 
            // lbReturnBal
            // 
            this.lbReturnBal.AutoSize = true;
            this.lbReturnBal.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lbReturnBal.Location = new System.Drawing.Point(308, 35);
            this.lbReturnBal.Name = "lbReturnBal";
            this.lbReturnBal.Size = new System.Drawing.Size(29, 17);
            this.lbReturnBal.TabIndex = 21;
            this.lbReturnBal.Text = "100";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label26.Location = new System.Drawing.Point(229, 35);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(68, 17);
            this.label26.TabIndex = 20;
            this.label26.Text = "返还余额：";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lbBalance.Location = new System.Drawing.Point(308, 14);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(29, 17);
            this.lbBalance.TabIndex = 19;
            this.lbBalance.Text = "200";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label28.Location = new System.Drawing.Point(229, 14);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 17);
            this.label28.TabIndex = 18;
            this.label28.Text = "充值卡余额：";
            // 
            // lbCheckout
            // 
            this.lbCheckout.BackColor = System.Drawing.Color.Black;
            this.lbCheckout.ForeColor = System.Drawing.Color.White;
            this.lbCheckout.Location = new System.Drawing.Point(171, 510);
            this.lbCheckout.Name = "lbCheckout";
            this.lbCheckout.Size = new System.Drawing.Size(92, 54);
            this.lbCheckout.TabIndex = 22;
            this.lbCheckout.Text = "结账";
            this.lbCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCheckout.Click += new System.EventHandler(this.lbCheckout_Click);
            // 
            // lbPreCheckout
            // 
            this.lbPreCheckout.BackColor = System.Drawing.Color.Black;
            this.lbPreCheckout.ForeColor = System.Drawing.Color.White;
            this.lbPreCheckout.Location = new System.Drawing.Point(308, 510);
            this.lbPreCheckout.Name = "lbPreCheckout";
            this.lbPreCheckout.Size = new System.Drawing.Size(92, 54);
            this.lbPreCheckout.TabIndex = 23;
            this.lbPreCheckout.Text = "预结";
            this.lbPreCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPreCheckout.Click += new System.EventHandler(this.lbPreCheckout_Click);
            // 
            // lbRunBill
            // 
            this.lbRunBill.BackColor = System.Drawing.Color.Black;
            this.lbRunBill.ForeColor = System.Drawing.Color.White;
            this.lbRunBill.Location = new System.Drawing.Point(445, 510);
            this.lbRunBill.Name = "lbRunBill";
            this.lbRunBill.Size = new System.Drawing.Size(92, 54);
            this.lbRunBill.TabIndex = 24;
            this.lbRunBill.Text = "挂账";
            this.lbRunBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbRunBill.Click += new System.EventHandler(this.lbRunBill_Click);
            // 
            // lbCancel
            // 
            this.lbCancel.BackColor = System.Drawing.Color.Black;
            this.lbCancel.ForeColor = System.Drawing.Color.White;
            this.lbCancel.Location = new System.Drawing.Point(582, 510);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(92, 54);
            this.lbCancel.TabIndex = 25;
            this.lbCancel.Text = "取消";
            this.lbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // label33
            // 
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label33.Location = new System.Drawing.Point(21, 497);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(811, 3);
            this.label33.TabIndex = 26;
            // 
            // gbCardInfo
            // 
            this.gbCardInfo.Controls.Add(this.label9);
            this.gbCardInfo.Controls.Add(this.lvCardName);
            this.gbCardInfo.Controls.Add(this.label24);
            this.gbCardInfo.Controls.Add(this.lbCardPhone);
            this.gbCardInfo.Controls.Add(this.lbReturnBal);
            this.gbCardInfo.Controls.Add(this.label28);
            this.gbCardInfo.Controls.Add(this.lbBalance);
            this.gbCardInfo.Controls.Add(this.label26);
            this.gbCardInfo.Location = new System.Drawing.Point(348, 61);
            this.gbCardInfo.Name = "gbCardInfo";
            this.gbCardInfo.Size = new System.Drawing.Size(367, 60);
            this.gbCardInfo.TabIndex = 27;
            this.gbCardInfo.TabStop = false;
            this.gbCardInfo.Visible = false;
            // 
            // FormCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 572);
            this.ControlBox = false;
            this.Controls.Add(this.gbCardInfo);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.lbRunBill);
            this.Controls.Add(this.lbPreCheckout);
            this.Controls.Add(this.lbCheckout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCardType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbBill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTabName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbBillkey);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormCheckout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "结账";
            this.Load += new System.EventHandler(this.FormCheckout_Load);
            this.gbBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBill)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbCardInfo.ResumeLayout(false);
            this.gbCardInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBillkey;
        private System.Windows.Forms.Label lbTabName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbBill;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbBillmoney;
        private System.Windows.Forms.Label lbDisMoney;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbActMoney;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbPreMoney;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbPaymethod;
        private System.Windows.Forms.ComboBox cbDiscount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbPre;
        private System.Windows.Forms.TextBox tbSHMoney;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbZL;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbMark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbCardType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lvCardName;
        private System.Windows.Forms.Label lbCardPhone;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbReturnBal;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lbCheckout;
        private System.Windows.Forms.Label lbPreCheckout;
        private System.Windows.Forms.Label lbRunBill;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.DataGridView dvBill;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox gbCardInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn give;
    }
}