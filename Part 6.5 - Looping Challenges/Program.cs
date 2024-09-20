using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6._5___Looping_Challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //10
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i * j > 9)
                        Console.Write(" ");
                    else
                        Console.Write("  ");
                    Console.Write(j * i); 
                }
                Console.Write("\n");
            }
            */

            /* //11
            for (int i = 1; i < 10; i++)
            {
                for (int l = 10; l > i; l--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write(j);
                }
                for (int k = i - 1; k > 0; k--)
                {
                    Console.Write(k);
                }
                Console.Write("\n");
            }
            */

            /* //9
            for (int i = 10; i > 0; i--)
            {
                for (int k = i; k < 10; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
            */

            for (int i = 1; i < 20; i++)
            {
                if (i < 10)
                {
                    for (int l = 10; l > i; l--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j < i + 1; j++)
                    {
                        Console.Write(j);
                    }
                    for (int k = i - 1; k > 0; k--)
                    {
                        Console.Write(k);
                    }
                }
                else
                {
                    /*for (int p = i - 10; p > 0; p--)
                    {
                        Console.Write(" ");
                    }*/
                    for (int h = 10; h > i - 10; h--)
                    {
                        Console.Write(h);
                    }
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
