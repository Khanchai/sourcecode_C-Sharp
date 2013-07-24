using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class ProgramFizzBuzz
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("Fizz Buzz" + "<---" + i);
                }
                else if (i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz" + "<---" + i);
                }
                else if (i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz" + "<---" + i);
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }
            System.Console.ReadKey();
        }
    }
}
