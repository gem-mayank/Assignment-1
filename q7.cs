using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class q7
    {
        public void ans()
        {
            char[] arr = new char[6];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter letter : ");
                arr[i] = (char)Console.ReadKey().KeyChar;
                Console.ReadLine();

            }
            Console.WriteLine("\n");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
