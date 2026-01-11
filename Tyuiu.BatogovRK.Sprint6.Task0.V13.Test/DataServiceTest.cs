using Tyuiu.BatogovRK.Sprint6.Task0.V13.Lib;

namespace Tyuiu.BatogovRK.Sprint6.Task0.V13.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double expected = 4.5;

            double actual = ds.Calculate(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
