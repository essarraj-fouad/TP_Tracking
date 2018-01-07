using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Trainee : User
    {
        public Trainee() { }
        public Trainee(string TraineeWroksFolderName):base()
        {
            if(!string.IsNullOrEmpty(TraineeWroksFolderName))
            {
                string[] names = TraineeWroksFolderName.Split(' ');
                if (names.Count() > 0)
                    this.FirstName = names[0];
                if (names.Count() > 1)
                    this.LastName = names[1];
                if (names.Count() == 0)
                    this.FirstName = TraineeWroksFolderName;
            }
        }

        public virtual Group Group { set; get; }
    }
}
