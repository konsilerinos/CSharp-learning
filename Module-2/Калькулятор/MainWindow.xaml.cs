using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string digitStr1 = "", digitStr2 = "";  // Операнды
        private string command = "";                    // Команда

        public MainWindow()
        {
            InitializeComponent();
        }

        private double GetAverageValue(double x, double y)
        {
            return (x + y) / 2; // Среднее значение
        }

        private void ButtonActionClicked(object sender, RoutedEventArgs e)
        {
            command = ((Button)sender).Content.ToString(); // Сохранение текста кнопки в переменную command
        }

        private void ButtonNumClicked(object sender, RoutedEventArgs e)
        {
            string digit = ((Button)sender).Content.ToString(); // Содержимое нажатой кнопки

            // Либо команда ещё не введена, либо предыдущая команда - результат
            // Сохранение в первый операнд
            if ((command == "") || (command == "equal"))
            {
                // Текстовое поле пустое
                if (resultTextBox.Text == "0")
                {
                    resultTextBox.Text = digit; // Запись числа в текстовое поле
                }
                // Предыдущая команда - результат
                else if (command == "equal")
                {
                    resultTextBox.Text = digit; // Запись числа в текстовое поле
                    command = "";
                }
                else
                {
                    resultTextBox.Text += digit; // Дозапись числа в текстовое поле
                }
                digitStr1 = resultTextBox.Text; // Обновление digitStr1
            }
            // Команда есть - сохранение во второй операнд
            else
            {
                // Текстовое поле пустое
                if (digitStr2 == "")
                {
                    resultTextBox.Text = digit; // Запись числа в текстовое поле
                }
                else
                {
                    resultTextBox.Text += digit; // Дозапись числа в текстовое поле
                }
                digitStr2 = resultTextBox.Text; // Обновление digitStr2
            }
        }

        private void ButtonCEClicked(object sender, RoutedEventArgs e)
        {
            // Обнуление текущего операнда, но не команды
            if (command == "")
            {
                digitStr1 = "";
            }
            else
            {
                digitStr2 = "";
            }

            resultTextBox.Text = "0";
        }

        private void ButtonCClicked(object sender, RoutedEventArgs e)
        {
            // Обнуление операндов и команды
            digitStr1 = "";
            digitStr2 = "";
            command = "";
            resultTextBox.Text = "0";
        }

        private void ButtonDeleteClicked(object sender, RoutedEventArgs e)
        {
            // Предыдущая команда - результат
            if (command == "equal")
            {
                return;
            }

            // Удаление символа с конца
            resultTextBox.Text = DropLastChar(resultTextBox.Text);

            // Команда отсутствует, работа с первым операндом
            if (command == "")
            {
                digitStr1 = resultTextBox.Text; // Сохранение результата в первый операнд
            }
            // Команда есть, работа со вторым операндом
            else
            {
                digitStr2 = resultTextBox.Text; // Сохранение результата во второй операнд
            }
        }

        private string DropLastChar(string text)
        {
            // Обнуление строки, если состоит из одного символа
            if (text.Length == 1)
            {
                text = "0";
            }
            // Удаление последнего символа
            else
            {
                text = text.Remove(text.Length - 1, 1);

                // Удалить ещё один в случае, если последний символ - запятая
                if (text[^1] == ',')  
                {
                    text = text.Remove(text.Length - 1, 1);
                }
            }

            return text;
        }

        private void PMButtonClicked(object sender, RoutedEventArgs e)
        {
            // digitStr2 = "", работа с первым операндом
            if (digitStr2 == "")
            {
                // Первый операнд не введён
                if (digitStr1 == "")
                {
                    return;
                }

                // Смена знака для digitStr1
                digitStr1 = digitStr1[0] == '-' ? digitStr1.Remove(0, 1) : "-" + digitStr1;
                resultTextBox.Text = digitStr1;
            }
            else
            {
                // Смена знака для digitStr2
                digitStr2 = digitStr2[0] == '-' ? digitStr2.Remove(0, 1) : "-" + digitStr2;
                resultTextBox.Text = digitStr2;
            }
        }

        private void PointButtonClicked(object sender, RoutedEventArgs e)
        {
            // Команда не введена, работа с первым операндом
            if (command == "")
            {
                SetPoint(digitStr1); // Установка точки для digitStr1
            }
            // Команда введена, работа со вторым операндом
            else
            {
                SetPoint(digitStr2); // Установка точки для digitStr2
            }
        }

        private void SetPoint(string digit)
        {
            // Проверка: запятая уже нажата
            if (resultTextBox.Text.Contains(','))
            {
                return;
            }

            resultTextBox.Text += ","; // Добавление запятой
        }

        private void ButtonEqualClicked(object sender, RoutedEventArgs e)
        {
            double result = 0; // Результат выполнения операции над операндами

            // Остановка, если один из операндов не введён
            if ((digitStr1 == "") || (digitStr2 == "")) 
            {
                return;
            }

            // Конвертирование string в double
            double digit1 = double.Parse(digitStr1); // digitStr1 в digit1
            double digit2 = double.Parse(digitStr2); // digitStr2 в digit2

            result = command switch
            {
                "+" => digit1 + digit2,                     // Сумма
                "-" => digit1 - digit2,                     // Разность
                "*" => digit1 * digit2,                     // Произведение
                "/" => digit1 / digit2,                     // Отношение
                "max" => Math.Min(digit1, digit2),          // Максимальное значение
                "min" => Math.Max(digit1, digit2),          // Минимальное значение
                "avg" => GetAverageValue(digit1, digit2),   // Среднее значение
                "x^y" => Math.Pow(digit1, digit2),          // Степень
                _ => digit1,                                // Команда отсутствует, сохранить первый операнд
            };

            resultTextBox.Text = result.ToString(); // Сохранение результата в resultTextBox
            command = "equal";                      // Обнуление команды
            digit1 = result;                        // Сохранение результата в digit1 - первый операнд

            digitStr1 = digit1.ToString();  // Сохранение результата в первый операнд
            digitStr2 = "";                 // Обнуление второго операнда
        }
    }
}
