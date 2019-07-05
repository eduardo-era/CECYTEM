using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySql.Data.Types;

namespace Proyecto_2
{
    public partial class CONFIGURAR_SEMESTRES : Form
    {
        MySqlConnection cone = new MySqlConnection("server = localhost; uid = root;" + "pwd = 307277891 ; database = Horarios;");

        public CONFIGURAR_SEMESTRES()
        {
            InitializeComponent();
            estilo_datos_datagrid();
        }

        private void CONFIGURAR_SEMESTRES_Load(object sender, EventArgs e)
        {
            cone.Open();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Semestre FROM Semestre", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells["Semestre"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Semestre"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cone.Open();

            MySqlCommand insertagru = new MySqlCommand($" Insert into Semestre (Semestre) values ('{textBox1.Text}')", cone);
            insertagru.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Semestre FROM Semestre", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();

            textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cone.Open();
            MySqlCommand cambiarg = new MySqlCommand($" UPDATE Semestre SET Semestre = ('{textBox3.Text}') WHERE Semestre = ('{textBox2.Text}')", cone);
            cambiarg.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Semestre FROM Semestre", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cone.Open();

            MySqlCommand borrargru = new MySqlCommand($" DELETE FROM Semestre where Semestre = ('{textBox4.Text}')", cone);
            borrargru.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Semestre FROM Semestre", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;

        }
        public void estilo_datos_datagrid()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 14);
        }
    }
}
