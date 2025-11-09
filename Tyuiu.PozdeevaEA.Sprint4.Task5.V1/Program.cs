using Tyuiu.PozdeevaEA.Sprint4.Task5.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();      

        Console.Title = "Спринт #4 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* случайными значениями в диапазоне от -9 до 8. Заменить положительные    *");
        Console.WriteLine("* элементы массива на 1.                                                  *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] matrix = new int[5, 5];
        for (int i = 0; i < (matrix.GetUpperBound(0) + 1); i++)
        {
            for (int j = 0; j < (matrix.GetLength(1)); j++)
            {
                matrix[i, j] = rnd.Next(-9, 8);
            }

        }
        Console.WriteLine();
        Console.WriteLine("Macссив: ");
        for (int i = 0; i < (matrix.GetUpperBound(0)); i++)
        {
            for (int j = 0; j < (matrix.GetLength(1)); j++)
            {
                Console.Write($"{matrix[i, j]} ");

            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int[,] res = ds.Calculate(matrix);
        Console.WriteLine("Массив после замены положительных элементов на 1:");

        for (int i = 0; i < res.GetLength(0); i++)
        {
            for (int j = 0; j < res.GetLength(1); j++)
            {
                Console.Write($"{res[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}