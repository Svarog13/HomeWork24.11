using System;

class Program
{
    static void Main(string[] args)
    {
        Func<int[], int> countMultiplesOfSeven = numbers => numbers.Count(n => n % 7 == 0);
        int[] array = { 1, 7, 14, 21, 30, 42, 56, 63, 70, 80 };
        int result = countMultiplesOfSeven(array);

        Console.WriteLine($"Numbers of digit in array, multiples 7: {result}");
    }
}