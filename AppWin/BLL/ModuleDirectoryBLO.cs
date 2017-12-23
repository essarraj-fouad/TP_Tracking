using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TP_Tracking.DAL;
using TP_Tracking.Entities;

namespace TP_Tracking.BLL
{
    public class ModuleDirectoryBLO
    {
        private ModuleDirectoryDAO moduleDirectoryDAO;
        private ValidateModuleDirectoryBLO validateModuleDirectoryBLO;

        public ModuleDirectory ModuleDirectory {
            get
            {
                return moduleDirectoryDAO.ModuleDirectory;
            }
        }

        public ModuleDirectoryBLO()
        {
            moduleDirectoryDAO = new ModuleDirectoryDAO();
            validateModuleDirectoryBLO = new ValidateModuleDirectoryBLO(moduleDirectoryDAO.ModuleDirectory);
            this.Validate();
        }

        /// <summary>
        /// Validate Repertories 
        /// </summary>
        /// <returns></returns>
        public void Validate()
        {
            validateModuleDirectoryBLO.Validation();
        }
        /// <summary>
        /// Save Job State
        /// </summary>
        public void SaveState()
        {
            moduleDirectoryDAO.SaveModuleDirectoryStat();
        }

        public static void CreateConfigurationFileExample()
        {
             ValidateModuleDirectoryBLO.CreateConfigurationFileExample();
        }
    }
}
