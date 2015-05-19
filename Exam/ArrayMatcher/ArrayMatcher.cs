using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

class ArrayMatcher
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] elements = input.Split('\\');
        string one = elements[0];
        string two = elements[1];
        string com = elements[2];
        List<string> a = one.Select(x => x.ToString()).ToList();
        List<string> b = two.Select(y => y.ToString()).ToList();
        switch(com)
        { 
            case "join":
            List<string> target = a.Concat(b).ToList();
            List<String> duplicates = target.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
            duplicates.Sort();
            for (int i = 0; i < duplicates.Count; i++)
            {
                Console.Write(duplicates[i]);
            }
            Console.WriteLine();
            break;  
         
            case "right exclude":
            a = a.Except(b).ToList();
            a.Sort();
            for (int i = 0; i < a.Count; i++)
            {
                    Console.Write(a[i]);
            }
            Console.WriteLine();
            break;

            case "left exclude":            
            b = b.Except(a).ToList();
            b.Sort();
            for (int i = 0; i < b.Count; i++)
            {
                Console.Write(b[i]);
            }
            Console.WriteLine();
            break;
        }
    }
}

