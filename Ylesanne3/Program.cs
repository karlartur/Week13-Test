using System;
using System.Collections.Generic;
using System.IO;
namespace Ylesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            string starsPath = @"\Users\opilane\samples\test\stars.txt";
            string planetsPath = @"\Users\opilane\samples\test\planets.txt";
            string MilkyWayPath = @"\Users\opilane\samples\test\MilkyWay.txt";
            List<string> stars = new List<string>();
            List<string> planets = new List<string>();

            string[] sourceData = File.ReadAllLines(MilkyWayPath);

            foreach (string element in sourceData)
            {
                if (element.Contains("star"))
                {
                    stars.Add(element);
                }
                if (element.Contains("planet"))
                {
                    planets.Add(element);
                }
            }

            File.WriteAllLines(starsPath, stars);
            File.WriteAllLines(planetsPath, planets);
        }
    }
}
