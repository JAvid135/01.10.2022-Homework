using System;
using System.Runtime.CompilerServices;

namespace Homework_01._10._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {   //================================================================
            // n ededi gelir. N ededinin sade ve ya murekkeb oldugunu tapin.
            // Taski bitirib githuba qoyub repositorinin linkini turn in edin.
            //================================================================
            int n = 6;
            if (n > 1)
            {
                if (n == 2 || n == 3 || n == 5 || n == 7)
                {
                    Console.WriteLine("Sadedir");
                }
                else
                {
                    if (n % 2 == 0 || n % 3 == 0 || n % 5 == 0 || n % 7 == 0)
                    {
                        Console.WriteLine("Murekkebdir");
                    }
                    else
                    {
                        Console.WriteLine("Sadedir");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
