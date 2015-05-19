using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TextFiller
{
    static void Main()
    {
        string banList = Console.ReadLine();
        string[] ban = banList.Split(new[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();
        for (int i = 0; i < ban.Length; i++ )
        { 
            string newText = text.Replace(ban[i].ToString(), new string('*', ban[i].ToString().Length));
            text = newText;
        }
        Console.WriteLine(text);
    }
}


