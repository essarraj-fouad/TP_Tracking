using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TP_Tracking.Entities;

namespace TP_Tracking.BLL
{
    public class ConfigurationBLO
    {
        /// <summary>
        /// Load Configuration : 
        /// </summary>
        public static Repertories LoadConfiguration()
        {
            Entities.Repertories configuration = new Entities.Repertories();

            // Load List of requied repetories
            configuration.ListRepertory.Add(new Repertory() { Name = "TD" });
            configuration.ListRepertory.Add(new Repertory() { Name = "TP" });
            configuration.ListRepertory.Add(new Repertory() { Name = "Cours" });

            // Load List of TD

            // Load List of TP

            return configuration;

        }
    }
}
