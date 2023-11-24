using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Action<int[]> displayUniqueNegatives = numbers =>
        {
            var uniqueNegatives = numbers.Where(n => n < 0).Distinct();
            Console.WriteLine("Unique,negative digits in array:");
            foreach (var num in uniqueNegatives)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        };
        int[] array = { -2, 5, -10, -2, 7, -5, -10, -3, -5, -2 };
        displayUniqueNegatives(array);
    }
}