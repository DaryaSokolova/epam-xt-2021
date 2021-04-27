using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_4._1
{
    internal class NewDirectory
    {
        internal const string FileFolder = @"C:\MyDirectory\FileFolder";
        internal const string ReserveFolder = @"C:\MyDirectory\ReserveFolder";
        internal const string MyLog = @"C:\MyDirectory\log.txt";

        internal static void CreateSourceFilesAndFolders()
        {
            DirectoryInfo directoryMain = new DirectoryInfo(FileFolder);

            if (!directoryMain.Exists)
            {
                directoryMain.Create();
            }

            DirectoryInfo directoryRecovery = new DirectoryInfo(ReserveFolder);

            if (!directoryRecovery.Exists)
            {
                directoryRecovery.Create();
            }

            FileInfo fileLog = new FileInfo(MyLog);

            if (!fileLog.Exists)
            {
                fileLog.Create().Close();
            }
        }
    }
}
