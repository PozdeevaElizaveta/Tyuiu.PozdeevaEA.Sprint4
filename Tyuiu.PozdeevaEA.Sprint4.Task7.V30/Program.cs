using Tyuiu.PozdeevaEA.Sprint4.Task7.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"684259137159648\". Преобразуйте ее    *");
        Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.               *");
        Console.WriteLine("* элементов в последнем столбце массива.                                  *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int n = 5;
        int m = 3;
        int[,] matrix = new int[n, m];
        string str = "684259137159648";

        int index = 0;

        Console.WriteLine("Массив: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(n, m, str);
        Console.WriteLine("Произведение четных чисел в массиве " + res);

        Console.ReadKey();

    }
}