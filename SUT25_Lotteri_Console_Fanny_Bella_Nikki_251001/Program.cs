using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT25_Lotteri_Console_Fanny_Bella_Nikki_251001
{
    internal class Program
    {
        static int[] userTickets = new int[5];//contains 5 places
        static int[] winnerTickets = new int[3]; //generates 3 random winning numbers

        static void Main(string[] args)
        {
            userBuyTickets();
            GenerateWinnerNumbers();
            Compare();
        }

        static void GenerateWinnerNumbers()
        {
            Random random = new Random();
            for (int i = 0; i <= 2; i++)
            {
                winnerTickets[i] = random.Next(1, 51);
            }
            Console.WriteLine("De vinnande numrena är " + winnerTickets[0] + ", " + winnerTickets[1] + " och " + winnerTickets[2]);
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
                Console.WriteLine("Välj ett nummer mellan 1 och 50 att skriva på lott ID " + i);

                while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 50)
                {
                    Console.WriteLine("Var vänlig välj ett giltigt nummer (1 - 50)");

                }
                userTickets[i] = userChoice;
            }

            // Calls on the static int userTickets global var
            //int[] userTickets = new int[5];


        }
        static void Compare()
        {
            bool userWon = false;
            int ticketID = 0;
            int winningNumber = 0;

            for (int i = 0; i < userTickets.Length; i++)
            {
                for (int j = 0; j < winnerTickets.Length; j++)
                {
                    if (winnerTickets[j] == userTickets[i])
                    {
                        userWon = true;
                        ticketID = i;
                        winningNumber = winnerTickets[j];
                    }
                }

                if (userWon)
                {
                    Console.WriteLine("Din lott med lott ID: " + ticketID + " har vunnit med nummer: " + winningNumber);
                    userWon = false;
                }

                else if (userTickets[i] != 0)
                {
                    Console.WriteLine("Lott ID " + i + " är en nitlott");
                }

            }
        }

    }
}
