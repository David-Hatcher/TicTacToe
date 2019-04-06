using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace TicTacToe
{
    public class TicTacToeGame
    {
        public string player;
        public string winner;

        string[] TicTacToeBoard =
        {
            "0","1","2","3","4","5","6","7","8"
        };

        static string[] TicTacToeBoardModel =
        {
            "-","-","-","-","-","-","-","-","-"
        };

        Dictionary<string, string[]> possibleWins = new Dictionary<string, string[]>
        {
            {"topRow",            new string[] {TicTacToeBoardModel[0],TicTacToeBoardModel[1],TicTacToeBoardModel[2] } },
            {"middleRow" ,        new string[] {TicTacToeBoardModel[3],TicTacToeBoardModel[4],TicTacToeBoardModel[5] } },
            {"bottomRow" ,        new string[] {TicTacToeBoardModel[6],TicTacToeBoardModel[7],TicTacToeBoardModel[8] } },
            {"firstColumn" ,      new string[] {TicTacToeBoardModel[0],TicTacToeBoardModel[3],TicTacToeBoardModel[6] } },
            {"secondColumn" ,     new string[] {TicTacToeBoardModel[1],TicTacToeBoardModel[4],TicTacToeBoardModel[7] } },
            {"thirdColumn" ,      new string[] {TicTacToeBoardModel[2],TicTacToeBoardModel[5],TicTacToeBoardModel[8] } },
            {"downwardDiagonal" , new string[] {TicTacToeBoardModel[0],TicTacToeBoardModel[4],TicTacToeBoardModel[8] } },
            {"upwardDiagonal" ,   new string[] {TicTacToeBoardModel[6],TicTacToeBoardModel[4],TicTacToeBoardModel[2] } },
        };
        Dictionary<string, int[]> possibleWinsValues = new Dictionary<string, int[]>
        {
            {"topRow",            new int[] {0,1,2} },
            {"middleRow" ,        new int[] {3,4,5} },
            {"bottomRow" ,        new int[] {6,7,8} },
            {"firstColumn" ,      new int[] {0,3,6} },
            {"secondColumn" ,     new int[] {1,4,7} },
            {"thirdColumn" ,      new int[] {2,5,8} },
            {"downwardDiagonal" , new int[] {0,4,8} },
            {"upwardDiagonal" ,   new int[] {6,4,2} },
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

        public void PlayerSelectPiece()
        {
            Console.WriteLine("Which piece would you like to play? (X/O)");
            string playerChoice = Console.ReadLine().ToUpper();
            if (playerChoice == "X" || playerChoice == "O")
            {
                player = playerChoice;
            }
            else
            {
                PlayerSelectPiece();
            }
        }

        public int SelectSpace()
        {
            int space = 0;
            Console.WriteLine("Where would you like to place your piece? (type a number you see above)");
            int choice = (int)Convert.ToDecimal(Console.ReadLine());
            if (choice >= 0 && choice <= 8 && TicTacToeBoardModel[choice] == "-")
            {
                space = choice;
            }
            else
            {
                Console.WriteLine("Please select an availible space above.");
                space = SelectSpace();
            }
            return space;
        }

        public void PlacePeice(int space)
        {
            TicTacToeBoard[space] = player;
            TicTacToeBoardModel[space] = player;
        }

        public bool isWinner()
        {
            bool winnerBool = false;
            string[] xWins = { "X", "X", "X" };
            string[] oWins = { "O", "O", "O" };
            foreach (string[] possibleWin in possibleWins.Values)
            {

                if (possibleWin == xWins)
                {
                    winnerBool = true;
                    winner = "X";
                }
                else if (possibleWin == oWins)
                {
                    winnerBool = true;
                    winner = "O";
                }
                Console.WriteLine(string.Join(" ", possibleWin));
            }
            return winnerBool;
        }
        public bool canComputerWin()
        {
            string[][] winConditions = new string[3][];
            bool computerCanWin = false;

            if (player == "X")
            {
                winConditions[0] = new string[] { "X", "X", "-" };
                winConditions[1] = new string[] { "X", "-", "X" };
                winConditions[2] = new string[] { "-", "X", "x" };
            }
            else
            {
                winConditions[0] = new string[] { "O", "O", "-" };
                winConditions[1] = new string[] { "O", "-", "O" };
                winConditions[2] = new string[] { "-", "O", "O" };
            }
            foreach (string[] winCon in winConditions)
            {
                foreach (string rowToCheck in )
                {

                }
            }
            return computerCanWin;
        }
    }
}