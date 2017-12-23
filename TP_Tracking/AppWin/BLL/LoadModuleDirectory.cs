using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace TP_Tracking.BLL
{
    public class LoadModuleDirectory
    {
        public  static void Load()
        {
            // Load Root Directory
            string[] Files = Directory.GetFileSystemEntries(".");
            foreach (var file in Files)
            {
                FileInfo fileInfo = new FileInfo(file);
                FileData ParentfileData = new FileData() { FileInfo = fileInfo };
                ModuleDirectoryBLO.moduleDirectory.RootDirectoty.ChildsFils.Add(ParentfileData);


                // TD
                if (fileInfo.Name.Contains("TD"))
                {
                    ModuleDirectoryBLO.moduleDirectory.TD = ParentfileData;
                    LoadChildDataFile(ModuleDirectoryBLO.moduleDirectory.TD);
                }

                // TP
                if (fileInfo.Name.Contains("TP"))
                {
                    ModuleDirectoryBLO.moduleDirectory.TP = ParentfileData;
                    LoadChildDataFile(ModuleDirectoryBLO.moduleDirectory.TP);
                }

                // Cours
                if (fileInfo.Name.Contains("Cours"))
                {
                    ModuleDirectoryBLO.moduleDirectory.Cours = ParentfileData;
                    LoadChildDataFile(ModuleDirectoryBLO.moduleDirectory.Cours);
                }

            }
        }

        private static void LoadChildDataFile(FileData fileData)
        {
            string[] ChildsFiles = Directory.GetFileSystemEntries(fileData.FileInfo.FullName);
            foreach (var childFile in ChildsFiles)
            {
                FileInfo fileInfo = new FileInfo(childFile);
                fileData.ChildsFils.Add(new FileData() { FileInfo = fileInfo });
            }


        }

    }
}
