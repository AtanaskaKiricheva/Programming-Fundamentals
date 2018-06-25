using System;
using System.Text.RegularExpressions;

class MemoryView
{
    static void Main()
    {
        string input = Console.ReadLine();
        string result = string.Empty;
        while (input != "Visual Studio crash")
        {
            result += input + " ";
            input = Console.ReadLine();
        }
        string pattern = @"32656 19759 32763 0 (\d+) 0"; // find length
        Match match = Regex.Match(result, pattern);
        while (match.Success)
        {
            int width = int.Parse(match.Groups[1].Value);
            string innerPattern = "32656 19759 32763 0 " + width + " 0 ((\\d+ ){" + width + "})"; //find word
            Match innerMatch = Regex.Match(result, innerPattern);
            string currentMatch = innerMatch.Groups[0].Value;
            string word = ReadWord(innerMatch.Groups[1].Value);
            Console.WriteLine(word);
            result = result.Replace(currentMatch, ""); //remove the already processed match from the whole text
            match = match.NextMatch();
        }
    }

    static string ReadWord(string text) // convert int to char
    {
        string word = "";
        string[] token = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string letter in token)
        {
            word += (char)(int.Parse(letter));
        }
        return word;
    }
}