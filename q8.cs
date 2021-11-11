using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class q8
    {
        public static bool itconsistsofuppercase(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 97 && a[i] <= 122)
                {
                    return false;
                }
            }
            return true;
        }
        public void ans()
        {
            String s = Console.ReadLine();
            bool res;
            res = itconsistsofuppercase(s);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
