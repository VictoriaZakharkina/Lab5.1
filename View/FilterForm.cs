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
		/// Событие на фильтрацию списка.
		/// </summary>
		public EventHandler FilterFigure;

        /// <summary>
        /// Конструктор FilterFigure.
        /// </summary>
        /// <param name="figureList">Список объемов фигур для фильтрации.</param>
        public FilterForm(BindingList<FigureBase> figureList)
        {
            InitializeComponent();
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            _originalFigureList = figureList;
            _textBoxValue.Enabled = false;

            DeactivateElements();

            _checkBoxPyramid.CheckedChanged += UpdateFilterState;
            _checkBoxParallelepiped.CheckedChanged += UpdateFilterState;
            _checkBoxBall.CheckedChanged += UpdateFilterState;
            _checkBoxVolume.CheckedChanged += ToggleTextBox;
        }

        /// <summary>
        /// Определяет активен ли элемент.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void StatusCheckBoxFilter(object sender, EventArgs e)
        {
            // Проверяем, выбран ли хотя бы один CheckBox
            bool status = _checkBoxPyramid.Checked
                || _checkBoxParallelepiped.Checked
                || _checkBoxSphere.Checked;

            _checkBoxValue.Enabled = status;
        }


    }
}
