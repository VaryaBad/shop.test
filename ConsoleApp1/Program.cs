using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args) 
        {
            int balance = (1000);
            int price = Convert.ToInt32 (Console.ReadLine());
            int weight = Convert.ToInt32 (Console.ReadLine());
            int c = (price * weight);
            balance += c;
            Console.WriteLine (balance);
        }
    }
 
}
