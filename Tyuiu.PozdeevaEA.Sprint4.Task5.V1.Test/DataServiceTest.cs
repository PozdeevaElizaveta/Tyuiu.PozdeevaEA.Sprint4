using Tyuiu.PozdeevaEA.Sprint4.Task5.V1.Lib;
namespace Tyuiu.PozdeevaEA.Sprint4.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5]{ {-6, 5, 6, -7, 3,},
                                      { 5, -4, 6, 7, 3,},
                                      { 5, 5, 5, 6, 5,},
                                      { -6, 5, 4, -4, 3,},
                                      { 4, 5, -4, 5, -5,} };
            int[,] wait = new int[5, 5] { {-6, 1, 1, -7, 1,},
                                      { 1, -4, 1, 1, 1,},
                                      { 1, 1, 1, 1, 1,},
                                      { -6, 1, 1, -4, 1,},
                                      { 1, 1, -4, 1, -5,} };
            int[,] res = ds.Calculate(matrix);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
