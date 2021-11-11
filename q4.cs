using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class q4
    {
        public void ans()
        {
            Console.WriteLine("Input a First number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a second number: ");
            int b = int.Parse(Console.ReadLine());
            if ((a > -10 && a < 10) || (b > -10 && b < 10))
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");

            Console.ReadKey();
        }
    }
}
