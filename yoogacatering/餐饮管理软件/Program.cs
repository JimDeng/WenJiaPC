using System;
using System.Collections.Generic;
using System.Windows.Forms;
using yoogacatering;
using yoogacatering.Utils;

namespace 餐饮管理软件
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Utils.Valid())
            {
                if (!App.isLogin)
                {
                    FormLogin fl = new FormLogin();
                    if (fl.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new FormMain());
                    }
                }
                else
                {
                    Application.Run(new FormMain());
                }
            }
            else
            {
                // 验证失败 请重新注册
            }
        }
    }
}
