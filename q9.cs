using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class q9
    {
        public static bool AlmostOnlyLetters(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (!((a[i] >= 65 && a[i] <= 90) || (a[i] >= 97 && a[i] <= 122) || a[i] == 32))
                {
                    return false;

                }

            }
            return true;
        }
        public void ans()
        {
            String a = Console.ReadLine();
            bool res = AlmostOnlyLetters(a);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
