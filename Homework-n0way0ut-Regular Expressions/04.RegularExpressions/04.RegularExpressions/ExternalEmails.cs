using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

class MailExtracter
{
    static void Main()
    {
        string input = Console.ReadLine();
        Regex emailRegex = new Regex(@"(?<![._\w+-])(?<user>\w+([-+.]\w+)*)@(?<host>\w+([-.]\w+)*\.\w+([-.]\w+)*)", RegexOptions.IgnoreCase);
        MatchCollection emailMatches = emailRegex.Matches(input);
        StringBuilder sb = new StringBuilder();
        foreach (Match emailMatch in emailMatches)
        {
            sb.AppendLine(emailMatch.Value);
        }
        Console.WriteLine(sb.ToString());
    }
}
