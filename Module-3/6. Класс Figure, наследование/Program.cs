using System;

namespace CSharp_tasks
{
    class Program
    {
        static void Main(string[] args) // Точка входа
        {
            Console.SetWindowSize(40, 30); // Установка размера для окна
            Console.SetBufferSize(40, 30); // Установка размера для буфера

            Figure[] figures = new Figure[2];
            figures[0] = new Square(2, 5, '#');
            figures[1] = new Stick(7, 4, '#');

            foreach(Figure figure in figures)
            {
                figure.Draw();
            }

            Console.ReadLine();
        }
    }
} // namespace CSharp_tasks
