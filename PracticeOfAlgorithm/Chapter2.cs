using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter2
{
    class Ch2
    {
        public void practice_1()
        {
            Console.WriteLine("Please input n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }
        public void practice_2()
        {
            for (int a = 1; a <= 9; a++)
                for (int b = 0; b <= 9; b++)
                {
                    int n = a * 1100 + b * 11;
                    int m = Convert.ToInt32(Math.Floor(Math.Sqrt(n) + 0.5));
                    if (m * m == n)
                    {
                        Console.WriteLine("{0}", n);
                    }
                }
        }
        public void practice_3()
        {
            for (int x = 1; ; x++)
            {
                int n = x * x;
                if (n < 1000) continue;
                if (n > 9999) break;
                int aa = n / 100;
                int bb = n % 100;
                if (aa / 10 == aa % 10 && bb / 10 == bb % 10)
                    Console.WriteLine("{0}", n);
            }

        }

        public void practice_4()
        {
            long n = Convert.ToInt64(Console.ReadLine());
            int count = 0;
            while (n > 1)
            {
                if (n % 2 == 1)
                    n = 3 * n + 1;
                else
                    n /= 2;
                count++;
                //Console.WriteLine("{0}", n);
            }
            Console.WriteLine("{0}", count);
        }
    }
}