using System;
using Assignment_2_Dice_Rolls;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("");
        Console.Write("How many dice rolls would you like to simulate? ");

        int numRolls = int.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRolls);
        Console.WriteLine("");

        diceRoller dice = new diceRoller();
        int[] rollResults = dice.RollDice(numRolls);

        for (int i = 2; i <= 12; i++)
        {
            int rollResult = rollResults[i];
            double v = ((double)rollResults[i] / numRolls) * 100;
            int percentRolled = (int)v;
            Console.WriteLine($"{i}: {new string('*', percentRolled)}");
        }

        Console.WriteLine("");
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}