using Tyuiu.PozdeevaEA.Sprint4.Task6.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных [\"Россия\", \"Украина\", \"Беларусь\",           *");
        Console.WriteLine("* \"Казахстан\", \"Молдова\", \"Латвия\", \"Эстония\"], используя класс           *");
        Console.WriteLine("* Array, выведите элементы массива, длина которых равна 7 символам.       *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        var month = new string[] { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };

        Console.WriteLine("Исходный мacссив: ");
        for (int i = 0; i <= (month.Length-1); i++)
        {
            Console.WriteLine(month[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string[] eq7 = ds.Calculate(month);
        Console.WriteLine("Количество элементов массива длина которых = 7:");
        for (int i = 0; i <= (eq7.Length - 1); i++)
        {
            Console.WriteLine(eq7[i]);
        }

        Console.ReadKey();
    }
}