using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleDailyTracker
{
    public class DailyList
    {
        private List<Daily> dailyList;

        public DailyList()
        {
            dailyList = new List<Daily>();
        }

        public int Count => dailyList.Count;

        public Daily this[int i]
        {
            get
            {
                return dailyList[i];
            }
            set
            {
                dailyList[i] = value;
            }
        }

        public void Add(Daily daily)
        {
            dailyList.Add(daily);
        }

        public void Remove(Daily daily)
        {
            dailyList.Remove(daily);
        }

        public static DailyList operator - (DailyList d1, Daily d)
        {
            d1.Remove(d);
            return d1;
        }

    }
}
