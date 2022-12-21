using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    //https://ktane.timwi.de/lfa#file=1c5e8afec1479c495dee626a21f040d55766ce95

    

    [TestClass]
    public class BinaryPuzzleTest
    {
        //https://ktane.timwi.de/lfa#file=41f32e4d452e1bcd1e771a63647a73417e44d6c3

        StreamWriter io = new StreamWriter("dummy.txt");

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[,]
                {
                    { '-', '-', '0', '-', '1', '-' },
                    { '1', '-', '0', '0', '-', '-' },
                    { '-', '-', '-', '1', '-', '-' },
                    { '-', '-', '-', '-', '-', '-' },
                    { '0', '-', '-', '-', '1', '-' },
                    { '-', '0', '-', '-', '-', '-' }

                };


            char[,] answer = new char[,]
                {
                    { '0', '1', '0', '0', '1', '1' },
                    { '1', '1', '0', '0', '1', '0' },
                    { '0', '0', '1', '1', '0', '1' },
                    { '1', '1', '0', '1', '0', '0' },
                    { '0', '0', '1', '0', '1', '1' },
                    { '1', '0', '1', '1', '0', '0' }

                };

            BinaryPuzzle module = new BinaryPuzzle(grid, io);

            char[,] output = module.Solve();

            Assert.IsTrue(SameGrid(answer, output));

            io.Close();
        }

        [TestMethod]
        public void Test2()
        {
            char[,] grid = new char[,]
                {
                    { '1', '-', '-', '-', '-', '-' },
                    { '1', '-', '0', '-', '-', '-' },
                    { '-', '-', '1', '-', '1', '-' },
                    { '-', '0', '-', '-', '1', '-' },
                    { '-', '-', '-', '-', '-', '-' },
                    { '-', '-', '1', '-', '1', '-' }

                };


            char[,] answer = new char[,]
                {
                    { '1', '0', '1', '0', '0', '1' },
                    { '1', '1', '0', '1', '0', '0' },
                    { '0', '0', '1', '0', '1', '1' },
                    { '1', '0', '0', '1', '1', '0' },
                    { '0', '1', '0', '1', '0', '1' },
                    { '0', '1', '1', '0', '1', '0' }

                };

            BinaryPuzzle module = new BinaryPuzzle(grid, io);

            char[,] output = module.Solve();

            Assert.IsTrue(SameGrid(answer, output));

            io.Close();
        }

        [TestMethod]
        public void Test3()
        {
            char[,] grid = new char[,]
                {
                    { '-', '1', '-', '-', '-', '-' },
                    { '-', '1', '-', '-', '1', '1' },
                    { '-', '-', '0', '-', '-', '0' },
                    { '-', '-', '-', '-', '-', '-' },
                    { '0', '-', '-', '-', '-', '-' },
                    { '-', '-', '-', '-', '-', '-' }

                };


            char[,] answer = new char[,]
                {
                    { '0', '1', '1', '0', '0', '1' },
                    { '0', '1', '0', '0', '1', '1' },
                    { '1', '0', '0', '1', '1', '0' },
                    { '1', '0', '1', '0', '0', '1' },
                    { '0', '1', '0', '1', '1', '0' },
                    { '1', '0', '1', '1', '0', '0' }

                };

            BinaryPuzzle module = new BinaryPuzzle(grid, io);

            char[,] output = module.Solve();

            Assert.IsTrue(SameGrid(answer, output));

            io.Close();
        }

        [TestMethod]
        public void Test4()
        {
            char[,] grid = new char[,]
                {
                    { '-', '-', '0', '-', '-', '-' },
                    { '1', '1', '-', '0', '-', '-' },
                    { '-', '-', '-', '-', '-', '-' },
                    { '-', '-', '-', '-', '-', '-' },
                    { '-', '-', '-', '-', '0', '-' },
                    { '-', '-', '-', '1', '-', '1' }

                };


            char[,] answer = new char[,]
                {
                    { '0', '1', '0', '0', '1', '1' },
                    { '1', '1', '0', '0', '1', '0' },
                    { '1', '0', '1', '1', '0', '0' },
                    { '0', '0', '1', '0', '1', '1' },
                    { '1', '1', '0', '1', '0', '0' },
                    { '0', '0', '1', '1', '0', '1' }

                };

            BinaryPuzzle module = new BinaryPuzzle(grid, io);

            char[,] output = module.Solve();

            Assert.IsTrue(SameGrid(answer, output));

            io.Close();
        }

        [TestMethod]
        public void Test5()
        {
            char[,] grid = new char[,]
                {
                    { '-', '0', '-', '-', '-', '1' },
                    { '-', '-', '-', '-', '-', '-' },
                    { '-', '-', '1', '-', '-', '-' },
                    { '-', '0', '-', '0', '-', '-' },
                    { '-', '0', '-', '-', '-', '1' },
                    { '-', '-', '-', '0', '-', '-' }

                };


            char[,] answer = new char[,]
                {
                    { '0', '0', '1', '1', '0', '1' },
                    { '1', '1', '0', '1', '0', '0' },
                    { '0', '1', '1', '0', '1', '0' },
                    { '0', '0', '1', '0', '1', '1' },
                    { '1', '0', '0', '1', '0', '1' },
                    { '1', '1', '0', '0', '1', '0' }

                };

            BinaryPuzzle module = new BinaryPuzzle(grid, io);

            char[,] output = module.Solve();

            Assert.IsTrue(SameGrid(answer, output));

            io.Close();
        }

        private bool SameGrid(char[,] b1, char[,] b2)
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