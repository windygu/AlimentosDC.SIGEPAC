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
    public partial class TextBoxBorderInferior : TextBox
    {
        Color colorBorde = Color.Black;
        public TextBoxBorderInferior()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;
            Controls.Add(new Label { Height = 1, Dock = DockStyle.Bottom, BackColor = colorBorde });
            InitializeComponent();
        }
        
        public Color ColorBorde
        {
            get { return colorBorde; }
            set
            {
                colorBorde = value;
                Controls[0].BackColor = colorBorde;
            }
        }
    }
}
