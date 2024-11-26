using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Класс Parallelepiped
    /// </summary>
    public class Parallelepiped : FigureBase
    {
        /// <summary>
        /// Длина
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина
        /// </summary>
        private double _width;

        /// <summary>
        /// Высота
        /// </summary>
        private double _height;

        /// <summary>
        /// Угол между длиной и шириной
        /// </summary>
        private double _angleLengthWidth;

        /// <summary>
        /// Угол между высотой и основанием
        /// </summary>
        private double _angleBaseHeight;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Parallelepiped()
        { }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="length">Длина</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <param name="angleLengthWidth">Угол длина/ширина</param>
        /// <param name="angleBaseHeight">Угол основание/высота</param>
        /// //TODO +: RSDN
        public Parallelepiped(double length, double width, double height, 
                double angleLengthWidth, double angleBaseHeight)
        {
            _length = length;
            _width = width;
            _height = height;
            _angleLengthWidth = angleLengthWidth;
            _angleBaseHeight = angleBaseHeight;
        }

        /// <summary>
        /// Длина
        /// </summary>
        public double Length
        {
            get { return _length; }
            set
            {
                CheckNumber(value);
                _length = value;
            }
        }

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width
        {
            get { return _width; }
            set
            {
                CheckNumber(value);
                _width = value;
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
        /// Угол между длиной и шириной
        /// </summary>
        public double AngleLengthWidth
        {
            get { return _angleLengthWidth; }
            set
            {
                CheckNumberAngle(value);
                _angleLengthWidth = value;
            }
        }

        /// <summary>
        /// Угол между основанием и высотой
        /// </summary>
        public double AngleBaseHeight
        {
            get { return _angleBaseHeight; }
            set
            {
                CheckNumberAngle(value);
                _angleBaseHeight = value;
            }
        }

        /// <summary>
        /// Расчет объёма параллелепипеда в см^3
        /// </summary>
        public override double Volume
        {
            get
            {
                return Length * Width * Height
                * Math.Sin(AngleLengthWidth * (Math.PI / 180))
                * Math.Sin(AngleBaseHeight * (Math.PI / 180));
            }
        }
    }
}
