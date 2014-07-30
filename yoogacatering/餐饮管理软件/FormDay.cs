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
    public partial class FormDay : Form
    {
        public FormDay()
        {
            InitializeComponent();
        }
        private void tabShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabShift.SelectedIndex == 1)
            {
                InitShiftInfos();
            }
        }

        private void InitShiftInfos()
        {
            dvShifts.Rows.Clear();
            ShiftInfoService service = new ShiftInfoService();
            List<ShiftInfo> shifts = service.GetAllShiftInfos();
            foreach (ShiftInfo s in shifts)
            {
                if (s.isDay == 1)
                {
                    dvShifts.Rows.Add(s.userName, s.shiftTime, s.turnoverMoney, s.cashMoney, s.vesaMoney, s.preMoney, s.disMoney, s.runMoney, s.billCount);
                }
            }
        }
        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void lbShift_Click(object sender, EventArgs e)
        {
            ShiftInfo shift = new ShiftInfo();
            shift.billCount = Convert.ToInt32(tbBillCount.Text);
            shift.cashMoney = float.Parse(tbCashSum.Text);
            shift.disMoney = float.Parse(tbDisSum.Text);
            shift.preMoney = float.Parse(tbPreSum.Text);
            shift.runMoney = float.Parse(tbRunSum.Text);
            shift.shiftTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            shift.turnoverMoney = float.Parse(tbTurnover.Text);
            shift.userName = App.userName;
            shift.vesaMoney = float.Parse(tbVesaSum.Text);
            shift.isDay = 1;
            ShiftInfoService service = new ShiftInfoService();
            service.AddShiftInfo(shift);
            MessageBox.Show("交班成功");
        }

        private void FormDay_Load(object sender, EventArgs e)
        {
            InitBaseInfo();
        }
        private void InitBaseInfo()
        {
            ShiftInfoService service = new ShiftInfoService();
            tbLastShiftTime.Text = service.GetLastShiftTime(1);
            tbUserName.Text = App.userName;

            BillInfoService bService = new BillInfoService();
            DateTime dt = dtDay.Value;
            List<BillInfo> bills = bService.GetBillInfosByTime(dt.ToString("yyyy-MM-dd 10:00:00"),dt.AddDays(1).ToString("yyyy-MM-dd 10:00:00"));

            float shMoneySum = 0.0f;
            float SHcashSum = 0.0f;
            float SHvesaSum = 0.0f;
            float preMoneySum = 0.0f;
            float disMoneySum = 0.0f;
            float runMoneySum = 0.0f;
            foreach (BillInfo b in bills)
            {

                // 2 挂账
                if (b.status == 2)
                {
                    runMoneySum += b.billMoney;
                }
                else
                {
                    shMoneySum += b.SHmoney;
                    SHcashSum += b.SHcash;
                    SHvesaSum += b.SHvesa;
                    preMoneySum += b.preMoney;
                    disMoneySum += b.disMoney;

                }
            }

            tbBillCount.Text = bills.Count + "";
            tbTurnover.Text = shMoneySum + "";
            tbCashSum.Text = SHcashSum + "";
            tbVesaSum.Text = SHvesaSum + "";
            tbPreSum.Text = preMoneySum + "";
            tbRunSum.Text = runMoneySum + "";
            tbDisSum.Text = disMoneySum + "";

        }

        private void lbDay_Click(object sender, EventArgs e)
        {
            InitBaseInfo();
        }
    }
}
