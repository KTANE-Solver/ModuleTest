using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using New_KTANE_Solver;
using System.IO;
namespace ModuleTests
{
    [TestClass]
    public class MysticSquareTest
    {
        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        [TestMethod]
        public void TestMethod1()
        {
            Bomb bomb = null;

            string text = "231084675";

                int[,] grid = new int[3, 3];


            for (int i = 0; i < 9; i++)
            {
                int row = i / 3;
                int col = i % 3;

                grid[row, col] = int.Parse("" + text[i]);
            }

            MysticSquares module = new MysticSquares(bomb, streamWriter);

            Assert.AreEqual(5, module.FindSkullDebug(grid));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Bomb bomb = null;


            string text = "457831206";

            int[,] grid = new int[3, 3];


            for (int i = 0; i < 9; i++)
            {
                int row = i / 3;
                int col = i % 3;

                grid[row, col] = int.Parse("" + text[i]);
            }

            MysticSquares module = new MysticSquares(bomb, streamWriter);

            Assert.AreEqual(5, module.FindSkullDebug(grid));
        }
    }
}

