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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace View
{
    /// <summary>
    /// Форма "Добавить фигуру".
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
		private Dictionary<RadioButton, UserControl> _figureAddableControls;

        /// <summary>
        /// Конструктор класса AddForm.
        /// </summary>
        public AddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            _figureAddableControls = new Dictionary<RadioButton, UserControl>()
            {
                { _radioButtonSphere, _userControlSphere },
                { _radioButtonParallelepiped , _userControlParallelepiped },
                { _radioButtonPyramid, _userControlPyramid }
            };
        }

        /// <summary>
        /// Загрузка формы данных шар.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ChangeUserControlVisibility(object sender, EventArgs e)
        {
            foreach(var element in _figureAddableControls)
            {
                element.Value.Visible = element.Key == sender;
            }
        }


        /// <summary>
        /// Метод нажатия на кнопку "Добавить".
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные и событие.</param>
        private void ButtonAdd(object sender, EventArgs e)
        {
            try
            {
                foreach (var element in _figureAddableControls)
                {
                    if (element.Value.Visible)
                    {
                        FigureAdded?.Invoke(this, 
                            new AddVolume(((IFigureAddable)element.Value).Figure));
                    }
                }                
            }
            catch (ArgumentException exeption)
            {
                MessageBox.Show($"{exeption.Message}", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Введите данные.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку "Закрыть".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void CloseButton(object sender, EventArgs e)
        {
            Close();
        }
    }
}
