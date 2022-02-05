using System;

namespace CSharp_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Конкатенация строк
            string str1 = "Hello, ";    // Первая строка
            string str2 = "World!";     // Вторая строка

            Console.WriteLine($"str1 = {str1}");
            Console.WriteLine($"str2 = {str2}");
            Console.WriteLine($"str1 + str2 = {str1 + str2}"); // Конкатенация

            // 2. Длина строки
            Console.WriteLine($"The size of str1 string is {str1.Length}");

            // 3. Отдельные символы
            char ch1 = 'a';                 // 1 символ
            int ch1Int = (int)ch1;          // Получение кода для 1-го символа
            char ch2 = (char)(ch1Int + 1);  // 2 символ

            Console.WriteLine($"'{ch1}', '{ch2}', ... ");

            // 4. Удаление первого символа из строки
            str2 = str2.Remove(0, 1);
            Console.WriteLine($"Removing the first character from a string: {str2}");

            // 5. Удаление последнего символа из строки
            str2 = str2.Remove(str2.Length - 1, 1);
            Console.WriteLine($"Removing the last character from a string: {str2}");
        }
    }
}
