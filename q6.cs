using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class q6
    {
        public void ans()
        {
            int c = 1;
            while (true)
            {

                Console.WriteLine("enter username: ");
                String username = Console.ReadLine();
                Console.WriteLine("enter password: ");
                String password = Console.ReadLine();
                if (username != "username" || password != "password")
                {
                    if (c == 3)
                    {
                        Console.WriteLine("Rejected");
                        break;
                    }
                    else
                    {
                        c = c + 1;
                        Console.WriteLine("invalid credentials");
                        Console.WriteLine("attempts left :" + (3 - c));

                    }
                }
                else
                {
                    Console.WriteLine("Successfully Logged in");
                    break;
                }

            }
            Console.ReadKey();
        }
    }
}
