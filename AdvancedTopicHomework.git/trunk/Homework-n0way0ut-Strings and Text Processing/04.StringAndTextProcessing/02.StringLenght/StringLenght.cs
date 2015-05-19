using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLenght
{
    static void Main()
    {
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            if(i>=20)
            {
                break;
            }
            Console.Write(input[i]);
        }
        if (input.Length < 20)
        {
            string fill = new string('*', 20 - input.Length);
            Console.Write(fill);
        }
    }
}

