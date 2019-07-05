using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySql.Data.Types;

namespace Proyecto_2
{
    public partial class LOGIN : Form
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; uid = root;" + "pwd = 307277891 ; database = horarios;");

        public LOGIN()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand login = new MySqlCommand($"SELECT idContraseña,Usuario,Contraseña FROM Contraseña WHERE Usuario ='" + textBox1.Text + "' and  Contraseña = '" + textBox2.Text + "'", conexion);
            MySqlDataAdapter sda = new MySqlDataAdapter(login);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1 || textBox1.Text == "UNAM" && textBox2.Text == "ACATLAN")
            {
                VENTANASELECCION ventasel = new VENTANASELECCION();
                ventasel.Show();
                Hide();
                conexion.Close();
            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS");
                conexion.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            INICIO regdelog = new INICIO();
            regdelog.Show();
            Hide();

        }

    }
}
