using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        int lostGamesCount = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        double headsets = (lostGamesCount / 2);
        double mouses = (lostGamesCount / 3);
        double keyboards = (lostGamesCount / 3 / 2);
        double displays = Math.Floor(keyboards / 2);

        double expenses = headsets*headsetPrice+mouses*mousePrice+keyboards*keyboardPrice+displays*displayPrice;

        Console.WriteLine($"Rage expenses: {expenses:f2} lv.");

    }
}