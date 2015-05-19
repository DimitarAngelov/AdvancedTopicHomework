using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static void Main()
    {
        string random = Console.ReadLine();
        for (int i = random.Length-1; i >= 0; i--)
        {
            Console.Write(random[i]);
        }
        Console.WriteLine();
    }
}

