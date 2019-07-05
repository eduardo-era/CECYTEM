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
    public partial class SELECCIONMAESTRO : Form
    {
        MySqlConnection cone = new MySqlConnection("server = localhost; uid = root;" + "pwd = 307277891 ; database = Horarios;");

        public SELECCIONMAESTRO()
        {
            InitializeComponent();
            llenar_materias();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            INICIO regredeprof = new INICIO();
            regredeprof.Show();
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cone.Open();

            MySqlCommand insertar_profesor = new MySqlCommand($" Insert into Profesor (Nombre , ApellidoP ,ApellidoM ,Genero , EstadoCivil, Curp ,Telefono , Celular, Correo, LugarNacimiento, FechaNaciemiento, RFC, Calle, CodigoPostal, Numero, Colonia, Estado, Licenciatura, CedulaLicenciatura, Maestria,CedulaMestria,Doctorado,CedulaDoctorado) values ('{textname.Text}','{textapellidop.Text}','{textapellidom.Text}', '{combogenero.Text}', '{comboestadocivil.Text}', '{textcurp.Text}', '{textel.Text}', '{textcell.Text}', '{textmail.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}', '{textcalle.Text}', '{textBox2.Text}', '{textBox7.Text}', '{textBox6.Text}', '{textBox8.Text}', '{textBox11.Text}', '{textBox14.Text}', '{textBox12.Text}', '{textBox15.Text}', '{textBox13.Text}', '{textBox16.Text}')",cone);
            insertar_profesor.ExecuteNonQuery();
            cone.Close();

            cone.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT idProfesor FROM Profesor WHERE Curp = '" + textcurp.Text + "'", cone);
            int idelprof = (int)cmd.ExecuteScalar();
            cone.Close();


            if(comboBox1.Text != "")
            {
                cone.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT idMateria FROM Materia WHERE Materia = '" + comboBox1.Text + "'", cone);
                int idelamat1 = (int)cmd1.ExecuteScalar();
                
                MySqlCommand insertar_profesor_materia = new MySqlCommand($" Insert into Materia_Profesor (idProfesor , idMateria) values ({idelprof},{idelamat1})", cone);
                insertar_profesor_materia.ExecuteNonQuery();
                cone.Close();

            }

            if (comboBox2.Text != "")
            {
                cone.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT idMateria FROM Materia WHERE Materia = '" + comboBox2.Text + "'", cone);
                int idelamat2 = (int)cmd2.ExecuteScalar();


                MySqlCommand insertar_profesor_materia2 = new MySqlCommand($" Insert into Materia_Profesor (idProfesor , idMateria) values ('{idelprof}','{idelamat2}')", cone);
                insertar_profesor_materia2.ExecuteNonQuery();
                cone.Close();

            }

            if (comboBox3.Text != "")
            {
                cone.Open();
                MySqlCommand cmd3 = new MySqlCommand("SELECT idMateria FROM Materia WHERE Materia = '" + comboBox3.Text + "'", cone);
                int idelamat3 = (int)cmd3.ExecuteScalar();


                MySqlCommand insertar_profesor_materia3 = new MySqlCommand($" Insert into Materia_Profesor (idProfesor , idMateria) values ('{idelprof}','{idelamat3}')", cone);
                insertar_profesor_materia3.ExecuteNonQuery();
                cone.Close();

            }

            if (comboBox4.Text != "")
            {
                cone.Open();
                MySqlCommand cmd4 = new MySqlCommand("SELECT idMateria FROM Materia WHERE Materia = '" + comboBox4.Text + "'", cone);
                int idelamat4 = (int)cmd4.ExecuteScalar();


                MySqlCommand insertar_profesor_materia4 = new MySqlCommand($" Insert into Materia_Profesor (idProfesor , idMateria) values ('{idelprof}','{idelamat4}')", cone);
                insertar_profesor_materia4.ExecuteNonQuery();
                cone.Close();

            }

            if (comboBox5.Text != "")
            {
                cone.Open();
                MySqlCommand cmd5 = new MySqlCommand("SELECT idMateria FROM Materia WHERE Materia = '" + comboBox5.Text + "'", cone);
                int idelamat5 = (int)cmd5.ExecuteScalar();


                MySqlCommand insertar_profesor_materia5 = new MySqlCommand($" Insert into Materia_Profesor (idProfesor , idMateria) values ('{idelprof}','{idelamat5}')", cone);
                insertar_profesor_materia5.ExecuteNonQuery();
                cone.Close();

            }

            if (comboBox6.Text != "")
            {
                cone.Open();
                MySqlCommand cmd6 = new MySqlCommand("SELECT idMateria FROM Materia WHERE Materia = '" + comboBox6.Text + "'", cone);
                int idelamat6 = (int)cmd6.ExecuteScalar();


                MySqlCommand insertar_profesor_materia6 = new MySqlCommand($" Insert into Materia_Profesor (idProfesor , idMateria) values ('{idelprof}','{idelamat6}')", cone);
                insertar_profesor_materia6.ExecuteNonQuery();
                cone.Close();

            }





            MessageBox.Show("SE GUARDARON LOS DATOS");

            textname.Text = string.Empty;
            textapellidop.Text = string.Empty;
            textapellidom.Text = string.Empty;
            combogenero.Text = string.Empty;
            comboestadocivil.Text = string.Empty;
            textcurp.Text = string.Empty;
            textel.Text = string.Empty;
            textcell.Text = string.Empty;
            textmail.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textcalle.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            textBox13.Text = string.Empty;
            textBox14.Text = string.Empty;
            textBox15.Text = string.Empty;
            textBox16.Text = string.Empty;
            comboestadocivil.Text = string.Empty;
            combogenero.Text = string.Empty;

        }

        private void textel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO NÚMEROS");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textcell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO NÚMEROS");
            }
        }

        public void llenar_materias ()
        {
            //materia 1
            MySqlCommand cmd = new MySqlCommand("SELECT idMateria,Materia FROM Materia", cone);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.Close();

            DataRow fila = dt.NewRow();
            fila["Materia"] = "";
            dt.Rows.InsertAt(fila, 0);

            comboBox1.ValueMember = "idMateria";
            comboBox1.DisplayMember = "Materia";
            comboBox1.DataSource = dt;

            // Materia 2
            MySqlCommand cmd1 = new MySqlCommand("SELECT idMateria,Materia FROM Materia", cone);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cone.Close();

            DataRow fila1 = dt1.NewRow();
            fila1["Materia"] = "";
            dt1.Rows.InsertAt(fila1, 0);

            comboBox2.ValueMember = "idMateria";
            comboBox2.DisplayMember = "Materia";
            comboBox2.DataSource = dt1;

             //materia 4
            MySqlCommand cmd2 = new MySqlCommand("SELECT idMateria,Materia FROM Materia", cone);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cone.Close();

            DataRow fila2 = dt2.NewRow();
            fila2["Materia"] = "";
            dt2.Rows.InsertAt(fila2, 0);

            comboBox3.ValueMember = "idMateria";
            comboBox3.DisplayMember = "Materia";
            comboBox3.DataSource = dt2;

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(e.KeyChar=='/')
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO NÚMEROS o /");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO NÚMEROS");
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO NÚMEROS");
            }
        }
    }
    
}