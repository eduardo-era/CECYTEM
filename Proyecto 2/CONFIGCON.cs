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
    public partial class CONFIGCON : Form
    {
        MySqlConnection cone = new MySqlConnection("server = localhost; uid = root;" + "pwd = 307277891 ; database = Horarios;");

        public CONFIGCON()
        {
            InitializeComponent();
            estilo_datos_datagrid();
        }

        private void CONFIGCON_Load(object sender, EventArgs e)
        {
            cone.Open();
            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Usuario,Contraseña FROM Contraseña", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;
            cone.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox2.Text = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["Contraseña"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text ==" "|| textBox5.Text==" ")
            {
                MessageBox.Show("FALTAN DATOS");
            }
            else
            {
                cone.Open();

                MySqlCommand insertarhora = new MySqlCommand($" Insert into Contraseña (Usuario,Contraseña) values ('{textBox1.Text}','{textBox5.Text}')", cone);
                insertarhora.ExecuteNonQuery();

                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Usuario,Contraseña FROM Contraseña", cone);
                mdaDatos.Fill(dtDatos);
                dataGridView1.DataSource = dtDatos;

                cone.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cone.Open();
            MySqlCommand cambiarh = new MySqlCommand($" UPDATE Usuario,Contraseña SET Contraseña = ('{textBox3.Text}'),('{textBox7.Text}') WHERE Dia = ('{textBox2.Text}'),('{textBox6.Text}')", cone);
            cambiarh.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Usuario,Contraseña FROM Contraseña", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cone.Open();

            MySqlCommand borrarhora = new MySqlCommand($" DELETE FROM Contraseña where Usuario = ('{textBox4.Text}')", cone);
            borrarhora.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Usuario,Contraseña FROM Contraseña", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();
            textBox4.Text = string.Empty;

        }
        public void estilo_datos_datagrid()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 14);
        }

    }
}
