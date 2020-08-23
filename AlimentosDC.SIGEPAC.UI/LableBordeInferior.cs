using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class LableBordeInferior : Label
    {
        
        public LableBordeInferior()
        {
            InitializeComponent();
            Paint += LableBordeInferior_Paint;
        }

        private void LableBordeInferior_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.DarkGray, 0, ButtonBorderStyle.None,
                Color.Transparent, 0, ButtonBorderStyle.None, Color.Transparent, 0, ButtonBorderStyle.None,
                Color.Black, 1, ButtonBorderStyle.Solid);
        }
    }
}
