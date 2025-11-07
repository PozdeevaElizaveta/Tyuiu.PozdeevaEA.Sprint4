using Tyuiu.PozdeevaEA.Sprint4.Task0.V3.Lib;
namespace Tyuiu.PozdeevaEA.Sprint4.Task0.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidMult()
        {
            DataService ds = new DataService();

            int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            int res = ds.GetMultOddArrEl(array);
            int wait = 945;
            Assert.AreEqual(wait, res);
        }
    }
}
