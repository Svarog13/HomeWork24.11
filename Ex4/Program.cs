using System;

class Program
{
    static void Main(string[] args)
    {
        Func<int[], int> countPositiveDigit = numbers => numbers.Count(n => n >=0);
        int[] array = { -1, 7, -14, 21, -30, 42, -56, 63, -70, 80 };
        int result = countPositiveDigit(array);

        Console.WriteLine($"Numbers of positive digits in Array: {result}");
    }
}