using CSharp_tasks;
using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array1 = new int[10]; // Создание массива

            //// Инициализация и вывод на экран
            //for(int i = 0; i < 10; i++)
            //{
            //    array1[i] = i;
            //    Console.Write($"{array1[i]} ");
            //}
            //Console.WriteLine();

            //// Вывод на экран
            //foreach(int i in array1)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine();

            //Point[] points = new Point[3]; // Массив точек
            //points[0] = new Point(1, 2, '*');
            //points[1] = new Point(3, 4, '#');
            //points[2] = new Point(5, 6, '@');

            //foreach(Point i in points)
            //{
            //    i.Draw();
            //}

            char[][] field = new char[3][];
            field[0] = new char[3];
            field[1] = new char[3];
            field[2] = new char[3];

            for(int i = 0; i < field.Length; i++)
            {
                for(int j = 0; j < field[i].Length; j++)
                {
                    field[i][j] = ' ';
                }
            }

            field[0][0] = 'x';
            field[2][2] = '0';

            for (int i = 0; i < field.Length; i++)
            {
                for(int j = 0; j < field[i].Length; j++)
                {
                    Console.Write(field[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
