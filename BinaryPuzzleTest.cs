using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ModuleTests
{
    [TestClass]
    public class BinaryPuzzleTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=e0917707c1a8ff0c3a39e35cf8a6947a2e97a676;bomb=6P0NB6

        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '0', '-', '1', '-', '1', '-' },
                { '-', '-', '-', '0', '-', '0' },
                { '-', '-', '0', '-', '-', '-' },
                { '-', '-', '-', '-', '1', '1' },
                { '-', '1', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '0', '1', '1', '0', '1', '0' },
                { '1', '1', '0', '0', '1', '0' },
                { '1', '0', '0', '1', '0', '1' },
                { '0', '0', '1', '0', '1', '1' },
                { '1', '1', '0', '1', '0', '0' },
                { '0', '0', '1', '1', '0', '1' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test10()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '0', '-', '-', '-' },
                { '-', '-', '0', '1', '-', '0' },
                { '-', '-', '-', '-', '1', '-' },
                { '-', '-', '-', '1', '-', '-' },
                { '0', '-', '0', '-', '-', '-' },
                { '0', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '1', '1', '0', '0', '1', '0' },
                { '1', '1', '0', '1', '0', '0' },
                { '0', '0', '1', '0', '1', '1' },
                { '1', '0', '1', '1', '0', '0' },
                { '0', '1', '0', '0', '1', '1' },
                { '0', '0', '1', '1', '0', '1' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test100()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '0', '-', '-', '-', '-' },
                { '-', '-', '0', '-', '1', '-' },
                { '-', '-', '0', '-', '-', '-' },
                { '-', '-', '-', '1', '-', '-' },
                { '-', '1', '-', '1', '1', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '0', '1', '1', '0', '0', '1' },
                { '1', '0', '1', '0', '0', '1' },
                { '1', '0', '0', '1', '1', '0' },
                { '0', '1', '0', '0', '1', '1' },
                { '1', '0', '1', '1', '0', '0' },
                { '0', '1', '0', '1', '1', '0' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test11()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '0', '-' },
                { '-', '-', '1', '-', '-', '-' },
                { '0', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '1', '1' },
                { '-', '-', '0', '-', '-', '-' },
                { '0', '0', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '1', '1', '0', '1', '0', '0' },
                { '1', '0', '1', '0', '1', '0' },
                { '0', '1', '0', '1', '0', '1' },
                { '0', '0', '1', '0', '1', '1' },
                { '1', '1', '0', '0', '1', '0' },
                { '0', '0', '1', '1', '0', '1' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test12()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '1', '-', '1', '-', '-' },
                { '-', '-', '-', '1', '-', '-' },
                { '-', '-', '1', '-', '1', '-' },
                { '0', '-', '-', '-', '-', '-' },
                { '0', '-', '-', '1', '-', '-' },
                { '-', '-', '-', '-', '-', '0' }
            };

            char[,] answer = new char[6, 6]
            {
                { '0', '1', '0', '1', '0', '1' },
                { '1', '0', '1', '1', '0', '0' },
                { '1', '0', '1', '0', '1', '0' },
                { '0', '1', '0', '0', '1', '1' },
                { '0', '0', '1', '1', '0', '1' },
                { '1', '1', '0', '1', '1', '0' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test13()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '0', '1', '-', '-' },
                { '-', '0', '-', '-', '-', '-' },
                { '1', '1', '-', '1', '-', '-' },
                { '-', '-', '-', '-', '1', '1' },
                { '1', '-', '1', '-', '-', '-' },
                { '-', '-', '-', '-', '1', '0' }
            };

            char[,] answer = new char[6, 6]
            {
                { '0', '1', '0', '1', '0', '1' },
                { '0', '0', '1', '0', '1', '1' },
                { '1', '1', '0', '1', '0', '0' },
                { '0', '1', '0', '0', '1', '1' },
                { '1', '0', '1', '1', '0', '0' },
                { '1', '0', '1', '0', '1', '0' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test14()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '1', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '0' },
                { '-', '-', '-', '0', '-', '-' },
                { '1', '-', '1', '-', '-', '-' },
                { '1', '-', '1', '0', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '0', '1', '0', '1', '1', '0' },
                { '0', '1', '1', '0', '0', '1' },
                { '1', '0', '0', '1', '1', '0' },
                { '0', '1', '0', '0', '1', '1' },
                { '1', '0', '1', '1', '0', '0' },
                { '1', '0', '1', '0', '0', '1' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test15()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '0', '-', '-', '-' },
                { '-', '1', '-', '1', '-', '-' },
                { '-', '-', '-', '1', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '1' },
                { '0', '-', '-', '-', '0', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '1', '1', '0', '0', '1', '0' },
                { '0', '1', '0', '1', '0', '1' },
                { '1', '0', '1', '1', '0', '0' },
                { '1', '0', '1', '0', '1', '0' },
                { '0', '1', '0', '0', '1', '1' },
                { '0', '0', '1', '1', '0', '1' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test16()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '1', '-', '-', '-', '-' },
                { '-', '1', '-', '-', '-', '-' },
                { '0', '-', '-', '1', '-', '-' },
                { '-', '0', '-', '-', '-', '1' },
                { '-', '-', '0', '-', '1', '-' },
                { '-', '-', '0', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '0', '1', '1', '0', '1', '0' },
                { '1', '1', '0', '1', '0', '0' },
                { '0', '0', '1', '1', '0', '1' },
                { '0', '0', '1', '0', '1', '1' },
                { '1', '1', '0', '0', '1', '0' },
                { '1', '0', '0', '1', '0', '1' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test17()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '0', '-', '-', '-', '-' },
                { '0', '-', '-', '-', '-', '1' },
                { '-', '-', '1', '-', '-', '-' },
                { '0', '-', '-', '-', '-', '-' },
                { '-', '0', '1', '-', '-', '1' },
                { '-', '-', '1', '-', '-', '0' }
            };

            char[,] answer = new char[6, 6]
            {
                { '1', '0', '0', '1', '0', '1' },
                { '0', '1', '0', '1', '0', '1' },
                { '1', '0', '1', '0', '1', '0' },
                { '0', '1', '0', '1', '1', '0' },
                { '1', '0', '1', '0', '0', '1' },
                { '0', '1', '1', '0', '1', '0' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test18()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '1', '-', '1', '-' },
                { '1', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '0', '0' },
                { '-', '1', '-', '-', '0', '-' },
                { '-', '0', '1', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '0', '0', '1', '0', '1', '1' },
                { '1', '0', '0', '1', '1', '0' },
                { '1', '1', '0', '1', '0', '0' },
                { '0', '1', '1', '0', '0', '1' },
                { '1', '0', '1', '0', '1', '0' },
                { '0', '1', '0', '1', '0', '1' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test19()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '1', '1', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '1', '-' },
                { '-', '-', '1', '-', '-', '-' },
                { '0', '-', '1', '-', '-', '-' },
                { '0', '-', '-', '0', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '1', '0', '1', '1', '0', '0' },
                { '0', '1', '0', '1', '0', '1' },
                { '1', '1', '0', '0', '1', '0' },
                { '1', '0', '1', '0', '1', '0' },
                { '0', '0', '1', '1', '0', '1' },
                { '0', '1', '0', '0', '1', '1' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test2()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '0' },
                { '0', '0', '-', '0', '-', '-' },
                { '-', '-', '0', '0', '-', '-' },
                { '-', '-', '-', '-', '-', '1' },
                { '-', '1', '-', '-', '-', '0' },
                { '-', '-', '1', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '1', '1', '0', '1', '0', '0' },
                { '0', '0', '1', '0', '1', '1' },
                { '1', '1', '0', '0', '1', '0' },
                { '1', '0', '0', '1', '0', '1' },
                { '0', '1', '1', '0', '1', '0' },
                { '0', '0', '1', '1', '0', '1' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test20()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '1', '-', '0', '-' },
                { '-', 'O', '-', '-', '-', '0' },
                { '-', '-', '-', '0', '1', '-' },
                { '0', '-', '0', '0', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '0', '1', '1', '0', '0', '1' },
                { '1', 'O', '1', '1', '0', '0' },
                { '1', '1', '0', '0', '1', '0' },
                { '0', '1', '0', '0', '1', '1' },
                { '0', '0', '1', '1', '0', '1' },
                { '1', '0', '0', '1', '1', '0' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test21()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '1', '0', '-', '-' },
                { '-', '-', '1', '-', '-', '1' },
                { '-', '-', '-', '-', '0', '-' },
                { '-', '-', '-', '-', '0', '-' },
                { '-', '-', '-', '-', '-', '0' },
                { '1', '-', '-', '-', '-', '0' }
            };

            char[,] answer = new char[6, 6]
            {
                { '0', '1', '1', '0', '0', '1' },
                { '0', '0', '1', '0', '1', '1' },
                { '1', '1', '0', '1', '0', '0' },
                { '0', '1', '0', '1', '0', '1' },
                { '1', '0', '1', '0', '1', '0' },
                { '1', '0', '0', '1', '1', '0' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test22()
        {
            char[,] grid = new char[6, 6]
            {
                { '1', '-', '-', '-', '-', '1' },
                { '-', '0', '-', '-', '0', '-' },
                { '-', '-', '-', '-', '-', '1' },
                { '-', '-', '-', '1', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '1', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '1', '0', '0', '1', '0', '1' },
                { '1', '0', '1', '1', '0', '0' },
                { '0', '1', '0', '0', '1', '1' },
                { '0', '1', '0', '1', '0', '1' },
                { '1', '0', '1', '0', '1', '0' },
                { '0', '1', '1', '0', '1', '0' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test23()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '1', '0', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '0', '-', '0', '0' },
                { '-', '1', '-', '-', '1', '-' },
                { '-', '-', '0', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '0', '0', '1', '1', '0', '1' },
                { '0', '0', '1', '0', '1', '1' },
                { '1', '1', '0', '1', '0', '0' },
                { '0', '1', '1', '0', '1', '0' },
                { '1', '0', '0', '1', '0', '1' },
                { '1', '1', '0', '0', '1', '0' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test24()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '0', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '1', '1', '-', '-', '1' },
                { '-', '-', '-', '-', '-', '1' },
                { '-', '-', '-', '-', '0', '-' },
                { '-', '-', '-', '0', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '0', '0', '1', '1', '0', '1' },
                { '1', '0', '0', '1', '1', '0' },
                { '0', '1', '1', '0', '0', '1' },
                { '0', '1', '0', '0', '1', '1' },
                { '1', '0', '1', '1', '0', '0' },
                { '1', '1', '0', '0', '1', '0' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test25()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '1', '-' },
                { '-', '-', '0', '-', '-', '-' },
                { '-', '1', '-', '-', '-', '-' },
                { '-', '-', '1', '-', '1', '-' },
                { '-', '1', '-', '-', '-', '1' },
                { '0', '0', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '1', '0', '0', '1', '1', '0' },
                { '1', '1', '0', '1', '0', '0' },
                { '0', '1', '1', '0', '0', '1' },
                { '1', '0', '1', '0', '1', '0' },
                { '0', '1', '0', '1', '0', '1' },
                { '0', '0', '1', '0', '1', '1' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test26()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '1', '1', '-', '-' },
                { '1', '-', '-', '-', '-', '1' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '1', '-', '-', '-', '0' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '1', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '1', '0', '1', '1', '0', '0' },
                { '1', '0', '1', '0', '0', '1' },
                { '0', '1', '0', '0', '1', '1' },
                { '1', '1', '0', '1', '0', '0' },
                { '0', '0', '1', '0', '1', '1' },
                { '0', '1', '0', '1', '1', '0' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test27()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '0', '-', '-', '-', '-' },
                { '-', '0', '-', '-', '-', '-' },
                { '-', '-', '1', '-', '1', '-' },
                { '-', '-', '1', '0', '-', '0' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '0', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '1', '0', '0', '1', '1', '0' },
                { '1', '0', '0', '1', '0', '1' },
                { '0', '1', '1', '0', '1', '0' },
                { '1', '0', '1', '0', '1', '0' },
                { '0', '1', '-', '1', '0', '1' },
                { '1', '1', '1', '0', '0', '1' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test28()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '1', '1', '-', '0', '-', '-' },
                { '0', '-', '0', '1', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '1', '-', '0', '-' },
                { '1', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '0', '0', '1', '0', '1', '1' },
                { '1', '1', '0', '0', '1', '0' },
                { '0', '1', '0', '1', '0', '1' },
                { '1', '0', '1', '0', '1', '0' },
                { '0', '0', '1', '1', '0', '1' },
                { '1', '1', '0', '1', '0', '0' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test29()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '0', '-', '-', '1' },
                { '-', '-', '-', '-', '1', '-' },
                { '1', '-', '-', '-', '-', '-' },
                { '1', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '1' },
                { '-', '1', '-', '-', '0', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '0', '1', '0', '0', '1', '1' },
                { '0', '0', '1', '0', '1', '1' },
                { '1', '0', '1', '1', '0', '0' },
                { '1', '1', '0', '1', '0', '0' },
                { '0', '0', '1', '1', '1', '1' },
                { '1', '1', '0', '1', '0', '0' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test3()
        {
            char[,] grid = new char[6, 6]
            {
                { '1', '-', '-', '1', '-', '-' },
                { '1', '-', '0', '-', '-', '-' },
                { '-', '-', '0', '-', '0', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '0', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '1', '0', '1', '1', '0', '0' },
                { '1', '1', '0', '0', '1', '0' },
                { '0', '1', '0', '1', '0', '1' },
                { '1', '0', '1', '0', '1', '0' },
                { '0', '0', '1', '1', '0', '1' },
                { '1', '1', '0', '0', '1', '1' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test30()
        {
            char[,] grid = new char[6, 6]
            {
                {'-','-','1','1','-','-'},
                {'1','-','-','1','-','-'},
                {'-','-','1','-','-','-'},
                {'-','-','-','-','-','1'},
                {'-','0','-','-','-','-'},
                {'-','-','1','-','-','-'}
            };
            char[,] answer = new char[6, 6]
            {
                {'0','0','1','1','0','1'},
                {'1','1','0','1','0','0'},
                {'1','0','1','0','1','0'},
                {'0','1','0','0','1','1'},
                {'1','0','0','1','0','1'},
                {'0','1','1','0','1','0'}
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test31()
        {
            char[,] grid = new char[6, 6]
{
    {'-','1','-','1','-','-'},
    {'-','-','-','-','-','-'},
    {'-','-','-','-','-','-'},
    {'-','-','-','0','-','0'},
    {'-','1','1','-','-','1'},
    {'-','-','1','-','-','-'}
};
            char[,] answer = new char[6, 6]
            {
    {'0','1','0','1','1','0'},
    {'0','0','1','0','1','1'},
    {'1','0','0','1','0','1'},
    {'1','1','0','0','1','0'},
    {'0','1','1','0','0','1'},
    {'1','0','1','1','0','0'}
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test32()
        {
            char[,] grid = new char[6, 6]
            {
    {'-','-','1','-','-','-'},
    {'-','-','-','-','-','0'},
    {'-','-','-','-','1','-'},
    {'-','0','0','-','1','-'},
    {'-','-','-','-','-','-'},
    {'1','-','1','-','1','-'}
            };
            char[,] answer = new char[6, 6]
            {
    {'0','1','1','0','0','1'},
    {'1','1','0','1','0','0'},
    {'0','0','1','0','1','1'},
    {'1','0','0','1','1','0'},
    {'0','1','0','1','0','1'},
    {'1','0','1','0','1','0'}
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test33()
        {
            char[,] grid = new char[6, 6]
            {
    {'-','-','-','-','1','-'},
    {'-','-','0','-','-','-'},
    {'-','-','-','-','0','0'},
    {'-','-','-','1','-','-'},
    {'1','-','-','-','-','1'},
    {'-','-','-','-','-','0'}
            };
            char[,] answer = new char[6, 6]
            {
    {'0','0','1','0','1','1'},
    {'0','1','0','0','1','1'},
    {'1','0','1','1','0','0'},
    {'0','1','0','1','1','0'},
    {'1','0','1','0','0','1'},
    {'1','1','0','1','0','0'}
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test34()
        {
            char[,] grid = new char[6, 6]
            {
    {'-','-','1','-','-','-'},
    {'-','-','-','0','-','0'},
    {'-','-','-','-','0','0'},
    {'-','-','1','-','0','-'},
    {'-','1','1','-','-','-'},
    {'-','-','-','-','-','-'}
            };
            char[,] answer = new char[6, 6]
            {
    {'0','0','1','0','1','1'},
    {'1','1','0','0','1','0'},
    {'1','1','0','1','0','0'},
    {'0','0','1','1','0','1'},
    {'0','1','1','0','1','0'},
    {'1','0','0','1','0','1'}
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test35()
        {
            char[,] grid = new char[6, 6]
            {
    {'-','-','0','-','-','-'},
    {'1','-','-','-','0','-'},
    {'-','0','-','-','-','1'},
    {'-','0','-','-','-','-'},
    {'-','-','-','-','-','-'},
    {'-','-','-','-','1','1'}
            };
            char[,] answer = new char[6, 6]
            {
    {'1','1','0','0','1','0'},
    {'1','1','0','1','0','0'},
    {'0','0','1','1','0','1'},
    {'1','0','1','0','1','0'},
    {'0','1','0','1','0','1'},
    {'0','0','1','0','1','1'}
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test36()
        {
            char[,] grid = new char[6, 6]
 {
    {'1','-','-','-','1','-'},
    {'-','-','-','1','-','-'},
    {'-','-','-','1','-','1'},
    {'1','-','0','-','-','-'},
    {'-','-','-','-','1','-'},
    {'0','-','-','-','-','-'}
 };
            char[,] answer = new char[6, 6]
            {
    {'1','0','1','0','1','0'},
    {'1','1','0','1','0','0'},
    {'0','0','1','1','0','1'},
    {'1','1','0','0','1','0'},
    {'0','0','1','0','1','1'},
    {'0','1','0','1','0','1'}
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test37()
        {
            char[,] grid = new char[6, 6]
            {
    {'-','1','-','-','1','-'},
    {'-','-','1','-','-','-'},
    {'-','1','-','-','-','-'},
    {'-','-','-','1','-','-'},
    {'1','1','-','-','-','-'},
    {'-','-','0','-','-','-'}
            };
            char[,] answer = new char[6, 6]
            {
    {'0','1','1','0','1','0'},
    {'0','0','1','0','1','1'},
    {'1','1','0','1','0','0'},
    {'0','0','1','1','0','1'},
    {'1','1','0','0','1','0'},
    {'1','0','0','1','0','1'}
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test38()
        {
            char[,] grid = new char[6, 6]
            {
    {'1','-','1','-','-','-'},
    {'-','-','1','-','1','1'},
    {'-','-','-','-','-','-'},
    {'0','1','-','-','-','-'},
    {'-','-','-','-','-','-'},
    {'1','-','-','-','-','-'}
            };
            char[,] answer = new char[6, 6]
            {
    {'1','0','1','1','0','0'},
    {'0','0','1','0','1','1'},
    {'1','1','0','1','0','0'},
    {'0','1','0','0','1','1'},
    {'0','0','1','1','0','1'},
    {'1','1','0','0','1','0'}
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test39()
        {
            char[,] grid = new char[6, 6]
            {
    {'-','-','-','-','-','-'},
    {'-','-','0','-','0','-'},
    {'-','-','0','-','0','-'},
    {'1','-','-','-','-','-'},
    {'-','-','-','-','-','0'},
    {'-','-','-','1','-','-'}
            };
            char[,] answer = new char[6, 6]
            {
    {'0','0','1','0','1','1'},
    {'1','1','0','1','0','0'},
    {'0','1','0','1','0','1'},
    {'1','0','1','0','1','0'},
    {'1','1','0','0','1','0'},
    {'0','0','1','1','0','1'}
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test40()
        {
            char[,] grid = new char[6, 6]
            {
    {'-','-','-','1','-','-'},
    {'-','-','-','-','-','-'},
    {'1','1','-','-','-','-'},
    {'1','-','-','1','-','-'},
    {'-','-','0','-','-','-'},
    {'-','-','-','-','0','0'}
            };
            char[,] answer = new char[6, 6]
            {
    {'0','0','1','1','0','1'},
    {'0','0','1','0','1','1'},
    {'1','1','0','0','1','0'},
    {'1','0','1','1','0','0'},
    {'0','1','0','0','1','1'},
    {'1','1','0','1','0','0'}
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }
        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));


            [TestMethod]
            public void Test1()
            {
                char[,] grid = new char[6, 6]
                {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
                };

                char[,] answer = new char[6, 6]
                {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
                };
                BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

                char[,] given = module.Solve();

                Assert.IsTrue(SameGrid(given, answer));
            }

            [TestMethod]
            public void Test1()
            {
                char[,] grid = new char[6, 6]
                {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
                };

                char[,] answer = new char[6, 6]
                {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
                };
                BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

                char[,] given = module.Solve();

                Assert.IsTrue(SameGrid(given, answer));
            }

            [TestMethod]
            public void Test1()
            {
                char[,] grid = new char[6, 6]
                {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
                };

                char[,] answer = new char[6, 6]
                {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
                };
                BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

                char[,] given = module.Solve();

                Assert.IsTrue(SameGrid(given, answer));
            }

            [TestMethod]
            public void Test1()
            {
                char[,] grid = new char[6, 6]
                {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
                };

                char[,] answer = new char[6, 6]
                {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
                };
                BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

                char[,] given = module.Solve();

                Assert.IsTrue(SameGrid(given, answer));
            }

        }

        private bool SameGrid(char[,] given, char[,] expected)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (given[i, j] != expected[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }

        [TestMethod]
        public void Test1()
        {
            char[,] grid = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };

            char[,] answer = new char[6, 6]
            {
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-' }
            };
            BinaryPuzzle module = new BinaryPuzzle(grid, streamWriter);

            char[,] given = module.Solve();

            Assert.IsTrue(SameGrid(given, answer));
        }











    }
}
