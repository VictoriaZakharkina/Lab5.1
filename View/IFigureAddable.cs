using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    /// <summary>
    /// Интерфейся для UserControls
    /// </summary>
    public interface IFigureAddable
    {
        /// <summary>
        /// Свойство, предоставляющее интерфейс.
        /// </summary>
        FigureBase Figure { get; }
    }
}
