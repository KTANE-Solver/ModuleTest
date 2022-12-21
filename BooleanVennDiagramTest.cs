using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.IO;

namespace ModuleTest
{
    [TestClass]
    public class BooleanVennDiagramTest
    {
        //https://ktane.timwi.de/lfa#file=3b94bff0b094c0721968bdaef6d1b45fd311dd30

        StreamWriter io = new StreamWriter("dummy.txt");

        [TestMethod]
        public void Test1()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "←", false, io);

            List<string> answer = module.Solve(true);

            Assert.IsTrue(answer.Count == 4);
            Assert.IsTrue(answer.Contains("None"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("B"));

            io.Close();
        }

        [TestMethod]
        public void Test2()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("→", "∧", true, io);

            List<string> answer = module.Solve(true);

            Assert.IsTrue(answer.Count == 3);
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("C"));

            io.Close();
        }

        [TestMethod]
        public void Test3()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "∨", false, io);

            List<string> answer = module.Solve(true);

            Assert.IsTrue(answer.Count == 5);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("None"));

            io.Close();
        }

        [TestMethod]
        public void Test4()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "∧", true, io);

            List<string> answer = module.Solve(true);

            Assert.IsTrue(answer.Count == 3);
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("BC"));

            io.Close();
        }

        [TestMethod]
        public void Test5()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "→", false, io);

            List<string> answer = module.Solve(true);

            Assert.IsTrue(answer.Count == 5);
            Assert.IsTrue(answer.Contains("None"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("C"));

            io.Close();
        }
    }
}