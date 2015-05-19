using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class wand
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string top = new string('.', ((3*n+1) / 2));
        Console.WriteLine("{0}*{0}", top);
        string house = new string('.', n);
        for(int i=0; i< (n+1)/2; i++)
        {
            string roof = new string('.', (3 * n + 1) / 2 - 1 - i);
            string fill = new string('.', 1 + 2 * i);
            Console.WriteLine("{0}*{1}*{0}", roof, fill);
        }
        string a = new string('*', n);
        string dots = new string('.', n + 2);
        Console.WriteLine("{0}{1}{0}", a, dots);
        for (int i = 0; i < n / 2; i++)
        {
            string roof = new string('.', 1+i);
            string fill = new string('.', 3*n-2*(1+i));
            Console.WriteLine("{0}*{1}*{0}", roof, fill);
        }
        int mizeriq = 0;
        for (int i = (n-1)/ 2; i > 0; i--) 
        {       
                string roof = new string('.', i - 1);
                string fill = new string('.', n / 2);
                string filla = new string('.', mizeriq);                
                Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", roof, fill, filla, house);
                mizeriq += 1;
        }
        string aster = new string('*', (n + 1) / 2);
        string miz = new string('.', n / 2);
        Console.WriteLine("{0}{1}*{2}*{1}{0}",aster,miz,house);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{0}*{0}",house);
        }
        string floor = new string('*', n + 2);
        Console.WriteLine("{0}{1}{0}",house,floor);

    }
}

