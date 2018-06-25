using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ex02
{
    static void Main()
    {
        string input = Console.ReadLine();

        string text = "";

        while (input != "Visual Studio crash")
        {
            text += input + " ";
            input = Console.ReadLine();
        }

        string[] words = text.Split(' ');
        for (int i = 0; i < words.Length; i++) // every string from the array
        {
            if (words[i] == "32656" && words[i + 1] == "19759" && words[i + 2] == "32763") // check for code
            {
                int length = int.Parse(words[i + 4]);
                string word = "";
                for (int j = 0; j < length; j++) // every other string from the array after checking for code
                {
                    word += Convert.ToChar(int.Parse(words[i+6+j]));
                }
                Console.WriteLine(word);
                word = "";
            }
        }

    }
}