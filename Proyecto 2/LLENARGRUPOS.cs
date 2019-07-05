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
using word = Microsoft.Office.Interop.Word;

namespace Proyecto_2
{
    public partial class LLENARGRUPOS : Form
    {
        MySqlConnection cone = new MySqlConnection("server = localhost; uid = root;" + "pwd = 307277891 ; database = Horarios;");

        public LLENARGRUPOS()
        {
            InitializeComponent();
            llenar_hora();
            llenar_dias();
            llenar_semestre();
            llenar_turno();
            llenar_salon();
            llena_especializacion();
            llenar_grupo();
            llenar_SALONE();
        }
        //LLENAR OTROS SALONES
        public void llenar_SALONE()
        {

            // LLENA HORA 1
            cone.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT idSalonE,SalonE FROM SalonE", cone);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.Close();

            DataRow fila = dt.NewRow();
            fila["SalonE"] = "";
            dt.Rows.InsertAt(fila, 0);

            comboBox37.ValueMember = "idSalonE";
            comboBox37.DisplayMember = "SalonE";
            comboBox37.DataSource = dt;


            // LLENA HORA 2
            cone.Open();
            MySqlCommand cmd1 = new MySqlCommand("SELECT idSalonE,SalonE FROM SalonE", cone);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cone.Close();

            DataRow fila1 = dt1.NewRow();
            fila1["SalonE"] = "";
            dt1.Rows.InsertAt(fila1, 0);

            comboBox36.ValueMember = "idSalonE";
            comboBox36.DisplayMember = "SalonE";
            comboBox36.DataSource = dt1;

            //LLENA HORA 3
            cone.Open();
            MySqlCommand cmd2 = new MySqlCommand("SELECT idSalonE,SalonE FROM SalonE", cone);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cone.Close();

            DataRow fila2 = dt2.NewRow();
            fila2["SalonE"] = "";
            dt2.Rows.InsertAt(fila2, 0);

            comboBox35.ValueMember = "idSalonE";
            comboBox35.DisplayMember = "SalonE";
            comboBox35.DataSource = dt2;

            //LLENA HORA 4
            cone.Open();
            MySqlCommand cmd3 = new MySqlCommand("SELECT idSalonE,SalonE FROM SalonE", cone);
            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            cone.Close();

            DataRow fila3 = dt3.NewRow();
            fila3["SalonE"] = "";
            dt3.Rows.InsertAt(fila3, 0);

            comboBox34.ValueMember = "idSalonE";
            comboBox34.DisplayMember = "SalonE";
            comboBox34.DataSource = dt3;

            //LLENA HORA 5
            cone.Open();
            MySqlCommand cmd4 = new MySqlCommand("SELECT idSalonE,SalonE FROM SalonE", cone);
            MySqlDataAdapter da4 = new MySqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            cone.Close();

            DataRow fila4 = dt4.NewRow();
            fila4["SalonE"] = "";
            dt4.Rows.InsertAt(fila4, 0);

            comboBox33.ValueMember = "idSalonE";
            comboBox33.DisplayMember = "SalonE";
            comboBox33.DataSource = dt4;

            //LLENA HORA 6
            cone.Open();
            MySqlCommand cmd5 = new MySqlCommand("SELECT idSalonE,SalonE FROM SalonE", cone);
            MySqlDataAdapter da5 = new MySqlDataAdapter(cmd5);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            cone.Close();

            DataRow fila5 = dt5.NewRow();
            fila5["SalonE"] = "";
            dt5.Rows.InsertAt(fila5, 0);

            comboBox32.ValueMember = "idSalonE";
            comboBox32.DisplayMember = "SalonE";
            comboBox32.DataSource = dt5;

            //LLENA HORA 7
            cone.Open();
            MySqlCommand cmd6 = new MySqlCommand("SELECT idSalonE,SalonE FROM SalonE", cone);
            MySqlDataAdapter da6 = new MySqlDataAdapter(cmd6);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            cone.Close();

            DataRow fila6 = dt6.NewRow();
            fila6["SalonE"] = "";
            dt6.Rows.InsertAt(fila6, 0);

            comboBox31.ValueMember = "idSalonE";
            comboBox31.DisplayMember = "SalonE";
            comboBox31.DataSource = dt6;

            //LLENA HORA 8
            cone.Open();
            MySqlCommand cmd7 = new MySqlCommand("SELECT idSalonE,SalonE FROM SalonE", cone);
            MySqlDataAdapter da7 = new MySqlDataAdapter(cmd7);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            cone.Close();

            DataRow fila7 = dt7.NewRow();
            fila7["SalonE"] = "";
            dt7.Rows.InsertAt(fila7, 0);

            comboBox30.ValueMember = "idSalonE";
            comboBox30.DisplayMember = "SalonE";
            comboBox30.DataSource = dt7;

            //LLENA HORA 9
            cone.Open();
            MySqlCommand cmd8 = new MySqlCommand("SELECT idSalonE,SalonE FROM SalonE", cone);
            MySqlDataAdapter da8 = new MySqlDataAdapter(cmd8);
            DataTable dt8 = new DataTable();
            da8.Fill(dt8);
            cone.Close();

            DataRow fila8 = dt8.NewRow();
            fila8["SalonE"] = "";
            dt8.Rows.InsertAt(fila8, 0);

            comboBox29.ValueMember = "idSalonE";
            comboBox29.DisplayMember = "SalonE";
            comboBox29.DataSource = dt8;
        }
        //LENA HORA 
        public void llenar_hora ()
        {

            // LLENA HORA 1
            cone.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT idHora,hora FROM hora", cone);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.Close();

            DataRow fila = dt.NewRow();
            fila["hora"] = "";
            dt.Rows.InsertAt(fila, 0);

            comboBox11.ValueMember = "idHora";
            comboBox11.DisplayMember = "hora";
            comboBox11.DataSource = dt;


            // LLENA HORA 2
            cone.Open();
            MySqlCommand cmd1 = new MySqlCommand("SELECT idHora,hora FROM hora", cone);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cone.Close();

            DataRow fila1 = dt1.NewRow();
            fila1["hora"] = "";
            dt1.Rows.InsertAt(fila1, 0);

            comboBox12.ValueMember = "idHora";
            comboBox12.DisplayMember = "hora";
            comboBox12.DataSource = dt1;

            //LLENA HORA 3
            cone.Open();
            MySqlCommand cmd2 = new MySqlCommand("SELECT idHora,hora FROM hora", cone);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cone.Close();

            DataRow fila2 = dt2.NewRow();
            fila2["hora"] = "";
            dt2.Rows.InsertAt(fila2, 0);

            comboBox13.ValueMember = "idHora";
            comboBox13.DisplayMember = "hora";
            comboBox13.DataSource = dt2;

            //LLENA HORA 4
            cone.Open();
            MySqlCommand cmd3 = new MySqlCommand("SELECT idHora,hora FROM hora", cone);
            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            cone.Close();

            DataRow fila3 = dt3.NewRow();
            fila3["hora"] = "";
            dt3.Rows.InsertAt(fila3, 0);

            comboBox14.ValueMember = "idHora";
            comboBox14.DisplayMember = "hora";
            comboBox14.DataSource = dt3;

            //LLENA HORA 5
            cone.Open();
            MySqlCommand cmd4 = new MySqlCommand("SELECT idHora,hora FROM hora", cone);
            MySqlDataAdapter da4 = new MySqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            cone.Close();

            DataRow fila4 = dt4.NewRow();
            fila4["hora"] = "";
            dt4.Rows.InsertAt(fila4, 0);

            comboBox15.ValueMember = "idHora";
            comboBox15.DisplayMember = "hora";
            comboBox15.DataSource = dt4;

            //LLENA HORA 6
            cone.Open();
            MySqlCommand cmd5 = new MySqlCommand("SELECT idHora,hora FROM hora", cone);
            MySqlDataAdapter da5 = new MySqlDataAdapter(cmd5);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            cone.Close();

            DataRow fila5 = dt5.NewRow();
            fila5["hora"] = "";
            dt5.Rows.InsertAt(fila5, 0);

            comboBox16.ValueMember = "idHora";
            comboBox16.DisplayMember = "hora";
            comboBox16.DataSource = dt5;

            //LLENA HORA 7
            cone.Open();
            MySqlCommand cmd6 = new MySqlCommand("SELECT idHora,hora FROM hora", cone);
            MySqlDataAdapter da6 = new MySqlDataAdapter(cmd6);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            cone.Close();

            DataRow fila6 = dt6.NewRow();
            fila6["hora"] = "";
            dt6.Rows.InsertAt(fila6, 0);

            comboBox56.ValueMember = "idHora";
            comboBox56.DisplayMember = "hora";
            comboBox56.DataSource = dt6;

            //LLENA HORA 8
            cone.Open();
            MySqlCommand cmd7 = new MySqlCommand("SELECT idHora,hora FROM hora", cone);
            MySqlDataAdapter da7 = new MySqlDataAdapter(cmd7);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            cone.Close();

            DataRow fila7 = dt7.NewRow();
            fila7["hora"] = "";
            dt7.Rows.InsertAt(fila7, 0);

            comboBox55.ValueMember = "idHora";
            comboBox55.DisplayMember = "hora";
            comboBox55.DataSource = dt7;

            //LLENA HORA 9
            cone.Open();
            MySqlCommand cmd8 = new MySqlCommand("SELECT idHora,hora FROM hora", cone);
            MySqlDataAdapter da8 = new MySqlDataAdapter(cmd8);
            DataTable dt8 = new DataTable();
            da8.Fill(dt8);
            cone.Close();

            DataRow fila8 = dt8.NewRow();
            fila8["hora"] = "";
            dt8.Rows.InsertAt(fila8, 0);

            comboBox54.ValueMember = "idHora";
            comboBox54.DisplayMember = "hora";
            comboBox54.DataSource = dt8;

        }
        // lena dias 
        public void llenar_dias()
        {

            //LLENAR DIA 1
            cone.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT idDia,Dia FROM Dia", cone);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.Close();

            DataRow fila = dt.NewRow();
            fila["Dia"] = "";
            dt.Rows.InsertAt(fila, 0);

            comboBox17.ValueMember = "idDia";
            comboBox17.DisplayMember = "Dia";
            comboBox17.DataSource = dt;

            //LLENA DIA 2
            cone.Open();
            MySqlCommand cmd1 = new MySqlCommand("SELECT idDia,Dia FROM Dia", cone);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cone.Close();

            DataRow fila1 = dt1.NewRow();
            fila1["Dia"] = "";
            dt1.Rows.InsertAt(fila1, 0);

            comboBox22.ValueMember = "idDia";
            comboBox22.DisplayMember = "Dia";
            comboBox22.DataSource = dt1;

            //LLENA DIA 3
            cone.Open();
            MySqlCommand cmd2 = new MySqlCommand("SELECT idDia,Dia FROM Dia", cone);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cone.Close();

            DataRow fila2 = dt2.NewRow();
            fila2["Dia"] = "";
            dt2.Rows.InsertAt(fila2, 0);

            comboBox21.ValueMember = "idDia";
            comboBox21.DisplayMember = "Dia";
            comboBox21.DataSource = dt2;

            //LLENA DIA 4
            cone.Open();
            MySqlCommand cmd3 = new MySqlCommand("SELECT idDia,Dia FROM Dia", cone);
            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            cone.Close();

            DataRow fila3 = dt3.NewRow();
            fila3["Dia"] = "";
            dt3.Rows.InsertAt(fila3, 0);

            comboBox20.ValueMember = "idDia";
            comboBox20.DisplayMember = "Dia";
            comboBox20.DataSource = dt3;

            //LLENA DIA 5
            cone.Open();
            MySqlCommand cmd4 = new MySqlCommand("SELECT idDia,Dia FROM Dia", cone);
            MySqlDataAdapter da4 = new MySqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            cone.Close();

            DataRow fila4 = dt4.NewRow();
            fila4["Dia"] = "";
            dt4.Rows.InsertAt(fila4, 0);

            comboBox19.ValueMember = "idDia";
            comboBox19.DisplayMember = "Dia";
            comboBox19.DataSource = dt4;

            //LLENA DIA 6
            cone.Open();
            MySqlCommand cmd5 = new MySqlCommand("SELECT idDia,Dia FROM Dia", cone);
            MySqlDataAdapter da5 = new MySqlDataAdapter(cmd5);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            cone.Close();

            DataRow fila5 = dt5.NewRow();
            fila5["Dia"] = "";
            dt5.Rows.InsertAt(fila5, 0);

            comboBox18.ValueMember = "idDia";
            comboBox18.DisplayMember = "Dia";
            comboBox18.DataSource = dt5;

            //LLENA DIA 7
            cone.Open();
            MySqlCommand cmd6 = new MySqlCommand("SELECT idDia,Dia FROM Dia", cone);
            MySqlDataAdapter da6 = new MySqlDataAdapter(cmd6);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            cone.Close();

            DataRow fila6 = dt6.NewRow();
            fila6["Dia"] = "";
            dt6.Rows.InsertAt(fila6, 0);

            comboBox51.ValueMember = "idDia";
            comboBox51.DisplayMember = "Dia";
            comboBox51.DataSource = dt6;

            //LLENA DIA 8
            cone.Open();
            MySqlCommand cmd7 = new MySqlCommand("SELECT idDia,Dia FROM Dia", cone);
            MySqlDataAdapter da7 = new MySqlDataAdapter(cmd7);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            cone.Close();

            DataRow fila7 = dt7.NewRow();
            fila7["Dia"] = "";
            dt7.Rows.InsertAt(fila7, 0);

            comboBox52.ValueMember = "idDia";
            comboBox52.DisplayMember = "Dia";
            comboBox52.DataSource = dt7;

            //LLENA DIA 9
            cone.Open();
            MySqlCommand cmd8 = new MySqlCommand("SELECT idDia,Dia FROM Dia", cone);
            MySqlDataAdapter da8 = new MySqlDataAdapter(cmd8);
            DataTable dt8 = new DataTable();
            da8.Fill(dt8);
            cone.Close();

            DataRow fila8 = dt8.NewRow();
            fila8["Dia"] = "";
            dt8.Rows.InsertAt(fila8, 0);

            comboBox53.ValueMember = "idDia";
            comboBox53.DisplayMember = "Dia";
            comboBox53.DataSource = dt8;

        }
        //Lena Semestre 
        public void llenar_semestre()
        {
            // LLENA HORA 1
            cone.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT idSemestre,Semestre FROM Semestre", cone);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.Close();

            DataRow fila = dt.NewRow();
            fila["Semestre"] = "";
            dt.Rows.InsertAt(fila, 0);

            comboBox7.ValueMember = "idSemestre";
            comboBox7.DisplayMember = "Semestre";
            comboBox7.DataSource = dt;

        }
        // llena salon
        public void llenar_salon ()
        {
            cone.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT idSalon,Salon FROM Salon", cone);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.Close();

            DataRow fila = dt.NewRow();
            fila["Salon"] = "";
            dt.Rows.InsertAt(fila, 0);

            comboBox8.ValueMember = "idSalon";
            comboBox8.DisplayMember = "Salon";
            comboBox8.DataSource = dt;

        }
        //llena turno
        public void llenar_turno ()
        {
            // LLENA HORA 1
            cone.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT idTurno,Turno FROM Turno", cone);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.Close();

            DataRow fila = dt.NewRow();
            fila["Turno"] = "";
            dt.Rows.InsertAt(fila, 0);

            comboBox10.ValueMember = "idTurno";
            comboBox10.DisplayMember = "Turno";
            comboBox10.DataSource = dt;

        }
        //llena grupo
        public void llenar_grupo ()
        {
            cone.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT idGrupo,Grupo FROM Grrupos", cone);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.Close();

            DataRow fila = dt.NewRow();
            fila["Grupo"] = "";
            dt.Rows.InsertAt(fila, 0);

            comboBox9.ValueMember = "idGrupo";
            comboBox9.DisplayMember = "Grupo";
            comboBox9.DataSource = dt;
        }   
        //llena especializacion 
        public void llena_especializacion()
        {
            cone.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT idEspecialidad,Especialidad FROM Especialidad", cone);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.Close();

            DataRow fila = dt.NewRow();
            fila["Especialidad"] = "";
            dt.Rows.InsertAt(fila, 0);

            comboBox41.ValueMember = "idEspecialidad";
            comboBox41.DisplayMember = "Especialidad";
            comboBox41.DataSource = dt;

        }
        
