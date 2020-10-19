using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = new TimeClass();
            time.Seconds = 10;
            UpdateTime(time);
            Console.WriteLine(time.Seconds);
            Console.ReadLine();

        }

        public static void UpdateTime(TimeClass time)
        {
            time.Seconds++;
        }

        public struct TimeStruct
        {
            public int Seconds { get; set; }

            public int CalculateMinutes()
            {
                return Seconds / 60;
            }
        }

       public class TimeClass
        {
            public int Seconds { get; set; }

            public int CalculateMinutes()
            {
                return Seconds / 60;
            }
        }
    }
}
