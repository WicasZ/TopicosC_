using System;
using System.Windows.Forms;

namespace BlocNota
{
    public partial class VentanaBloc : Form
    {
        
        public VentanaBloc()
        {
            InitializeComponent();
            combotamaño
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            
            lbl_historial.Text = "Color cambiado";

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_comilas_Click(object sender, EventArgs e)
        {
            String cadena = txt_out.Text;
            String seleccion = txt_out.SelectedText;
            if(seleccion != "") {
                txt_out.Text = cadena.Replace(seleccion, "''" + seleccion + "''");
                lbl_historial.Text = "Comillas añadido a " + seleccion;
            }

            
        }

        private void btn_tamaño_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