        //GUARDA EN LA BASE DE DATOS
        private void button1_Click(object sender, EventArgs e)
        {
            cone.Open();
            MySqlCommand llenar_grupo = new MySqlCommand($" INSERT INTO Grupo (Grupo, Turno, Especialidad, Salon, Semestre, Maestro1, Materia1,  SalonE1,  Hora1,  Dias1, Maestro2, Materia2,  SalonE2,  Hora2,  Dias2, Maestro3, Materia3,  SalonE3,  Hora3,  Dias3, Maestro4, Materia4,  SalonE4,  Hora4,  Dias4, Maestro5, Materia5,  SalonE5,  Hora5,  Dias5, Maestro6, Materia6,  SalonE6,  Hora6,  Dias6, Maestro7, Materia7,  SalonE7,  Hora7,  Dias7, Maestro8, Materia8,  SalonE8,  Hora8,  Dias8, Maestro9, Materia9,  SalonE9,  Hora9,  Dias9) values ('{comboBox9.Text}','{comboBox10.Text}','{comboBox41.Text}', '{comboBox8.Text}', '{comboBox7.Text}', '{comboBox1.Text}', '{comboBox23.Text}', '{comboBox37.Text}', '{comboBox11.Text}', '{comboBox17.Text}', '{comboBox2.Text}', '{comboBox28.Text}', '{comboBox36.Text}', '{comboBox12.Text}', '{comboBox22.Text}', '{comboBox3.Text}', '{comboBox27.Text}', '{comboBox35.Text}', '{comboBox13.Text}', '{comboBox21.Text}', '{comboBox4.Text}', '{comboBox26.Text}', '{comboBox34.Text}', '{comboBox14.Text}', '{comboBox20.Text}', '{comboBox5.Text}', '{comboBox25.Text}', '{comboBox33.Text}', '{comboBox15.Text}', '{comboBox19.Text}', '{comboBox6.Text}', '{comboBox24.Text}', '{comboBox32.Text}', '{comboBox16.Text}', '{comboBox18.Text}', '{comboBox59.Text}', '{comboBox48.Text}', '{comboBox31.Text}', '{comboBox56.Text}', '{comboBox51.Text}', '{comboBox54.Text}', '{comboBox49.Text}', '{comboBox30.Text}', '{comboBox55.Text}', '{comboBox52.Text}', '{comboBox57.Text}', '{comboBox50.Text}', '{comboBox29.Text}', '{comboBox54.Text}', '{comboBox53.Text}')", cone);
            llenar_grupo.ExecuteNonQuery();
            cone.Close();

            MessageBox.Show("GRUPO GUARDADO");
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            comboBox10.SelectedIndex = -1;
            comboBox11.SelectedIndex = -1;
            comboBox12.SelectedIndex = -1;
            comboBox13.SelectedIndex = -1;
            comboBox14.SelectedIndex = -1;
            comboBox15.SelectedIndex = -1;
            comboBox16.SelectedIndex = -1;
            comboBox17.SelectedIndex = -1;
            comboBox18.SelectedIndex = -1;
            comboBox19.SelectedIndex = -1;
            comboBox20.SelectedIndex = -1;
            comboBox21.SelectedIndex = -1;
            comboBox22.SelectedIndex = -1;
            comboBox23.SelectedIndex = -1;
            comboBox24.SelectedIndex = -1;
            comboBox25.SelectedIndex = -1;
            comboBox26.SelectedIndex = -1;
            comboBox27.SelectedIndex = -1;
            comboBox28.SelectedIndex = -1;
            comboBox29.SelectedIndex = -1;
            comboBox30.SelectedIndex = -1;
            comboBox31.SelectedIndex = -1;
            comboBox32.SelectedIndex = -1;
            comboBox33.SelectedIndex = -1;
            comboBox34.SelectedIndex = -1;
            comboBox35.SelectedIndex = -1;
            comboBox36.SelectedIndex = -1;
            comboBox37.SelectedIndex = -1;
            comboBox41.SelectedIndex = -1;
            comboBox48.SelectedIndex = -1;
            comboBox49.SelectedIndex = -1;
            comboBox50.SelectedIndex = -1;
            comboBox51.SelectedIndex = -1;
            comboBox52.SelectedIndex = -1;
            comboBox53.SelectedIndex = -1;
            comboBox54.SelectedIndex = -1;
            comboBox55.SelectedIndex = -1;
            comboBox56.SelectedIndex = -1;
            comboBox57.SelectedIndex = -1;
            comboBox58.SelectedIndex = -1;
            comboBox59.SelectedIndex = -1;
        }
        //BOTON REGRESAR
        private void button4_Click_1(object sender, EventArgs e)
        {
            VENTANASELECCION regdesmas = new VENTANASELECCION();
            regdesmas.Show();
            Close();
        }

