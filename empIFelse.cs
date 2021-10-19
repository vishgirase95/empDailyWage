using System;

namespace ConsoleApp10
{
    class EmpWage
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int genNum = num.Next(0, 1);
            Console.WriteLine(genNum);
        }
    }
}
