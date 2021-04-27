using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._1
{
    internal class ResetClass
    {
        private static Dictionary<DateTime, string> tableOfLogs = new Dictionary<DateTime, string>();
        private static DateTime date;
        private static string[] strFile = File.ReadAllLines(NewDirectory.MyLog);

        internal static void RollBack(DateTime dataTemp)
        {
            AddToTable();

            NewTable(dataTemp);
        }

        private static void AddToTable()
        {
            for (int i = 0; i < strFile.Length; i++)
            {
                if (DateTime.TryParse(strFile[i], out date) && !tableOfLogs.ContainsKey(date))
                {
                    tableOfLogs.Add(date, strFile[i + 1]);
                }
            }
        }

        private static void NewTable(DateTime dateValue)
        {
            foreach (var item in tableOfLogs)
            {
                if (item.Key >= dateValue)
                {
                    Directory.Delete(NewDirectory.FileFolder, true);
                    Directory.CreateDirectory(NewDirectory.FileFolder);
                    WriteClass.CopyFiles(item.Value, NewDirectory.FileFolder);

                    break;
                }
            }

        }
    }
}
