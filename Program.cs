using System;

enum DaysOfWeek
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        // Задание 1: 
        int[] array = new int[10];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 11); 
        }

        Console.WriteLine("Элементы массива с четным индексом:");
        for (int i = 0; i < array.Length; i += 2) 
        {
            Console.WriteLine($"array[{i}] = {array[i]}");
        }

        // Задание 2:
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        Console.WriteLine("\nСумма элементов массива: " + sum);
        if (sum >= 0)
        {
            Console.WriteLine("Сумма элементов массива является неотрицательным числом.");
        }
        else
        {
            Console.WriteLine("Сумма элементов массива является отрицательным числом.");
        }

        // Задание 3:
        int[,] multiplicationTable = new int[9, 9];

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                multiplicationTable[i, j] = (i + 1) * (j + 1);
            }
        }

        Console.WriteLine("\nТаблица умножения:");
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write($"{multiplicationTable[i, j],3} ");
            }
            Console.WriteLine();
        }

        // Задание 4:
        int[,] array5x5 = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array5x5[i, j] = random.Next(-10, 11);
            }
        }

        int max = array5x5[0, 0];
        int min = array5x5[0, 0];
        int minRow = 0, minCol = 0;
        int maxRow = 0, maxCol = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array5x5[i, j] > max)
                {
                    max = array5x5[i, j];
                    maxRow = i;
                    maxCol = j;
                }
                if (array5x5[i, j] < min)
                {
                    min = array5x5[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        Console.WriteLine("\nДвумерный массив 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{array5x5[i, j],3} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Максимальный элемент: {max} с координатами ({maxRow}, {maxCol})");
        Console.WriteLine($"Минимальный элемент: {min} с координатами ({minRow}, {minCol})");

        // Задание 5:
        Console.Write("\nВведите количество дней: ");
        int days = int.Parse(Console.ReadLine());

        int dayOfWeekNumber = (days % 7) + 1;
        DaysOfWeek resultDay = (DaysOfWeek)dayOfWeekNumber;

        Console.WriteLine($"Через {days} дней будет: {resultDay}");
    }
}
