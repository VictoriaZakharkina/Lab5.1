using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Класс формирования случайной фигуры
    /// </summary>
    public static class RandomFigure
    {
        /// <summary>
        /// Создание случайных параметров
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Генерация случайного расчета объема
        /// </summary>
        /// <returns></returns>
        public static FigureBase GetRandomFigure()
        {
            switch (_random.Next(0, 3))
            {
                case 0:
                {
                    return RandomSphere();
                }
                case 1:
                {
                    return RandomParallelepiped();
                }
                default:
                {
                    return RandomPyramid();
                }
            }
        }

        /// <summary>
        /// Генерация случайной фигуры Шар
        /// </summary>
        /// <returns>Параметры расчета фигуры</returns>
        public static FigureBase RandomSphere()
        {
            Sphere sphere = new Sphere
            {
                Radius = ConvertToDouble(1, 150),
            };
            return sphere;
        }

        /// <summary>
        /// Генерация случайной фигуры Параллелепипед
        /// </summary>
        /// <returns>Параметры расчета фигуры</returns>
        public static FigureBase RandomParallelepiped()
        {
            Parallelepiped parallelepiped = new Parallelepiped
            {
                Length = ConvertToDouble(1, 200),
                Height = ConvertToDouble(1, 350),
                Width = ConvertToDouble(1, 150),
                AngleLengthWidth = ConvertToDouble(1, 179),
                AngleBaseHeight = ConvertToDouble(1, 179)
            };
            return parallelepiped;
        }

        /// <summary>
        /// Генерация случайной фигуры Пирамида
        /// </summary>
        /// <returns>Параметры расчета фигуры</returns>
        public static FigureBase RandomPyramid()
        {
            Pyramid pyramid = new Pyramid
            {
                AreaOfBase = ConvertToDouble(1, 100),
                Height = ConvertToDouble(1, 150)
            };
            return pyramid;
        }

        /// <summary>
        /// Генерация случайного числа double через int
        /// </summary>
        /// <param name="minValue">Минимальное значение</param>
        /// <param name="maxValue">Максимальное значение</param>
        /// <returns>Сгенерированное число типа double</returns>
        public static double ConvertToDouble(int minValue, int maxValue)
        {
            var randomValue = Convert.ToDouble(
                _random.Next(minValue, maxValue));
            return randomValue;
        }
    }
}

