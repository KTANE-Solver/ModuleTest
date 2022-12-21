using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    [TestClass]
    public class MicrocontrollerTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=f24110e5b9b0dbaa286c6725c69a2680c2b88bee;bomb=UA1TN5

        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        Bomb bomb = null;

        [TestMethod]
        public void Test1()
        {
            Microcontroller module = new Microcontroller(bomb, streamWriter, "Bottom Left", "STRK", 8, 0, 1);

            List<Color> list = module.Solve();
            Assert.AreEqual("White", list[0].Name.Replace("[","").Replace("]",""));
            Assert.AreEqual("Red", list[1].Name.Replace("[","").Replace("]",""));
            Assert.AreEqual("White", list[2].Name.Replace("[","").Replace("]",""));
            Assert.AreEqual("Yellow", list[3].Name.Replace("[","").Replace("]",""));
            Assert.AreEqual("Magenta", list[4].Name.Replace("[","").Replace("]",""));
            Assert.AreEqual("Blue", list[5].Name.Replace("[","").Replace("]",""));
            Assert.AreEqual("White", list[6].Name.Replace("[","").Replace("]",""));
            Assert.AreEqual("Green", list[7].Name.Replace("[","").Replace("]",""));

            streamWriter.Close();
        }

        [TestMethod]
        public void Test2()
        {
            Microcontroller module = new Microcontroller(bomb, streamWriter, "Bottom Left", "CNTD", 8, 9, 7);

            List<Color> list = module.Solve();
            Assert.AreEqual("Blue", list[0].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Magenta", list[1].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("White", list[2].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Red", list[3].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Green", list[4].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("White", list[5].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("White", list[6].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Yellow", list[7].Name.Replace("[", "").Replace("]", ""));
            streamWriter.Close();
        }

        [TestMethod]
        public void Test3()
        {
            Microcontroller module = new Microcontroller(bomb, streamWriter, "Top Left", "STRK", 10, 9, 8);

            List<Color> list = module.Solve();
            Assert.AreEqual("White", list[0].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("White", list[1].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("White", list[2].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("White", list[3].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Red", list[4].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Green", list[5].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Blue", list[6].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Yellow", list[7].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("White", list[8].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Magenta", list[9].Name.Replace("[", "").Replace("]", ""));
            streamWriter.Close();
        }

        [TestMethod]
        public void Test4()
        {
            Microcontroller module = new Microcontroller(bomb, streamWriter, "Bottom Left", "STRK", 6, 9, 1);

            List<Color> list = module.Solve();
            Assert.AreEqual("White", list[0].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Blue", list[1].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Green", list[2].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Magenta", list[3].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Yellow", list[4].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Red", list[5].Name.Replace("[", "").Replace("]", ""));
            streamWriter.Close();
        }

        [TestMethod]
        public void Test5()
        {
            Microcontroller module = new Microcontroller(bomb, streamWriter, "Top Left", "LEDS", 10, 2, 3);

            List<Color> list = module.Solve();
            Assert.AreEqual("Green", list[0].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Red", list[1].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Magenta", list[2].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("White", list[3].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("White", list[4].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("White", list[5].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Yellow", list[6].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("Blue", list[7].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("White", list[8].Name.Replace("[", "").Replace("]", ""));
            Assert.AreEqual("White", list[9].Name.Replace("[", "").Replace("]", ""));
            streamWriter.Close();
        }
    }
}