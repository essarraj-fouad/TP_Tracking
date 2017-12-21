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
        public static RepertoriesConfiguration LoadConfiguration()
        {
            RepertoriesConfiguration configuration = new Entities.ModuleDirectory();

            // Load List of requied repetories
            configuration.ListRepertory.Add(new FileData() { Name = "TD" });
            configuration.ListRepertory.Add(new FileData() { Name = "TP" });
            configuration.ListRepertory.Add(new FileData() { Name = "Cours" });

            // Load List of TD

            // Load List of TP

            return configuration;

        }
    }
}