        //BOTON SALIR
        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //COMPRUEBA QUE NO SE REPITAN HORAS 
        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox11.Text;

            if (compara != "")
            {
                if (compara == comboBox12.Text || compara == comboBox13.Text || compara == comboBox14.Text || compara == comboBox15.Text || compara == comboBox16.Text || compara == comboBox56.Text || compara == comboBox55.Text || compara == comboBox54.Text)
                {
                    MessageBox.Show("HORA YA ASIGNADA");
                }
            }
        }
        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox12.Text;

            if (compara != "")
            {
                if (compara == comboBox11.Text || compara == comboBox13.Text || compara == comboBox14.Text || compara == comboBox15.Text || compara == comboBox16.Text || compara == comboBox56.Text || compara == comboBox55.Text || compara == comboBox54.Text)
                {
                    MessageBox.Show("HORA YA ASIGNADA");
                }
            }
        }
        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox13.Text;

            if (compara != "")
            {
                if (compara == comboBox12.Text || compara == comboBox11.Text || compara == comboBox14.Text || compara == comboBox15.Text || compara == comboBox16.Text || compara == comboBox56.Text || compara == comboBox55.Text || compara == comboBox54.Text)
                {
                    MessageBox.Show("HORA YA ASIGNADA");
                }
            }
        }
        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox14.Text;

            if (compara != "")
            {
                if (compara == comboBox12.Text || compara == comboBox13.Text || compara == comboBox11.Text || compara == comboBox15.Text || compara == comboBox16.Text || compara == comboBox56.Text || compara == comboBox55.Text || compara == comboBox54.Text)
                {
                    MessageBox.Show("HORA YA ASIGNADA");
                }
            }
        }
        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox15.Text;

            if (compara != "")
            {
                if (compara == comboBox12.Text || compara == comboBox13.Text || compara == comboBox14.Text || compara == comboBox11.Text || compara == comboBox16.Text || compara == comboBox56.Text || compara == comboBox55.Text || compara == comboBox54.Text)
                {
                    MessageBox.Show("HORA YA ASIGNADA");
                }
            }
        }
        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox16.Text;

            if (compara != "")
            {
                if (compara == comboBox12.Text || compara == comboBox13.Text || compara == comboBox14.Text || compara == comboBox15.Text || compara == comboBox11.Text || compara == comboBox56.Text || compara == comboBox55.Text || compara == comboBox54.Text)
                {
                    MessageBox.Show("HORA YA ASIGNADA");
                }
            }
        }
        private void comboBox56_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox56.Text;

            if (compara != "")
            {
                if (compara == comboBox12.Text || compara == comboBox13.Text || compara == comboBox14.Text || compara == comboBox15.Text || compara == comboBox16.Text || compara == comboBox11.Text || compara == comboBox55.Text || compara == comboBox54.Text)
                {
                    MessageBox.Show("HORA YA ASIGNADA");
                }
            }
        }
        private void comboBox55_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox55.Text;

            if (compara != "")
            {
                if (compara == comboBox12.Text || compara == comboBox13.Text || compara == comboBox14.Text || compara == comboBox15.Text || compara == comboBox16.Text || compara == comboBox56.Text || compara == comboBox11.Text || compara == comboBox54.Text)
                {
                    MessageBox.Show("HORA YA ASIGNADA");
                }
            }
        }
        private void comboBox54_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox54.Text;

            if (compara != "")
            {
                if (compara == comboBox12.Text || compara == comboBox13.Text || compara == comboBox14.Text || compara == comboBox15.Text || compara == comboBox16.Text || compara == comboBox56.Text || compara == comboBox55.Text || compara == comboBox11.Text)
                {
                    MessageBox.Show("HORA YA ASIGNADA");
                }
            }
        }
        //llena materias
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox1.Text;
            int resultado1;
            if (compara != "")
            {
                cone.Open();
                MySqlCommand cmd = new MySqlCommand("select idProfesor from profesor where concat(Nombre,' ',ApellidoP,' ',ApellidoM) ='" + comboBox1.Text + "'", cone);
                resultado1 = (int)cmd.ExecuteScalar();
                llenar_materias(resultado1);

                cone.Close();


                if (comboBox1.Text==comboBox2.Text|| comboBox1.Text == comboBox3.Text ||comboBox1.Text == comboBox4.Text || comboBox1.Text == comboBox5.Text || comboBox1.Text == comboBox6.Text || comboBox1.Text == comboBox59.Text || comboBox1.Text == comboBox58.Text || comboBox1.Text == comboBox57.Text)
                {
                    MessageBox.Show("Profesor ya asignado");
                }
            }
        }
        public void llenar_materias(int resultado1)
        {
            //llena materia 1
            MySqlCommand cmd94 = new MySqlCommand("select Materia.idMateria,Materia from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where semestre.Semestre=  '" + comboBox7.Text + "' and profesor.idProfesor = @idSemestre ", cone);
            cmd94.Parameters.AddWithValue("idSemestre", resultado1);
            MySqlDataAdapter da94 = new MySqlDataAdapter(cmd94);
            DataTable dt94 = new DataTable();
            da94.Fill(dt94);
            cone.Close();

            DataRow fila94 = dt94.NewRow();
            fila94[columnName: "Materia"] = "";
            dt94.Rows.InsertAt(fila94, 0);

            comboBox23.DisplayMember = "Materia";
            comboBox23.DataSource = dt94;
        }
        public void llenar_materias3(int resultado1)
        {
            //llena materia 3
            MySqlCommand cmd94 = new MySqlCommand("select Materia.idMateria,Materia from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where semestre.Semestre=  '" + comboBox7.Text + "' and profesor.idProfesor = @idSemestre ", cone);
            cmd94.Parameters.AddWithValue("idSemestre", resultado1);
            MySqlDataAdapter da94 = new MySqlDataAdapter(cmd94);
            DataTable dt94 = new DataTable();
            da94.Fill(dt94);
            cone.Close();

            DataRow fila94 = dt94.NewRow();
            fila94[columnName: "Materia"] = "";
            dt94.Rows.InsertAt(fila94, 0);

            comboBox27.DisplayMember = "Materia";
            comboBox27.DataSource = dt94;
        }
        public void llenar_materias2(int resultado1 )
        {

            //llena materia 2
            MySqlCommand cmd941 = new MySqlCommand("select Materia.idMateria,Materia from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where semestre.Semestre=  '" + comboBox7.Text + "' and profesor.idProfesor = @idSemestre ", cone);
            cmd941.Parameters.AddWithValue("idSemestre", resultado1);
            MySqlDataAdapter da941 = new MySqlDataAdapter(cmd941);
            DataTable dt941 = new DataTable();
            da941.Fill(dt941);
            cone.Close();

            DataRow fila941 = dt941.NewRow();
            fila941[columnName: "Materia"] = "";
            dt941.Rows.InsertAt(fila941, 0);

            comboBox28.DisplayMember = "Materia";
            comboBox28.DataSource = dt941;

        }

        //llena maestros
        public void llenar_maestro(int resultado)
        {
            //llena profe 1
            MySqlCommand cmd84 = new MySqlCommand("select Profesor.idProfesor,concat(Nombre,' ',ApellidoP,' ',ApellidoM) as Nombre from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where Semestre.idSemestre  = @idSemestre ", cone);
            cmd84.Parameters.AddWithValue("idSemestre", resultado);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd84);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.Close();

            DataRow fila = dt.NewRow();
            fila[columnName: "Nombre"] = "";
            dt.Rows.InsertAt(fila, 0);

            //comboBox9.ValueMember = "Profesor.idProfesor";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = dt;

            //llena profe 2
            MySqlCommand cmd841 = new MySqlCommand("select Profesor.idProfesor,concat(Nombre,' ',ApellidoP,' ',ApellidoM) as Nombre from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where Semestre.idSemestre  = @idSemestre ", cone);
            cmd841.Parameters.AddWithValue("idSemestre", resultado);
            MySqlDataAdapter da841 = new MySqlDataAdapter(cmd841);
            DataTable dt841 = new DataTable();
            da841.Fill(dt841);
            cone.Close();

            DataRow fila841 = dt841.NewRow();
            fila841[columnName: "Nombre"] = "";
            dt841.Rows.InsertAt(fila841, 0);

            //comboBox9.ValueMember = "Profesor.idProfesor";
            comboBox2.DisplayMember = "Nombre";
            comboBox2.DataSource = dt841;

            //llena profe 3
            MySqlCommand cmd842 = new MySqlCommand("select Profesor.idProfesor,concat(Nombre,' ',ApellidoP,' ',ApellidoM) as Nombre from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where Semestre.idSemestre  = @idSemestre ", cone);
            cmd842.Parameters.AddWithValue("idSemestre", resultado);
            MySqlDataAdapter da842 = new MySqlDataAdapter(cmd842);
            DataTable dt842 = new DataTable();
            da842.Fill(dt842);
            cone.Close();

            DataRow fila842 = dt842.NewRow();
            fila842[columnName: "Nombre"] = "";
            dt842.Rows.InsertAt(fila842, 0);

            //comboBox9.ValueMember = "Profesor.idProfesor";
            comboBox3.DisplayMember = "Nombre";
            comboBox3.DataSource = dt842;

            //llena profe 4
            MySqlCommand cmd843 = new MySqlCommand("select Profesor.idProfesor,concat(Nombre,' ',ApellidoP,' ',ApellidoM) as Nombre from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where Semestre.idSemestre  = @idSemestre ", cone);
            cmd843.Parameters.AddWithValue("idSemestre", resultado);
            MySqlDataAdapter da843 = new MySqlDataAdapter(cmd843);
            DataTable dt843 = new DataTable();
            da843.Fill(dt843);
            cone.Close();

            DataRow fila843 = dt843.NewRow();
            fila843[columnName: "Nombre"] = "";
            dt843.Rows.InsertAt(fila843, 0);

            //comboBox9.ValueMember = "Profesor.idProfesor";
            comboBox4.DisplayMember = "Nombre";
            comboBox4.DataSource = dt843;

            //llena profe 5
            MySqlCommand cmd844 = new MySqlCommand("select Profesor.idProfesor,concat(Nombre,' ',ApellidoP,' ',ApellidoM) as Nombre from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where Semestre.idSemestre  = @idSemestre ", cone);
            cmd844.Parameters.AddWithValue("idSemestre", resultado);
            MySqlDataAdapter da844 = new MySqlDataAdapter(cmd844);
            DataTable dt844 = new DataTable();
            da844.Fill(dt844);
            cone.Close();

            DataRow fila844 = dt844.NewRow();
            fila844[columnName: "Nombre"] = "";
            dt844.Rows.InsertAt(fila844, 0);

            //comboBox9.ValueMember = "Profesor.idProfesor";
            comboBox5.DisplayMember = "Nombre";
            comboBox5.DataSource = dt844;

            //llena profe 6
            MySqlCommand cmd845 = new MySqlCommand("select Profesor.idProfesor,concat(Nombre,' ',ApellidoP,' ',ApellidoM) as Nombre from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where Semestre.idSemestre  = @idSemestre ", cone);
            cmd845.Parameters.AddWithValue("idSemestre", resultado);
            MySqlDataAdapter da845 = new MySqlDataAdapter(cmd845);
            DataTable dt845 = new DataTable();
            da845.Fill(dt845);
            cone.Close();

            DataRow fila845 = dt845.NewRow();
            fila845[columnName: "Nombre"] = "";
            dt845.Rows.InsertAt(fila845, 0);

            //comboBox9.ValueMember = "Profesor.idProfesor";
            comboBox6.DisplayMember = "Nombre";
            comboBox6.DataSource = dt845;

            //llena profe 7
            MySqlCommand cmd846 = new MySqlCommand("select Profesor.idProfesor,concat(Nombre,' ',ApellidoP,' ',ApellidoM) as Nombre from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where Semestre.idSemestre  = @idSemestre ", cone);
            cmd846.Parameters.AddWithValue("idSemestre", resultado);
            MySqlDataAdapter da846 = new MySqlDataAdapter(cmd846);
            DataTable dt846 = new DataTable();
            da846.Fill(dt846);
            cone.Close();

            DataRow fila846 = dt846.NewRow();
            fila846[columnName: "Nombre"] = "";
            dt846.Rows.InsertAt(fila846, 0);

            //comboBox9.ValueMember = "Profesor.idProfesor";
            comboBox59.DisplayMember = "Nombre";
            comboBox59.DataSource = dt846;

            //llena profe 8
            MySqlCommand cmd847 = new MySqlCommand("select Profesor.idProfesor, concat(Nombre,' ',ApellidoP,' ',ApellidoM) as Nombre from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where Semestre.idSemestre  = @idSemestre ", cone);
            cmd847.Parameters.AddWithValue("idSemestre", resultado);
            MySqlDataAdapter da847 = new MySqlDataAdapter(cmd847);
            DataTable dt847 = new DataTable();
            da847.Fill(dt847);
            cone.Close();

            DataRow fila847 = dt847.NewRow();
            fila847[columnName: "Nombre"] = "";
            dt847.Rows.InsertAt(fila847, 0);

            //comboBox9.ValueMember = "Profesor.idProfesor";
            comboBox58.DisplayMember = "Nombre";
            comboBox58.DataSource = dt847;


            //llena profe 9
            MySqlCommand cmd848 = new MySqlCommand("select Profesor.idProfesor,concat(Nombre,' ',ApellidoP,' ',ApellidoM) as Nombre from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where Semestre.idSemestre  = @idSemestre ", cone);
            cmd848.Parameters.AddWithValue("idSemestre", resultado);
            MySqlDataAdapter da848 = new MySqlDataAdapter(cmd848);
            DataTable dt848 = new DataTable();
            da848.Fill(dt848);
            cone.Close();

            DataRow fila848 = dt848.NewRow();
            fila848[columnName: "Nombre"] = "";
            dt848.Rows.InsertAt(fila848, 0);

            //comboBox9.ValueMember = "Profesor.idProfesor";
            comboBox57.DisplayMember = "Nombre";
            comboBox57.DataSource = dt848;
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox7.Text;
            int resultado;
            if (compara != "")
            {
                cone.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT idSemestre FROM Semestre WHERE Semestre = '" + comboBox7.Text + "'", cone);
                resultado = (int)cmd.ExecuteScalar();
                llenar_maestro(resultado);
                cone.Close();

            }

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox2.Text;
            int resultado1;
            if (compara != "")
            {
                cone.Open();
                MySqlCommand cmd = new MySqlCommand("select idProfesor from profesor where concat(Nombre,' ',ApellidoP,' ',ApellidoM) = '" + comboBox2.Text + "'", cone);
                resultado1 = (int)cmd.ExecuteScalar();
                llenar_materias2(resultado1);

                cone.Close();


                if (comboBox2.Text == comboBox1.Text || comboBox2.Text == comboBox3.Text || comboBox2.Text == comboBox4.Text || comboBox2.Text == comboBox5.Text || comboBox2.Text == comboBox6.Text || comboBox2.Text == comboBox59.Text || comboBox2.Text == comboBox58.Text || comboBox2.Text == comboBox57.Text)
                {
                    MessageBox.Show("Profesor ya asignado");
                }
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox3.Text;
            int resultado1;
            if (compara != "")
            {
                cone.Open();
                MySqlCommand cmd = new MySqlCommand("select idProfesor from profesor where concat(Nombre,' ',ApellidoP,' ',ApellidoM) ='" + comboBox3.Text + "'", cone);
                resultado1 = (int)cmd.ExecuteScalar();
                llenar_materias3(resultado1);

                cone.Close();


                if (comboBox3.Text == comboBox1.Text || comboBox3.Text == comboBox2.Text || comboBox3.Text == comboBox4.Text || comboBox3.Text == comboBox5.Text || comboBox3.Text == comboBox6.Text || comboBox3.Text == comboBox59.Text || comboBox3.Text == comboBox58.Text || comboBox3.Text == comboBox57.Text)
                {
                    MessageBox.Show("Profesor ya asignado");
                }
            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox4.Text;
            int resultado1;
            if (compara != "")
            {
                cone.Open();
                MySqlCommand cmd = new MySqlCommand("select idProfesor from profesor where concat(Nombre,' ',ApellidoP,' ',ApellidoM) ='" + comboBox4.Text + "'", cone);
                resultado1 = (int)cmd.ExecuteScalar();
                llenar_materias4(resultado1);
                cone.Close();
                if (comboBox4.Text == comboBox1.Text || comboBox4.Text == comboBox2.Text || comboBox4.Text == comboBox3.Text || comboBox4.Text == comboBox5.Text || comboBox4.Text == comboBox6.Text || comboBox4.Text == comboBox59.Text || comboBox4.Text == comboBox58.Text || comboBox4.Text == comboBox57.Text)
                {
                    MessageBox.Show("Profesor ya asignado");
                }
            }
        }
        public void llenar_materias4(int resultado1)
        {
            //llena materia 3
            MySqlCommand cmd94 = new MySqlCommand("select Materia.idMateria,Materia from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where semestre.Semestre=  '" + comboBox7.Text + "' and profesor.idProfesor = @idSemestre ", cone);
            cmd94.Parameters.AddWithValue("idSemestre", resultado1);
            MySqlDataAdapter da94 = new MySqlDataAdapter(cmd94);
            DataTable dt94 = new DataTable();
            da94.Fill(dt94);
            cone.Close();

            DataRow fila94 = dt94.NewRow();
            fila94[columnName: "Materia"] = "";
            dt94.Rows.InsertAt(fila94, 0);

            comboBox26.DisplayMember = "Materia";
            comboBox26.DataSource = dt94;
        }
        public void llenar_materias5(int resultado1)
        {
            //llena materia 3
            MySqlCommand cmd94 = new MySqlCommand("select Materia.idMateria,Materia from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where semestre.Semestre=  '" + comboBox7.Text + "' and profesor.idProfesor = @idSemestre ", cone);
            cmd94.Parameters.AddWithValue("idSemestre", resultado1);
            MySqlDataAdapter da94 = new MySqlDataAdapter(cmd94);
            DataTable dt94 = new DataTable();
            da94.Fill(dt94);
            cone.Close();

            DataRow fila94 = dt94.NewRow();
            fila94[columnName: "Materia"] = "";
            dt94.Rows.InsertAt(fila94, 0);

            comboBox25.DisplayMember = "Materia";
            comboBox25.DataSource = dt94;
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox5.Text;
            int resultado1;
            if (compara != "")
            {
                cone.Open();
                MySqlCommand cmd = new MySqlCommand("select idProfesor from profesor where concat(Nombre,' ',ApellidoP,' ',ApellidoM) ='" + comboBox5.Text + "'", cone);
                resultado1 = (int)cmd.ExecuteScalar();
                llenar_materias5(resultado1);

                cone.Close();


                if (comboBox5.Text == comboBox1.Text || comboBox5.Text == comboBox2.Text || comboBox5.Text == comboBox3.Text || comboBox5.Text == comboBox4.Text || comboBox5.Text == comboBox6.Text || comboBox5.Text == comboBox59.Text || comboBox5.Text == comboBox58.Text || comboBox5.Text == comboBox57.Text)
                {
                    MessageBox.Show("Profesor ya asignado");
                }
            }
        }
        public void llenar_materias6(int resultado1)
        {
            //llena materia 3
            MySqlCommand cmd94 = new MySqlCommand("select Materia.idMateria,Materia from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where semestre.Semestre=  '" + comboBox7.Text + "' and profesor.idProfesor = @idSemestre ", cone);
            cmd94.Parameters.AddWithValue("idSemestre", resultado1);
            MySqlDataAdapter da94 = new MySqlDataAdapter(cmd94);
            DataTable dt94 = new DataTable();
            da94.Fill(dt94);
            cone.Close();

            DataRow fila94 = dt94.NewRow();
            fila94[columnName: "Materia"] = "";
            dt94.Rows.InsertAt(fila94, 0);

            comboBox24.DisplayMember = "Materia";
            comboBox24.DataSource = dt94;
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox6.Text;
            int resultado1;
            if (compara != "")
            {
                cone.Open();
                MySqlCommand cmd = new MySqlCommand("select idProfesor from profesor where concat(Nombre,' ',ApellidoP,' ',ApellidoM) = '" + comboBox6.Text + "'", cone);
                resultado1 = (int)cmd.ExecuteScalar();
                llenar_materias6(resultado1);

                cone.Close();


                if (comboBox6.Text == comboBox1.Text || comboBox6.Text == comboBox2.Text || comboBox6.Text == comboBox3.Text || comboBox6.Text == comboBox4.Text || comboBox6.Text == comboBox5.Text || comboBox6.Text == comboBox59.Text || comboBox6.Text == comboBox58.Text || comboBox6.Text == comboBox57.Text)
                {
                    MessageBox.Show("Profesor ya asignado");
                }
            }
        }
        public void llenar_materias7(int resultado1)
        {
            //llena materia 3
            MySqlCommand cmd94 = new MySqlCommand("select Materia.idMateria,Materia from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where semestre.Semestre=  '" + comboBox7.Text + "' and profesor.idProfesor = @idSemestre ", cone);
            cmd94.Parameters.AddWithValue("idSemestre", resultado1);
            MySqlDataAdapter da94 = new MySqlDataAdapter(cmd94);
            DataTable dt94 = new DataTable();
            da94.Fill(dt94);
            cone.Close();

            DataRow fila94 = dt94.NewRow();
            fila94[columnName: "Materia"] = "";
            dt94.Rows.InsertAt(fila94, 0);

            comboBox48.DisplayMember = "Materia";
            comboBox48.DataSource = dt94;
        }
        private void comboBox59_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox59.Text;
            int resultado1;
            if (compara != "")
            {
                cone.Open();
                MySqlCommand cmd = new MySqlCommand("select idProfesor from profesor where concat(Nombre,' ',ApellidoP,' ',ApellidoM) = '" + comboBox59.Text + "'", cone);
                resultado1 = (int)cmd.ExecuteScalar();
                llenar_materias7(resultado1);

                cone.Close();


                if (comboBox59.Text == comboBox1.Text || comboBox59.Text == comboBox2.Text || comboBox59.Text == comboBox3.Text || comboBox59.Text == comboBox4.Text || comboBox59.Text == comboBox5.Text || comboBox59.Text == comboBox6.Text || comboBox59.Text == comboBox58.Text || comboBox59.Text == comboBox57.Text)
                {
                    MessageBox.Show("Profesor ya asignado");
                }
            }
        }
        public void llenar_materias8(int resultado1)
        {
            //llena materia 3
            MySqlCommand cmd94 = new MySqlCommand("select Materia.idMateria,Materia from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where semestre.Semestre=  '" + comboBox7.Text + "' and profesor.idProfesor = @idSemestre ", cone);
            cmd94.Parameters.AddWithValue("idSemestre", resultado1);
            MySqlDataAdapter da94 = new MySqlDataAdapter(cmd94);
            DataTable dt94 = new DataTable();
            da94.Fill(dt94);
            cone.Close();

            DataRow fila94 = dt94.NewRow();
            fila94[columnName: "Materia"] = "";
            dt94.Rows.InsertAt(fila94, 0);

            comboBox49.DisplayMember = "Materia";
            comboBox49.DataSource = dt94;
        }
        private void comboBox58_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox58.Text;
            int resultado1;
            if (compara != "")
            {
                cone.Open();
                MySqlCommand cmd = new MySqlCommand("select idProfesor from profesor where concat(Nombre,' ',ApellidoP,' ',ApellidoM) = '" + comboBox58.Text + "'", cone);
                resultado1 = (int)cmd.ExecuteScalar();
                llenar_materias8(resultado1);

                cone.Close();


                if (comboBox58.Text == comboBox1.Text || comboBox58.Text == comboBox2.Text || comboBox58.Text == comboBox3.Text || comboBox58.Text == comboBox4.Text || comboBox58.Text == comboBox5.Text || comboBox58.Text == comboBox6.Text || comboBox58.Text == comboBox59.Text || comboBox58.Text == comboBox57.Text)
                {
                    MessageBox.Show("Profesor ya asignado");
                }
            }
        }
        public void llenar_materias9(int resultado1)
        {
            //llena materia 3
            MySqlCommand cmd94 = new MySqlCommand("select Materia.idMateria,Materia from Materia_Profesor inner join Profesor on Materia_Profesor.idProfesor = Profesor.idProfesor inner join Materia on Materia_Profesor.idMateria = Materia.idMateria inner join Semestre on Materia.idSemestre = Semestre.idSemestre where semestre.Semestre=  '" + comboBox7.Text + "' and profesor.idProfesor = @idSemestre ", cone);
            cmd94.Parameters.AddWithValue("idSemestre", resultado1);
            MySqlDataAdapter da94 = new MySqlDataAdapter(cmd94);
            DataTable dt94 = new DataTable();
            da94.Fill(dt94);
            cone.Close();

            DataRow fila94 = dt94.NewRow();
            fila94[columnName: "Materia"] = "";
            dt94.Rows.InsertAt(fila94, 0);

            comboBox50.DisplayMember = "Materia";
            comboBox50.DataSource = dt94;
        }
        private void comboBox57_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox57.Text;
            int resultado1;
            if (compara != "")
            {
                cone.Open();
                MySqlCommand cmd = new MySqlCommand("select idProfesor from profesor where concat(Nombre,' ',ApellidoP,' ',ApellidoM) = '" + comboBox57.Text + "'", cone);
                resultado1 = (int)cmd.ExecuteScalar();
                llenar_materias9(resultado1);

                cone.Close();


                if (comboBox57.Text == comboBox1.Text || comboBox57.Text == comboBox2.Text || comboBox57.Text == comboBox3.Text || comboBox57.Text == comboBox4.Text || comboBox57.Text == comboBox5.Text || comboBox57.Text == comboBox6.Text || comboBox57.Text == comboBox59.Text || comboBox57.Text == comboBox58.Text)
                {
                    MessageBox.Show("Profesor ya asignado");
                }
            }
        }
       
        // que no se repitan materias
        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox23.Text;

            if (compara != "")
            {
                if (compara == comboBox28.Text || compara == comboBox27.Text || compara == comboBox26.Text || compara == comboBox25.Text || compara == comboBox24.Text || compara == comboBox48.Text || compara == comboBox49.Text || compara == comboBox50.Text)
                {
                    MessageBox.Show("MATERIA YA ASIGNADA");
                }
            }
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox28.Text;

            if (compara != "")
            {
                if (compara == comboBox23.Text || compara == comboBox27.Text || compara == comboBox26.Text || compara == comboBox25.Text || compara == comboBox24.Text || compara == comboBox48.Text || compara == comboBox49.Text || compara == comboBox50.Text)
                {
                    MessageBox.Show("MATERIA YA ASIGNADA");
                }
            }
        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox27.Text;

            if (compara != "")
            {
                if (compara == comboBox28.Text || compara == comboBox23.Text || compara == comboBox26.Text || compara == comboBox25.Text || compara == comboBox24.Text || compara == comboBox48.Text || compara == comboBox49.Text || compara == comboBox50.Text)
                {
                    MessageBox.Show("MATERIA YA ASIGNADA");
                }
            }
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox26.Text;

            if (compara != "")
            {
                if (compara == comboBox28.Text || compara == comboBox27.Text || compara == comboBox23.Text || compara == comboBox25.Text || compara == comboBox24.Text || compara == comboBox48.Text || compara == comboBox49.Text || compara == comboBox50.Text)
                {
                    MessageBox.Show("MATERIA YA ASIGNADA");
                }
            }
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox25.Text;

            if (compara != "")
            {
                if (compara == comboBox28.Text || compara == comboBox27.Text || compara == comboBox26.Text || compara == comboBox23.Text || compara == comboBox24.Text || compara == comboBox48.Text || compara == comboBox49.Text || compara == comboBox50.Text)
                {
                    MessageBox.Show("MATERIA YA ASIGNADA");
                }
            }
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox24.Text;

            if (compara != "")
            {
                if (compara == comboBox28.Text || compara == comboBox27.Text || compara == comboBox26.Text || compara == comboBox25.Text || compara == comboBox23.Text || compara == comboBox48.Text || compara == comboBox49.Text || compara == comboBox50.Text)
                {
                    MessageBox.Show("MATERIA YA ASIGNADA");
                }
            }
        }

        private void comboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox48.Text;

            if (compara != "")
            {
                if (compara == comboBox28.Text || compara == comboBox27.Text || compara == comboBox26.Text || compara == comboBox25.Text || compara == comboBox24.Text || compara == comboBox23.Text || compara == comboBox49.Text || compara == comboBox50.Text)
                {
                    MessageBox.Show("MATERIA YA ASIGNADA");
                }
            }
        }

        private void comboBox49_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox49.Text;

            if (compara != "")
            {
                if (compara == comboBox28.Text || compara == comboBox27.Text || compara == comboBox26.Text || compara == comboBox25.Text || compara == comboBox24.Text || compara == comboBox48.Text || compara == comboBox23.Text || compara == comboBox50.Text)
                {
                    MessageBox.Show("MATERIA YA ASIGNADA");
                }
            }
        }

        private void comboBox50_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox50.Text;

            if (compara != "")
            {
                if (compara == comboBox28.Text || compara == comboBox27.Text || compara == comboBox26.Text || compara == comboBox25.Text || compara == comboBox24.Text || compara == comboBox48.Text || compara == comboBox49.Text || compara == comboBox23.Text)
                {
                    MessageBox.Show("MATERIA YA ASIGNADA");
                }
            }
        }
        // NO SE REPITAN OTROS SALONES
        private void comboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox37.Text;

            if (compara != "")
            {
                if (compara == comboBox36.Text || compara == comboBox35.Text || compara == comboBox34.Text || compara == comboBox33.Text || compara == comboBox32.Text || compara == comboBox31.Text || compara == comboBox30.Text || compara == comboBox29.Text)
                {
                    MessageBox.Show("SALON YA ASIGNADO");
                }
            }
        }

        private void comboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox36.Text;

            if (compara != "")
            {
                if (compara == comboBox37.Text || compara == comboBox35.Text || compara == comboBox34.Text || compara == comboBox33.Text || compara == comboBox32.Text || compara == comboBox31.Text || compara == comboBox30.Text || compara == comboBox29.Text)
                {
                    MessageBox.Show("SALON YA ASIGNADO");
                }
            }
        }

        private void comboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox35.Text;

            if (compara != "")
            {
                if (compara == comboBox36.Text || compara == comboBox37.Text || compara == comboBox34.Text || compara == comboBox33.Text || compara == comboBox32.Text || compara == comboBox31.Text || compara == comboBox30.Text || compara == comboBox29.Text)
                {
                    MessageBox.Show("SALON YA ASIGNADO");
                }
            }
        }

        private void comboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox34.Text;

            if (compara != "")
            {
                if (compara == comboBox36.Text || compara == comboBox35.Text || compara == comboBox37.Text || compara == comboBox33.Text || compara == comboBox32.Text || compara == comboBox31.Text || compara == comboBox30.Text || compara == comboBox29.Text)
                {
                    MessageBox.Show("SALON YA ASIGNADO");
                }
            }
        }

        private void comboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox33.Text;

            if (compara != "")
            {
                if (compara == comboBox36.Text || compara == comboBox35.Text || compara == comboBox34.Text || compara == comboBox37.Text || compara == comboBox32.Text || compara == comboBox31.Text || compara == comboBox30.Text || compara == comboBox29.Text)
                {
                    MessageBox.Show("SALON YA ASIGNADO");
                }
            }
        }

        private void comboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox32.Text;

            if (compara != "")
            {
                if (compara == comboBox36.Text || compara == comboBox35.Text || compara == comboBox34.Text || compara == comboBox33.Text || compara == comboBox37.Text || compara == comboBox31.Text || compara == comboBox30.Text || compara == comboBox29.Text)
                {
                    MessageBox.Show("SALON YA ASIGNADO");
                }
            }
        }

        private void comboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox31.Text;

            if (compara != "")
            {
                if (compara == comboBox36.Text || compara == comboBox35.Text || compara == comboBox34.Text || compara == comboBox33.Text || compara == comboBox32.Text || compara == comboBox37.Text || compara == comboBox30.Text || compara == comboBox29.Text)
                {
                    MessageBox.Show("SALON YA ASIGNADO");
                }
            }
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox30.Text;

            if (compara != "")
            {
                if (compara == comboBox36.Text || compara == comboBox35.Text || compara == comboBox34.Text || compara == comboBox33.Text || compara == comboBox32.Text || compara == comboBox31.Text || compara == comboBox37.Text || compara == comboBox29.Text)
                {
                    MessageBox.Show("SALON YA ASIGNADO");
                }
            }
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox29.Text;

            if (compara != "")
            {
                if (compara == comboBox36.Text || compara == comboBox35.Text || compara == comboBox34.Text || compara == comboBox33.Text || compara == comboBox32.Text || compara == comboBox31.Text || compara == comboBox30.Text || compara == comboBox37.Text)
                {
                    MessageBox.Show("SALON YA ASIGNADO");
                }
            }
        }
        //que no se repitan dias
        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox17.Text;

            if (compara != "")
            {
                if (compara == comboBox22.Text || compara == comboBox21.Text || compara == comboBox20.Text || compara == comboBox19.Text || compara == comboBox18.Text || compara == comboBox51.Text || compara == comboBox52.Text || compara == comboBox53.Text)
                {
                    MessageBox.Show("DÍA YA ASIGNADO");
                }
            }
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox22.Text;

            if (compara != "")
            {
                if (compara == comboBox17.Text || compara == comboBox21.Text || compara == comboBox20.Text || compara == comboBox19.Text || compara == comboBox18.Text || compara == comboBox51.Text || compara == comboBox52.Text || compara == comboBox53.Text)
                {
                    MessageBox.Show("DÍA YA ASIGNADO");
                }
            }
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox21.Text;

            if (compara != "")
            {
                if (compara == comboBox17.Text || compara == comboBox17.Text || compara == comboBox20.Text || compara == comboBox19.Text || compara == comboBox18.Text || compara == comboBox51.Text || compara == comboBox52.Text || compara == comboBox53.Text)
                {
                    MessageBox.Show("DÍA YA ASIGNADO");
                }
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox20.Text;

            if (compara != "")
            {
                if (compara == comboBox17.Text || compara == comboBox21.Text || compara == comboBox17.Text || compara == comboBox19.Text || compara == comboBox18.Text || compara == comboBox51.Text || compara == comboBox52.Text || compara == comboBox53.Text)
                {
                    MessageBox.Show("DÍA YA ASIGNADO");
                }
            }
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox19.Text;

            if (compara != "")
            {
                if (compara == comboBox17.Text || compara == comboBox21.Text || compara == comboBox20.Text || compara == comboBox17.Text || compara == comboBox18.Text || compara == comboBox51.Text || compara == comboBox52.Text || compara == comboBox53.Text)
                {
                    MessageBox.Show("DÍA YA ASIGNADO");
                }
            }
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox18.Text;

            if (compara != "")
            {
                if (compara == comboBox17.Text || compara == comboBox21.Text || compara == comboBox20.Text || compara == comboBox19.Text || compara == comboBox17.Text || compara == comboBox51.Text || compara == comboBox52.Text || compara == comboBox53.Text)
                {
                    MessageBox.Show("DÍA YA ASIGNADO");
                }
            }
        }

        private void comboBox51_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox51.Text;

            if (compara != "")
            {
                if (compara == comboBox17.Text || compara == comboBox21.Text || compara == comboBox20.Text || compara == comboBox19.Text || compara == comboBox18.Text || compara == comboBox17.Text || compara == comboBox52.Text || compara == comboBox53.Text)
                {
                    MessageBox.Show("DÍA YA ASIGNADO");
                }
            }
        }

        private void comboBox52_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox52.Text;

            if (compara != "")
            {
                if (compara == comboBox17.Text || compara == comboBox21.Text || compara == comboBox20.Text || compara == comboBox19.Text || compara == comboBox18.Text || compara == comboBox51.Text || compara == comboBox17.Text || compara == comboBox53.Text)
                {
                    MessageBox.Show("DÍA YA ASIGNADO");
                }
            }
        }

        private void comboBox53_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compara = comboBox53.Text;

            if (compara != "")
            {
                if (compara == comboBox17.Text || compara == comboBox21.Text || compara == comboBox20.Text || compara == comboBox19.Text || compara == comboBox18.Text || compara == comboBox51.Text || compara == comboBox52.Text || compara == comboBox17.Text)
                {
                    MessageBox.Show("DÍA YA ASIGNADO");
                }
            }
        }
    }
}
