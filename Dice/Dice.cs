using System;

namespace RPGdice

{
    public class Dice
    {
        private readonly Random random = new Random();

        public int Total { get; set; }

        public string Input { get; set; }

        public int NumberOfDice { get; set; }

        public int NumberOfSides { get; set; }

        public int Modifier { get; set; }

        public string FirstSplit { get; set; }

        public string SecondSplit { get; set; }


        public int Roll(string dice_input)
        {
            Input = dice_input;
            Total = 0;

            Parse(dice_input);

            return Total;
        }


        private void Parse(string _diceInput)
        {
            string[] FirstSplit = _diceInput.Split('d');
            NumberOfDice = Int32.Parse(FirstSplit[0]);

            if (_diceInput.Contains("+"))
            {
                string[] SecondSplit = FirstSplit[1].Split('+');

                NumberOfSides = Int32.Parse(SecondSplit[0]);

                Modifier = Int32.Parse(SecondSplit[1]);

                Math(NumberOfDice, NumberOfSides, Modifier);
            }
            else if (_diceInput.Contains("-"))
            {
                string[] SecondSplit = FirstSplit[1].Split('-');

                NumberOfSides = Int32.Parse(SecondSplit[0]);

                Modifier = Int32.Parse(SecondSplit[1]);

                Math(NumberOfDice, NumberOfSides, Modifier);
            }
            else
            {
                NumberOfDice = Int32.Parse(FirstSplit[0]);

                NumberOfSides = Int32.Parse(FirstSplit[1]);

                Math(NumberOfDice, NumberOfSides);
            }
        }

        private void Math(int numberOfDice, int numberOfSides)
        {
            for (int i = 0; i < numberOfDice; i++)
            {
                Total += random.Next(1, numberOfSides + 1);
            }
        }

        private void Math(int numberOfDice, int numberOfSides, int modifier)
        {
            for (int i = 0; i < numberOfDice; i++)
            {
                Total += random.Next(1, numberOfSides + 1);
            }

            if (Input.Contains("+"))
            {
                Total += modifier;
            }
            else if (Input.Contains("-"))
            {
                Total -= modifier;
            }
        }
    }
}