using System;
using System.IO;

namespace SmartBuilder
{
    public static class FileManager
    {

        public static void CreateDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);
        }

        public static void DeleteDirectory(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
                Directory.Delete(directoryPath, true);
        }

        public static void InitializeMainFolder()
        {
            USUtil.CurrentPath = Properties.Settings.Default.SavePath;
            if (String.IsNullOrEmpty(USUtil.CurrentPath))
                USUtil.CurrentPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            CreateDirectory(Path.Combine(USUtil.CurrentPath, USUtil.DumpFolderName));
           USUtil.SavePath = USUtil.CurrentPath + "\\" + USUtil.DumpFolderName + "\\";

            Properties.Settings.Default.SavePath = USUtil.CurrentPath;
            Properties.Settings.Default.Save();
        }


    }
}
