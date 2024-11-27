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
    public partial class UserControlPyramid : UserControl, IFigureAddable
    {
        public UserControlPyramid()
        {
            InitializeComponent();
        }

        public FigureBase Figure
        {
            get
            {
                return new Pyramid()
                {
                    AreaOfBase = Convert.ToDouble(_textBoxAreaOfBase.Text),
                    Height = Convert.ToDouble(_textBoxHeight.Text)
                };
            }
        }
    }
}
