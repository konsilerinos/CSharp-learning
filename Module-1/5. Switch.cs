using System;

namespace CSharp_tasks
{
    class Program
    {
        static void Main(string[] args) // Точка входа
        {
            int digit1 = 0, digit2 = 0; // Числа
            string command = "";        // Операция над числами

            digit1 = ReadInt32("Enter first digit: ");  // Ввод 1-го числа
            digit2 = ReadInt32("Enter second digit: "); // Ввод 2-го числа

            Console.Write("Enter operation (+, -, *, /, //, %, max, min): ");   // Приглашение на ввод операции
            command = Console.ReadLine();                                       // Ввод

            double result = Calculator(digit1, digit2, command);            // Вычисление результата
            Console.WriteLine($"{digit1} {command} {digit2} = {result}");   // Вывод результата на экран
        }

        static double Calculator(int a, int b, string command) // Калькулятор
        {
            switch(command)
            {
                case "+": return a + b;
                case "-": return a - b;
                case "*": return a * b;
                case "/": return (double)a / b;
                case "//": return a / b;
                case "%": return a % b;
                case "max": return GetMax(a, b);
                case "min": return GetMin(a, b);
                default: return 0;
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
