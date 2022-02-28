using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine(week[i]);
            }
        }
    }
}