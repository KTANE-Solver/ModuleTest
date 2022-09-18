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
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=9f585ce6b5e42e4a6b1601763e267bb0b3acc8f6;bomb=KJ0NV2
        
        StreamWriter io = new StreamWriter("dummy.txt");

        [TestMethod]
        public void Test1()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "⊻", false, io);

            List<string> answer = module.Solve(true);
            io.Close();

            Assert.AreEqual(4,answer.Count);
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("ABC"));
        }

        [TestMethod]
        public void Test10()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "→", false, io);
            
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("None"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("AB"));
        }


        [TestMethod]
        public void Test100()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↓", "|", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(1, answer.Count);
            Assert.IsTrue(answer.Contains("BC"));
        }

        [TestMethod]
        public void Test11()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "↓", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(2, answer.Count);
            Assert.IsTrue(answer.Contains("None"));
            Assert.IsTrue(answer.Contains("AB"));
        }

        [TestMethod]
        public void Test12()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∧", "∨", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(3, answer.Count);
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("ABC"));
        }

        [TestMethod]
        public void Test13()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "→", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("ABC"));

            io.Close();
        }

        [TestMethod]
        public void Test14()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∧", "|", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(3, answer.Count);
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("A"));
        }

        [TestMethod]
        public void Test15()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "←", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("None"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("AC"));
        }

        [TestMethod]
        public void Test16()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↔", "↓", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(2, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("A"));
        }

        [TestMethod]
        public void Test17()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("→", "⊻", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("None"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("AB"));
        }

        [TestMethod]
        public void Test18()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "→", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(6, answer.Count);
            Assert.IsTrue(answer.Contains("None"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("ABC"));
        }

        [TestMethod]
        public void Test19()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "⊻", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(6, answer.Count);
            Assert.IsTrue(answer.Contains("None"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("A"));
        }

        [TestMethod]
        public void Test2()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "←", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("None"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("AC"));
        }
        [TestMethod]
        public void Test20()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∧", "←", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("None"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test21()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("→", "∧", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(3, answer.Count);
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test22()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "←", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test23()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "∧", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(2, answer.Count);
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("AC"));
        }
        [TestMethod]
        public void Test24()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↓", "∧", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(3, answer.Count);
            Assert.IsTrue(answer.Contains("None"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("B"));
        }
        [TestMethod]
        public void Test25()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("→", "↔", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test26()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("→", "⊻", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(6, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test27()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "⊻", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test28()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "|", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test29()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↔", "∨", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test3()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↔", "↓", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("BC"));

        }
        [TestMethod]
        public void Test30()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "⊻", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(6, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test31()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↓", "∧", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(1, answer.Count);
            Assert.IsTrue(answer.Contains("C"));
        }
        [TestMethod]
        public void Test32()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↔", "⊻", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test33()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↓", "↓", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(3, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("BC"));
        }
        [TestMethod]
        public void Test34()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "←", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("ABC"));

        }
        [TestMethod]
        public void Test35()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↔", "∨", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(6, answer.Count);
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test36()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∨", "↔", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test37()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↔", "↓", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("BC"));
        }
        [TestMethod]
        public void Test38()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "→", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test39()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("→", "←", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(7, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test4()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "∧", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(3, answer.Count);
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
        }
        [TestMethod]
        public void Test40()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↔", "→", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(6, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test41()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∨", "∨", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(7, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test42()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "|", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test43()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "∨", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(6, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test44()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∨", "∨", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(7, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test45()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∨", "↓", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test46()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↔", "⊻", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test47()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∧", "←", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test48()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "⊻", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test49()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "←", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test5()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "→", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("BC"));

        }
        [TestMethod]
        public void Test50()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∧", "←", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test51()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "↓", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(2, answer.Count);
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test52()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↓", "∨", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(1, answer.Count);
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test53()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∨", "⊻", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
        }
        [TestMethod]
        public void Test54()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↓", "∧", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(1, answer.Count);
            Assert.IsTrue(answer.Contains("C"));
        }
        [TestMethod]
        public void Test55()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("→", "↓", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("None"));

        }

        [TestMethod]
        public void Test56()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "⊻", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("ABC"));

        }
        [TestMethod]
        public void Test57()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∨", "↔", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test58()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "→", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));

        }
        [TestMethod]
        public void Test59()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("→", "↔", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test6()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∨", "→", false, io);

            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(7, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test60()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∧", "⊻", true, io);

            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));

        }
        [TestMethod]
        public void Test61()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "↓", true, io);

            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(1, answer.Count);
            Assert.IsTrue(answer.Contains("AB"));
        }
        [TestMethod]
        public void Test62()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("→", "↔", true, io);

            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test63()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∧", "∧", true, io);

            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(1, answer.Count);
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test64()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "←", true, io);

            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(7, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test65()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "∨", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(7, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test66()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "⊻", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test67()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∧", "|", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(3, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
        }
        [TestMethod]
        public void Test68()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↔", "∧", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(2, answer.Count);
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test69()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↓", "⊻", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(2, answer.Count);
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("None"));

        }
        [TestMethod]
        public void Test7()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "←", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test70()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("→", "←", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(7, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));

        }
        [TestMethod]
        public void Test71()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "→", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test72()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∧", "∨", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(3, answer.Count);
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("ABC"));

        }

        [TestMethod]
        public void Test73()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "→", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test74()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "⊻", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test75()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∨", "→", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(7, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test76()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "⊻", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(6, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test77()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↔", "↔", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test78()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "↔", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test79()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↔", "⊻", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test8()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∧", "→", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(3, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test80()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "↓", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(7, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test81()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↓", "∨", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test82()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∨", "∨", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(7, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test83()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↓", "↔", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
        }
        [TestMethod]
        public void Test84()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∧", "↔", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(2, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test85()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "∨", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("BC"));
        }
        [TestMethod]
        public void Test86()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "∧", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(7, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test87()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∨", "∧", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(3, answer.Count);
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test88()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "⊻", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test89()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↓", "∧", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(3, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test9()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∨", "∧", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test90()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "|", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test91()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("|", "→", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test92()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("∨", "←", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(7, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test93()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "→", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("BC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test94()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↓", "↔", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(2, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
        }
        [TestMethod]
        public void Test95()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("→", "⊻", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test96()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "←", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(7, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("ABC"));
            Assert.IsTrue(answer.Contains("None"));
        }
        [TestMethod]
        public void Test97()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("←", "→", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("AC"));
            Assert.IsTrue(answer.Contains("ABC"));
        }
        [TestMethod]
        public void Test98()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("⊻", "⊻", false, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(4, answer.Count);
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("ABC"));
        }

        [TestMethod]
        public void Test99()
        {
            BooleanVennDiagram module = new BooleanVennDiagram("↓", "←", true, io);
            List<string> answer = module.Solve(true);
            io.Close();
            Assert.AreEqual(5, answer.Count);
            Assert.IsTrue(answer.Contains("AB"));
            Assert.IsTrue(answer.Contains("A"));
            Assert.IsTrue(answer.Contains("B"));
            Assert.IsTrue(answer.Contains("C"));
            Assert.IsTrue(answer.Contains("None"));
        }


    }
}