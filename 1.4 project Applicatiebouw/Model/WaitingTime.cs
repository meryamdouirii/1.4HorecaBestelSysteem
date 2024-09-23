using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WaitingTime
    {
        public DateTime Starttime { get; set; }

        public int timewaiting
        {
            get
            {
                TimeSpan timeDifference = Starttime - DateTime.Now;

                return (int)timeDifference.TotalMinutes * -1;
            }
        } 
    }
}
