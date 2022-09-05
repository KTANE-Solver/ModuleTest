using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using New_KTANE_Solver;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
namespace ModuleTests
{
    [TestClass]
    public class SemaphoreTest
    {
        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        [TestMethod]
        public void TestMethod1()
        {
            Bomb bomb = new Bomb(Day.Sunday, "3W8DU1", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);

            New_KTANE_Solver.Semaphore module = new New_KTANE_Solver.Semaphore(bomb,streamWriter, new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.North, New_KTANE_Solver.Semaphore.FlagState.NorthEast));

            Assert.AreEqual("Valid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.West, New_KTANE_Solver.Semaphore.FlagState.SouthWest)));
            Assert.AreEqual("Valid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.North, New_KTANE_Solver.Semaphore.FlagState.East)));
            Assert.AreEqual("Invalid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.South, New_KTANE_Solver.Semaphore.FlagState.NorthEast)));


            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Bomb bomb = new Bomb(Day.Sunday, "3W8DU1", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);

            New_KTANE_Solver.Semaphore module = new New_KTANE_Solver.Semaphore(bomb, streamWriter, new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.North, New_KTANE_Solver.Semaphore.FlagState.East));
            Assert.AreEqual("Valid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.North, New_KTANE_Solver.Semaphore.FlagState.South)));
            Assert.AreEqual("Invalid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.SouthEast, New_KTANE_Solver.Semaphore.FlagState.East)));


            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod3()
        {
            Bomb bomb = new Bomb(Day.Sunday, "3W8DU1", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);

            New_KTANE_Solver.Semaphore module = new New_KTANE_Solver.Semaphore(bomb, streamWriter, new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.North, New_KTANE_Solver.Semaphore.FlagState.NorthEast));
            Assert.AreEqual("Valid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.West, New_KTANE_Solver.Semaphore.FlagState.SouthWest)));
            Assert.AreEqual("Valid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.North, New_KTANE_Solver.Semaphore.FlagState.East)));
            Assert.AreEqual("Valid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.North, New_KTANE_Solver.Semaphore.FlagState.South)));
            Assert.AreEqual("Invalid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.West, New_KTANE_Solver.Semaphore.FlagState.North)));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod4()
        {
            Bomb bomb = new Bomb(Day.Sunday, "3W8DU1", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);

            New_KTANE_Solver.Semaphore module = new New_KTANE_Solver.Semaphore(bomb, streamWriter, new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.North, New_KTANE_Solver.Semaphore.FlagState.East));
            Assert.AreEqual("Valid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.North, New_KTANE_Solver.Semaphore.FlagState.South)));
            Assert.AreEqual("Valid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.North, New_KTANE_Solver.Semaphore.FlagState.NorthEast)));
            Assert.AreEqual("Valid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.NorthWest, New_KTANE_Solver.Semaphore.FlagState.South)));
            Assert.AreEqual("Valid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.SouthWest, New_KTANE_Solver.Semaphore.FlagState.South)));
            Assert.AreEqual("Valid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.West, New_KTANE_Solver.Semaphore.FlagState.SouthWest)));
            Assert.AreEqual("Valid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.North, New_KTANE_Solver.Semaphore.FlagState.East)));
            Assert.AreEqual("Invalid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.NorthWest, New_KTANE_Solver.Semaphore.FlagState.North)));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod5()
        {
            Bomb bomb = new Bomb(Day.Sunday, "3W8DU1", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);

            New_KTANE_Solver.Semaphore module = new New_KTANE_Solver.Semaphore(bomb, streamWriter, new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.North, New_KTANE_Solver.Semaphore.FlagState.East));

            Assert.AreEqual("Invalid", module.DebugSolve(new New_KTANE_Solver.Semaphore.Flag(New_KTANE_Solver.Semaphore.FlagState.West, New_KTANE_Solver.Semaphore.FlagState.NorthEast)));

            streamWriter.Close();
        }
    }
}
