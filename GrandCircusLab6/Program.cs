using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;

            while(true) //see if they want to play
            {

                Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? ('y' to roll!)");

                char playerChoice = Console.ReadKey(true).KeyChar;

                if(playerChoice == 'y' || playerChoice == 'Y')
                {
                    playing = true;
                    break;
                }
                else
                {
                    playing = false;
                    break;
                }

            }

  
            int diceSides;
            string diceInput;

            if (playing == true) //ready to ask them for a number
            {
                while (true)
                {
                    Console.WriteLine("How many sides should the 2 dice have?");
                    diceInput = Console.ReadLine();

                    if (int.TryParse(diceInput, out diceSides))
                    {
                        diceSides = int.Parse(diceInput);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please only enter a number!");
                    }
                }

                int rollCounter = 1;

                while (true)
                {
                    int dieOne = GetDiceRoll(diceSides, 1);

                    int dieTwo = GetDiceRoll(diceSides, 2);

                    Console.WriteLine("Roll {0}...\n{1}\n{2}", rollCounter, dieOne, dieTwo);

                    if (dieOne == 1 && dieTwo == 1)
                    {
                        Console.WriteLine(">>>>> Snake eyes!!!");
                    }

                    if (dieOne == diceSides && dieTwo == diceSides)
                    {
                        Console.WriteLine(">>>>> Box cars!!!");
                    }

                    if ((dieOne + dieTwo) == 2 || (dieOne + dieTwo) == 3 || (dieOne + dieTwo) == 12)
                    {
                        Console.WriteLine(">>>>> Craps!!!");
                    }

                    Console.WriteLine("\nWould you like to roll again? (y/n)");

                    char playerResponse = Console.ReadKey(true).KeyChar;

                    if (playerResponse == 'y')
                    {
                        rollCounter++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("GOODBYE!");
                        Console.ReadLine();
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("GOODBYE!");
                Console.ReadLine();
            }


        }//--------------END MAIN----------------------


        static int GetDiceRoll(int diceSides, int dieNumber)
        {
            Random rnd = new Random();
            
            int diceResult = rnd.Next(1, (diceSides + 1));

            int diceResult2 = rnd.Next(1, (diceSides + 1));

            if (dieNumber == 1)
            {
                return diceResult;
            }
            else
            {
                return diceResult2;
            }
        }
    }
}
