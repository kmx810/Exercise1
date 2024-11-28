class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(numbers);
        Console.WriteLine($"Średnia: {average}");
    }

    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta.");
        }

        double sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Length;
    }
}