using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CalculadoraGUI : Form
    {
        private int operacion, contador;
        private String[] savedig;
        public CalculadoraGUI()
        {
            InitializeComponent();
            operacion = contador = 0;
            savedig = new string[3];
            
        }

        private void btn_uno_Click(object sender, EventArgs e)
        {
            if (lbl_mostrar.Text == "1234567890")
            {
                lbl_mostrar.Text = "";
            }
            if (lbl_mostrar.Text != null)
            {
                String num = lbl_mostrar.Text + "1";
                lbl_mostrar.Text = num;
            }
            else
            {
                lbl_mostrar.Text = "1";
            }
            if (operacion == 0)
            {
                savedig[contador] = "1";
                operacion++;
            }
            else
            {
                savedig[contador] += "1";
            }
            lbl_mostrar.ForeColor = Color.Black;
        }

        private void btn_dos_Click(object sender, EventArgs e)
        {
            if (lbl_mostrar.Text == "1234567890")
            {
                lbl_mostrar.Text = "";
            }
            if (lbl_mostrar.Text != null)
            {
                String num = lbl_mostrar.Text + "2";
                lbl_mostrar.Text = num;
            }
            else
            {
                lbl_mostrar.Text = "2";
            }
            if (operacion == 0)
            {
                savedig[contador] = "2";
                operacion++;
            }
            else
            {
                savedig[contador] += "2";
            }
            lbl_mostrar.ForeColor = Color.Black;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (lbl_mostrar.Text == "1234567890")
            {
                lbl_mostrar.Text = "";
            }
            if (lbl_mostrar.Text != null)
            {
                String num = lbl_mostrar.Text + "3";
                lbl_mostrar.Text = num;
            }
            else
            {
                lbl_mostrar.Text = "3";
            }
            if (operacion == 0)
            {
                savedig[contador] = "3";
                operacion++;
            }
            else
            {
                savedig[contador] += "3";
            }
            lbl_mostrar.ForeColor = Color.Black;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (lbl_mostrar.Text == "1234567890")
            {
                lbl_mostrar.Text = "";
            }
            if (lbl_mostrar.Text != null)
            {
                String num = lbl_mostrar.Text + "4";
                lbl_mostrar.Text = num;
            }
            else
            {
                lbl_mostrar.Text = "4";
            }
            if (operacion == 0)
            {
                savedig[contador] = "4";
                operacion++;
            }
            else
            {
                savedig[contador] += "4";
            }
            lbl_mostrar.ForeColor = Color.Black;
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            if (lbl_mostrar.Text == "1234567890")
            {
                lbl_mostrar.Text = "";
            }
            if (lbl_mostrar.Text != null)
            {
                String num = lbl_mostrar.Text + "5";
                lbl_mostrar.Text = num;
            }
            else
            {
                lbl_mostrar.Text = "5";
            }
            if (operacion == 0)
            {
                savedig[contador] = "5";
                operacion++;
            }
            else
            {
                savedig[contador] += "5";
            }
            lbl_mostrar.ForeColor = Color.Black;
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            if (lbl_mostrar.Text == "1234567890")
            {
                lbl_mostrar.Text = "";
            }
            if (lbl_mostrar.Text != null)
            {
                String num = lbl_mostrar.Text + "6";
                lbl_mostrar.Text = num;
            }
            else
            {
                lbl_mostrar.Text = "6";
            }
            if (operacion == 0)
            {
                savedig[contador] = "6";
                operacion++;
            }
            else
            {
                savedig[contador] += "6";
            }
            lbl_mostrar.ForeColor = Color.Black;
        }

        private void btn_siete_Click(object sender, EventArgs e)
        {
            if (lbl_mostrar.Text == "1234567890")
            {
                lbl_mostrar.Text = "";
            }
            if (lbl_mostrar.Text != null)
            {
                String num = lbl_mostrar.Text + "7";
                lbl_mostrar.Text = num;
            }
            else
            {
                lbl_mostrar.Text = "7";
            }
            if (operacion == 0)
            {
                savedig[contador] = "7";
                operacion++;
            }
            else
            {
                savedig[contador] += "7";
            }
            lbl_mostrar.ForeColor = Color.Black;
        }

        private void btn_ocho_Click(object sender, EventArgs e)
        {
            if (lbl_mostrar.Text == "1234567890")
            {
                lbl_mostrar.Text = "";
            }
            if (lbl_mostrar.Text != null)
            {
                String num = lbl_mostrar.Text + "8";
                lbl_mostrar.Text = num;
            }
            else
            {
                lbl_mostrar.Text = "8";
            }
            if (operacion == 0)
            {
                savedig[contador] = "8";
                operacion++;
            }
            else
            {
                savedig[contador] += "8";
            }
            lbl_mostrar.ForeColor = Color.Black;
        }

        private void btn_nueve_Click(object sender, EventArgs e)
        {
            if (lbl_mostrar.Text == "1234567890")
            {
                lbl_mostrar.Text = "";
            }
            if (lbl_mostrar.Text != null)
            {
                String num = lbl_mostrar.Text + "9";
                lbl_mostrar.Text = num;
            }
            else
            {
                lbl_mostrar.Text = "9";
            }
            if (operacion == 0)
            {
                savedig[contador] = "9";
                operacion++;
            }
            else
            {
                savedig[contador] += "9";
            }
            lbl_mostrar.ForeColor = Color.Black;
        }

        private void btn_AC_Click(object sender, EventArgs e)
        {
            lbl_mostrar.Text = "";
            operacion = 0;
            contador = 0;
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            if (lbl_mostrar.Text =="1234567890" || lbl_mostrar.Text =="")
            {
                lbl_mostrar.Text = "0.";
                if (operacion == 0)
                {
                    savedig[contador] = "0.";
                    operacion++;
                }

            }
            else
            {

                String num = lbl_mostrar.Text + ".";
                lbl_mostrar.Text = num;
                savedig[contador] += ".";
            }
            lbl_mostrar.ForeColor = Color.Black;
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            if ((lbl_mostrar.Text != "1234567890") && (contador < savedig.Length))
            {
                lbl_mostrar.Text = lbl_mostrar.Text + "x";
                if (operacion != 0) { contador++; }
                savedig[contador] = "1";
                contador++;
                operacion = 0;
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if ((lbl_mostrar.Text != "1234567890") && (contador < savedig.Length))
            {
                lbl_mostrar.Text = lbl_mostrar.Text + "/";
                if (operacion != 0) { contador++; }
                savedig[contador] = "5";
                contador++;
                operacion = 0;
            }
        }

        private void btn_rest_Click(object sender, EventArgs e)
        {
            if ((lbl_mostrar.Text != "1234567890") && (contador < savedig.Length))
            {
                lbl_mostrar.Text = lbl_mostrar.Text + "-";
                if (operacion != 0) { contador++; }
                savedig[contador] = "4";
                contador++;
                operacion = 0;
            }
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            if ((lbl_mostrar.Text != "1234567890") && (contador < savedig.Length))
            {
                lbl_mostrar.Text = lbl_mostrar.Text + "+";
                if (operacion != 0) { contador++; }
                savedig[contador] = "3";
                contador++;
                operacion = 0;
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            contador = 1;
            operacion = 0;
            savedig[0] = op.operacion(savedig);
            lbl_mostrar.Text = savedig[0];

        }

        private void btn_cero_Click(object sender, EventArgs e)
        {
            if (lbl_mostrar.Text == "1234567890")
            {
                lbl_mostrar.Text = "";
            }
            if (lbl_mostrar.Text != null)
            {
                String num = lbl_mostrar.Text + "0";
                lbl_mostrar.Text = num;
            }
            else
            {
                lbl_mostrar.Text = "0";
            }
            if (operacion == 0)
            {
                savedig[contador] = "0";
                operacion++;
            }
            else
            {
                savedig[contador] += "0";
            }
            lbl_mostrar.ForeColor = Color.Black;
        }
    }
}
