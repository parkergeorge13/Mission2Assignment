using System;

namespace Mission2Assignment
{
    class Program
    {
        //Parker George
        //Section 04
        //Group 12
        static void Main(string[] args)
        {
            //Variables
            int rolls = 0;
            int num1 = 0;
            int num2 = 0;
            Random rnd = new Random();

            //Initial UI
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");

            rolls = int.Parse(Console.ReadLine());
            int[] totalNum = new int[11];

            //Group the rolls by how many times the dice added up to each number
            for (int i = 0; i < rolls; i++)
            {
                int combinedRoll = 0;
                num1 = rnd.Next(1, 7);
                num2 = rnd.Next(1, 7);
                combinedRoll = num1 + num2;

                if (combinedRoll == 2) { totalNum[0] = totalNum[0] + 1; }
                if (combinedRoll == 3) { totalNum[1] = totalNum[1] + 1; }
                if (combinedRoll == 4) { totalNum[2] = totalNum[2] + 1; }
                if (combinedRoll == 5) { totalNum[3] = totalNum[3] + 1; }
                if (combinedRoll == 6) { totalNum[4] = totalNum[4] + 1; }
                if (combinedRoll == 7) { totalNum[5] = totalNum[5] + 1; }
                if (combinedRoll == 8) { totalNum[6] = totalNum[6] + 1; }
                if (combinedRoll == 9) { totalNum[7] = totalNum[7] + 1; }
                if (combinedRoll == 10) { totalNum[8] = totalNum[8] + 1; }
                if (combinedRoll == 11) { totalNum[9] = totalNum[9] + 1; }
                if (combinedRoll == 12) { totalNum[10] = totalNum[10] + 1; }
            }

            //More UI
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rolls + ".");

            //Display a histogram of the rolled groups with each "*" equalling 1%
            for (int i = 0; i < totalNum.Length; i++)
            {
                decimal rollsRounded = 0;
                decimal starsAmount = 0;

                rollsRounded = Decimal.Divide(totalNum[i], rolls);
                starsAmount = Math.Round(rollsRounded * 100);

                string stars = "";
                for (int ii = 0; ii < starsAmount; ii++)
                {
                    stars += "*" + " ";
                    stars += "";
                }
                Console.WriteLine(i + 2 + ": " + stars);
            }
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
