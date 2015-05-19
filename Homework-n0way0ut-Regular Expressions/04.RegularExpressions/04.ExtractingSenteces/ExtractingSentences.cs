using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

class ExtractingSentences
{
    static void Main()
    {
        string keyword = Console.ReadLine();
        string input = Console.ReadLine();
        string check = string.Format(@"(?<=\s|^)(.*?\b{0}\b.*?(?=\!|\.|\?)[?.!])", keyword);
        Regex sentences = new Regex(check);
        MatchCollection fullSentences = sentences.Matches(input);
        StringBuilder sb = new StringBuilder();
        foreach (Match Match in fullSentences)
        {
            sb.AppendLine(Match.Value);
        }
        Console.WriteLine(sb.ToString());
    }
}