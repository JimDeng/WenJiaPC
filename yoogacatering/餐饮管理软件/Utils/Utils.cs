using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace yoogacatering.Utils
{
    class Utils
    {
        public static void WriteToExcel(DataTable table, String FileName)
        {
            try
            {
                SaveFileDialog SDialog = new SaveFileDialog();
                SDialog.Filter = "文档(*.xls)|*.xls";
                SDialog.ShowDialog();
                String FilePath = SDialog.FileName;
                System.IO.StreamWriter sw = new System.IO.StreamWriter(FilePath, true, System.Text.Encoding.Default); //写入流
                object[] values = new object[table.Columns.Count];
                sw.WriteLine("          " + FileName);
                sw.Write("\r\n");
                for (int i = 0; i < table.Columns.Count; ++i)
                {
                    if (table.Columns[i].Caption.ToString() == "列名")
                    {
                        table.Columns[i].Caption = "自己给列起的名字";
                    }
                    sw.Write(table.Columns[i].Caption.ToString());
                    sw.Write('\t');
                }
                sw.Write("\r\n");

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    for (int j = 0; j < values.Length; ++j)
                    {
                        sw.Write(table.Rows[i][j].ToString());
                        sw.Write('\t');
                    }
                    sw.Write("\r\n");
                }
                sw.Flush();
                sw.Close();
                MessageBox.Show("数据导出成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据导出异常" + ex.Message);
            }
        }
        public static bool Valid()
        {
            return true;
        }

        public static string GetChineseSpell(string strText)
        {
            int len = strText.Length;
            string myStr = "";
            for (int i = 0; i < len; i++)
            {
                myStr += getSpell(strText.Substring(i, 1));
            }
            return myStr;
        }
        public static string getSpell(string cnChar)
        {
            byte[] arrCN = Encoding.Default.GetBytes(cnChar);
            if (arrCN.Length > 1)
            {
                int area = (short)arrCN[0];
                int pos = (short)arrCN[1];
                int code = (area << 8) + pos;
                int[] areacode = { 45217, 45253, 45761, 46318, 46826, 47010, 47297, 47614, 48119, 48119, 49062, 49324, 49896, 50371, 50614, 50622, 50906, 51387, 51446, 52218, 52698, 52698, 52698, 52980, 53689, 54481 };
                for (int i = 0; i < 26; i++)
                {
                    int max = 55290;
                    if (i != 25) max = areacode[i + 1];
                    if (areacode[i] <= code && code < max)
                    {
                        return Encoding.Default.GetString(new byte[] { (byte)(65 + i) });
                    }
                }
                return "*";
            }
            else return cnChar;
        }

    }
}
