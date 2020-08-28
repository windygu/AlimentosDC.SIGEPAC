using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmCargando : MetroForm
    {
        public FrmCargando(string Encabezado)
        {
            InitializeComponent();
            pbGenerando.MarqueeAnimationSpeed = 30;
            Text = Encabezado;
        }
    }
}
