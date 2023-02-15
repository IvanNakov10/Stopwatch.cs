using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Properties
{
    internal class Stopwatch
    {
        private DateTime startTime;
        private TimeSpan spendTime;

        public void Start()
        {
            startTime = DateTime.Now;
        }

        private void stop()
        {
            spendTime = DateTime.Now - startTime;
        }

        public string GetFullSpendTime()
        {
            this.stop();
            int min = spendTime.Minutes;
            int sec = spendTime.Seconds;
            string milsec = spendTime.Milliseconds.ToString().PadLeft(3, '0');
            return min + "min " + sec + "sec " + milsec + "msec";
        }

        public int GetFullSpendTimeInMilliseconds()
        {
            this.stop();
            int minAsMsec = 60 * 1000 * spendTime.Minutes;
            int secAsMsec = 1000 * spendTime.Seconds;
            int milliseconds = minAsMsec + secAsMsec + spendTime.Milliseconds;
            return milliseconds;
        }
    }
}
