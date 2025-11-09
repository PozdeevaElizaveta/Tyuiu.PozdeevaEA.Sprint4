using Tyuiu.PozdeevaEA.Sprint4.Task2.V24.Lib;
namespace Tyuiu.PozdeevaEA.Sprint4.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 4, 5, 8, 7, 4, 5, 7, 6, 4, 8, 7, 9 };
            int res = ds.Calculate(array);
            int wait = 40;
            Assert.AreEqual(wait, res);
        }
    }
}
