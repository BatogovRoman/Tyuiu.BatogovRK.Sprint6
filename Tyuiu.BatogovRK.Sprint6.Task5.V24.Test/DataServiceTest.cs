using Tyuiu.BatogovRK.Sprint6.Task5.V24.Lib;

namespace Tyuiu.BatogovRK.Sprint6.Task5.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"InPutFileTask5V24.txt";
            string[] testData = { "1.5", "0", "3.7", "0.0", "-2.1", "0.000", "4.8", "-0.0", "2.3" };
            File.WriteAllLines(path, testData);

            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(9, result.Length);

            Assert.AreEqual(1.5, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(3.7, result[2]);
            Assert.AreEqual(0, result[3]);
            Assert.AreEqual(-2.1, result[4]);
            Assert.AreEqual(0, result[5]);
            Assert.AreEqual(4.8, result[6]);
            Assert.AreEqual(0, result[7]);
            Assert.AreEqual(2.3, result[8]);

            File.Delete(path);
        }
    }
}
