using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class TextBoxWaterMark : TextBox
    {
        string textMarcaAgua = "";
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);
        public TextBoxWaterMark()
        {
            InitializeComponent();
        }
        //Creamos un propiedad pública para poder setear el valor de la marca de agua en el
        //diseñador de Windows Forms
        public string TextoMarcaAgua
        {
            get { return textMarcaAgua; }
            set
            {
                if (value!=textMarcaAgua)
                {
                    textMarcaAgua = value;
                    ActualizarMarcaAgua();
                }
            }
        }

        //Sobreescribimos el método OnHandleCreated para inicializar la marca de agua
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            ActualizarMarcaAgua();
        }

        void ActualizarMarcaAgua()
        {
            //Enviamos el mensaje sólo si el Handle del control ha sido creado
            if (IsHandleCreated)
            {
                SendMessage(Handle, 0x1501, (IntPtr)1, TextoMarcaAgua);
            }
        }
        
    }      

    class NativeMethods
    {

    }
}
