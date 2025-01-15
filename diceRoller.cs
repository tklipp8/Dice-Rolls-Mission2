using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Dice_Rolls
{
    class diceRoller
    {
        Random rnd = new Random();

        public int[] RollDice(int numRolls)
        {
            int[] rollResults = new int[13];

            for (int i = 0; i < numRolls; i++)
            {
                int diceOne = rnd.Next(1, 7);
                int diceTwo = rnd.Next(1, 7);
                int diceCombo = diceOne + diceTwo;

                rollResults[diceCombo]++;
            }
            return rollResults;
        }
    }
}
