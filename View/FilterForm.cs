using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Исходный список расчитанных фигур.
        /// </summary>
        private readonly BindingList<FigureBase> _originalFigureList;

        /// <summary>
        /// Отфильтрованный список расчитанных фигур.
        /// </summary>
        private BindingList<FigureBase> _filterFigureList;

        /// <summary>
        /// Конструктор FilterFigure.
        /// </summary>
        /// <param name="figureList">Список объемов фигур для фильтрации.</param>
        public FilterForm(BindingList<FigureBase> figureList)
        {
            InitializeComponent();
        }
    }
}
