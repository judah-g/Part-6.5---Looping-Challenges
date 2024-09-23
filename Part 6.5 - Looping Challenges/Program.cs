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

            //9
            /*for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j < 10; j++)
                {
                    Console.Write(j - i);
                }
                Console.Write("\n");
            }*/

            //12
            /*for (int i = 1; i < 19; i++)
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
                else if (i > 10)
                {
                    for (int h = 0; h < i - 9; h++)
                    {
                        Console.Write(" ");
                    }
                    for (int g = i - 9; g < 10; g++)
                    {
                        Console.Write(g - (i - 10));
                    }
                }
                if (i != 10)
                {
                    Console.Write("\n");
                }
            }*/


            for (int i = 1; i < 19; i++)
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
                    for (int g = i - 9; g < 10; g++)
                    {
                        Console.Write(g - (i - 10));
                    }
                    for (int k = 1; k > 0; k--)
                    {
                        Console.Write(k - i);
                    }
                }

                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
