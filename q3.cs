using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class q3
    {
        public void ans()
        {
            int t = 0;
            Console.WriteLine("Input the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number");
            int b = int.Parse(Console.ReadLine());
            t = a;
            a = b;
            b = t;
            Console.WriteLine("After Swapping");
            Console.WriteLine("First number : " + a);
            Console.WriteLine("Second number : " + b);
            Console.ReadKey();
        }
    }
}
