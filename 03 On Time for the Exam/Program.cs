using System;

namespace _03_On_Time_for_the_Exam
{
class Program
{
    static void Main(string[] args)
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinutes = int.Parse(Console.ReadLine());
        int arrivalHour = int.Parse(Console.ReadLine());
        int arrivalMinutes = int.Parse(Console.ReadLine());

        var examTimeInMinutes = (examHour * 60) + examMinutes;
        var arrivalTimeInMinutes = (arrivalHour * 60) + arrivalMinutes;
        var time = examTimeInMinutes - arrivalTimeInMinutes;

            var maikatiDeba = Math.Abs(arrivalHour - examHour);
            var bashtatiDeba = Math.Abs(arrivalMinutes - examMinutes);

            //On time

            if (examTimeInMinutes == arrivalTimeInMinutes)
            {
                Console.WriteLine("On time");
            }
            else if (time <= 30 && time > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", bashtatiDeba);
            }
            //Early

            else if (time > 30)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0}:{1} hours before the start", maikatiDeba, bashtatiDeba);
            }
            //Late

            else if (time < 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start",bashtatiDeba);
            }
            else
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0}:{1} hours after the start",maikatiDeba , bashtatiDeba);
            }

    }
}
}

