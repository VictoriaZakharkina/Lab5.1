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
    public partial class UserControlParallelepiped : UserControl, IFigureAddable
    {
        public UserControlParallelepiped()
        {
            InitializeComponent();
        }

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
