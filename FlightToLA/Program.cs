using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightToLA
{
    class Program
    {
        
        static void Main(string[] args)
        {
            FlightsFromMilwaukee flights = new FlightsFromMilwaukee();
            DateTime time = new DateTime(2016, 5, 10, 23, 59, 0);
            string flightNumber = "0";
            foreach (string[] linearray in flights)
            {
                if(linearray[1] == "losAngeles")
                {
                    DateTime flightTime = DateTime.Parse(linearray[2]);
                    int result = DateTime.Compare(time, flightTime);
                    if (result > 0)
                    {
                        time = flightTime;
                        flightNumber = linearray[0];
                    }
                }
            }
            Console.WriteLine("flightNumber: {0}, leaving at {1}", flightNumber, time);
            Console.ReadKey();
        }
    }
}
