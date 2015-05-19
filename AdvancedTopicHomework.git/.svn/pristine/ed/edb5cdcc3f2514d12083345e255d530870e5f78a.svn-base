using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();

            for (int i = 97; i < 123; i++)
            {
                char ch = (char)i;
                string r = ch.ToString() + "+";
                Regex rgx = new Regex(@r);
                Match match = rgx.Match(input);

                while (match != Match.Empty)
                {
                    input = input.Replace(match.Value, ch.ToString());
                    match = match.NextMatch();
                }
            }
            Console.WriteLine(input);
        }
    }
