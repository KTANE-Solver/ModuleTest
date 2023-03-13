using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ModuleTest
{
    [TestClass]
    public class ColorFlashTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=a4cd3f9e9220c629eac865f587e24982c677dfdd;bomb=H62DD2
        StreamWriter io = new StreamWriter("dummy.txt");

        [TestMethod]
        public void Test1()
        {
           List<string> words = new List<string>()
           { 
                "B",
                "Y",
                "R",
                "W",
                "M",
                "M",
                "Y",
                "G",
           };

            List<string> colors = new List<string>()
           {
                "R",
                "Y",
                "G",
                "W",
                "R",
                "M",
                "B",
                "B"
           };
            ColorFlash2 module = new ColorFlash2(colors, words, io);
            KeyValuePair<string, int> answer = module.Solve(true);
            
            io.Close();

            Assert.AreEqual("Yes", answer.Key);
            Assert.AreEqual(1, answer.Value);
        }

        [TestMethod]
        public void Test2()
        {
            List<string> words = new List<string>()
           {
                "M",
                "M",
                "M",
                "W",
                "W",
                "B",
                "W",
                "W",
           };

            List<string> colors = new List<string>()
           {
                "Y",
                "M",
                "W",
                "G",
                "W",
                "G",
                "W",
                "G"
           };
            ColorFlash2 module = new ColorFlash2(colors, words, io);
            KeyValuePair<string, int> answer = module.Solve(true);

            io.Close();

            Assert.AreEqual("No", answer.Key);
            Assert.AreEqual(5, answer.Value);
        }


        [TestMethod]
        public void Test3()
        {
            List<string> words = new List<string>()
           {
                "W",
                "B",
                "M",
                "M",
                "W",
                "B",
                "R",
                "Y",
           };

            List<string> colors = new List<string>()
           {
                "B",
                "Y",
                "M",
                "R",
                "B",
                "B",
                "R",
                "Y"
           };
            ColorFlash2 module = new ColorFlash2(colors, words, io);
            KeyValuePair<string, int> answer = module.Solve(true);

            io.Close();

            Assert.AreEqual("No", answer.Key);
            Assert.AreEqual(2, answer.Value);
        }

        [TestMethod]
        public void Test4()
        {
            List<string> words = new List<string>()
           {
                "R",
                "M",
                "M",
                "B",
                "Y",
                "B",
                "R",
                "R",
           };

            List<string> colors = new List<string>()
           {
                "Y",
                "Y",
                "M",
                "R",
                "M",
                "B",
                "R",
                "M"
           };
            ColorFlash2 module = new ColorFlash2(colors, words, io);
            KeyValuePair<string, int> answer = module.Solve(true);

            io.Close();

            Assert.AreEqual("Yes", answer.Key);
            Assert.AreEqual(3, answer.Value);
        }

        [TestMethod]
        public void Test5()
        {
            List<string> words = new List<string>()
           {
                "R",
                "M",
                "R",
                "Y",
                "R",
                "W",
                "Y",
                "M",
           };

            List<string> colors = new List<string>()
           {
                "Y",
                "M",
                "R",
                "Y",
                "R",
                "G",
                "G",
                "G"
           };
            ColorFlash2 module = new ColorFlash2(colors, words, io);
            KeyValuePair<string, int> answer = module.Solve(true);

            io.Close();

            Assert.AreEqual("Yes", answer.Key);
            Assert.AreEqual(2, answer.Value);
        }
    }
}