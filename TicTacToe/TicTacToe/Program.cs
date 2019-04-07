using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame tttg = new TicTacToeGame();            
            string[][] canSomeoneWin = tttg.canPieceWin("X");
            Console.WriteLine("Piece" + string.Join(" ", canSomeoneWin[0]) + " can win");
            Console.WriteLine("Take space" + tttg.someoneCanWinSpaceToTake(canSomeoneWin).ToString());
            Console.ReadLine();
        }
    }
}
