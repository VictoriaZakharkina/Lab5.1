using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Класс Sphere
    /// </summary>
    public class Sphere : FigureBase
    {
        /// <summary>
        /// Радиус
        /// </summary>
        private double _radius;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Sphere()
        { }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Sphere(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius
        {
            get { return _radius; }
            set
            {
                CheckNumber(value);
                _radius = value;
            }
        }

        /// <summary>
        /// Расчет объёма шара
        /// </summary>
        public override double Volume()
        {
            return (4 * Math.PI * Math.Pow(Radius, 3)) / 3;
        }
    }
}
