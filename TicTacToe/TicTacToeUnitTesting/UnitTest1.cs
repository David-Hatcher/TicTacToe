using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        TicTacToeGame tttg = new TicTacToeGame();
        [TestMethod]
        public void PlayerSelectTest()
        {
            Assert.AreEqual(tttg.PlayerSelect("x"), "X");
        }
    }
}
