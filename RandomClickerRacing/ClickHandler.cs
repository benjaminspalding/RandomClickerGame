using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClickerRacing
{
    public static class ClickHandler
    {
        public static bool CanLoad(ref int tempTracker, int benchmark)
        {
            tempTracker = tempTracker + 1;

            return tempTracker >= benchmark;
        }
    }
}
