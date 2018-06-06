using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencion_de_Procesos
{
    public partial class Form1 : Form
    {
        Lista lista = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            Proceso nuevo = null;

            int p;
            int pf = 0;
            int pa = 0;
            int cv = 0;
            int cp = 0;
            int pp = 0;

            for(int i = 1; i <=15; i++)
            {
                p = aleatorio.Next(1, 101);
                if(p <= 35)
                {
                    nuevo = new Proceso();
                    lista.agregar(nuevo);
                    pf++;
                }
                if (lista.ver() != null)
                {
                    lista.ver().ciclo--;
                    if (lista.ver().ciclo == 0)
                    {
                        lista.eliminar();
                        pa++;
                    }
                    else
                        lista.cambiar();
                }
                else
                    cv++;
                
            }

            while (lista.ver() != null && lista.ver().ciclo > 0)
            {
                lista.ver().ciclo--;
                cp++;
                if (lista.ver().ciclo == 0)
                {
                    lista.eliminar();
                    pp++;
                }
            }

            txtCV.Text = cv.ToString();
            txtPF.Text = pf.ToString();
            txtPA.Text = pa.ToString();
            txtCP.Text = cp.ToString();
            txtPP.Text = pp.ToString();
        }
    }
}
