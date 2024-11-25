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
    /// 
    /// </summary>
    internal class FilterFigure : EventArgs
    {
        /// <summary>
		/// Свойство для получения списка после фильтрации.
		/// </summary>
		public BindingList<FigureBase> FigureFilter { get; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="filterList">Cписок после фильтрации.</param>
        /// <exception cref="ArgumentNullException">Проверка.</exception>
        public FilterFigure(BindingList<FigureBase>
            filterList)
        {
            FigureFilter = filterList ?? throw new ArgumentNullException();
        }
    }
}
