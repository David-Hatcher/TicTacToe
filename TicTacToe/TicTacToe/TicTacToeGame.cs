using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TicTacToe
{
    public class TicTacToeGame
    {
        string[] TicTacToeBoard =
        {
            "0","1","2","3","4","5","6","7","8"
        };

        string[] TicTacToeBoardModel =
{
            "-","-","-","-","-","-","-","-","-"
        };

        public void DisplayBoard()
        {
            for (int rowValueAdjustment = 0; rowValueAdjustment <= 6; rowValueAdjustment += 3)
            {
                string[] rowArray = new string[3];

                for (int colValue = 0; colValue < 3; colValue++)
                {
                    rowArray[colValue] = TicTacToeBoard[colValue + rowValueAdjustment];
                }
                Console.WriteLine(rowArray[0] + " | " + rowArray[1] + " | " + rowArray[2]);

                if (rowValueAdjustment < 6)
                {
                    Console.WriteLine("----------");
                }
            }
        }
        public void PlayerSelect()
        {
            Console.WriteLine("Which piece would you like to play? (X/O)");
            string player = Console.ReadLine().ToUpper();
        }
        public int SelectSpace()
        {
            Console.WriteLine("Where would you like to place your piece? (type a number you see above)");
            return Convert.ToInt32(Console.ReadLine());
        }
        public void PlacePeice()
        {

        }
    }
}