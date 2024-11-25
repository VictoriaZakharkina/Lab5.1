using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Класс Pyramid
    /// </summary>
    public class Pyramid : FigureBase
    {
        /// <summary>
        /// Площадь основания
        /// </summary>
        private double _areaOfBase;

        /// <summary>
        /// Высота
        /// </summary>
        private double _height;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Pyramid()
        { }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="areaOfBase">Площадь основания</param>
        /// <param name="height">Высота</param>
        public Pyramid(double areaOfBase, double height)
        {
            _areaOfBase = areaOfBase;
            _height = height;
        }

        /// <summary>
        ///Площадь основания
        /// </summary>
        public double AreaOfBase
        {
            get { return _areaOfBase; }
            set
            {
                CheckNumber(value);
                _areaOfBase = value;
            }
        }

        /// <summary>
        /// Высота
        /// </summary>
        public double Height
        {
            get { return _height; }
            set
            {
                CheckNumber(value);
                _height = value;
            }
        }

        /// <summary>
        /// Расчет объёма пирамиды
        /// </summary>
        public override double Volume
        {
            get
            {
                return (AreaOfBase * Height) / 3;
            }
        }
        /// <summary>
        /// Параметры
        /// </summary>
        public override string Parameters
        {
            get
            {
                return $"Площадь основания = {AreaOfBase}, высота = {Height}";
            }
        }
        /// <summary>
        /// Вид фигуры
        /// </summary>
        public override string TypeFigure
        {
            get
            {
                return "Пирамида";
            }
        }
    }
}
