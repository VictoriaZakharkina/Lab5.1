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
    public partial class AddForm : Form
    {
        /// <summary>
        /// Поле для обработки события добавления.
        /// </summary>
        public EventHandler FigureAdded;

        /// <summary>
		/// Список UserControls.
		/// </summary>
		private List<IFigureAddable> _figureAddableControls;

        public AddForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление фигуры.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ButtonFigureAdd(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            _figureAddableControls = new List<IFigureAddable>()
            {
                _userControlSphere,
                _userControlParallelepiped,
                _userControlPyramid,
            };
        }

        /// <summary>
        /// Загрузка формы данных Шар.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void CheckBoxSphereChanged(object sender, EventArgs e)
        {
            _userControlSphere.Visible = true;
            _userControlParallelepiped.Visible = false;
            _userControlPyramid.Visible = false;
        }

        /// <summary>
        /// Загрузка формы данных Параллелепипед.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void CheckBoxParallelepipedChanged(object sender, EventArgs e)
        {
            _userControlSphere.Visible = false;
            _userControlParallelepiped.Visible = true;
            _userControlPyramid.Visible = false;
        }

        /// <summary>
        /// Загрузка формы данных Пирамида.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void CheckBoxPyramidChanged(object sender, EventArgs e)
        {
            _userControlSphere.Visible = false;
            _userControlParallelepiped.Visible = false;
            _userControlPyramid.Visible = true;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            try
            {
                FigureBase baseFigure = null;

                foreach (var userControl in _figureAddableControls)
                {
                    if (((UserControl)userControl).Visible)
                    {
                        baseFigure = userControl.Figure;
                    }
                }

                FigureAdded?.Invoke(this, new AddVolume(baseFigure));
            }
            catch (ArgumentException exeption)
            {
                MessageBox.Show($"{exeption.Message}", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Введите данные.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
