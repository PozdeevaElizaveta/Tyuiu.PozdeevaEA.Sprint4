using Tyuiu.PozdeevaEA.Sprint4.Task1.V24.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов заполненный         *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 5 подсчитать произведение   *");
        Console.WriteLine("* нечетных элементов массива.                                             *");
        Console.WriteLine("* С клавиатуры: 2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5, 3, 4, 3, 5, 2            *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] array = new int[16];
        Console.WriteLine("Введите 16 целых чисел в диапазоне от 2 до 5:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i}: ");
            int value = int.Parse(Console.ReadLine());

            if (value < 2 || value > 5)
            {
                Console.WriteLine("Ошибка! Число должно быть в диапазоне от 2 до 5");
                i--;
                continue;
            }

            array[i] = value;
        }
        Console.WriteLine();
        Console.WriteLine("Массив: ");
        for (int i = 0; i <= 16 - 1; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(array);
        Console.WriteLine("Произведение нечетных элементов массива " + res);

        Console.ReadKey();
        
    }
}
