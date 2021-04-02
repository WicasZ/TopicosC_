using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        private int x, y;
        private int fx, fy;
        Image personaje = null;
        private int suj = 0;
        private bool tipo;
        private double velocidad = 0.1;
        private int tiempo = 200;

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.suj++;
            if (suj >= 3) {
                this.suj = 0;
            }
            if (tipo) {
                this.fy = 254;
            }
            else {
                fy = 0;
            }
            Console.WriteLine("Mono: " + suj);
            AreaTrabajo.Invalidate();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar.ToString());
            int distancia = (int)(velocidad*tiempo);
            if (e.KeyChar == 68) {
                this.x+=distancia;
                tipo = true;
            }
            if (e.KeyChar == 65)
            {
                this.x-=distancia;
                tipo = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Liberado");
            tipo = false;

        }

        public Form1()
        {
            InitializeComponent();
            personaje = Image.FromFile("C:\\Users\\WillH\\Documents\\C_\\Ejercicio8\\Recursos\\Tortuga.png");
            x = y = 0;
            fx = fy = 0;
            tipo = false;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void AreaTrabajo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(personaje, new Rectangle(x, y, 200, 254), (fx+suj*255), fy, 220, 254, GraphicsUnit.Pixel);
        }
    }
}
