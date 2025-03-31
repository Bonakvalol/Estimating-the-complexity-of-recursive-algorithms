using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string ss = Console.ReadLine();

        string cleane = ss.Replace(" ", "").ToLower();

        bool pp = Palindrom(cleane);

        if (pp)
        {
            Console.WriteLine("Строка является палиндромом");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом");
        }
    }

    static bool Palindrom(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;  
            }
            left++;
            right--;
        }

        return true;  
    }
}
