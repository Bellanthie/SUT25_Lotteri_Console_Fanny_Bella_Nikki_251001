using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT25_Lotteri_Console_Fanny_Bella_Nikki_251001
{
    internal class Program
    {
        static int[] userTickets = new int [5];//contains 5 places
        static int[] winnerTickets = new int[3]; //generates 3 random winning numbers

        static void Main(string[] args)
        {
        }

        static void GenerateWinnerNumbers()
        {
            for (int i = 0; i < 2; i++)
            {
                winnerTickets[i] = new Random().Next(1-51);
            }
        }

        static void userBuyTickets()
        {
            int userTicketsCount = 0; 
            // Informs user to choose 5 numbers from the lottery and asks which numbers they'd like to choose
            Console.WriteLine("Hur många lotter vill du köpa? Du får köpa max 5");
            while (!int.TryParse(Console.ReadLine(), out userTicketsCount) || userTicketsCount > 5)
            {
                Console.WriteLine("Skriv hur många lotter du vill köpa:");
                
            }

            int userChoice = 0;
            for (int i = 0; i < userTicketsCount; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 50)
                {
                    Console.WriteLine("Skriv hur många lotter du vill köpa:");

                }
                userTickets[i] = userChoice;
            }

            // Calls on the static int userTickets global var
            //int[] userTickets = new int[5];


        }
        static void Compare()
        {
            foreach (int ticket in userTickets)
            {


                foreach (int winner in winnerTickets)
                {
                    Console.WriteLine($"Ditt vinnande nummer är {winner}");
                }
            }
        }

    }
}
