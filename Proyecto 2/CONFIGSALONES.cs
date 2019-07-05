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
    public partial class CONFIGSALONES : Form
    {
        MySqlConnection cone = new MySqlConnection("server = localhost; uid = root;" + "pwd = 307277891 ; database = Horarios;");

        public CONFIGSALONES()
        {
            InitializeComponent();
            estilo_datos_datagrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells["Salon"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Salon"].Value.ToString();
        }

        private void CONFIGSALONES_Load(object sender, EventArgs e)
        {
            cone.Open();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Salon FROM Salon", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cone.Open();

            MySqlCommand insertagru = new MySqlCommand($" Insert into Salon (Salon) values ('{textBox1.Text}')", cone);
            insertagru.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Salon FROM Salon", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();

            textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cone.Open();
            MySqlCommand cambiarg = new MySqlCommand($" UPDATE Salon SET Salon = ('{textBox3.Text}') WHERE Salon = ('{textBox2.Text}')", cone);
            cambiarg.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Salon FROM Salon", cone);
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

            MySqlCommand borrargru = new MySqlCommand($" DELETE FROM Salon where Salon = ('{textBox4.Text}')", cone);
            borrargru.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Salon FROM Salon", cone);
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
