using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakveContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 7)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("\n");
            for (int b = 1; b <= 10; b++)

            {
                if (b == 7)
                {
                    continue;

                }

                Console.WriteLine(b);
            }
            Console.ReadLine();
        }

    }
}
