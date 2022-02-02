using System;

namespace CSharp_tasks
{
    class Program
    {
        static void Main(string[] args) // Точка входа
        {
            string str = ""; // Хранилище консольного ввода
            int digit1 = 0, digit2 = 0;

            Console.Write("Enter first digit: "); // Приглашение на ввод 1-го числа
            str = Console.ReadLine(); // Сохранение ввода в str
            digit1 = Int32.Parse(str); // Преобразование string в int

            Console.Write("Enter second digit: "); // Приглашение на ввод 2-го числа
            str = Console.ReadLine(); // Сохранение ввода в str
            digit2 = Int32.Parse(str); // Преобразование string в int

            // Сравнение чисел
            if (digit1 > digit2)
            {
                Console.WriteLine($"Max value is {digit1}, min value is {digit2}");
            }
            else if (digit1 == digit2)
            {
                Console.WriteLine($"{digit1} equals {digit2}");
            }
            else
            {
                Console.WriteLine($"Max value is {digit2}, min value is {digit1}");
            }
        }
    }
} // namespace CSharp_tasks
