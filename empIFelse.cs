using System;

namespace ConsoleApp10
{
    class EmpWage
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int genNum = num.Next(0, 2);
           if (genNum = 1)
            {
               Console.WriteLine("Emp is present");
            }
            else
            {
                Console.WriteLine("Emp is absent");
            }
        }
    }
}
