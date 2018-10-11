using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1
{
    class Ch1
    {
        public void practice_1()
        {
            System.Console.WriteLine("1+1={0}", 1 + 1);
            System.Console.WriteLine("3-4={0}", 3 - 4);
            System.Console.WriteLine("5/6={0}", 5 / 6);
            System.Console.WriteLine("8/4={0}", 8 / 4);
            System.Console.WriteLine("8/5={0}", 8.0 / 5.0);
        }



        public void practice_3()
        {
            System.Console.WriteLine("{0}", 1 + 2 * System.Math.Sqrt(3) / (5 - 0.1));
        }

        public void practice_4()
        {
            System.Console.WriteLine("Please input 'a'");
            int a = Convert.ToInt32(Console.ReadLine()); ;
            System.Console.WriteLine("Please input 'b'");
            int b = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("a={0},b={1}", a, b);
            System.Console.WriteLine("a+b={0}", a + b);
        }

        private const double PI = 3.1415926;
        public void practice_5()
        {
            Console.WriteLine("Please input r:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input h:");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("r={0},h={1}", r, h);
            double s1 = PI * r * r;
            double s2 = 2.0 * PI * r * h;
            double s = 2.0 * s1 + s2;
            Console.WriteLine("s={0}", s.ToString("G6"));//保留6位有效数字
            Console.WriteLine("s={0}", s.ToString("0.00"));//保留小数点后两位有效数字
        }

        public void practice_6()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n={0}\n{1}{2}{3}", n, n % 10, n / 10 % 10, n / 100);
        }

        public void practice_7()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n={0}\n{1}", n, n % 10 * 100 + n / 10 % 10 * 10 + n / 100);
        }

        /*三变法*/
        public void practice_8()
        {
            Console.WriteLine("Please input a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a={0},b={1}", a, b);
            int t = a;
            Console.WriteLine("Switch:a={0},b={1}", a = b, b = t);
        }

        public void practice_9()
        {
            Console.WriteLine("Please input a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a={0},b={1}", a, b);
            Console.WriteLine("Switch:a={2},b={1}", a = a + b, b = a - b, a = a - b);
        }

        /*鸡兔同笼*/
        public void practice_10()
        {
            Console.WriteLine("How many rabbits and chicken here?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many legs here?");
            int m = Convert.ToInt32(Console.ReadLine());
            int a = (4 * n - m) / 2;
            int b = n - a;
            if (m % 2 == 1 || a < 0 || b < 0)
                Console.WriteLine("No Answer!");
            else
                Console.WriteLine("The Number of Chicken is:{0}\n The Number of Rabbits is:{1}", a, b);
        }
        /*三整数排序*/
        public void practice_11()
        {
            Console.WriteLine("Please input a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input c:");
            int c = Convert.ToInt32(Console.ReadLine());
            int t;
            if (a > b)
            {
                t = a;
                a = b;
                b = t;
            }
            if (a > c)
            {
                t = a;
                a = c;
                c = t;
            }
            if (b > c)
            {
                t = b;
                b = c;
                c = t;
            }
            Console.WriteLine("{0}\t{1}\t{2}", a, b, c);
        }
    }
}
