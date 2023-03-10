using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;

namespace ModuleTest
{
    //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=7425441d33c0c8d2e000b9b7efb926d4124003d3;bomb=6K2EN0




    [TestClass]
    public class WordSearchTest
    {
        Bomb bomb = new Bomb(Day.Sunday, "6K2EN0", 2, 1,
         new Indicator("BOB", true, true), new Indicator("CAR", false, false), new Indicator("CLR", true, true),
         new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", true, true),
         new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
         new Indicator("SND", false, false), new Indicator("TRN", false, false),
         new List<Plate>() { new Plate(false, false, false, false, false, false),
                             new Plate(false, false, false, false, false, false)}
);
        StreamWriter io = new StreamWriter("dummy.txt");

        [TestMethod]
        public void Test1()
        {
            WordSearch module = new WordSearch(bomb, io, 'Z', 'X', 'O', 'J');

            string answerStr = module.Solve(true);
            io.Close();

            
            string[] expectedArr = ConvertStringtoAnswer("ZULU, BOMBS, MANUAL, TEST", ',');
            string[] answerArr = ConvertStringtoAnswer(answerStr, '\n');

            for(int i = 0; i < 4; i++)
            {
                Assert.IsTrue(expectedArr.Contains(answerArr[i]));

            }
        }

        [TestMethod]
        public void Test2()
        {
            WordSearch module = new WordSearch(bomb, io, 'X', 'Z', 'R', 'O');

            string answerStr = module.Solve(true);
            io.Close();

            string[] expectedArr = ConvertStringtoAnswer("VICTOR, BRAVO, PANIC, WORK", ',');
            string[] answerArr = ConvertStringtoAnswer(answerStr, '\n');

            for (int i = 0; i < 4; i++)
            {
                Assert.IsTrue(expectedArr.Contains(answerArr[i]));
            }
        }

        [TestMethod]
        public void Test3()
        {
            WordSearch module = new WordSearch(bomb, io, 'V', 'O', 'Z', 'M');

            string answerStr = module.Solve(true);
            io.Close();

            string[] expectedArr = ConvertStringtoAnswer("LIST, FINISH, LINE, NUMBER", ',');
            string[] answerArr = ConvertStringtoAnswer(answerStr, '\n');

            for (int i = 0; i < 4; i++)
            {
                Assert.IsTrue(expectedArr.Contains(answerArr[i]));
            }

        }

        [TestMethod]
        public void Test4()
        {
            WordSearch module = new WordSearch(bomb, io, 'P', 'K', 'Y', 'R');

            string answerStr = module.Solve(true);
            io.Close();

            string[] expectedArr = ConvertStringtoAnswer("GOLF, DECOY, INDIA, TALK", ',');
            string[] answerArr = ConvertStringtoAnswer(answerStr, '\n');

            for (int i = 0; i < 4; i++)
            {
                Assert.IsTrue(expectedArr.Contains(answerArr[i]));
            }

        }

        [TestMethod]
        public void Test5()
        {
            WordSearch module = new WordSearch(bomb, io, 'Q', 'P', 'Q', 'Z');

            string answerStr = module.Solve(true);
            io.Close();

            string[] expectedArr = ConvertStringtoAnswer("LINE, NUMBER, SEE, SIERRA", ',');
            string[] answerArr = ConvertStringtoAnswer(answerStr, '\n');

            for (int i = 0; i < 4; i++)
            {
                Assert.IsTrue(expectedArr.Contains(answerArr[i]));
            }

        }

        private string[] ConvertStringtoAnswer(string s, char split)
        {
            string[] arr = s.Split(split);

            for (int i = 0; i < 4; i++)
            {
                arr[i] = arr[i].Trim();
            }

            return arr;
        }

    }
}