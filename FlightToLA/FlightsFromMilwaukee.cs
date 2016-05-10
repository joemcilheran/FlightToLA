using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightToLA
{
    class FlightsFromMilwaukee
    {
        public FlightsFromMilwaukee()
        {

        }
        public IEnumerator GetEnumerator()
        {
            string path = get_file_path("FlightList");
            string[] flightSchedule = read_file(path);
            foreach(string line in flightSchedule)
            {
                string[] lineArray = splitString(line);
                yield return lineArray;
            }

        }
        public string get_file_path(string fileName)
        {
            string path = String.Format(@"C: \Users\Joseph A McIlheran\Documents\Visual Studio 2015\Projects\FlightToLa\FlightToLa\{0}.txt", fileName);
            return path;
        }
        public string[] read_file(string path)
        {
            string[] file = File.ReadAllLines(path);
            return file;
        }
        public string[] splitString(string input)
        {
            Char delimiter = ',';
            String[] inputString = input.Split(delimiter);
            return inputString;
        }
    }
}
