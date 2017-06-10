using System;

namespace _01_Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double high = double.Parse(Console.ReadLine());
            double wight = double.Parse(Console.ReadLine());

            var roomsWigh = (wight * 100) - 100;
            var colls = Math.Floor(roomsWigh / 70);
            //var desksOnRow = wokingPlaceWight * 70;           
            var roomsHigh = (high * 100);
            var rows = Math.Floor(roomsHigh / 120);

            var workingPlaces = (rows * colls) - 3;

            Console.WriteLine(workingPlaces);
        }
    }
}
