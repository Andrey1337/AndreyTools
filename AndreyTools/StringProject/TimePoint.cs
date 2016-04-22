using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProject
{
    public class TimePoint
    {
        private long _milliseconds;
        private Point _point;
        private string _description;

        public TimePoint(long milliseconds, Point point, string description)
        {
            _milliseconds = milliseconds;
            _point = point;
            _description = description;
        }

        public override string ToString()
        {
            return String.Format("Time: {0}| Point: {1} | Description: {2}", MillisecondsToTime(_milliseconds),_point, _description);
        }

        /// <summary>
        /// TODO: Repair Hours String
        /// </summary>
        /// <param name="milliseconds"></param>
        /// <returns></returns>
        private static string MillisecondsToTime(long milliseconds)
        {
            long hrsCount = milliseconds / 3600;
            long minCount = (milliseconds - hrsCount * 3600) / 60;
            long secCount = milliseconds - hrsCount * 3600 - minCount * 60;
            string hrsString = hrsCount < 10 ? "0" + hrsCount : hrsCount.ToString();
            string minString = minCount < 10 ? "0" + minCount : minCount.ToString();
            string secString = secCount < 10 ? "0" + secCount : secCount.ToString();
            return String.Format("{0}:{1}:{2}", hrsString, minString, secString);
        }
    }
}
