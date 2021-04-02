using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2 //ADEMAS ESTA EL EJERCICIO 3 DONDE PUEDO IMPLEMENTAR UNA SUMATORIA
{
    public partial class Ventana : Form
    {
        private bool clicked = false;
        private String dato;
        private int valorsum;
        public Ventana()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e) {
            //Console.WriteLine("Presionado!!");

            dato = Lector.Text;
            txt_out.AppendText(dato + "\r\n");
            Lector.Text = "";
            if (IsNum(dato)) {
                valorsum += int.Parse(dato);

            }
            if (dato.Equals("SUMA")) {
                txt_out.AppendText(valorsum + "\r\n");
            }


        }

        public bool IsNum(String val) {
            try {
                if (val != null) {
                    int.Parse(val);
                }
            } catch (FormatException e) {
                return false;
            }
            return true;
        }
    }
}
