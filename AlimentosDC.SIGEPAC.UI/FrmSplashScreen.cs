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
using AlimentosDC.SIGEPAC.UI.Properties;
using System.Reflection;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmSplashScreen : Form
    {
        SolidBrush darkGray = new SolidBrush(Color.DarkGray);
        SolidBrush blue = new SolidBrush(Color.Blue);
        Rectangle rectangulo1 = new Rectangle(22, 22, 22, 22) { Location= new Point(162, 322) };
        Rectangle rectangulo2 = new Rectangle(22, 22, 22, 22) { Location = new Point(213, 322) };
        Rectangle rectangulo3 = new Rectangle(22, 22, 22, 22) { Location = new Point(266, 322) };
        Rectangle rectangulo4 = new Rectangle(22, 22, 22, 22) { Location = new Point(322, 322) };
        int contador;
        int contador2;
        FrmLogin login = new FrmLogin();
        static FrmSplashScreen objetoSplashScreen;
        public static FrmSplashScreen ObjetoSplashScreen { get { return objetoSplashScreen; } }
        public FrmSplashScreen()
        {
            InitializeComponent();
            objetoSplashScreen = this;
            contador = 0;
            contador2 = 0;
            timer.Start();
            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            contador += 1;
            switch (contador)
            {
                case 1:
                    Invalidate(rectangulo4);
                    Invalidate(rectangulo1);
                    break;
                case 2:
                    Invalidate(rectangulo1);
                    Invalidate(rectangulo2);
                    break;
                case 3:
                    Invalidate(rectangulo2);
                    Invalidate(rectangulo3);
                    break;
                case 4:
                    Invalidate(rectangulo3);
                    Invalidate(rectangulo4);
                    break;
            }
        }

        private void FrmSplashScreen_Paint(object sender, PaintEventArgs e)
        {
            if (contador==0)
            {
                e.Graphics.FillEllipse(darkGray, rectangulo1);
                e.Graphics.FillEllipse(darkGray, rectangulo2);
                e.Graphics.FillEllipse(darkGray, rectangulo3);
                e.Graphics.FillEllipse(darkGray, rectangulo4);
            }
            else
            {
                switch (contador)
                {
                    case 1:
                        e.Graphics.FillEllipse(darkGray, rectangulo4);
                        e.Graphics.FillEllipse(blue, rectangulo1);
                        break;
                    case 2:
                        e.Graphics.FillEllipse(darkGray, rectangulo1);
                        e.Graphics.FillEllipse(blue, rectangulo2);
                        break;
                    case 3:
                        e.Graphics.FillEllipse(darkGray, rectangulo2);
                        e.Graphics.FillEllipse(blue, rectangulo3);
                        break;
                    case 4:
                        e.Graphics.FillEllipse(darkGray, rectangulo3);
                        e.Graphics.FillEllipse(blue, rectangulo4);
                        contador = 0;
                        break;
                }
            }   
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            //Assembly ensambladoActual = Assembly.GetExecutingAssembly();
            lblVersion.Text = string.Concat(ProductName, " v. 1.0");
            lblCopyRight.Text = "Todos los derechos reservados ©  2020";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador2 += 1;
            if (contador2==3)
            {
                timer.Stop();
                timer1.Stop();
                login.Show();
            }
        }
    }
}
