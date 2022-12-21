using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    [TestClass]
    public class ButtonTest
    {

        StreamWriter io = new StreamWriter("dummy.txt");

        string holdAnswer = "Hold Button\nBlue: 4\nYellow: 5\nElse: 1";

        [TestMethod]
        public void BlueAbort()
        {
            Bomb bomb = null;

            New_KTANE_Solver.Button module = new New_KTANE_Solver.Button(bomb, io);

            Assert.AreEqual(holdAnswer, module.Solve(Color.Blue, "Abort"));

            io.Close();
        }

        [TestMethod]
        public void Detonate1Battery()
        {
            Bomb bomb = null;

            New_KTANE_Solver.Button module = new New_KTANE_Solver.Button(bomb, io);

            Assert.AreEqual("Press", module.Solve(Color.Blue, "Detonate"));

            io.Close();
        }

        [TestMethod]
        public void WhiteLitCar()
        {
            Bomb bomb = null;

            New_KTANE_Solver.Button module = new New_KTANE_Solver.Button(bomb, io);

            Assert.AreEqual(holdAnswer, module.Solve(Color.White, "Abort"));

            io.Close();
        }

        [TestMethod]
        public void LitFRK2Battery()
        {
            Bomb bomb = null;

            New_KTANE_Solver.Button module = new New_KTANE_Solver.Button(bomb, io);

            Assert.AreEqual("Press", module.Solve(Color.White, "Abort"));

            io.Close();
        }

        [TestMethod]
        public void Yellow()
        {
            Bomb bomb = null;

            New_KTANE_Solver.Button module = new New_KTANE_Solver.Button(bomb, io);

            Assert.AreEqual(holdAnswer, module.Solve(Color.Yellow, "Abort"));

            io.Close();
        }

        [TestMethod]
        public void RedHold()
        {
            Bomb bomb = null;

            New_KTANE_Solver.Button module = new New_KTANE_Solver.Button(bomb, io);

            Assert.AreEqual("Press", module.Solve(Color.Red, "Hold"));

            io.Close();
        }

        [TestMethod]
        public void Other()
        {
            Bomb bomb = null;

            New_KTANE_Solver.Button module = new New_KTANE_Solver.Button(bomb, io);

            Assert.AreEqual(holdAnswer, module.Solve(Color.Red, "Abort"));

            io.Close();
        }
    }
}