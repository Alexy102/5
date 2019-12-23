using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int symm = 0;
            Console.WriteLine("Введите число:");
            int x = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i<x;i++)
            {
                if(x%i==0)
                {
                    symm += i; 
                }
            }
            if(x==symm)
            {
                Console.WriteLine("Совершенно!");
            }
            else
            {
                Console.WriteLine("Не Совершенно!");
            }
        }
    }
}
