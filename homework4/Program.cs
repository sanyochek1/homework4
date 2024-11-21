using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("№1");
        /*Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива,
которые нужно поменять местами. Вывести на экран получившийся массив.*/



        Random random = new Random();
        int[] numbers = new int[20];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(numbers);

        Console.WriteLine("Введите два числа из массива, которые нужно поменять местами:");

        int firstNumber;
        int secondNumber;

        while (true)
        {
            Console.Write("Первое число: ");
            if (int.TryParse(Console.ReadLine(), out firstNumber) && Contains(numbers, firstNumber))
                break;
            Console.WriteLine("Число не найдено в массиве. Попробуйте снова.");
        }

        while (true)
        {
            Console.Write("Второе число: ");
            if (int.TryParse(Console.ReadLine(), out secondNumber) && Contains(numbers, secondNumber))
                break;
            Console.WriteLine("Число не найдено в массиве. Попробуйте снова.");
        }

        int index1 = Array.IndexOf(numbers, firstNumber);
        int index2 = Array.IndexOf(numbers, secondNumber);

        numbers[index1] = secondNumber;
        numbers[index2] = firstNumber;

        Console.WriteLine("Массив после обмена:");
        PrintArray(numbers);
    }

    static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static bool Contains(int[] array, int number)
    {
        foreach (int element in array)
        {
            if (element == number)
                return true;
        }
        return false;
    }
}