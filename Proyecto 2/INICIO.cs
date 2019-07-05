using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_2
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }
        private void btnmaes_Click_1(object sender, EventArgs e)
        {
            SELECCIONMAESTRO datosmes = new SELECCIONMAESTRO();
            datosmes.Show();
            Hide();
        }

        private void btndir_Click_1(object sender, EventArgs e)
        {
            LOGIN contraseñas = new LOGIN();
            contraseñas.Show();
            Hide();

        }
    }
}
