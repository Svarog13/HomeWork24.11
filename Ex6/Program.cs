using System;
class Program
{
    static void Main(string[] args)
    {
        Func<string, string, bool> containsWord = (text, word) =>
                text.Split(new[] { ' ', ',', '.', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                    .Any(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase));

        string inputText = "This is an example text for testing the lambda expression.";
        string searchWord = "example";

        bool result = containsWord(inputText, searchWord);
        Console.WriteLine($"The text does {(!result ? "not " : "")}contain the word '{searchWord}'.");
    }

}

