using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    /// <summary>
    /// Класс отдает данные событию при фильтрации фигуры.
    /// </summary>
    internal class FilterFigure : EventArgs
    {
        /// <summary>
		/// Свойство для получения отфильтрованного списка.
		/// </summary>
		public BindingList<FigureBase> FilterFigureList { get; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="filterFigureList">Отфильтрованный список.</param>
        /// <exception cref="ArgumentNullException">Проверка списка
        /// на null.</exception>
        public FilterFigure(BindingList<FigureBase>
            filterFigureList)
        {
            if (filterFigureList == null)
            {
                throw new ArgumentNullException();
            }

            FilterFigureList = filterFigureList;
        }
    }
}
