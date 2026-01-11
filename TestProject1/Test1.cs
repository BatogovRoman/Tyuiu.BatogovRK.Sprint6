using ClassLibrary2;
namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            Class2 ds = new Class2();
            int N = 2;
            int M = 2;
            int[,] array = new int[N, M];

            int n1 = 1;
            int n2 = 3;

            int c = 0;
            int k = 0;
            int l = 1;

            int res = ds.result(ds.GetMatrix(array, n1, n2), c, k, l);
            int wait = 0;
            Assert.AreEqual(res, wait);
        }
    }
}
