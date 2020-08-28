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
    public partial class FrmSplashScreen : Form
    {
        SolidBrush lightBlue = new SolidBrush(Color.DarkGray);
        SolidBrush blue = new SolidBrush(Color.DarkBlue);
        Rectangle rectangulo1 = new Rectangle(22, 22, 22, 22) { Location= new Point(162, 322) };
        Rectangle rectangulo2 = new Rectangle(22, 22, 22, 22) { Location = new Point(213, 322) };
        Rectangle rectangulo3 = new Rectangle(22, 22, 22, 22) { Location = new Point(266, 322) };
        Rectangle rectangulo4 = new Rectangle(22, 22, 22, 22) { Location = new Point(322, 322) };
        int contador;
        FrmLogin login = new FrmLogin();
        public FrmSplashScreen()
        {
            InitializeComponent();
            contador = 0;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            contador += 1;
            switch (contador)
            {
                case 1:
                    Invalidate(rectangulo1);
                    break;
                case 2:
                    Invalidate(rectangulo2);
                    break;
                case 3:
                    Invalidate(rectangulo3);
                    break;
                case 4:
                    Invalidate(rectangulo4);
                    break;
            }
        }

        private void FrmSplashScreen_Paint(object sender, PaintEventArgs e)
        {
            if (contador==0)
            {
                e.Graphics.FillEllipse(lightBlue, rectangulo1);
                e.Graphics.FillEllipse(lightBlue, rectangulo2);
                e.Graphics.FillEllipse(lightBlue, rectangulo3);
                e.Graphics.FillEllipse(lightBlue, rectangulo4);
            }
            else
            {
                switch (contador)
                {
                    case 1:
                        e.Graphics.FillEllipse(blue, rectangulo1);
                        break;
                    case 2:
                        e.Graphics.FillEllipse(blue, rectangulo2);
                        break;
                    case 3:
                        e.Graphics.FillEllipse(blue, rectangulo3);
                        break;
                    case 4:
                        e.Graphics.FillEllipse(blue, rectangulo4);
                        timer.Stop();
                        Hide();
                        login.Show();
                        break;
                }
            }   
        }
    }
}
