using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carreraliebre_tortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liebre c1 = new Liebre(10);
            int get = c1.Posicion;
            Tortuga c2 = new Tortuga(20);
            int gel = c2.Posicion;

            t1.Text = Convert.ToString(c1) + Convert.ToString(c2);
            {
                do
                {
                    c1.Correr();
                    c2.Correr();
                    t1.Text += (gel + get);
                }
                while (c1.Posicion <= 100 && c2.Posicion <= 100);


                if (c2.Posicion == c1.Posicion)
                    t1.Text = "Empate";
                else if (c1.Posicion > c2.Posicion)
                    t1.Text = "Liebre Gano";
                else
                    t1.Text = "Tortuga Gano";



            }

        }
    }
}
