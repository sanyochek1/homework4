using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("№1");
        /*Написать метод, возвращающий наибольшее из двух чисел. Входные
параметры метода – два целых числа. Протестировать метод.*/


        Console.WriteLine("Тест 1: Наибольшее из 78 и 93: " + Max(78, 93));
        Console.WriteLine("Тест 2: Наибольшее из -658 и -722: " + Max(-658, -722));
        Console.WriteLine("Тест 3: Наибольшее из 1000 и 1000: " + Max(1000, 1000));
        Console.WriteLine("Тест 4: Наибольшее из 0 и 17: " + Max(0, 17));
    }

    static int Max(int a, int b)
    {
        return (a > b) ? a : b;
    }
}
