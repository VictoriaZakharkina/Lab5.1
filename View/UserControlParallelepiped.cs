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
    /// Класс интерфейса Параллелепипед.
    /// </summary>
    public partial class UserControlParallelepiped : UserControl, IFigureAddable
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public UserControlParallelepiped()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Чтение данных.
        /// </summary>
        public FigureBase Figure
        {
            get
            {
                return new Parallelepiped()
                {
                    Length = Convert.ToDouble(_textBoxLength.Text),
                    Width = Convert.ToDouble(_textBoxWidth.Text),
                    Height = Convert.ToDouble(_textBoxHeight.Text),
                    AngleLengthWidth = Convert.ToDouble(_textBoxAngleLengthWidth.Text),
                    AngleBaseHeight = Convert.ToDouble(_textBoxAngleBaseHeight.Text)
                };
            }
        }
    }
}
