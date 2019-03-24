using System;
using variables;


namespace maincode
{
    class DiceRoller
    {



        public void Start()
        {
            Console.WriteLine("Welcome to the RPG dice roller.");

            Console.WriteLine("\n" + "what dice to roll?");

            // to get the die command
            Variables.DiceInput = Console.ReadLine();

            // tetsing to make sure we got the input
            Console.WriteLine("\n" + "you typed: " + Variables.DiceInput);
        }




        public void SplitInput(string die_input)
        {

            string[] first_split = die_input.Split('d');
            Console.WriteLine("\n" + "number of dice " + first_split[0]);
            Variables.NumOfDice = Int32.Parse(first_split[0]);

            if (die_input.Contains("+")) //2d6+7
            {
                //Console.WriteLine("contain +"); 

                string[] second_split = first_split[1].Split('+');
                // Console.WriteLine("\n" + "2d6+7 sides of dice: " + second_split[0]);
                Variables.NumOfSides = Int32.Parse(second_split[0]);
                //Console.WriteLine("\n" + "2d6+7 additive: " + second_split[1]);
                Variables.AddOrNeg = Int32.Parse(second_split[1]);

                Roll();

            }
            else if (die_input.Contains("-")) //2d6-7
            {
                //Console.WriteLine("contain -");

                string[] second_split = first_split[1].Split('-');
                //Console.WriteLine("\n" + "2d6-7 sides of dice: " + second_split[0]);
                Variables.NumOfSides = Int32.Parse(second_split[0]);
                //Console.WriteLine("\n" + "2d6-7 additive: " + second_split[1]);
                Variables.AddOrNeg = Int32.Parse(second_split[1]);

                Roll();
            }
            else //2d6
            {
                //Console.WriteLine("\n" + "this is the first number: " + first_split[0]);
                Variables.NumOfDice = Int32.Parse(first_split[0]);


                //Console.WriteLine("\n" + "first number: " + first_split[0]); //testing only
                Variables.NumOfDice = Int32.Parse(first_split[0]);
                //Console.WriteLine("\n" + "second number: " + first_split[1]); //testing only
                Variables.NumOfSides = Int32.Parse(first_split[1]);

                Roll();
            }
        }

        public void Roll()
        {
            Random Random = new Random();

            for (int i = 0; i < Variables.NumOfDice; i++)
            {
                Variables.Total += Random.Next(1, Variables.NumOfSides);
            }

            if (Variables.DiceInput.Contains("+"))
            {
                //Console.WriteLine("plus");
                Variables.Total += Variables.AddOrNeg;
            }
            else if (Variables.DiceInput.Contains("-"))
            {
                //Console.WriteLine("negative");
                Variables.Total -= Variables.AddOrNeg;
            }

            Console.WriteLine("this is it -- total: " + Variables.Total);
           
        }
    }
}