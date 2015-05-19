using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DreamItem
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] elements = input.Split('\\');
        string Month = elements[0];
        decimal mph = decimal.Parse(elements[1]);
        decimal hours = decimal.Parse(elements[2]);
        decimal price = decimal.Parse(elements[3]);
        decimal days = 0;
        switch(Month)
        {
            case "Jan": 
            case "March":
            case "May": 
            case "July": 
            case "Aug":
            case "Oct": 
            case "Dec":
                days = days + 21;
                break;
            case "Feb":
                days = days + 18;
                break;
            case "Apr":
            case "June":
            case "Sept":
            case "Nov":
                days = days + 20;
                break;
        }
        decimal gains = (decimal)days * (decimal)mph * (decimal)hours;
        if (gains > 700)
        {
            gains = (decimal)gains + (decimal)gains / (decimal)10;
        }
        if ((gains - price) > 0)
        {
            Console.WriteLine("Money left = {0:0.00} leva.", Math.Ceiling((gains - price) * 100) / 100);
        }
        else if(gains == price)
        {
            Console.WriteLine("Money left = 0.00 leva.");
        }
                else
        {
            Console.WriteLine("Not enough money. {0:0.00} leva needed.", Math.Ceiling((price - gains) * 100) / 100);
        }
    }
}


