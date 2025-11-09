using Tyuiu.PozdeevaEA.Sprint4.Task6.V12.Lib;
namespace Tyuiu.PozdeevaEA.Sprint4.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValisCalc()
        {
            DataService ds = new DataService();
            var month = new string[] { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };
            string[] eq7 = ds.Calculate(month);
            string[] wait = { "Украина", "Молдова", "Эстония" };
            CollectionAssert.AreEqual(eq7, wait);

        }
    }
}
