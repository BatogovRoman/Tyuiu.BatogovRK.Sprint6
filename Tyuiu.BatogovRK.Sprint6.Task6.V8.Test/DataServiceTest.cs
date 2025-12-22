using Tyuiu.BatogovRK.Sprint6.Task6.V8.Lib;

namespace Tyuiu.BatogovRK.Sprint6.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            string path = @"C:\Users\User\source\repos\ТИУ с 1 спринта\Tyuiu.BatogovRK.Sprint6\files\InPutDataFileTask6V8.txt";
            //C:\Users\User\source\repos\ТИУ с 1 спринта\Tyuiu.BatogovRK.Sprint6\files
            var res = ds.CollectTextFromFile(path);
            string wait = "RizdogMOZpCb GqzgGQOdWpd ztMvvn";
            Assert.AreEqual(wait, res);
        }
    }
}
