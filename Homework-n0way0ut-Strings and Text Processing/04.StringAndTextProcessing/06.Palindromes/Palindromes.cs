using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Palindromes
{

    static void Main()
    {
        string input = Console.ReadLine();
        string[] text = input.Split(new[] { ' ', ',', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);
        string result = string.Empty;
        foreach (string value in text)
        {
            if (IsPalindrome(value) == true)
            {
                Console.WriteLine(value);
            }
        }
    }
    static bool IsPalindrome(string value)
    {
        int min = 0;
        int max = value.Length - 1;
        while (true)
        {
            if (min > max)
            {
                return true;
            }
            char a = value[min];
            char b = value[max];
            if (a != b)
            {
                return false;
            }
            min++;
            max--;
        }
    }
}