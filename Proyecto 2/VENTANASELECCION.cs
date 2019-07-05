using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_2
{
    public partial class VENTANASELECCION : Form
    {
        public VENTANASELECCION()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BUSCAR busvent = new BUSCAR();
            busvent.Show();
            Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LLENARGRUPOS llegru = new LLENARGRUPOS();
            llegru.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CONFIGURACION conf = new CONFIGURACION();
            conf.Show();
            Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            LOGIN contraseñasv = new LOGIN();
            contraseñasv.Show();
            Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
