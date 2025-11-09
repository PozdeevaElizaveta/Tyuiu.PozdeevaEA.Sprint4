using Tyuiu.PozdeevaEA.Sprint4.Task3.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* статическими значениями в диапазоне от 3 до 8. Найдите произведение     *");
        Console.WriteLine("* элементов в последнем столбце массива.                                  *");
        Console.WriteLine("* 8, 3, 3, 3, 5,                                                          *");
        Console.WriteLine("* 6, 7, 3, 3, 7,                                                          *");
        Console.WriteLine("* 4, 5, 4, 6, 6,                                                          *");
        Console.WriteLine("* 5, 5, 8, 8, 7,                                                          *");
        Console.WriteLine("* 4, 6, 6, 7, 7,                                                          *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] array = new int[5, 5]{ {8, 3, 3, 3, 5, },
                                      { 6, 7, 3, 3, 7, },
                                      { 4, 5, 4, 6, 6, },
                                      { 5, 5, 8, 8, 7, },
                                      { 4, 6, 6, 7, 7,} };

        Console.WriteLine();
        Console.WriteLine("Массив: ");
        for (int i=0; i < (array.GetUpperBound(0) + 1); i++)
        {
            for (int j = 0; j < (array.GetLength(1) - 1); j++)
            {
                Console.Write(array[i, j]);
            }
        }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);
            Console.WriteLine("Произведение нечетных элементов массива " + res);

            Console.ReadKey();
        
    }
}