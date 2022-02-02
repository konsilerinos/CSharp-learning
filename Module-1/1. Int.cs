using System;

// Операции над целыми числами

namespace CSharp_tasks
{
    class Program
    {
        static void Main(string[] args) // Точка входа
        {
            Console.Write("Enter first digit: "); // Вывод строки в консоль

            string str1 = Console.ReadLine(); // Сохранение ввода в str2
            int digit1 = Int32.Parse(str1);   // Преобразование string в int

            Console.Write("Enter second digit: "); // Вывод строки в консоль

            string str2 = Console.ReadLine(); // Сохранение ввода в str2
            int digit2 = Int32.Parse(str2);   // Преобразование string в int

            // Вывод строк в консоль
            Console.WriteLine($"{digit1} + {digit2} = {digit1 + digit2}"); // Сумма 
            Console.WriteLine($"{digit1} - {digit2} = {digit1 - digit2}"); // Разность
            Console.WriteLine($"{digit1} * {digit2} = {digit1 * digit2}"); // Произведение
            Console.WriteLine($"{digit1} / {digit2} = {digit1 / digit2}"); // Отношение
            Console.WriteLine($"{digit1} % {digit2} = {digit1 % digit2}"); // Остаток от деления
        }
    }
}
