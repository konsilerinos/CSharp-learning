using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_tasks
{
    class Stick : Figure
    {
        public Stick(int newX, int newY, char newSymbol)
        {
            x = newX; // Сохранение абсциссы
            y = newY; // Сохранение ординаты

            symbol = newSymbol; // Сохранение символа заполнения

            CreateStick(); // Инициализация фигуры
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
