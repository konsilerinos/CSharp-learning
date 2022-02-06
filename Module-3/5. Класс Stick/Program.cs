using System;

namespace CSharp_tasks
{
    class Program
    {
        static void Main(string[] args) // Точка входа
        {
            Console.SetWindowSize(40, 30); // Установка размера для окна
            Console.SetBufferSize(40, 30); // Установка размера для буфера

            //Square square1 = new Square(1, 7, '#');
            //square1.Draw();

            Stick stick1 = new Stick(0, 0, '#');
            Stick stick2 = new Stick(5, 7, '#');

            stick1.Draw();
            stick2.Draw();

            Console.ReadLine();
        }
    }
} // namespace CSharp_tasks
