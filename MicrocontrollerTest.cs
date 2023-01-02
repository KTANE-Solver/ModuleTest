using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Formats.Asn1;
using static New_KTANE_Solver.Microcontroller.DotPos;

namespace ModuleTest
{
    [TestClass]
    public class MicrocontrollerTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=f24110e5b9b0dbaa286c6725c69a2680c2b88bee;bomb=UA1TN5

        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "UA1TN5", 2, 1,
    new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
    new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
    new Indicator("MSA", true, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
    new Indicator("SND", false, false), new Indicator("TRN", true, true), new List<Plate>()
{
            new Plate(false, true, false, true, false, true),
            new Plate(false, true, false, true, false, false) });

        [TestMethod]
        public void Test1()
        {
            Microcontroller module = new Microcontroller(bomb, io, BL, "STRK", 8, 0, 1);

            List<Color> colors = module.Solve();

            List<string> answer = ConvertColorToString(colors);

            io.Close();



            Assert.AreEqual("Magenta", answer[4]);
            Assert.AreEqual("Blue", answer[5]);
            Assert.AreEqual("White", answer[6]);
            Assert.AreEqual("Green", answer[7]);
            Assert.AreEqual("Yellow", answer[3]);
            Assert.AreEqual("White", answer[2]);
            Assert.AreEqual("Red", answer[1]);
            Assert.AreEqual("White", answer[0]);
        }

        [TestMethod]
        public void Test2()
        {
            Microcontroller module = new Microcontroller(bomb, io, BL, "CNTD", 8, 9, 7);

            List<Color> colors = module.Solve();

            List<string> answer = ConvertColorToString(colors);

            io.Close();

            Assert.AreEqual("Green", answer[4]);
            Assert.AreEqual("White", answer[5]);
            Assert.AreEqual("White", answer[6]);
            Assert.AreEqual("Yellow", answer[7]);
            Assert.AreEqual("Red", answer[3]);
            Assert.AreEqual("White", answer[2]);
            Assert.AreEqual("Magenta", answer[1]);
            Assert.AreEqual("Blue", answer[0]);
        }

        [TestMethod]
        public void Test3()
        {
            Microcontroller module = new Microcontroller(bomb, io, TL, "STRK", 10, 9, 8);

            List<Color> colors = module.Solve();

            List<string> answer = ConvertColorToString(colors);

            io.Close();

            Assert.AreEqual("White", answer[0]);
            Assert.AreEqual("White", answer[1]);
            Assert.AreEqual("White", answer[2]);
            Assert.AreEqual("White", answer[3]);
            Assert.AreEqual("Red", answer[4]);
            Assert.AreEqual("Magenta", answer[9]);
            Assert.AreEqual("White", answer[8]);
            Assert.AreEqual("Yellow", answer[7]);
            Assert.AreEqual("Blue", answer[6]);
            Assert.AreEqual("Green", answer[5]);

        }

        [TestMethod]
        public void Test4()
        {
            Microcontroller module = new Microcontroller(bomb, io, BL, "STRK", 6, 9, 1);

            List<Color> colors = module.Solve();

            List<string> answer = ConvertColorToString(colors);

            io.Close();

            Assert.AreEqual("Magenta", answer[3]);
            Assert.AreEqual("Yellow", answer[4]);
            Assert.AreEqual("Red", answer[5]);
            Assert.AreEqual("Green", answer[2]);
            Assert.AreEqual("Blue", answer[1]);
            Assert.AreEqual("White", answer[0]);
        }

        [TestMethod]
        public void Test5()
        {
            Microcontroller module = new Microcontroller(bomb, io, TL, "LEDS", 10, 2, 3);

            List<Color> colors = module.Solve();

            List<string> answer = ConvertColorToString(colors);

            io.Close();

            Assert.AreEqual("Green", answer[0]);
            Assert.AreEqual("Red", answer[1]);
            Assert.AreEqual("Magenta", answer[2]);
            Assert.AreEqual("White", answer[3]);
            Assert.AreEqual("White", answer[4]);
            Assert.AreEqual("White", answer[9]);
            Assert.AreEqual("White", answer[8]);
            Assert.AreEqual("Blue", answer[7]);
            Assert.AreEqual("Yellow", answer[6]);
            Assert.AreEqual("White", answer[5]);
        }

        private List<string> ConvertColorToString(List<Color> list)
        {
            List<string> answer = new List<string>();

            foreach(Color color in list) 
            {
                string s = "";

                foreach (char c in color.ToString())
                {
                    if (c != '[' && c != ']')
                    {
                        s += c;
                    }
                }

                s = s.Remove(0, 6);
                answer.Add(s);
            }

            return answer;
        }


    }



}