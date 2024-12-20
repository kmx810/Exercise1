﻿class Program
{
    static void Main(string[] args)
    {
        int[] numbersAverage = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(numbersAverage);
        Console.WriteLine($"Średnia: {average}");
        
        int[] numbersMax = { 3, 7, 1, 8, 5 };
        int maxValue = FindMaxValue(numbersMax);
        Console.WriteLine($"Maksymalna wartość: {maxValue}");
    }

    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta.");
        }

        double sum1 = 0;
        foreach (int number in numbers)
        {
            sum1 += number;
        }

        return sum1 / numbers.Length;
    }

    public static int FindMaxValue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta.");
        }

        int max = numbers[0]; // Przyjmujemy pierwszy element jako początkowe maksimum
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number; // Aktualizujemy maksymalną wartość
            }
        }

        return max;
    }
}
