using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color
{
    public partial class vnt_colores : Form
    {
        private TextBox colores;
        String cadena;
        public vnt_colores(TextBox cadena)
        {
            this.cadena = cadena.Text;
            InitializeComponent();
        }

        private void bton_red_Click(object sender, EventArgs e)
        {
            colores.Text = cadena;

        }
    }
}
