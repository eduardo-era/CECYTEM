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
    public partial class CONFIGESPECIALIZACION : Form
    {
        MySqlConnection cone = new MySqlConnection("server = localhost; uid = root;" + "pwd = 307277891 ; database = Horarios;");

        public CONFIGESPECIALIZACION()
        {
            InitializeComponent();
            estilo_datos_datagrid();

        }

        private void CONFIGESPECIALIZACION_Load(object sender, EventArgs e)
        {
            cone.Open();
            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Especialidad FROM Especialidad", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;
            cone.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cone.Open();

            MySqlCommand insertarhora = new MySqlCommand($" Insert into Especialidad (Especialidad) values ('{textBox1.Text}')", cone);
            insertarhora.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Especialidad FROM Especialidad", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();

            textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cone.Open();
            MySqlCommand cambiarh = new MySqlCommand($" UPDATE Especialidad SET Especialidad = ('{textBox3.Text}') WHERE Especialidad = ('{textBox2.Text}')", cone);
            cambiarh.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Especialidad FROM Especialidad", cone);
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

            MySqlCommand borrarhora = new MySqlCommand($" DELETE FROM Especialidad where Especialidad = ('{textBox4.Text}')", cone);
            borrarhora.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Especialidad FROM Especialidad", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells["Especialidad"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Especialidad"].Value.ToString();
        }
        public void estilo_datos_datagrid()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
