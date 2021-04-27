using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._1
{
    internal class CheckClass
    {
        internal static void View()
        {
            FileSystemWatcher checkFiles = new FileSystemWatcher();
            checkFiles.Path = NewDirectory.FileFolder;
            checkFiles.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.LastAccess
                                    | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            checkFiles.EnableRaisingEvents = true;
            checkFiles.IncludeSubdirectories = true;
            checkFiles.Filter = "*.*";

            checkFiles.Created += new FileSystemEventHandler(WriteClass.WhenCreate);
            checkFiles.Renamed += new RenamedEventHandler(WriteClass.WhenRenamed);
            checkFiles.Changed += new FileSystemEventHandler(WriteClass.WhenChange);
            checkFiles.Deleted += new FileSystemEventHandler(WriteClass.WhenDelete);
            checkFiles.EnableRaisingEvents = true;
        }
    }
}
