using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        foreach (char c in input)
        {
            Unicode(c);
        }
    }
    static string Unicode(char c)
    {
        Console.Write("\\" + ((int)c).ToString("X4"));
        return c.ToString();
    }
}

