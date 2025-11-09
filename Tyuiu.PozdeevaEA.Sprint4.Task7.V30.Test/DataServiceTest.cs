using Tyuiu.PozdeevaEA.Sprint4.Task7.V30.Lib;
namespace Tyuiu.PozdeevaEA.Sprint4.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 5;
            int m = 3;
            int[,] matrix = new int[n, m];
            string str = "684259137159648";
            int res = ds.Calculate(n, m, str);
            int wait = 73728;
            Assert.AreEqual(wait, res);
        }
    }
}
