using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=30df1d7112aa113134d03961af225e222a9ef20b;bomb=G51EC5



    [TestClass]
    public class FizzBuzzTest
    {
        Bomb bomb = new Bomb(Day.Sunday, "G51EC5", 2, 2,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", true, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", true, true),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), 
             new List<Plate>() {
            new Plate(true, false, true, false, false, false) 
             });

        StreamWriter io = new StreamWriter("dummy.txt");


        [TestMethod]
        public void Test1()
        {
            FizzBuzz module = new FizzBuzz("Green", "4593729", "White", "2659873", "Blue", "2219740", bomb, io);
            string answer = module.Solve(true);

            bomb.IncrementStrike();
            bomb.IncrementStrike();

            string strikeAnswer = module.Solve(true);

            io.Close();

            Assert.AreEqual(strikeAnswer, answer);
        }

        [TestMethod]
        public void Test2()
        {
            FizzBuzz module = new FizzBuzz("Yellow", "7402425", "White", "6075291", "Red", "4271773", bomb, io);
            string answer = module.Solve(true);

            bomb.IncrementStrike();
            bomb.IncrementStrike();

            string strikeAnswer = module.Solve(true);

            io.Close();

            Assert.AreEqual("1.FizzBuzz\n2.Fizz\n3.FizzBuzz\n", answer);
            Assert.AreEqual("1.#\n2.Fizz\n3.#\n", strikeAnswer);

        }

        [TestMethod]
        public void Test3()
        {
            FizzBuzz module = new FizzBuzz("Yellow", "5225741", "White", "599173", "White", "2988985", bomb, io);
            string answer = module.Solve(true);

            bomb.IncrementStrike();
            bomb.IncrementStrike();

            string strikeAnswer = module.Solve(true);

            io.Close();

            Assert.AreEqual("1.#\n2.#\n3.Buzz\n", answer);
            Assert.AreEqual("1.#\n2.#\n3.#\n", strikeAnswer);

        }

        [TestMethod]
        public void Test4()
        {
            FizzBuzz module = new FizzBuzz("White", "1894356", "White", "2148203", "Yellow", "7352613", bomb, io);
            string answer = module.Solve(true);

            bomb.IncrementStrike();
            bomb.IncrementStrike();

            string strikeAnswer = module.Solve(true);

            io.Close();

            Assert.AreEqual("1.Fizz\n2.#\n3.Fizz\n", answer);
            Assert.AreEqual("1.#\n2.#\n3.Buzz\n", strikeAnswer);

        }

        [TestMethod]
        public void Test5()
        {
            FizzBuzz module = new FizzBuzz("Red", "7426137", "Yellow", "8101235", "Red", "7069798", bomb, io);
            string answer = module.Solve(true);

            bomb.IncrementStrike();
            bomb.IncrementStrike();

            string strikeAnswer = module.Solve(true);

            io.Close();

            Assert.AreEqual("1.#\n2.Buzz\n3.Buzz\n", answer);
            Assert.AreEqual("1.Buzz\n2.Fizz\n3.#\n", strikeAnswer);

        }


    }
}