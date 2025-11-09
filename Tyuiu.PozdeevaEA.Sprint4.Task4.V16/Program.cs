using Tyuiu.PozdeevaEA.Sprint4.Task4.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 7. Заменить четные элементы *");
        Console.WriteLine("* массива на 1.                                                           *");
        Console.WriteLine("* 6, 5, 6, 7, 3,                                                          *");
        Console.WriteLine("* 5, 4, 6, 7, 3,                                                          *");
        Console.WriteLine("* 5, 5, 5, 6, 5,                                                          *");
        Console.WriteLine("* 6, 5, 4, 4, 3,                                                          *");
        Console.WriteLine("* 4, 5, 4, 5, 5,                                                          *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] matrix = new int[5,5];
        Console.WriteLine("Введите 25 целых чисел в диапазоне от 3 до 7:");
        for (int i = 0; i < (matrix.GetUpperBound(0) + 1); i++)
        {
            for (int j = 0; j < (matrix.GetLength(1)); j++)
            {
                Console.Write($"Введите {i},{j} элемент массива ");
                int value = Convert.ToInt32(Console.ReadLine());

                if (value < 3 || value > 7)
                {
                    Console.WriteLine("Ошибка! Число должно быть в диапазоне от 3 до 7");
                    j--;
                    continue;
                }
                matrix[i,j] = value;
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

             int [,] res = ds.Calculate(matrix);
        Console.WriteLine("Массив после замены четных элементов на 1:");

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