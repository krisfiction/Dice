/*
 *  RPG Dice Roller
 *  By: Kris Fiction
 *  krisfiction@gmail.com
 *
 *  Microsoft Visual Studio Community 2017
 *  Visual C# Console App
 *
 *  RPG Dice Roller is a app to aid in rolling RPG dice.
 *  1d6 = rolls one six sided die
 *  2d6 = rolls two six sided die
 *  2d6+4 = rolls two six sided die and adds 4 to the total
 *  2d6-4 = rolls two six sided die and subtracts 4 from the total
 *
 *  Last Update: 03-11-2019
 */



using System;
using maincode;
using variables;

namespace AppTest 
{
    class Program
    {
        static void Main()
        {
            //rest variables - probably needs moved
            Variables.NumOfDice = 0;
            Variables.SetNumOfSides(0);
            Variables.Total = 0;
            Variables.SetAddOrNeg(0);

            
            //call dice program 
            DiceRoller diceRoller = new DiceRoller();
            diceRoller.Start();

            diceRoller.SplitInput(Variables.DiceInput);





            // switch case code
            Console.WriteLine("Would you like to roll again?");
            Console.WriteLine("1 for Yes or 2 for No");

            //need error checking for when useing enter a letter instead of a number

            int intTemp = Convert.ToInt32(Console.ReadLine());
            switch (intTemp)
            {
                case 1:
                    Console.WriteLine("yes");
                    Main();
                    break;
                    //re-run code here
                case 2:
                    Console.WriteLine("no");
                    Environment.Exit(0);
                    break;
                    //exit code here
                default:
                    Console.WriteLine("other");
                    Main();
                    break;
                    // re-run
            }
             



            /* if code
            Console.WriteLine("\n\n" + "Would you like to roll another");
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
            */







            //to keep console alive
            Console.WriteLine("\n" + "press any key to exit.");
            Console.ReadKey();
            
        }
        
    }
    
}
 