using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, r = 0, i;
            int s1 = 0, s2 = 0, l1 = 0, l2 = 0;
            n = int.Parse(Console.ReadLine());
            x = n;
            for (i = 0; i < x; i++)
            {
                if (n % 3 == 0)
                {
                    if (n > l1) l1 = n;
                    else if (n < l2) l2 = n;
                }
                if (n % 3 == 1)
                {
                    if (n > s1) s1 = n;
                }
                if (n % 3 == 2)
                {
                    if (n > s2) s2 = n;
                }
                n = int.Parse(Console.ReadLine());
            }
            r = Math.Max(l1 + l2, s1 + s2);
            Console.WriteLine(r);

            Console.ReadKey();



        }
    }
}
