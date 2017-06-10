using System;

class TransportPrice
{
    static void Main()
    {
        int distance = int.Parse(Console.ReadLine());
        string dayTime = Console.ReadLine();

        var price = 0.0;
        if (dayTime == "day" && distance < 20)
        {
            price = 0.7 + (distance * 0.79);
        }
        else if (dayTime == "night" && distance < 20)
        {
            price = 0.7 + (distance * 0.9);
        }
        else if (dayTime == "day" && distance >= 20 && distance < 100)
        {
            price = distance * 0.09;
        }
        else if (dayTime == "night" && distance >= 20 && distance < 100)
        {
            price = distance * 0.09;
        }
        else if (dayTime == "day" && distance >= 100)
        {
            price = distance * 0.06;
        }
        else if (dayTime == "night" && distance >= 100)
        {
            price = distance * 0.06;
        }
        Console.WriteLine(price);
    }
}
