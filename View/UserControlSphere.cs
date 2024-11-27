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
    public partial class UserControlSphere : UserControl, IFigureAddable
    {
        public UserControlSphere()
        {
            InitializeComponent();
        }

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
