using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PozdeevaEA.Sprint4.Task3.V21.Lib
{
    public class DataService : ISprint4Task3V21

    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int lastcol = array.GetLength(1) - 1; ;
           
            int mult = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                mult*= array[i,lastcol];
            }
            return mult;
        }
    }
}
