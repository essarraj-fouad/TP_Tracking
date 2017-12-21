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
        public static Repertories LoadRepertoies()
        {
            // Load Repertories
            Repertories repertories = new Repertories();
            string[] files = Directory.GetFileSystemEntries(".");
            
            foreach (var item in files)
            {
                FileInfo fileInfo = new FileInfo(item);
                
                repertories.ListRepertory.Add(new Repertory() { FileInfo = fileInfo });
            }

            // Validation
            Validation(repertories);

            return repertories;
        }

        private static void Validation(Repertories repertories)
        {
            foreach (var repetory in repertories.ListRepertory)
            {
                Repertories Configuration = ConfigurationBLO.LoadConfiguration();
                if (Configuration.ListRepertory.Where(config => config.Name == repetory.FileInfo.Name).Count() != 0)
                    repetory.Validation = Enumerations.ValisationStat.Valid;
                else
                    repetory.Validation = Enumerations.ValisationStat.NotValid;

            }
        }
    }
}
