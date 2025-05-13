using System;

class Program
{
    static void Main()
    {
        // Исходный массив строк
        string[] input = new string[] { "Hello", "2", "world", ":-)" };

        // Подсчитаем нужное количество строк (длина ≤ 3)
        int count = 0;
        foreach (string str in input)
        {
            if (str.Length <= 3)
                count++;
        }

        // Создаём новый массив нужного размера
        string[] result = new string[count];
        int index = 0;
        foreach (string str in input)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        // Вывод результата
        Console.WriteLine("Результат:");
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    }
}
