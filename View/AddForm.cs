﻿using Library;
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
            BackColor = Color.Honeydew;
            StartPosition = FormStartPosition.CenterScreen;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            ballUserControl.textBoxRadius.KeyPress += new
                KeyPressEventHandler(CheckTextBox.TextBoxCheck);

            parallelepipedUserControl.textBoxLength.KeyPress += new
                KeyPressEventHandler(CheckTextBox.TextBoxCheck);

            parallelepipedUserControl.textBoxWidth.KeyPress += new
                KeyPressEventHandler(CheckTextBox.TextBoxCheck);

            parallelepipedUserControl.textBoxHeight.KeyPress += new
                KeyPressEventHandler(CheckTextBox.TextBoxCheck);

            parallelepipedUserControl.textBoxAngleLengthWidth.KeyPress += new
                KeyPressEventHandler(CheckTextBox.TextBoxCheck);

            parallelepipedUserControl.textBoxAngleLengthHeight.KeyPress += new
                KeyPressEventHandler(CheckTextBox.TextBoxCheck);

            pyramidUserControl.textBoxAreaOfBase.KeyPress += new
                KeyPressEventHandler(CheckTextBox.TextBoxCheck);

            pyramidUserControl.textBoxPyramidHeight.KeyPress += new
                KeyPressEventHandler(CheckTextBox.TextBoxCheck);
        }

        /// <summary>
        /// Кнопка Добавить объём фигуры.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FigureBase figureBase = null;

                if (ballUserControl.Visible)
                {
                    figureBase = new Ball()
                    {
                        Radius = Convert.ToDouble(
                            ballUserControl.textBoxRadius.Text),
                    };
                }

                if (parallelepipedUserControl.Visible)
                {
                    figureBase = new Parallelepiped()
                    {
                        Length = Convert.ToDouble(
                            parallelepipedUserControl.textBoxLength.Text),
                        Width = Convert.ToDouble(
                            parallelepipedUserControl.textBoxWidth.Text),
                        Height = Convert.ToDouble(
                            parallelepipedUserControl.textBoxHeight.Text),
                        AngleLengthWidth = Convert.ToDouble(
                            parallelepipedUserControl.textBoxAngleLengthWidth.Text),
                        AngleLengthHeight = Convert.ToDouble(
                            parallelepipedUserControl.textBoxAngleLengthHeight.Text),
                    };
                }

                if (pyramidUserControl.Visible)
                {
                    figureBase = new Pyramid()
                    {
                        AreaOfBase = Convert.ToDouble(
                            pyramidUserControl.textBoxAreaOfBase.Text),
                        Height = Convert.ToInt32(
                            pyramidUserControl.textBoxPyramidHeight.Text),
                    };
                }

                FigureAdded?.Invoke(this, new VolumeAddedEvent(figureBase));
            }
            catch (ArgumentOutOfRangeException exeption)
            {
                MessageBox.Show($"{exeption.Message}", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Введите данные.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Загрузка формы данных Шар.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            ballUserControl.Visible = true;
            parallelepipedUserControl.Visible = false;
            pyramidUserControl.Visible = false;
        }

        /// <summary>
        /// Загрузка формы данных Параллелепипед.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void RadioButtonParallelepipedCheckedChanged(object sender, EventArgs e)
        {
            ballUserControl.Visible = false;
            parallelepipedUserControl.Visible = true;
            pyramidUserControl.Visible = false;
        }

        /// <summary>
        /// Загрузка формы данных Пирамида.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void RadioButtonPyramidaCheckedChanged(object sender, EventArgs e)
        {
            ballUserControl.Visible = false;
            parallelepipedUserControl.Visible = false;
            pyramidUserControl.Visible = true;
        }
    }
}
