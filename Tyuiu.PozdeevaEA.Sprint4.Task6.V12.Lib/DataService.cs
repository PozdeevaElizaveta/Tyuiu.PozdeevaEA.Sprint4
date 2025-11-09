using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PozdeevaEA.Sprint4.Task6.V12.Lib
{
    public class DataService : ISprint4Task6V12
    {
        public string[] Calculate(string[] array)
        {
            string[] month = Array.FindAll(array, eq => eq.Length == 7);
            return month;
        }
    }
}
