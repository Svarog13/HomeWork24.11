using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        Func<Color, Tuple<int, int, int>> getRgbForRainbowColor = delegate (Color rainbowColor)
        {
            return new Tuple<int, int, int>(rainbowColor.R, rainbowColor.G, rainbowColor.B);
        };

        Color rainbowColor = Color.Orange; 

        Tuple<int, int, int> rgbValues = getRgbForRainbowColor(rainbowColor);

        Console.WriteLine($"RGB values for {rainbowColor}: R={rgbValues.Item1}, G={rgbValues.Item2}, B={rgbValues.Item3}");
    }
}