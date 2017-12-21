using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    public class ErrorMessage
    {

        public string Message { set; get; }
        public ErrorMessage(string msg)
        {
            this.Message = msg;
        }

       
        public override string ToString()
        {
            return this.Message;
        }
    }
}
