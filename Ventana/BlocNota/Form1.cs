using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocNota
{
    public partial class VentanaBloc : Form
    {
        public VentanaBloc()
        {
            InitializeComponent();
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            
            lbl_historial.Text = "Color cambiado";

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
