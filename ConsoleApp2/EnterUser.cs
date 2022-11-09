using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class EnterUser
    {
        public delegate void NumberDeleagate(int number);
        public event NumberDeleagate NumberEvent;
        public int EnterNumber(int number)
        {
            try
            {
                NumberEvent?.Invoke(number);
                if (number != 1 && number != 2)
                {
                    throw new Exception("Длина не равна 1 или 2");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен не верный формат");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return number;
        }
    }
}
