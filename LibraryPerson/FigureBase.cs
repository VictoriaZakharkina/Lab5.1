using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Library
{
    /// <summary>
    /// Класс FigureBase
    /// </summary>
    [XmlInclude(typeof(Sphere))]
    [XmlInclude(typeof(Parallelepiped))]
    [XmlInclude(typeof(Pyramid))]
    public abstract class FigureBase
    {
        /// <summary>
        /// Вид фигуры
        /// </summary>
        [DisplayName("Вид")]
        public abstract string TypeFigure { get; }

        /// <summary>
        /// Параметры
        /// </summary>
        [DisplayName("Параметры")]
        public abstract string Parameters { get; }

        /// <summary>
        /// Объем фигуры
        /// </summary>
        [DisplayName("Объем, см^3")]
        public abstract double Volume { get; }

        /// <summary>
        /// Проверка введенного значения
        /// </summary>
        /// <param name="number">Введенное число</param>
        /// <returns>Число</returns>
        /// <exception cref="ArgumentException">Некорректный ввод</exception>
        protected static double CheckNumber(double number)
        {
            if (number <= 0 || double.IsNaN(number))
            {
                throw new ArgumentException("Число должно быть положительным!");
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
            if (number <= 0 || number >= 180 || double.IsNaN(number))
            {
                throw new ArgumentException("Угол должен быть от 0 до 180 град");
            }
            else
            {
                return number;
            }
        }
    }
}
