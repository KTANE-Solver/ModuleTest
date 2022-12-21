using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    [TestClass]
    public class _3DMazeTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=6eccc2452db5b8806fd0106803d0d5885979cb24;bomb=GQ2EI1

        StreamWriter io = new StreamWriter("dummy.txt");


        Bomb bomb = new Bomb(Day.Sunday, "GQ2EI1", 0, 0,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", true, true),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
        {
            new Plate(false, false, false, false, false, false),
            new Plate(false, true, false, true, false, true) });

        [TestMethod]
        public void Test1()
        {
            _3DMaze module = new _3DMaze(bomb, io);

            module.SetMaze("ADH");

            //finds correct cardinal space

            module.PlayerPosition = module.Maze[0, 0];

            //compatile coordinates: [0,5] [2,1] [5,0]

            module.FindCardinal();

            _3DMaze.Node playerPos = module.PlayerPosition;

            bool validCardinalSpace = (playerPos.Row == 0 && playerPos.Colunm == 5) ||
                                      (playerPos.Row == 2 && playerPos.Colunm == 1) ||
                                      (playerPos.Row == 5 && playerPos.Colunm == 0);

            Assert.IsTrue(validCardinalSpace);

            //finds correct wall to run into

            module.MainCardinalGoal = "NORTH";

            int row = module.FindRow();

            int column = module.FindColumn();

            module.MainGoal = module.Maze[row, column];

            Assert.AreEqual(2, row);
            Assert.AreEqual(2, column);

            Assert.AreEqual(module.Maze[row, column], module.MainGoal);

            module.UpdateGoal();



            //-MainCardinalGoal is correct

            Assert.AreEqual(module.Maze[0,2], module.MainGoal);

            //-SecondaryCardinalGoal is correct

            Assert.AreEqual(module.Maze[7, 2], module.SecondaryGoal);

            io.Close();
        }

        [TestMethod]
        public void Test2()
        {
            _3DMaze module = new _3DMaze(bomb, io);

            module.SetMaze("ABH");

            //finds correct cardinal space

            module.PlayerPosition = module.Maze[0, 0];

            //compatile coordinates: [1,0] [3,4] [6,5]

            module.FindCardinal();

            _3DMaze.Node playerPos = module.PlayerPosition;

            bool validCardinalSpace = (playerPos.Row == 1 && playerPos.Colunm == 0) ||
                                      (playerPos.Row == 3 && playerPos.Colunm == 4) ||
                                      (playerPos.Row == 6 && playerPos.Colunm == 5);

            Assert.IsTrue(validCardinalSpace);

            //finds correct wall to run into

            module.MainCardinalGoal = "SOUTH";

            int row = module.FindRow();

            int column = module.FindColumn();

            module.MainGoal = module.Maze[row, column];

            Assert.AreEqual(2, row);
            Assert.AreEqual(2, column);


            Assert.AreEqual(module.Maze[row, column], module.MainGoal);

            module.UpdateGoal();

            //-MainCardinalGoal is correct

            Assert.AreEqual(module.Maze[4, 2], module.MainGoal);

            //-SecondaryCardinalGoal is correct

            Assert.AreEqual(module.Maze[5, 2], module.SecondaryGoal);

            io.Close();
        }

        [TestMethod]
        public void Test3()
        {
            _3DMaze module = new _3DMaze(bomb, io);

            module.SetMaze("CDH");

            //finds correct cardinal space

            module.PlayerPosition = module.Maze[0, 0];

            //compatile coordinates: [1,5] [6,0] [6,6]

            module.FindCardinal();

            _3DMaze.Node playerPos = module.PlayerPosition;

            bool validCardinalSpace = (playerPos.Row == 1 && playerPos.Colunm == 5) ||
                                      (playerPos.Row == 6 && playerPos.Colunm == 0) ||
                                      (playerPos.Row == 6 && playerPos.Colunm == 6);

            Assert.IsTrue(validCardinalSpace);

            //finds correct wall to run into

            module.MainCardinalGoal = "SOUTH";

            int row = module.FindRow();

            int column = module.FindColumn();

            module.MainGoal = module.Maze[row, column];

            Assert.AreEqual(2, row);
            Assert.AreEqual(2, column);


            Assert.AreEqual(module.Maze[row, column], module.MainGoal);

            module.UpdateGoal();

            //-MainCardinalGoal is correct

            Assert.AreEqual(module.Maze[4, 2], module.MainGoal);

            //-SecondaryCardinalGoal is correct

            Assert.AreEqual(module.Maze[5, 2], module.SecondaryGoal);

            io.Close();
        }

        [TestMethod]
        public void Test4()
        {
            _3DMaze module = new _3DMaze(bomb, io);

            module.SetMaze("BCD");

            //finds correct cardinal space

            module.PlayerPosition = module.Maze[0, 0];

            //compatile coordinates: [1,6] [2,1] [6,4]

            module.FindCardinal();

            _3DMaze.Node playerPos = module.PlayerPosition;

            bool validCardinalSpace = (playerPos.Row == 1 && playerPos.Colunm == 6) ||
                                      (playerPos.Row == 2 && playerPos.Colunm == 1) ||
                                      (playerPos.Row == 6 && playerPos.Colunm == 4);

            Assert.IsTrue(validCardinalSpace);

            //finds correct wall to run into

            module.MainCardinalGoal = "EAST";

            int row = module.FindRow();

            int column = module.FindColumn();

            module.MainGoal = module.Maze[row, column];

            Assert.AreEqual(2, row);
            Assert.AreEqual(2, column);


            Assert.AreEqual(module.Maze[row, column], module.MainGoal);

            module.UpdateGoal();

            //-MainCardinalGoal is correct

            Assert.AreEqual(module.Maze[2, 3], module.MainGoal);

            //-SecondaryCardinalGoal is correct

            Assert.AreEqual(module.Maze[2, 4], module.SecondaryGoal);

            io.Close();
        }

        [TestMethod]
        public void Test5()
        {
            _3DMaze module = new _3DMaze(bomb, io);

            module.SetMaze("ADH");

            //finds correct cardinal space

            module.PlayerPosition = module.Maze[0, 0];

            //compatile coordinates: [0,5] [2,1] [5,0]

            module.FindCardinal();

            _3DMaze.Node playerPos = module.PlayerPosition;

            bool validCardinalSpace = (playerPos.Row == 0 && playerPos.Colunm == 5) ||
                                      (playerPos.Row == 2 && playerPos.Colunm == 1) ||
                                      (playerPos.Row == 5 && playerPos.Colunm == 0);

            Assert.IsTrue(validCardinalSpace);

            //finds correct wall to run into

            module.MainCardinalGoal = "NORTH";

            int row = module.FindRow();

            int column = module.FindColumn();

            module.MainGoal = module.Maze[row, column];

            Assert.AreEqual(2, row);
            Assert.AreEqual(2, column);


            Assert.AreEqual(module.Maze[row, column], module.MainGoal);

            module.UpdateGoal();

            //-MainCardinalGoal is correct

            Assert.AreEqual(module.Maze[0, 2], module.MainGoal);

            //-SecondaryCardinalGoal is correct

            Assert.AreEqual(module.Maze[7, 2], module.SecondaryGoal);

            io.Close();
        }
    }
}