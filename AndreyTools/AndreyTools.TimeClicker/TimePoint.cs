using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace AndreyTools.TimeClicker
{
    public class TimePoint
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
    }
}
