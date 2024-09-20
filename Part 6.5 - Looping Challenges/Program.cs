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

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                { 
                    for (int k = i; k > 0; k--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(j); 
                }
                Console.Write("\n");
            }


            Console.ReadLine();
        }
    }
}
