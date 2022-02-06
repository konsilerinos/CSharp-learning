using System;

namespace CSharp_tasks
{
    class Program
    {
        static void Main(string[] args) // Точка входа
        {
            Console.SetWindowSize(40, 30); // Установка размера для окна
            Console.SetBufferSize(40, 30); // Установка размера для буфера

            Point p1 = new Point
            {
                x = 2,
                y = 5,
                c = '*'
            };

            p1.Draw();

            Console.ReadLine();
        }
    }
} // namespace CSharp_tasks
