using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace famas_last_theorem
{
    class Program
    {
        static void Main(string[] args)
        {
            strt:
            //x^n + y^n = z^n
            //ОДЗ:
            //x, y, z != 0;
            //x, y, z є Z;
            //n є N
            //n > 2;
            int[] x, y, z;
            x = new int[200];
            y = new int[200];
            z = new int[200];

            //x[1] = 5;
            //int n = 3;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            int solutions = 0;
            Number p;
            p = new Number();
            x[0] = 3;
            x = p.Pow(x, 3);
            int l = 0;
            for (int i2 = 199; i2 > -1; i2--)
            {
                if (x[i2] > 0)
                {
                    l = i2;
                    break;
                }
            }
            for (int i1 = l; i1 > -1; i1--)
                Console.Write(x[i1]);
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor= ConsoleColor.Yellow;
            p = new Unnumber();
            x = y;
            x[0] = 3;
            x = p.Pow(x, 3);
            l = 0;
            for (int i2 = 199; i2 > -1; i2--)
            {
                if (x[i2] > 0)
                {
                    l = i2;
                    break;
                }
            }
            
            for (int i1 = l; i1 > -1; i1--)
                Console.Write(x[i1]);
            Console.WriteLine();
            p = new Num();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.White;
            x = z;
            x[0] = 3;
            x = p.Pow(x, 3);
            l = 0;
            for (int i2 = 199; i2 > -1; i2--)
            {
                if (x[i2] > 0)
                {
                    l = i2;
                    break;
                }
            }
            for (int i1 = l; i1 > -1; i1--)
                Console.Write(x[i1]);
            Console.WriteLine();
            /*for (n = 3; n < 20; n++)
            {
                //for (double x = 1; x < 11; x++)
                //{

                //    for (double y = 1; y < 11; y++)
                //    {

                //        for (double z = 1; z < 11; z++)
                //        {
                //            if ((x != 0) && (y != 0) && (z != 0))
                //            {
                //                if ((Power(x, n) + Math.Pow(y, n)) == Math.Pow(z, n))
                //                {
                //                    solutions++;
                //                    Console.WriteLine("Sol. {0}: x = {1}; y = {2}; z = {3}; n = {4}", solutions, x, y, z, n);
                //                    Console.WriteLine(Math.Pow(x, n) + " + " + Math.Pow(y, n) + " = " + Math.Pow(z, n));
                //                }
                //            }
                //        }
                //    }
                //}
            }*/
            //Console.WriteLine("Amount of solutions = {0}", solutions);
            

            if (ConsoleKey.A.Equals(false))
            {
                goto strt;
            }
            else
            {
                Console.ReadKey(ConsoleKey.A.Equals(false));
            }
            
        }

        class Number
        {
            public int[] Pow(int[] a, int n)
            {
                int length = 0;
                for (int i = 199; i > -1; i--)
                {
                    if (a[i] > 0)
                    {
                        length = i + 1;
                        break;
                    }
                }
                long x = 0;
                int q = 1;
                for (int i = 0; i < length; i++, q *= 10)
                {
                    x += a[i] * q;
                }
                for (int i = 0; i < n; i++)
                { 
                    for (int j = 0; j < length; j++)
                    {
                        a[j] += (int)x;
                        if (a[j] > 9)
                        {
                            a[j + 1]++;
                            a[j] -= 10;
                            for (int i1 = 199; i1 > -1; i1--)
                            {
                                if (a[i1] > 0)
                                {
                                    if (length != i1 + 1)
                                        j = -1;
                                    length = i1 + 1;
                                    break;
                                }
                            }
                        }
                    }
                    //a0 = a;
                }
                return a;
            }
            //public int[] Multiplication()
            //{
            //    return;
            //}
            //public int[] Sum(int []a, int b)
            //{

            //    return ;
            //}
        }

        class Unnumber : Number
        {

        }

        class Num : Unnumber
        {

        }
    }
}
