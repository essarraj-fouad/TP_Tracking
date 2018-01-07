using GApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    /// <summary>
    /// Validate error Message
    /// </summary>
    public class TraineeWorkValidateError: BaseEntity
    {
        public string Message { set; get; }
        public TraineeWorkValidateError(){}
        public TraineeWorkValidateError(string msg)
        {
            this.Message = msg;
        }
        public override string ToString()
        {
            return this.Message;
        }
    }
}
