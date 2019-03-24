using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    public class Variables
    {

//number of side
        private static int nos = 0;

        public static int NumOfSides
        {
            get { return nos; }
            set { nos= value; }
        }

//number of dice
        private static int nod = 0;

        public static int NumOfDice
        {
            get { return nod; }
            set { nod = value; }
        }

//additive or negative
        private static int aon = 0;

        public static int AddOrNeg
        {
            get { return aon; }
            set { aon = value; }
        }

//dice input
        private static string di;

        public static string DiceInput
        {
            get { return di; }
            set { di = value; }
        }

//total
        private static int tot = 0;

        public static int Total
        {
            get { return tot; }
            set { tot = value; }
        }




    }
}