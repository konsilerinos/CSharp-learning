using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_tasks
{
    class Figure
    {
        protected int x; // Абсцисса
        protected int y; // Ордината

        protected char symbol;                    // Символ заполнения
        protected Point[] figure = new Point[4];  // Фигура

        public void Draw()
        {
            foreach (Point point in figure)
            {
                point.Draw();
            }
        }
    }
}
