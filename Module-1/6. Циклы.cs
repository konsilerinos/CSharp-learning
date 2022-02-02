using System;

namespace CSharp_tasks
{
    class Program
    {
        static void Main(string[] args) // Точка входа
        {
            int digit1 = 0, digit2 = 0; // Числа
            string command = "";        // Операция над числами

            do
            {
                digit1 = ReadInt32("Enter first digit: ");  // Ввод 1-го числа
                digit2 = ReadInt32("Enter second digit: "); // Ввод 2-го числа

                Console.Write("Enter operation (+, -, *, /, //, %, max, min): ");   // Приглашение на ввод операции
                command = Console.ReadLine();                                       // Ввод

                double result = Calculator(digit1, digit2, command);            // Вычисление результата
                Console.WriteLine($"{digit1} {command} {digit2} = {result}");   // Вывод результата на экран
            }
            while (AskContinue());
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

        static bool AskContinue() // Продолжение работы калькулятора
        {
            string command = ""; // Хранилище для консольного ввода
            
            while(true)
            {
                Console.Write("Would you like to continue? Y/N: "); // Приглашение на ввод
                command = Console.ReadLine();                       // Ввод

                if ((command == "N") || (command == "n"))
                {
                    Console.WriteLine("Break, ok");
                    return false; // Завершение работы
                }
                else if ((command == "Y") || (command == "y"))
                {
                    Console.WriteLine("Continue, ok");
                    return true; // Продолжение работы
                }
                else
                {
                    Console.WriteLine("Unknown value, try it again");
                }
            }
        }

        static int ReadInt32(string message) // Консольный ввод, число
        {
            string inputStr = "";   // Хранилище для консольного ввода
            int result = 0;         // Ввод в формате Int32

            while (true)
            {
                Console.Write(message);         // Приглашение на ввод
                inputStr = Console.ReadLine();  // Ввод

                // Попытка преобразования string в int
                if (Int32.TryParse(inputStr, out result))
                {
                    break; // Успех
                }

                Console.WriteLine("Error! Try it again"); // Неудача
            }
            
            return result; // Ввод в формате Int32
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
