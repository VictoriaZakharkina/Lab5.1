using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    /// <summary>
    /// При добавлении объекта данные поступают к событию.
    /// </summary>
    internal class AddVolume : EventArgs
    {
        /// <summary>
		/// Свойство считывания фигуры.
		/// </summary>
		public FigureBase FigureBase { get; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="figureBase">Фигура.</param>
        /// <exception cref="ArgumentNullException">Проверка.</exception>
        public AddVolume(FigureBase figureBase)
        {
            FigureBase = figureBase ?? throw new ArgumentNullException();
        }
    }
}
