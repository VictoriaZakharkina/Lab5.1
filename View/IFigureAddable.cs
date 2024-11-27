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
    internal interface IFigureAddable
    {
        FigureBase Figure { get; }
    }
}
