using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceDAO
    {
        private static string FormerDeviceVolumeLabel = "Formateur";
       
        public DriveInfo GetFormerDeviceInfo()
        {
            DriveInfo driveFormateur = DriveInfo.GetDrives()
                         .Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable)
                         .Where(drive => drive.VolumeLabel == "Formateur")
                         .FirstOrDefault();

            return driveFormateur;
        }

        public bool isFormerDeviceExist()
        {
            if (GetFormerDeviceInfo() == null)
                return false;
            else
                return true;
        }
    }
}
