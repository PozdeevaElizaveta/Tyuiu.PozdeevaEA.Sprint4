using Tyuiu.PozdeevaEA.Sprint4.Task0.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
        Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
        Console.WriteLine("* нечетных элементов массива. {8, 9, 4, 1, 2, 3, 4, 5, 6 ,7}              *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
        int res = ds.GetMultOddArrEl(array);

        Console.WriteLine("Исходный массив { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 }");


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Произведение нечетных элементов массива " + res);

        Console.ReadKey();
    }
}