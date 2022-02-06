using System;

namespace CSharp_tasks
{
    class Program
    {
        static void Main(string[] args) // Точка входа
        {
            Console.SetWindowSize(40, 30); // Установка размера для окна
            Console.SetBufferSize(40, 30); // Установка размера для буфера

            Point p1 = new Point(1, 2, '*');
            Point p2 = new Point();

            p1.Draw();
            p2.Draw();

            Console.ReadLine();
        }
    }
} // namespace CSharp_tasks
