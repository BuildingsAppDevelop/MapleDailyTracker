using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleDailyTracker
{
    public class Daily
    {

        private string name;
        private bool dailyCheck;
        public Daily()
        {

        }

        public Daily(bool dailyCheck, string name)
        {
            this.Name = name;
            this.DailyCheck = dailyCheck;
        }

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public bool DailyCheck
        {
            get
            {
                return dailyCheck;
            }
            set
            {
                dailyCheck = value;
            }
        }

        public String GetDisplayText() => name;
    }
}
