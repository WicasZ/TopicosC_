using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            String texto = text_in.Text;
            text_out.AppendText(texto + "\r\n");

        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            text_in.Text = "";
            text_out.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
