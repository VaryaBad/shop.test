using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    class Program
    {
        static void Main( string[] args ) 
        {
            int balance = 1000;
            balance = UpdateBalance(balance);
            ShowBalance(balance);
        }


        static int UpdateBalance(int balance)
        {
            int price = Convert.ToInt32(Console.ReadLine());
            int weight = Convert.ToInt32(Console.ReadLine());
            int c = (price * weight);
            balance += c;
            return balance;
        }
        static void ShowBalance( int balance)
        {
            Console.WriteLine("Итоговый баланс равен: " + balance);
        }

    }
 
}
