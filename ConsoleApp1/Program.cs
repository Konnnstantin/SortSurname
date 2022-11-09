using System;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 0-255");
            byte number = byte.Parse(Console.ReadLine());

            Console.WriteLine("Введите два числа для деления");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            try
            {
                int result = a / b;
                Console.WriteLine($" Результат будет равен = {result}");
            }
            catch (DivideByZeroException) when (b == 0)
            {
                Console.WriteLine("Делить на ноль нельзя");
            }
            try
            {
                if (number < 10 || number > 100)
                {
                    throw new Exception("Длина меньше 10 или больше 100");

                }
                else if (number < 0 || number > 255)
                {
                    throw new OverflowException();
                }
                else
                {
                    Console.WriteLine($"{number}");
                }

                int[] NumberArr = new int[3] { 1, 2, 3 };
                for (int i = 0; i < NumberArr.Length; i++)
                {
                    Console.WriteLine("Введите индекс массива который хотите получить");
                    var n = int.Parse(Console.ReadLine());
                    Console.WriteLine(NumberArr[n]);
                }

                Console.WriteLine("Введите слово");
                string world = Console.ReadLine();
                if (world == "")
                {
                    throw new ArgumentException();
                }
                else
                {
                    Console.WriteLine($"Ваше слово {Exper(world)}");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Индекс выходит за пределы");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static string Exper(string world)
        {
            return world;
        }
    }

}


