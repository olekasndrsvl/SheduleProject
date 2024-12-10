using MyDST;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
       
        }

        [Test]
        public void Test1()
        {
            int[,] Data = { { 0, 1, 1 }, { 1, 0, 1 }, { 1, 1, 0 } };
            var t = new Graph(Data, 0);
            Assert.That(t.Peaks.Last().ToString(), Is.EqualTo("| 2 Peaks:0 1 |"));
        }


        [Test]
        public void Test2()
        {
            int[,] Data = { { 0, 1, 1 }, { 1, 0, 1 }, { 1, 1, 0 } };
            var t = new Graph(Data, 0);
            Assert.That(t.Peaks.First().ToString(), Is.EqualTo("| 0 Peaks:1 2 |"));
        }

        [Test]
        public void Test3()
        {
            int[,] Data = { { 0, 1, 1 }, { 1, 0, 1 }, { 1, 1, 0 } };
            var t = new Graph(Data, 0);
            Assert.That(t.Peaks[1].ToString(), Is.EqualTo("| 1 Peaks:0 2 |"));
        }
    }
}