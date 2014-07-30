using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace yoogacatering.Printer
{
    class PrintUtils
    {
        public static string GetConsumePrintName()
        {
            string conprinter = string.Empty;
            conprinter = System.Configuration.ConfigurationManager.AppSettings["conprinter"];
            return conprinter;
        }

        public static string GetKitchenPrintName()
        {
            string conprinter = string.Empty;
            conprinter = System.Configuration.ConfigurationManager.AppSettings["kitprinter"];
            return conprinter;
        }

        public static string GetBarPrintName()
        {
            string conprinter = string.Empty;
            conprinter = System.Configuration.ConfigurationManager.AppSettings["barprinter"];
            return conprinter;
        }

        public static List<string> GetAllPrint()
        {
            List<string> list = new List<string>();
            ManagementObjectSearcher query;
            ManagementObjectCollection queryCollection;
            string _classname = "SELECT * FROM Win32_Printer";

            query = new ManagementObjectSearcher(_classname);
            queryCollection = query.Get();

            foreach (ManagementObject mo in queryCollection)
            {
                list.Add(mo["Name"].ToString());
            }
            return list;

        }
        public static void SetDefaultPrint(string printName)
        {
            ManagementObjectSearcher query;
            ManagementObjectCollection queryCollection;
            string _classname = "SELECT * FROM Win32_Printer";

            query = new ManagementObjectSearcher(_classname);
            queryCollection = query.Get();

            foreach (ManagementObject mo in queryCollection)
            {

                if (string.Compare(mo["Name"].ToString(), printName, true) == 0)
                {
                    mo.InvokeMethod("SetDefaultPrinter", null);
                    break;
                }
            }
        }
    }
}
