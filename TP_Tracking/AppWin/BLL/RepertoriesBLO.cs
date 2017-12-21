using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace TP_Tracking.BLL
{
    public class RepertoriesBLO
    {
        /// <summary>
        /// Load Repertories and Validate
        /// </summary>
        /// <returns></returns>
        public static Repertories LoadRepertoies()
        {
            
            Repertories repertories = new Repertories();

            // Load Root Repertories
            string[] files = Directory.GetFileSystemEntries(".");
            foreach (var item in files)
            {
                FileInfo fileInfo = new FileInfo(item);
                repertories.ListRepertory.Add(new Repertory() { FileInfo = fileInfo });
            }

            // Load TD
            LoadTD();

            // Load TP
            Repertory RepertoryTP = repertories.ListRepertory.Where(r => r.Name.ToUpper().Contains("TP")).FirstOrDefault();
            if (RepertoryTD == null)
            {
                string msg = string.Format("Le répertoir TP n'existe pas");
                repertories.AddErrorMessage(new ErrorMessage(msg));
            }
            else
            {

            }

            // Load Cours 


            // Validation
            Validation(repertories);

            return repertories;
        }

        private static void LoadRepertoryByName(List<Repertory> ListRepertory,string NameOfRepertory,Action<string> AddErrorMessage)
        {
            Repertory CheckedRepertory = ListRepertory.Where(r => r.Name.ToUpper().Contains(NameOfRepertory)).FirstOrDefault();
            if (CheckedRepertory == null)
            {
                string msg = string.Format("Le répertoir TD n'existe pas");
                AddErrorMessage(new ErrorMessage(msg));
            }
            else
            {
                string[] directoryTD = Directory.GetFileSystemEntries(RepertoryTD.FileInfo.FullName);
                foreach (var item in directoryTD)
                {
                    FileInfo fileInfo = new FileInfo(item);
                    repertories.ListTD.Add(new Repertory() { FileInfo = fileInfo });
                }

            }
        }

        private static void Validation(Repertories repertories)
        {
            RepertoriesConfiguration Configuration = ConfigurationBLO.LoadConfiguration();

            // Check Directory that do not have to exist
            foreach (var repetory in repertories.ListRepertory)
            {
                if (Configuration.ListRepertory.Where(config => config.Name == repetory.FileInfo.Name).Count() != 0)
                    repetory.Validation = Enumerations.ValisationStat.Valid;
                else
                {
                    repetory.Validation = Enumerations.ValisationStat.NotValid;
                    string msg = string.Format("Le répertoir {0} ne doit pas exister",repetory.Name);
                    repertories.AddErrorMessage(new ErrorMessage(msg));
                    
                }
            }
           
        }
    }
}
