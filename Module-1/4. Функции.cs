using System;

namespace CSharp_tasks
{
    class Program
    {
        static void Main(string[] args) // Точка входа
        {
            int digit1 = 0, digit2 = 0;

            digit1 = ReadInt32("Enter first digit: ");  // Ввод 1-го числа
            digit2 = ReadInt32("Enter second digit: "); // Ввод 2-го числа

            int max = GetMax(digit1, digit2); // Максимальное из digit1 и digit2
            int min = GetMin(digit1, digit2); // Минимальное из digit1 и digit2

            if (max == min)
            {
                Console.WriteLine($"{digit1} equals {digit2}");
            }
            else
            {
                Console.WriteLine($"Max value is {max}, min value is {min}");
            }
        }

        static int ReadInt32(string message) // Консольный ввод, число
        {
            string inputStr = ""; // Хранилище для консольного ввода

            Console.Write(message);         // Приглашение на ввод
            inputStr = Console.ReadLine();  // Ввод

            return Int32.Parse(inputStr); // Преобразование string в int
        }

        static int GetMax(int a, int b) // Максимальное из двух чисел
        {
            if (a > b)
                return a;

            return b;
        }

        static int GetMin(int a, int b) // Минимальное из двух чисел
        {
            if (a < b)
                return a;

            return b;
        }
    }
} // namespace CSharp_tasks
