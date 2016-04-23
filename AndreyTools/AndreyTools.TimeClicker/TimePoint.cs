using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace AndreyTools.TimeClicker
{
    public class TimePoint : IComparable
    {
        public DateTime Time { get;  set; }
        public Point Point { get; set; }
        public string Description { get; set; }

        public TimePoint(DateTime time, Point point, string description)
        {
            Time = time;
            Point = point;
            Description = description;
        }

        public override string ToString()
        {
            return String.Format("Time: {0} | Point: {1} | {2}", Time.ToLongTimeString(), Point, Description);
        }

        public int CompareTo(object obj)
        {
            TimePoint point = (TimePoint)obj;
            if (this.Time > point.Time)
                return 1;
            if (this.Time < point.Time)
                return -1;
            return 0;
        }
    }
}
