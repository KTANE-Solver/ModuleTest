using System;
using New_KTANE_Solver;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleTests
{
    //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=0b46d4f7bcd23f1c7a2f2fc8f2df1183dc879623;bomb=6U7UE3
    [TestClass]
    public class ChordQualitiesTest
    {
        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        [TestMethod]
        public void TestMethod1()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "E", "F#", "G", "B" }
            );

            Assert.AreEqual("E,A,B,D", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod10()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F#", "A#", "D", "F" }
            );

            Assert.AreEqual("C,E,G,A#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod100()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A", "C#", "E", "G#" }
            );

            Assert.AreEqual("A#,C#,F#,A", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod11()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "G", "A#", "B", "F" }
            );

            Assert.AreEqual("A,C,E,G#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod12()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "G", "C", "D", "F" }
            );

            Assert.AreEqual("D,F,A,C#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod13()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "C#", "F", "G#", "C" }
            );

            Assert.AreEqual("A#,C,C#,F", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod14()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F#", "A#", "D", "E" }
            );

            Assert.AreEqual("F#,A#,C#,E", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod15()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F#", "A", "A#", "E" }
            );

            Assert.AreEqual("A,C#,E,G", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod16()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "C#", "E", "A", "C" }
            );

            Assert.AreEqual("B,C#,D,F#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod17()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D#", "G", "B", "D" }
            );

            Assert.AreEqual("C,D#,E,A#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod18()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F", "G#", "B", "D#" }
            );

            Assert.AreEqual("C#,D#,F,G#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod19()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "B", "D", "F#", "A#" }
            );

            Assert.AreEqual("F,G#,C,D#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod2()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F", "A", "C#", "D#" }
            );

            Assert.AreEqual("F#,G#,A#,C#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod20()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A#", "C", "C#", "F" }
            );

            Assert.AreEqual("E,G#,C,D#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod21()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D#", "G", "A#", "D" }
            );

            Assert.AreEqual("A#,C#,D,G#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod22()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F#", "A", "A#", "E" }
            );

            Assert.AreEqual("A,C#,E,G", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod23()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "G#", "B", "C", "F#" }
            );

            Assert.AreEqual("A,C#,F,G", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod24()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "G", "A#", "D", "F#" }
            );

            Assert.AreEqual("F,G#,C,E", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod25()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "C", "D#", "G#", "B" }
            );

            Assert.AreEqual("B,D,F,A", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod26()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "C", "D#", "F#", "A#" }
            );

            Assert.AreEqual("C#,E,G,B", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod27()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "C#", "F", "G#", "C" }
            );

            Assert.AreEqual("A#,C,C#,F", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod28()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A", "D", "E", "G" }
            );

            Assert.AreEqual("D,F,A#,C#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod29()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "B", "D", "D#", "A" }
            );

            Assert.AreEqual("A,C,E,G", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod3()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "C", "D#", "G", "B" }
            );

            Assert.AreEqual("F,G#,B,D#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod30()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D", "F", "F#", "C" }
            );

            Assert.AreEqual("A,C#,E,G#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod31()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D", "F", "A", "C#" }
            );

            Assert.AreEqual("F,A,C,E", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod32()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A#", "C#", "E", "G#" }
            );

            Assert.AreEqual("C#,F,A,C", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod33()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "E", "G", "A#", "D" }
            );

            Assert.AreEqual("C#,F#,G#,B", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod34()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D", "F#", "A", "C#" }
            );

            Assert.AreEqual("A#,D,F,A", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod35()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "B", "D#", "F#", "A" }
            );

            Assert.AreEqual("G,A#,D,F", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod36()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A", "C", "C#", "G" }
            );

            Assert.AreEqual("A,C,F,G#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod37()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A#", "D", "F#", "G#" }
            );

            Assert.AreEqual("F#,A#,D,F", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod38()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F#", "A#", "D", "F" }
            );

            Assert.AreEqual("C,E,G,A#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod39()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "B", "D", "F#", "A" }
            );

            Assert.AreEqual("G#,B,D#,F#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod4()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F#", "A#", "C#", "F" }
            );

            Assert.AreEqual("A#,D,F,G#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod40()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A#", "D", "F", "G#" }
            );

            Assert.AreEqual("G,B,D#,F#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod41()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D#", "F#", "A#", "C#" }
            );

            Assert.AreEqual("G#,B,C,F#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod42()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "G", "C", "D", "F" }
            );

            Assert.AreEqual("D,F,A,C#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod43()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A", "D", "E", "G" }
            );

            Assert.AreEqual("D,F,A#,C#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod44()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F", "G#", "B", "D#" }
            );

            Assert.AreEqual("C#,D#,F,G#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod45()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "G#", "B", "E", "G" }
            );

            Assert.AreEqual("B,D#,G,A", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod46()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F", "A", "C#", "E" }
            );

            Assert.AreEqual("C,D,E,G", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod47()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A#", "D", "F", "A" }
            );

            Assert.AreEqual("A#,D,F#,A", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod48()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "B", "E", "F#", "A" }
            );

            Assert.AreEqual("D,F,A,C", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod49()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D", "F", "A", "C" }
            );

            Assert.AreEqual("G#,C,D#,G", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod5()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A#", "C#", "F", "A" }
            );

            Assert.AreEqual("F,A,C#,E", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod50()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "B", "D#", "F#", "A" }
            );

            Assert.AreEqual("G,A#,D,F", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod51()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "C", "F", "G", "A#" }
            );

            Assert.AreEqual("D,F,G#,C", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod52()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A", "B", "C#", "E" }
            );

            Assert.AreEqual("D#,F#,B,D", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod53()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "C#", "D#", "F", "G#" }
            );

            Assert.AreEqual("D#,F,F#,A#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod54()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A#", "C#", "D", "G#" }
            );

            Assert.AreEqual("A,C#,F,G#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod55()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "G", "A#", "D", "F#" }
            );

            Assert.AreEqual("F,G#,C,E", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod56()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "C#", "E", "G", "B" }
            );

            Assert.AreEqual("C#,D#,E,G#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod57()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A", "C", "D#", "G" }
            );

            Assert.AreEqual("C#,E,A,C", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod58()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "E", "G", "G#", "D" }
            );

            Assert.AreEqual("A,D,E,G", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod59()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F#", "A#", "D", "F" }
            );

            Assert.AreEqual("C,E,G,A#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod6()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D", "F", "F#", "C" }
            );

            Assert.AreEqual("A,C#,E,G#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod60()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F", "G#", "C#", "E" }
            );

            Assert.AreEqual("B,C#,D#,F#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod61()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F#", "B", "C#", "E" }
            );

            Assert.AreEqual("D,F#,A,C", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod62()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "G#", "A#", "B", "D#" }
            );

            Assert.AreEqual("E,G#,C,D", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod63()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "B", "D#", "F#", "A#" }
            );

            Assert.AreEqual("A#,C#,F,G#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod64()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A", "B", "C#", "E" }
            );

            Assert.AreEqual("D#,F#,B,D", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod65()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "C#", "F#", "G#", "B" }
            );

            Assert.AreEqual("D,E,F,A", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod66()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D", "F", "A", "C" }
            );

            Assert.AreEqual("G#,C,D#,G", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod67()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D", "F#", "A#", "C" }
            );

            Assert.AreEqual("F#,A#,C#,F", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod68()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A#", "C#", "E", "G#" }
            );

            Assert.AreEqual("C#,F,A,C", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod69()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D", "E", "F#", "A" }
            );

            Assert.AreEqual("D#,G,A#,D", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod7()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "C#", "E", "F", "B" }
            );

            Assert.AreEqual("A,B,C,E", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod70()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F#", "G#", "A", "C#" }
            );

            Assert.AreEqual("E,G#,B,D", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod71()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D", "F", "A#", "C#" }
            );

            Assert.AreEqual("B,D#,F#,A#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod72()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F#", "A#", "D", "E" }
            );

            Assert.AreEqual("F#,A#,C#,E", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod73()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D#", "G#", "A#", "C#" }
            );

            Assert.AreEqual("D,F,F#,C", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod74()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "C", "D#", "G", "A#" }
            );

            Assert.AreEqual("G#,B,D,F#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod75()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A#", "D", "F#", "G#" }
            );

            Assert.AreEqual("F#,A#,D,F", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod76()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "G", "A", "B", "D" }
            );

            Assert.AreEqual("D#,F#,A#,D", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod77()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A", "C#", "F", "G#" }
            );

            Assert.AreEqual("C,D#,G#,B", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod78()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A", "D", "E", "G" }
            );

            Assert.AreEqual("D,F,A#,C#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod79()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "G", "C", "D", "F" }
            );

            Assert.AreEqual("D,F,A,C#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod8()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D", "F", "A", "C#" }
            );

            Assert.AreEqual("F,A,C,E", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod80()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A#", "C#", "E", "G#" }
            );

            Assert.AreEqual("C#,F,A,C", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod81()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "G", "B", "D#", "F" }
            );

            Assert.AreEqual("F#,A,C#,F", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod82()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A#", "C", "C#", "F" }
            );

            Assert.AreEqual("E,G#,C,D#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod83()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A#", "C#", "F", "G#" }
            );

            Assert.AreEqual("G#,C,E,G", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod84()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D", "F", "G#", "C" }
            );

            Assert.AreEqual("C#,F,G#,C", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod85()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "B", "D", "F", "A" }
            );

            Assert.AreEqual("C#,E,G#,B", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod86()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "E", "F#", "G", "B" }
            );

            Assert.AreEqual("E,A,B,D", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod87()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "G", "A#", "D", "F" }
            );

            Assert.AreEqual("G#,B,D#,G", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod88()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "G", "A#", "B", "F" }
            );

            Assert.AreEqual("A,C,E,G#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod89()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "D#", "F#", "A#", "C#" }
            );

            Assert.AreEqual("G#,B,C,F#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod9()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "C", "D#", "F#", "A#" }
            );

            Assert.AreEqual("C#,E,G,B", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod90()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "E", "G#", "B", "D#" }
            );

            Assert.AreEqual("A#,D#,F,G#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod91()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "E", "A", "B", "D" }
            );

            Assert.AreEqual("D,G,A,C", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod92()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "E", "G", "C", "D#" }
            );

            Assert.AreEqual("B,E,F#,A", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod93()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "C", "D#", "G", "B" }
            );

            Assert.AreEqual("F,G#,B,D#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod94()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F", "G#", "B", "D#" }
            );

            Assert.AreEqual("C#,D#,F,G#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod95()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A#", "C", "D", "F" }
            );

            Assert.AreEqual("D#,G,B,D", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod96()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "F#", "A#", "C#", "E" }
            );

            Assert.AreEqual("G,B,D,F", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod97()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A", "C", "E", "G" }
            );

            Assert.AreEqual("G#,B,E,G", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod98()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "A#", "C", "C#", "F" }
            );

            Assert.AreEqual("E,G#,C,D#", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod99()
        {
            ChordQualities module = new ChordQualities(
                null,
                streamWriter,
                new List<string>() { "B", "D#", "F#", "A" }
            );

            Assert.AreEqual("G,A#,D,F", module.Solve(true).Replace(" ", ""));

            streamWriter.Close();
        }

    }
}
