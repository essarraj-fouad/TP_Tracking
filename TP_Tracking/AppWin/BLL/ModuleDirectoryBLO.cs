using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TP_Tracking.Entities;

namespace TP_Tracking.BLL
{
    public class ModuleDirectoryBLO
    {
        public static ModuleDirectory moduleDirectory = new ModuleDirectory();
        public static DataFilesConfiguration dataFilesConfiguration;
        public static TrakingState trakingState;

        /// <summary>
        /// Load and Validate Repertories 
        /// </summary>
        /// <returns></returns>
        public static ModuleDirectory Load_Validate_SaveTraineeState()
        {

             moduleDirectory = new ModuleDirectory();
             trakingState = new TrakingState();

            // Load  moduleDirectory 
            LoadModuleDirectory.Load();

            // Validation moduleDirectory
            ValidateModuleDirectory.Validation(moduleDirectory);

            return moduleDirectory;
        }


     

       

        public static void SaveModuleDirectoryStat()
        {
            if (USBDevice.GetDeviceInfo() != null)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ModuleDirectory));
                string path = USBDevice.GetDeviceInfo().RootDirectory.FullName + "SuiviTP_Madani_Ali.xml";
                TextWriter TextWriter = new StreamWriter(path);
                xmlSerializer.Serialize(TextWriter, ModuleDirectoryBLO.moduleDirectory);
                TextWriter.Close();
            }else
            {
                throw new USBDeviceNotExistException();
            }
           
        }
    }
}
