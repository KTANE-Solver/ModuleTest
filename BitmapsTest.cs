using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    //https://ktane.timwi.de/lfa#file=3e9683414e60c3869a5b82b24e0f605232cf7bd4



    [TestClass]
    public class BitmapsTest
    {
        Bomb bomb = new Bomb(Day.Sunday, "QX4JH2", 3, 2,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", true, true),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), 
             new List<Plate>() {
            new Plate(false, false, false, false, false, false),
            new Plate(false, true, false, true, false, true),

             });

        StreamWriter io = new StreamWriter("dummy.txt");


        [TestMethod]
        public void Test1()
        {
            bool[,] grid = new bool[,]
            {
                { false, true, false, true, true, false, false, false },
                { false, true, false, true, true, false, false, true },
                { true, false, false, false, true, false, false, false },
                { true, true, true, true, false, true, true, false },
                { true, true, false, false, false, true, false,  false },
                { false, false, true, false, false, true, false, false },
                { false, true, true, true, true, false, false, false},
                { false, false, false, true, true, true, false, false}
            };

            Bitmaps module = new Bitmaps(grid, bomb, io);

            Assert.AreEqual(3, module.Solve(true));

            io.Close();
        }

        [TestMethod]
        public void Test2()
        {
            bool[,] grid = new bool[,]
            {
                { false, true, true, false, false, true, true, true},
                { true, true, false, false, false, true, true, false},
                { true, true, true, false, false, false, false, false},
                { false, true, false, false, false, false, true, true},
                { true, false, false, false, false, true, false, false},
                { false, true, false, true, false, true, false, true},
                { true, false, true, true, true, false, false, true},
                { false, true, true, false, false, true, true, true}

            };

            Bitmaps module = new Bitmaps(grid, bomb, io);

            Assert.AreEqual(1, module.Solve(true));

            io.Close();
        }

        [TestMethod]
        public void Test3()
        {
            bool[,] grid = new bool[,]
            {
                {true, true, false, false, true, true, false, false },
                { false, true, false, false, false, false, true, false}, 
                { true, false, false, true, false, false, true, true}, 
                { true, false, true, false, false, false, true, true}, 
                { false, false, false, false, true, false, false, true}, 
                { false, false, false, true, true, false, false, false},
                { false, false, true, false, true, true, true, false},
                { false, false, false, true, false, true, false, true}
            };

            Bitmaps module = new Bitmaps(grid, bomb, io);

            Assert.AreEqual(3, module.Solve(true));

            io.Close();
        }

        [TestMethod]
        public void Test4()
        {
            bool[,] grid = new bool[,]
            {
                {false, true, true, false, true, false, true, true },
                { true, true, true, false, false, false, true, false},
                { false, true, true, true, false, true, true, false},
                { false, false, true, true, true, true, false, false},
                { true, true, true, true, true, false, true, false},
                { true, false, true, true, true, false, true, true},
                { false, false, true, true, false, true, true, true},
                { false, false, false, true, true, true, true, true}

            };

            Bitmaps module = new Bitmaps(grid, bomb, io);

            Assert.AreEqual(4, module.Solve(true));

            io.Close();
        }

        [TestMethod]
        public void Test5()
        {
            bool[,] grid = new bool[,]
            {
                {true, false, false, true, false, false, true, true },
                { false, true, false, true, false, true, true, true},
                { true, false, true, true, true, true, false, false},
                { false, true, true, false, true, true, false, false},
                { true, true, true, false, false, true, false, true},
                { true, true, true, true, true, true, false, true},
                { true, false, true, true, false,true, false, true},
                { true, false, false, true, false, true, false, false}

            };

            Bitmaps module = new Bitmaps(grid, bomb, io);

            Assert.AreEqual(2, module.Solve(true));

            io.Close();
        }
    }
}