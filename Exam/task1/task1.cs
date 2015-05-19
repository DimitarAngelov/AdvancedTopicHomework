using System;


class task1
{
    static void Main()
    {
        uint r = uint.Parse(Console.ReadLine());
        uint d = uint.Parse(Console.ReadLine());
        uint e = uint.Parse(Console.ReadLine());
        uint b = uint.Parse(Console.ReadLine());
        uint mleva = uint.Parse(Console.ReadLine());
        double rleva = r * 3.5/100;
        double dleva = 1.5 * d;
        double eleva = 1.95 * e;
        double bleva = (double)b / 2;
        double m = mleva;
        if(rleva<dleva && rleva<eleva && rleva<bleva && rleva<m)
        {
            Console.WriteLine("{0:0.00}",rleva);
        }
        else if (dleva < rleva && dleva < eleva && dleva < bleva && dleva < m)
        {
            Console.WriteLine("{0:0.00}", dleva);
        }
        else if (eleva < dleva && eleva < rleva && eleva < bleva && eleva < m)
        {
            Console.WriteLine("{0:0.00}", eleva);
        }
        else if (bleva < dleva && bleva < eleva && bleva < rleva && bleva < m)
        {
            Console.WriteLine("{0:0.00}", bleva);
        }
        else if (m < dleva && m < eleva && m < rleva && m < bleva)
        {
            Console.WriteLine("{0:0.00}", m);
        }
    }
}

//Jan\9.234\6\2000