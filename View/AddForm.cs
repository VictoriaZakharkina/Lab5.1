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

        public AddForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление фигуры.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void buttonFigureAdd(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Загрузка формы данных Шар.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void CheckBoxSphereChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Загрузка формы данных Параллелепипед.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void CheckBoxParallelepipedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Загрузка формы данных Пирамида.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void CheckBoxPyramidChanged(object sender, EventArgs e)
        {

        }


    }
}
