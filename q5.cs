using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class q5
    {
        public void ans()
        {
            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine((a + b) * 3);
            }
            else
            {
                Console.WriteLine(a + b);
            }
            Console.ReadKey();
        }
    }
   
}
