using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ModuleTest
{
    [TestClass]
    public class AdjacentLettersTest
    {

        StreamWriter io = new StreamWriter("dummy.txt");

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[,]
            {
                { 'U', 'Y', 'J', 'H' },
                { 'L', 'A', 'B', 'T' },
                { 'Z', 'K', 'I', 'X' }

            };

            AdjacentLetters module = new AdjacentLetters(grid, null, io);

            bool[,] answer = new bool[,]
            {
                {true, true, false, false },
                {false, true, true, false },
                {true, false, false, false }
            };

            bool[,] output = module.Solve(true);

            Assert.IsTrue(SameGrid(answer, output));

            io.Close();
        }

        [TestMethod]
        public void Test2()
        {
            char[,] grid = new char[,]
            {
                { 'A', 'O', 'U', 'N' },
                { 'X', 'P', 'K', 'Q' },
                { 'L', 'R', 'Y', 'I' }

            };

            AdjacentLetters module = new AdjacentLetters(grid, null, io);

            bool[,] answer = new bool[,]
            {
                {true, true, false, false },
                {true, true, true, true },
                {true, false, false, false }
            };

            bool[,] output = module.Solve(true);

            Assert.IsTrue(SameGrid(answer, output));

            io.Close();
        }

        [TestMethod]
        public void Test3()
        {
            char[,] grid = new char[,]
            {
                { 'T', 'F', 'P', 'Z' },
                { 'E', 'N', 'W', 'Q' },
                { 'I', 'D', 'J', 'M' }

            };

            AdjacentLetters module = new AdjacentLetters(grid, null, io);

            bool[,] answer = new bool[,]
            {
                {false, false, false, false },
                {false, true, true, false },
                {true, true, false, false }
            };

            bool[,] output = module.Solve(true);

            Assert.IsTrue(SameGrid(answer, output));

            io.Close();
        }

        [TestMethod]
        public void Test4()
        {
            char[,] grid = new char[,]
            {
                { 'A', 'O', 'B', 'L' },
                { 'S', 'P', 'X', 'G' },
                { 'D', 'M', 'N', 'T' }

            };

            AdjacentLetters module = new AdjacentLetters(grid, null, io);

            bool[,] answer = new bool[,]
            {
                {true, false, true, false },
                {false, true, true, false },
                {false, true, false, false }
            };

            bool[,] output = module.Solve(true);

            Assert.IsTrue(SameGrid(answer, output));

            io.Close();
        }

        [TestMethod]
        public void Test5()
        {
            char[,] grid = new char[,]
            {
                { 'C', 'O', 'A', 'T' },
                { 'K', 'W', 'F', 'H' },
                { 'B', 'U', 'P', 'Z' }

            };

            AdjacentLetters module = new AdjacentLetters(grid, null, io);

            bool[,] answer = new bool[,]
            {
                {false, false, true, false },
                {false, true, true, false },
                {false, false, true, false }
            };

            bool[,] output = module.Solve(true);

            Assert.IsTrue(SameGrid(answer, output));

            io.Close();
        }

        private bool SameGrid(bool[,] b1, bool[,] b2)
        {
            int rowLength = b1.GetLength(0);
            int colLength = b1.GetLength(1);

            for (int row = 0; row < rowLength; row++)
            {
                for (int col = 0; col < colLength; col++)
                {
                    if (b1[row, col] != b2[row, col])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}