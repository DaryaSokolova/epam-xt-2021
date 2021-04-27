using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static task_4._1.NewDirectory;

namespace task_4._1
{
    internal class WriteClass
    {
        internal static string temp;

        internal static void WhenCreate(object sender, FileSystemEventArgs e)
        {
            using (StreamWriter variableForCreate = new StreamWriter(MyLog, true, Encoding.Default))
            {
                temp = $"{ReserveFolder}\\{Guid.NewGuid()}";
                variableForCreate.WriteLine(DateTime.Now);
                variableForCreate.WriteLine(temp);
                variableForCreate.Write($"{e.Name} {e.ChangeType} {e.FullPath}" + Environment.NewLine);
                variableForCreate.Write(" ");
            }

            Directory.CreateDirectory(temp);
            CopyFiles(FileFolder, temp);
        }


        internal static void WhenRenamed(object sender, RenamedEventArgs e)
        {
            using (StreamWriter variableForRename = new StreamWriter(MyLog, true, Encoding.Default))
            {
                temp = $"{ReserveFolder}\\{Guid.NewGuid()}";
                variableForRename.WriteLine(DateTime.Now);
                variableForRename.WriteLine(temp);
                variableForRename.Write($"{e.OldFullPath} ->> {e.FullPath} {e.ChangeType} {e.FullPath}." + Environment.NewLine);
                variableForRename.Write(" ");
            }

            Directory.CreateDirectory(temp);
            CopyFiles(FileFolder, temp);
        }

        internal static void WhenChange(object sender, FileSystemEventArgs e)
        {
            using (StreamWriter variableForChange = new StreamWriter(MyLog, true, Encoding.Default))
            {
                temp = $"{ReserveFolder}\\{Guid.NewGuid()}";
                variableForChange.WriteLine(DateTime.Now);
                variableForChange.WriteLine(temp);
                variableForChange.Write($"{e.Name} {e.ChangeType} {e.FullPath}" + Environment.NewLine);
                variableForChange.Write(" ");
            }

            Directory.CreateDirectory(temp);
            CopyFiles(FileFolder, temp);
        }

        internal static void WhenDelete(object sender, FileSystemEventArgs e)
        {
            using (StreamWriter variableForDelete = new StreamWriter(MyLog, true, Encoding.Default))
            {
                temp = $"{ReserveFolder}\\{Guid.NewGuid()}";
                variableForDelete.WriteLine(DateTime.Now);
                variableForDelete.WriteLine(temp);
                variableForDelete.Write($"{e.Name} {e.ChangeType} {e.FullPath}" + Environment.NewLine);
                variableForDelete.Write(" ");
            }

            Directory.CreateDirectory(temp);
            CopyFiles(FileFolder, temp);
        }

        internal static void CopyFiles(string dir, string copyDir)
        {
            Directory.CreateDirectory(copyDir);

            foreach (string item in Directory.GetFiles(dir))
            {
                string file2 = copyDir + "\\" + Path.GetFileName(item);
                File.Copy(item, file2, true);
            }

            foreach (string item in Directory.GetDirectories(dir))
            {
                CopyFiles(item, copyDir + "\\" + Path.GetFileName(item));
            }

        }
    }
}
