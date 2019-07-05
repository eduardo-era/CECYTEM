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
    public partial class CONFIGRUPOS : Form
    {
        MySqlConnection cone = new MySqlConnection("server = localhost; uid = root;" + "pwd = 307277891 ; database = Horarios;");
        public CONFIGRUPOS()
        {
            InitializeComponent();
            estilo_datos_datagrid();
        }

        //BOTON AGREGAR GRUPO
        private void button1_Click(object sender, EventArgs e)
        {
            cone.Open();

            MySqlCommand insertagru = new MySqlCommand($" Insert into Grrupos (Grupo) values ('{textBox1.Text}')", cone);
            insertagru.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Grupo FROM Grrupos", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();

            textBox1.Text = string.Empty;
        }

        //CARGA EL DATA GRID DESDE EL INICIO
        private void CONFIGRUPOS_Load(object sender, EventArgs e)
        {
            cone.Open();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Grupo FROM Grrupos", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();
        }

        //BOTON ACTUALIZAR GRUPO
        private void button2_Click(object sender, EventArgs e)
        {
            cone.Open();
            MySqlCommand cambiarg = new MySqlCommand($" UPDATE Grrupos SET Grupo = ('{textBox3.Text}') WHERE Grupo = ('{textBox2.Text}')", cone);
            cambiarg.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Grupo FROM Grrupos", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        //BOTON ELIMINAR GRUPO
        private void button4_Click(object sender, EventArgs e)
        {
            cone.Open();

            MySqlCommand borrargru = new MySqlCommand($" DELETE FROM Grrupos where Grupo = ('{textBox4.Text}')", cone);
            borrargru.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Grupo FROM Grrupos", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        //CARGA LOS TEXTBOX CON DATOS DEL DATAGRID
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells["Grupo"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Grupo"].Value.ToString();
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
