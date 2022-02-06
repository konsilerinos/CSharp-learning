using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Day day1 = Day.Fri;
            Day day2 = (Day)3;

            if (day1 == Day.Fri)
            {
                Console.WriteLine($"Friday, the num is {(int)day1}");
            }

            if((int) day2 == 3)
            {
                Console.WriteLine($"Tuesday, the num is {(int)day2}");
            }
        }
    }
}
