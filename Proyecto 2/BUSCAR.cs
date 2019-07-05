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
    public partial class BUSCAR : Form
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; uid = root;" + "pwd = 307277891 ; database = horarios;");

        public BUSCAR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string quebus = comboBox1.Text;

            if(quebus=="ASIGNATURAS DEL PROFESOR")
            {
                conexion.Open();
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter("select concat(Nombre,'  ',ApellidoP,'  ',ApellidoM) AS PROFESOR,Materia,Semestre from Materia_Profesor inner join Profesor on  Materia_Profesor.idProfesor=Profesor.idProfesor inner join Materia on  Materia_Profesor.idMateria=Materia.idMateria inner join Semestre on Materia.idSemestre=Semestre.idSemestre where Nombre = '" + textBox1.Text + "'" , conexion);
                mdaDatos.Fill(dtDatos);
                dataGridView1.DataSource = dtDatos;
                conexion.Close();
            }

            if (quebus == "MAESTRO")
            {
                conexion.Open();
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter("select Nombre, ApellidoP, ApellidoM, Genero ,EstadoCivil ,Curp ,Telefono, Celular ,Correo  ,LugarNacimiento ,FechaNaciemiento ,RFC,Calle ,CodigoPostal, Numero ,Colonia,Estado ,Licenciatura, CedulaLicenciatura ,Maestria ,CedulaMestria, Doctorado ,CedulaDoctorado from Profesor WHERE Nombre = '" + textBox1.Text + "'" + "or" + " " + "ApellidoP = '" + textBox1.Text + "'" + "or" + " " + "ApellidoM = '" + textBox1.Text + "'", conexion);


                mdaDatos.Fill(dtDatos);
                dataGridView1.DataSource = dtDatos;
                conexion.Close();
            }

            if(quebus == "SALON")
            {
                conexion.Open();
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter($"select * from Grupo WHERE Salon = '{textBox1.Text}'", conexion);
                mdaDatos.Fill(dtDatos);
                dataGridView1.DataSource = dtDatos;
                conexion.Close();
            }
            if(quebus == "HORA")
            {
                conexion.Open();
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter($"select distinct * from grupo where Hora1 or Hora2 or Hora3 or Hora4 or Hora5 or Hora6 or Hora7 or Hora8 or Hora9  = '{textBox1.Text}'", conexion);
                mdaDatos.Fill(dtDatos);
                dataGridView1.DataSource = dtDatos;
                conexion.Close();
            }
            if (quebus == "DIA")
            {
                conexion.Open();
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter($"select  * from grupo where Dias1= '" + textBox1.Text + "'" + " or Dias2= '" + textBox1.Text + "'" + " or Dias3= '" + textBox1.Text + "'" + " or Dias4= '" + textBox1.Text + "'" + " or Dias5= '" + textBox1.Text + "'" + " or Dias6= '" + textBox1.Text + "'" + " or Dias7= '" + textBox1.Text + "'" + " or Dias8= '" + textBox1.Text + "'" + " or Dias9 = '" + textBox1.Text + "'", conexion);
                mdaDatos.Fill(dtDatos);
                dataGridView1.DataSource = dtDatos;
                conexion.Close();
            }
            if (quebus == "MATERIA")
            {
                conexion.Open();
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter($"select * from grupo where Materia1 = '" + textBox1.Text + "'"+ "or Materia2= '" + textBox1.Text + "'" + "or Materia3= '" + textBox1.Text + "'" + " or Materia4= '" + textBox1.Text + "'" + " or Materia5= '" + textBox1.Text + "'" + " or Materia6= '" + textBox1.Text + "'" + " or Materia7= '" + textBox1.Text + "'" + " or Materia8= '" + textBox1.Text + "'" + " or Materia9= '" + textBox1.Text + "'", conexion);
                mdaDatos.Fill(dtDatos);
                dataGridView1.DataSource = dtDatos;
                conexion.Close();
            }
            if (quebus == "SALON ESPECIAL")
            {
                conexion.Open();
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter($"select * from grupo where SalonE1 = '" + textBox1.Text + "'" + "or SalonE2= '" + textBox1.Text + "'" + "or SalonE3= '" + textBox1.Text + "'" + " or SalonE4= '" + textBox1.Text + "'" + " or SalonE5= '" + textBox1.Text + "'" + " or SalonE6= '" + textBox1.Text + "'" + " or SalonE7= '" + textBox1.Text + "'" + " or SalonE8= '" + textBox1.Text + "'" + " or SalonE9= '" + textBox1.Text + "'", conexion);
                mdaDatos.Fill(dtDatos);
                dataGridView1.DataSource = dtDatos;
                conexion.Close();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            VENTANASELECCION regdebus = new VENTANASELECCION();
            regdebus.Show();
            Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}