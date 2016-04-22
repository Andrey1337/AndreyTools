using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace StringProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "aaaa| X:2222, Y:1111 |dddd";
            //int x = str.LastIndexOf("X:");
            //Console.WriteLine(x);

            //List<TimePoint> timePoints = new List<TimePoint>();
            //timePoints.Add(new TimePoint(new DateTime().AddMilliseconds(4124124312), new Point(500, 500), "Game point"));
            //timePoints.Add(new TimePoint(new DateTime().AddMilliseconds(4124124312), new Point(321, 352), "Browser point"));
            //SerializeToJson(timePoints, "newJson.txt");

            ////List<TimePoint> timePoints = DeserializeFromJson("newJson.txt");
            //for (int i = 0; i < timePoints.Count; i++)
            //{
            //    Console.WriteLine(timePoints[i]);
            //}

        }

        public static void SerializeToJson(IEnumerable<TimePoint> timePoints, string path)
        {
            List<string> allTimePointJSons = new List<string>();

            allTimePointJSons.Add(JsonConvert.SerializeObject(timePoints.ToList()));

            File.WriteAllLines(path, allTimePointJSons);
        }

        public static List<TimePoint> DeserializeFromJson(string path)
        {
            try {
                List<TimePoint> timePoints = new List<TimePoint>();
                timePoints = JsonConvert.DeserializeObject<List<TimePoint>>(File.ReadAllLines(path)[0]);
                return timePoints;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
