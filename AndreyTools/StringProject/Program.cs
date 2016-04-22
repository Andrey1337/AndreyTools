using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "aaaa| X:2222, Y:1111 |dddd";
            //int x = str.LastIndexOf("X:");
            //Console.WriteLine(x);

            List<TimePoint> timePoints = new List<TimePoint>();
            timePoints.Add(new TimePoint(123141, new Point(500, 500), "Game point"));
            timePoints.Add(new TimePoint(24135, new Point(321, 352), "Browser point"));
        }

        public static void SerializeToJson(IEnumerable<TimePoint> timePoints)
        {

        }

        public static void DeserializeFromJson()
        {

        }
    }
}
