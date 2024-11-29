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
    /// Класс интерфейса Шар.
    /// </summary>
    public partial class UserControlSphere : UserControl, IFigureAddable
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public UserControlSphere()
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
                return new Sphere()
                {
                    Radius = Convert.ToDouble(_textBoxRadius.Text),
                };
            }
        }
    }
}
