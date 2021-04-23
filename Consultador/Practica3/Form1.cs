using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Vnt_consultador : Form
    {
        public Vnt_consultador()
        {
            InitializeComponent();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            String url = txt_url.Text;
            getIP(url);
        }

        private void getIP(String url) {
            IPAddress[] addresses = Dns.GetHostAddresses(url);

            Console.WriteLine($"GetHostAddresses({url}) returns:");

            foreach (IPAddress address in addresses)
            {
                lbl_informacion.Text = "La direccion IP es: " + $"    {address}";
            }

        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_url.Text = "";
            lbl_informacion.Text = "";
        }

        private void txt_url_TextChanged(object sender, EventArgs e)
        {
            txt_url.Text = "";
        }

        private void txt_url_Click(object sender, EventArgs e)
        {
            txt_url.Text = "";
            txt_url.ForeColor = Color.Black;
        }

        private void txt_url_AcceptsTabChanged(object sender, EventArgs e)
        {
            txt_url.ForeColor = Color.Black;
        }

        private void txt_url_KeyDown(object sender, KeyEventArgs e)
        {
            txt_url.ForeColor = Color.Black;
        }
    }
}
