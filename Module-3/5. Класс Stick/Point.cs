using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_tasks
{
    public class Point
    {
        public int x;
        public int y;
        public char c;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);    // Установка курсора по координатам
            Console.Write(c);                   // Печать символа
        }

        public Point(int a, int b, char sym)
        {
            x = a;
            y = b;
            c = sym;
        }
        public Point()
        {
            x = 0;
            y = 0;
            c = '-';
        }
    }
}
