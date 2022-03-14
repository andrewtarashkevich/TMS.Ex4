using System;

namespace TMS.Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Введите число: ");
            int a1 = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 1000; i++)
            {
                if (i % a1 == 0)
                    Console.WriteLine(i);
            }

            //Задание 2
            Console.WriteLine("Введите число: ");
            int a2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Math.Pow(a2, 2); i++)
            {
                if (Math.Pow(i, 2) < a2)
                    Console.WriteLine(i);
            }

            //Задание 3
            Console.WriteLine("Введите число: ");
            int max_d3 = 0;
            int a3 = int.Parse(Console.ReadLine());
            for (int i = 1; i < a3; i++)
            {
                if (a3 % i == 0)
                    max_d3 = i;
            }
            Console.WriteLine(max_d3);

            //Задание 4
            Console.Write("Введите число: ");
            int a4 = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int b4 = int.Parse(Console.ReadLine());
            int sum4 = 0;
            for (int i = Math.Min(a4, b4); i <= Math.Max(a4, b4); i++)
            {
                if (i % 7 == 0)
                    sum4 += i;
            }
            Console.WriteLine(sum4);

            //Задание 5
            Console.Write("Введите число: ");
            int a5 = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int b5 = int.Parse(Console.ReadLine());
            int dividend5 = Math.Max(a5, b5);
            int divisor5 = Math.Min(a5, b5);
            int quotient5 = dividend5 / divisor5;
            int remainder5 = dividend5 - quotient5 * divisor5;
            do
            {
                dividend5 = divisor5;
                divisor5 = remainder5;
                quotient5 = dividend5 / divisor5;
                remainder5 = dividend5 - quotient5 * divisor5;

            } while (remainder5 != 0);
            Console.WriteLine(divisor5);

            //Задание 6
            Console.Write("Введите число: ");
            double a6 = double.Parse(Console.ReadLine());

            //Задача 7
            Console.Write("Введите число: ");
            int a7 = int.Parse(Console.ReadLine());
            int sum7 = 0;
            foreach (var i in a7.ToString())
            {
                string i_str7 = Convert.ToString(i);
                int i_int7 = Convert.ToInt32(i_str7);
                if (i_int7 % 2 != 0)
                    sum7 += (int)i_int7;
            }
            Console.WriteLine(sum7);

            //Задача 8
            Console.Write("Введите число: ");
            int a8 = int.Parse(Console.ReadLine());
            do
            {
                Console.Write(a8 % 10);
                a8 = a8 / 10;
            } while (a8 / 10 != 0);
            Console.Write(a8);

            //Задача 9
            Console.Write("Введите число: ");
            int a9 = int.Parse(Console.ReadLine());
            for (int j = 0; j < a9; j++)
            {
                int i = j;
                int even = 0; //четные
                int odd = 0; //нечетные
                do
                {
                    if ((i % 10) % 2 == 0)
                        even += i % 10;
                    else
                        odd += i % 10;
                    i = i / 10;
                } while (i / 10 != 0);

                if ((i % 10) % 2 == 0)
                    even += i % 10;
                else
                    odd += i % 10;

                if (even > odd)
                    Console.WriteLine(j);
            }

            //Задача 10
            Console.Write("Введите число: ");
            int a10 = 123/*int.Parse(Console.ReadLine())*/;
            Console.Write("Введите число: ");
            int b10 = 456/*int.Parse(Console.ReadLine())*/;
            int min10 = Math.Min(a10, b10);
            int max10 = Math.Max(a10, b10);
            bool flag = false;
            for (int i = 0; i < Math.Max(a10, b10).ToString().Length; i++)
            {
                
                do
                {
                    do
                    {
                        if ((min10 % 10) == (max10 % 10))
                            flag = true;
                        else
                            flag = false;
                        min10 = min10 / 10;
                    } while (min10 / 10 != 0);

                    if ((min10 % 10) == (max10 % 10))
                        flag = true;
                    else
                        flag = false;

                    max10 = max10 / 10;
                } while (max10 / 10 != 0);
            }

            if ((min10 % 10) == (max10 % 10))
                flag = true;
            else
                flag = false;


            if (flag == true)
                Console.WriteLine("Да");
            else
                Console.WriteLine("Нет");
        }
    }
}
