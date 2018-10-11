using System;
using chapter1;

namespace chapter1_homework
{
    public class Ch1_hw
    {
        public void homework_1()
        {
            Console.WriteLine("请输入3个整数：");
            Console.Write("a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The average number is:{0}", (Convert.ToDouble(a + b + c) / 3).ToString("0.000"));
        }
        public void homework_2()
        {
            Console.Write("Please input Fahrenheit：");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The temperater is:{0}", (5 * (f - 32) / 9).ToString("0.000"));
        }
        public void homework_3()
        {
            Console.Write("1+2+...+n=?\nPlease input n：");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The temperater is:{0}", n * (1 + n) / 2);
        }
        public void homework_4()
        {
            Console.Write("Please input a positive integer number which should less than 360.\nn:");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 360 || n < 0)
            {
                Console.Write("Wrong Number! Please input again!\nn:");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("sin(n)={0},cos(n)={1}", Math.Sin(n), Math.Cos(n));
        }
        public void homework_5()
        {
            Console.WriteLine("Please input the number of clothes.");
            int n = Convert.ToInt32(Console.ReadLine());
            Double m = ((n * 95) < 300) ? (n * 95) : (n * 95 * 0.85);
            Console.WriteLine("You should pay {0} yuan", m.ToString("0.00"));
        }
        public void homework_6()
        {
            Console.WriteLine("Please input length of three side of a triangle.(positive interger number)");
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
            if ((a + b) < c)
                Console.WriteLine("not a triangle");
            else if (a * a + b * b == c * c)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
        public void homework_7()
        {
            Console.WriteLine("Please input the number of years.");
            int n = Convert.ToInt32(Console.ReadLine());
            int t = 0;
            if (n % 400 == 0)
                t = 1;
            else if (n % 100 != 0 && n % 4 == 0)
                t = 1;
            else
                t = 2;
            switch (t)
            {
                case 1:
                    Console.WriteLine("yes");
                    break;
                case 2:
                    Console.WriteLine("no");
                    break;
            }
        }
    }
}
