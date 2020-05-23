/*
 *  RPG Dice Roller
 *  By: Kris Fiction
 *  krisfiction@gmail.com
 *
 *  Microsoft Visual Studio Community 2019
 *  C# Console App
 *
 *  RPG Dice Roller is a app to aid in rolling RPG dice.
 *  1d6 = rolls one six sided die (1 - 6)
 *  2d6 = rolls two six sided die (2 - 12)
 *  2d6+4 = rolls two six sided die and adds 4 to the total (6 - 16)
 *  2d6-4 = rolls two six sided die and subtracts 4 from the total (-2 - 8)
 *
 *  Last Update: 2020-05-23
 */

using System;
using RPGdice;

namespace AppTest
{
    internal static class Program
    {
        public static string Input { get; set; }
        public static int Answer { get; set; }


        private static void Main()
        {
            Console.WriteLine("Welcome to the RPG dice roller.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("what dice would you like to roll?");

            Input = Console.ReadLine();

            Dice dice = new Dice();
            Answer = dice.Roll(Input);
            Console.WriteLine(Answer);

            //! testing
            //int i = 0;
            //do
            //{
            //    int answer = dice.Roll("2d12+5"); //7, 29
            //    Console.WriteLine(answer);
            //    i++;
            //} while (i < 100);

            Console.WriteLine("\n\nWould you like to roll another");
            Console.WriteLine("[Y]es or [N]o");
            string x = Console.ReadLine();

            if (x == "y")
            {
                Main();
            }
            else if (x == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                Main(); //re-run if user enter wrong info
            }
        }
    }
}