using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountSubstringOccurances
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string subtext = Console.ReadLine().ToLower();
        int count = 0;
        int index = text.IndexOf(subtext);
        do
        {
            count++;
            int newIndex = text.IndexOf(subtext, index + 1);
            index = newIndex;
        }
        while (index > 0);
        Console.WriteLine(count);
    }
}

