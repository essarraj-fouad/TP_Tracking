﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Enumerations;

namespace TP_Tracking.Entities
{
    public class Repertory
    {
        public Repertory()
        {
            this.Validation = ValisationStat.Neutral;
        }

        private FileInfo fileInfo;
        public FileInfo FileInfo
        {
            set
            {
                this.fileInfo = value;
                this.Name = fileInfo.Name;
            }
            get
            {

                return this.fileInfo;
            }
        }
        public string Name
        {
            set;
            get;
        }

        public ValisationStat Validation { set; get; }
        public string ValidationErrorMessage { set; get; }

    }
}
