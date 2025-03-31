using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество чисел Фибоначчи для вывода: ");
        int count = int.Parse(Console.ReadLine());

        if (count <= 0)
        {
            Console.WriteLine("Количество должно быть положительным");
            return;
        }

        long[] num = new long[count];

        // Инициализация первых двух чисел Фибоначчи
        if (count > 0) num[0] = 0;
        if (count > 1) num[1] = 1;

        // Заполнение массива числами Фибоначчи
        for (int i = 2; i < count; i++)
        {
            num[i] = num[i - 1] + num[i - 2];
        }

        Console.WriteLine("Числа Фибоначчи:");

        // Вывод чисел Фибоначчи
        for (int i = 0; i < count; i++)
        {
            Console.Write(num[i] + " ");
        }
    }
}
