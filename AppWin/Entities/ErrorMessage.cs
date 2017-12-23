using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    /// <summary>
    /// Validate error Message
    /// </summary>
    public class ValidateErrorMessage
    {
        public string Message { set; get; }
        public ValidateErrorMessage(){}
        public ValidateErrorMessage(string msg)
        {
            this.Message = msg;
        }
        public override string ToString()
        {
            return this.Message;
        }
    }
}
