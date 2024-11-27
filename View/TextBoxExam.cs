using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс проверки вводимых данных.
    /// </summary>
    internal class TextBoxExam : TextBox
    {
        /// <summary>
        /// Конструктор класса TextBoxExam.
        /// </summary>
        public TextBoxExam()
        {
            KeyPress += new KeyPressEventHandler(Exam);
        }

        /// <summary>
        /// Проверка данных от пользователя в TextBox.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        static public void Exam(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && textBox.Text.Contains(","))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '0' && string.IsNullOrEmpty(textBox.Text.Trim('0')))
            {
                e.Handled = true;
            }
        }
    }
}
