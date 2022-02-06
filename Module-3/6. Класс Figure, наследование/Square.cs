using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_tasks
{
    class Square : Figure
    {
        public Square(int newX, int newY, char newSymbol)
        {
            x = newX; // Сохранение абсциссы
            y = newY; // Сохранение ординаты

            symbol = newSymbol; // Сохранение символа заполнения

            CreateSquare(); // Инициализация фигуры
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
