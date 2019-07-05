using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2
{
    public partial class CONFIGURACION : Form
    {
        public CONFIGURACION()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VENTANASELECCION regdehorados = new VENTANASELECCION();
            regdehorados.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CONFIGHORA venthora = new CONFIGHORA();
            venthora.TopLevel = false;
            panel1.Controls.Add(venthora);
            venthora.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CONFIGRUPOS vengru = new CONFIGRUPOS();
            vengru.TopLevel = false;
            panel1.Controls.Add(vengru);
            vengru.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CONFIGSALONES vensal = new CONFIGSALONES();
            vensal.TopLevel = false;
            panel1.Controls.Add(vensal);
            vensal.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CONFIGURAR_SEMESTRES vensem = new CONFIGURAR_SEMESTRES();
            vensem.TopLevel = false;
            panel1.Controls.Add(vensem);
            vensem.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CONFIGURARMATERIAS venmater = new CONFIGURARMATERIAS();
            venmater.TopLevel = false;
            panel1.Controls.Add(venmater);
            venmater.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //MAESTROS
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CONFIGDIAS vendi = new CONFIGDIAS();
            vendi.TopLevel = false;
            panel1.Controls.Add(vendi);
            vendi.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CONFIGESPECIALIZACION venes = new CONFIGESPECIALIZACION();
            venes.TopLevel = false;
            panel1.Controls.Add(venes);
            venes.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CONFIGTURN ventur = new CONFIGTURN();
            ventur.TopLevel = false;
            panel1.Controls.Add(ventur);
            ventur.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CONFIGSALONESESP ventsalesp = new CONFIGSALONESESP();
            ventsalesp.TopLevel = false;
            panel1.Controls.Add(ventsalesp);
            ventsalesp.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CONFIGCON vencon = new CONFIGCON();
            vencon.TopLevel = false;
            panel1.Controls.Add(vencon);
            vencon.Show();
        }
    }
}
