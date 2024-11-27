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
        /// Конструктор FilterForm.
        /// </summary>
        /// <param name="figureList">Список объемов фигур для фильтрации.</param>
        public FilterForm(BindingList<FigureBase> figureList)
        {
            InitializeComponent();
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            _originalFigureList = figureList;
            _textBoxValue.Enabled = false;

            ElementDeactive();

            _checkBoxPyramid.CheckedChanged += StatusCheckBoxFilter;
            _checkBoxParallelepiped.CheckedChanged += StatusCheckBoxFilter;
            _checkBoxSphere.CheckedChanged += StatusCheckBoxFilter;
            _checkBoxValue.CheckedChanged += ActivateCheckBox;
        }

        /// <summary>
        /// Определение активеного элемента.
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

        /// <summary>
        /// Активация поля.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ActivateCheckBox(object sender, EventArgs e)
        {
            _textBoxValue.Enabled = _checkBoxValue.Checked;
        }

        /// <summary>
        /// Активация поля ввода объема..
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ActivateTextBox(object sender, EventArgs e)
        {
            if (_checkBoxValue.Checked)
            {
                _textBoxValue.Enabled = true;
            }
        }

        /// <summary>
        /// Деактивация элементов.
        /// </summary>
        private void ElementDeactive()
        {
            _checkBoxValue.Enabled = false;
            _textBoxValue.Enabled = false;
        }

        /// <summary>
		/// Фильтрация списка.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ButtonFoundClick(object sender, EventArgs e)
        {
            _filterFigureList = new BindingList<FigureBase>();

            BindingList<FigureBase> tempFilteredList =
                new BindingList<FigureBase>();

            if (_checkBoxSphere.Checked)
            {
                FoundByType(_filterFigureList, tempFilteredList,
                    typeof(Sphere));
            }

            if (_checkBoxParallelepiped.Checked)
            {
                FoundByType(_filterFigureList, tempFilteredList,
                    typeof(Parallelepiped));
            }

            if (_checkBoxPyramid.Checked)
            {
                FoundByType(_filterFigureList, tempFilteredList,
                    typeof(Pyramid));
            }

            if (_checkBoxValue.Checked)
            {
                if (!string.IsNullOrEmpty(_textBoxValue.Text))
                {
                    tempFilteredList = FoundByValue(tempFilteredList,
                        Convert.ToDouble(_textBoxValue.Text));
                }
                else
                {
                    MessageBox.Show("Не задан объём фигуры.", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            foreach (var figure in _filterFigureList)
            {
                if (tempFilteredList.Contains(figure))
                {
                    _filterFigureList.Add(figure);
                }
            }

            if (_filterFigureList.Count == 0 || _filterFigureList is null)
            {
                MessageBox.Show("Совпадений не найдено.", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FilterFigure?.Invoke(this, new FilterFigure(
                _filterFigureList));
        }

        /// <summary>
        /// Фильтрация списка по типу.
        /// </summary>
        /// <param name="originalList">Лист до фильтрации.</param>
        /// <param name="filterList">Лист после фильтрации.</param>
        /// <param name="type">Тип значений.</param>
        private static void FoundByType(BindingList<FigureBase> originalList,
            BindingList<FigureBase> filterList, Type type)
        {
            foreach (var figure in originalList)
            {
                if (type == figure.GetType())
                {
                    filterList.Add(figure);
                }
            }
        }

        /// <summary>
        /// Фильтрация списка по значению.
        /// </summary>
        /// <param name="filterList">Лист для фильтрации.</param>
        /// <param name="value">Значение.</param>
        /// <returns>Отфильтрованный список.</returns>
        private static BindingList<FigureBase> FoundByValue(
            BindingList<FigureBase> filterList, double value)
        {
            BindingList<FigureBase> newList = 
                new BindingList<FigureBase>();
            foreach (var figure in filterList)
            {
                if (figure.Volume == value)
                {
                    newList.Add(figure);
                }
            }
            return newList;
        }
    }
}
