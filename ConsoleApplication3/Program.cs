using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите, пожалуйста ФИО: ");
            string fullName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Приветствую тебя, " + fullName);

            Console.Write("Хотите перейти к следующему заданию(да/нет): ");
            string answer = Console.ReadLine();
            if (answer == "да")
            {
                Console.Clear();
                Console.WriteLine("Вводите числа через Enter: ");
                int x;
                List<int> l = new List<int>();
                while (Int32.TryParse(Console.ReadLine(), out x))
                {
                    l.Add(x);
                }
                Console.WriteLine(l.Sum());
            }
            else
            {
            }
        }
    }
}
