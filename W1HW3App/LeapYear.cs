using System;
namespace HelloWorld
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                int year =int.Parse(Console.ReadLine());
                Console.WriteLine((year%4==0)?((year%100==0&&year%400!=0)?"no":"yes"):"no");
            }
            
        }
    }
}