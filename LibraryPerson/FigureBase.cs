using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Класс FigureBase
    /// </summary>
    public abstract class FigureBase
    {
        /// <summary>
        /// Объем фигуры
        /// </summary>
        public abstract double Volume();

        /// <summary>
        /// Проверка введенного значения
        /// </summary>
        /// <param name="number">Введенное число</param>
        /// <returns>Число</returns>
        /// <exception cref="ArgumentException">Некорректный ввод</exception>
        protected static double CheckNumber(double number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Число должно быть положительным");
            }
            else
            {
                return number;
            }
        }
        /// <summary>
        /// Проверка введенного значения
        /// </summary>
        /// <param name="number">Введенное число</param>
        /// <returns>Число</returns>
        /// <exception cref="ArgumentException">Некорректный ввод</exception>
        protected static double CheckNumberAngle(double number)
        {
            if (number <= 0 || number >= 180)
            {
                throw new ArgumentException("Угол должен быть от 0 до 180");
            }
            else
            {
                return number;
            }
        }
    }
}
