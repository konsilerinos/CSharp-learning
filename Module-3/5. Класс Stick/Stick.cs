using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_tasks
{
    class Stick
    {
        private int x;          // Абсцисса
        private int y;          // Ордината
        private char symbol;    // Символ заполнения

        private Point[] figure = new Point[4];  // Фигура

        public Stick(int newX, int newY, char newSymbol)
        {
            x = newX; // Сохранение абсциссы
            y = newY; // Сохранение ординаты

            symbol = newSymbol; // Сохранение символа заполнения

            CreateStick(); // Инициализация фигуры
        }

        public void Draw()
        {
            foreach(Point point in figure)
            {
                point.Draw();
            }
        }

        private void CreateStick()
        {
            figure[0] = new Point(x, y, symbol);
            figure[1] = new Point(x, y + 1, symbol);
            figure[2] = new Point(x, y + 2, symbol);
            figure[3] = new Point(x, y + 3, symbol);
        }
    }
}
