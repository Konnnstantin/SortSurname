using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1 для сортировки (от А до Я) или 2 для сортировки ( от Я до А) ");
            int number = int.Parse(Console.ReadLine());
            EnterUser enterUser = new EnterUser();
            enterUser.NumberEvent += SortFamily;
            enterUser.EnterNumber(number);
        }
        static void SortFamily(int number)
        {
            var people = new List<string>() { "Петров", "Иванов", "Андреев", "Уткин", "Яковлев" };
            people.Sort();
            if (number == 1)
            {
                foreach (var i in people)
                {
                    Console.WriteLine(i);
                }
            }
            else if (number == 2)
            {
                people.Reverse();
                foreach (var i in people)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
