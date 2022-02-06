using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Human
    {
        private int age;     // Возраст
        private int height;  // Рост

        public Human(int newAge, int newHeight)
        {
            age = newAge;       // Сохранение возраста
            height = newHeight; // Сохранение роста
        }

        int GetAge()
        {
            return age;
        }
    }
}
