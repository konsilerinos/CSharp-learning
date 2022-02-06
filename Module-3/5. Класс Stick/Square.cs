using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_tasks
{
    class Square
    {
        private int x;          // Абсцисса
        private int y;          // Ордината
        private char symbol;    // Символ заполнения

        private Point[] figure = new Point[4];  // Фигура

        public Square(int newX, int newY, char newSymbol)
        {
            x = newX; // Сохранение абсциссы
            y = newY; // Сохранение ординаты

            symbol = newSymbol; // Сохранение символа заполнения

            CreateSquare(); // Инициализация фигуры
        }

        public void Draw()
        {
            foreach(Point point in figure)
            {
                point.Draw();
            }
        }

        private void CreateSquare()
        {
            figure[0] = new Point(x, y, symbol);
            figure[1] = new Point(x + 1, y, symbol);
            figure[2] = new Point(x, y + 1, symbol);
            figure[3] = new Point(x + 1, y + 1, symbol);
        }
    }
}
