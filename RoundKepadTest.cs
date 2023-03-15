using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ModuleTest
{
    [TestClass]
    public class RoundKeypadTest
    {

        StreamWriter io = new StreamWriter("dummy.txt");

        [TestMethod]
        public void Test1()
        {
            List<RoundKeypad.Symbol> list = new List<RoundKeypad.Symbol>()
            {
                RoundKeypad.Symbol.SmilyFace,
                RoundKeypad.Symbol.X,
                RoundKeypad.Symbol.Swirl,
                RoundKeypad.Symbol.A,
                RoundKeypad.Symbol.Squid,
                RoundKeypad.Symbol.UfinishedR,
                RoundKeypad.Symbol.B,
                RoundKeypad.Symbol.BlackStar
            };
            RoundKeypad module = new RoundKeypad(io, list);
            RoundKeypad.Symbol[] answer = module.Solve();
            io.Close();

            Assert.AreEqual(4, answer.Length);
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.Swirl));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.UfinishedR));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.A));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.BlackStar));
        }

        [TestMethod]
        public void Test2()
        {
            List<RoundKeypad.Symbol> list = new List<RoundKeypad.Symbol>()
            {
                RoundKeypad.Symbol.X,
                RoundKeypad.Symbol.Swirl,
                RoundKeypad.Symbol.B,
                RoundKeypad.Symbol.BackwardsC,
                RoundKeypad.Symbol.C,
                RoundKeypad.Symbol.N,
                RoundKeypad.Symbol.Lightning,
                RoundKeypad.Symbol.E
            };
            RoundKeypad module = new RoundKeypad(io, list);
            RoundKeypad.Symbol[] answer = module.Solve();
            io.Close();

            Assert.AreEqual(5, answer.Length);
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.X));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.B));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.C));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.N));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.Lightning));
        }

        [TestMethod]
        public void Test3()
        {
            List<RoundKeypad.Symbol> list = new List<RoundKeypad.Symbol>()
            {
                RoundKeypad.Symbol.Swirl,
                RoundKeypad.Symbol.Ae,
                RoundKeypad.Symbol.Lambda,
                RoundKeypad.Symbol.WhiteStar,
                RoundKeypad.Symbol.Paragraph,
                RoundKeypad.Symbol.O,
                RoundKeypad.Symbol.SmilyFace,
                RoundKeypad.Symbol.H
            };
            RoundKeypad module = new RoundKeypad(io, list);
            RoundKeypad.Symbol[] answer = module.Solve();
            io.Close();

            Assert.AreEqual(4, answer.Length);
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.Ae));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.Lambda));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.Paragraph));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.SmilyFace));
        }

        [TestMethod]
        public void Test4()
        {
            List<RoundKeypad.Symbol> list = new List<RoundKeypad.Symbol>()
            {
                RoundKeypad.Symbol.A,
                RoundKeypad.Symbol.Squid,
                RoundKeypad.Symbol.Trident,
                RoundKeypad.Symbol.Swirl,
                RoundKeypad.Symbol.Lightning,
                RoundKeypad.Symbol.Omega,
                RoundKeypad.Symbol.E,
                RoundKeypad.Symbol.Six
            };
            RoundKeypad module = new RoundKeypad(io, list);
            RoundKeypad.Symbol[] answer = module.Solve();
            io.Close();

            Assert.AreEqual(4, answer.Length);
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.A));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.Squid));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.Swirl));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.Lightning));
        }

        [TestMethod]
        public void Test5()
        {
            List<RoundKeypad.Symbol> list = new List<RoundKeypad.Symbol>()
            {
                RoundKeypad.Symbol.BackwardsC,
                RoundKeypad.Symbol.Hashtag,
                RoundKeypad.Symbol.Ae,
                RoundKeypad.Symbol.Six,
                RoundKeypad.Symbol.B,
                RoundKeypad.Symbol.E,
                RoundKeypad.Symbol.QuestionMark,
                RoundKeypad.Symbol.BlackStar
            };
            RoundKeypad module = new RoundKeypad(io, list);
            RoundKeypad.Symbol[] answer = module.Solve();
            io.Close();

            Assert.AreEqual(4, answer.Length);
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.BackwardsC));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.B));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.QuestionMark));
            Assert.IsTrue(answer.Contains(RoundKeypad.Symbol.BlackStar));
        }
    }
}