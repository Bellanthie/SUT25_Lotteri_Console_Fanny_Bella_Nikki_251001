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
    }
}
