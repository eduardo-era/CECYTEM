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
    public partial class CONFIGURARMATERIAS : Form
    {
        MySqlConnection cone = new MySqlConnection("server = localhost; uid = root;" + "pwd = 307277891 ; database = Horarios;");
        string materia;
        string horastt;
        string horaspp;
        int resultado;
        public CONFIGURARMATERIAS()
        {
            InitializeComponent();
            llenarsemestres();
            estilo_datos_datagrid();
        }

        private void CONFIGURARMATERIAS_Load(object sender, EventArgs e)
        {
            cone.Open();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Materia, Semestre.Semestre,HorasP,HorasT,TotalHoras FROM Materia JOIN Semestre ON Materia.idSemestre = Semestre.idSemestre ", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("NO HAS ASIGNADO SEMESTRE");
            }
            else
            {

                cone.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT idSemestre FROM Semestre WHERE Semestre = '" + comboBox1.Text + "'", cone);
                resultado = (int)cmd.ExecuteScalar();

                int horasT = int.Parse(textBox3.Text);
                int horasP = int.Parse(textBox4.Text);
                int horastot = horasT + horasP;


                MySqlCommand insertagru = new MySqlCommand($" Insert into Materia (Materia,idSemestre,HorasP,HorasT,TotalHoras) values ('{textBox1.Text}', '{resultado}', '{horasT}', '{horasP}', '{horastot}')", cone);
                insertagru.ExecuteNonQuery();

                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Materia, Semestre.Semestre,HorasP,HorasT,TotalHoras FROM Materia JOIN Semestre ON Materia.idSemestre = Semestre.idSemestre ", cone);
                mdaDatos.Fill(dtDatos);
                dataGridView1.DataSource = dtDatos;

                cone.Close();

                textBox1.Text = string.Empty;
                textBox3.Text = String.Empty;
                textBox4.Text = String.Empty;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            materia = textBox1.Text = dataGridView1.CurrentRow.Cells["Materia"].Value.ToString();
            horastt = textBox3.Text = dataGridView1.CurrentRow.Cells["HorasT"].Value.ToString();
            horaspp = textBox4.Text = dataGridView1.CurrentRow.Cells["HorasP"].Value.ToString();
        }

        public void llenarsemestres()
        {
            cone.Open();
     
            MySqlCommand cmd = new MySqlCommand("SELECT idSemestre,Semestre FROM Semestre", cone);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.Close();

            DataRow fila = dt.NewRow();
            fila["Semestre"] = "";
            dt.Rows.InsertAt(fila, 0);

            comboBox1.ValueMember = "idSemestre";
            comboBox1.DisplayMember = "Semestre";
            comboBox1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int horasT;
            int horasP;
            int horastot;

            if (comboBox1.Text== "")
            {
                MessageBox.Show("NO HAS ASIGNADO SEMESTRE");
            }
            else
            {
                cone.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT idSemestre FROM Semestre WHERE Semestre = '" + comboBox1.Text + "'", cone);
                int resultado2 = (int)cmd.ExecuteScalar();

                horasT = int.Parse(textBox3.Text);
                horasP = int.Parse(textBox4.Text);
                horastot = horasT + horasP;

                string materia2 = textBox1.Text;
                string horastt2 = textBox3.Text;
                string horaspp2 = textBox4.Text;
                string semestree2 = comboBox1.Text;


                if (materia==materia2)
                {

                    MySqlCommand cambiarmater = new MySqlCommand($" UPDATE Materia SET  HorasP = ('{textBox4.Text}'), HorasT = ('{textBox3.Text}'), TotalHoras = ('{horastot}'), idSemestre = ('{resultado2}') WHERE Materia = ('{textBox1.Text}')", cone);
                    cambiarmater.ExecuteNonQuery();
                }

                if(horastt==horastt2)
                {
                    MySqlCommand cambiarmater = new MySqlCommand($" UPDATE Materia SET Materia = ('{textBox1.Text}'), HorasP = ('{textBox4.Text}'), TotalHoras = ('{horastot}'), idSemestre = ('{resultado2}') WHERE HorasT = ('{textBox3.Text}')", cone);
                    cambiarmater.ExecuteNonQuery();
                }

                if(horaspp==horaspp2)
                {
                    MySqlCommand cambiarmater = new MySqlCommand($" UPDATE Materia SET Materia = ('{textBox1.Text}'), HorasT = ('{textBox3.Text}'), TotalHoras = ('{horastot}'), idSemestre = ('{resultado2}') WHERE HorasP = ('{textBox4.Text}')", cone);
                    cambiarmater.ExecuteNonQuery();
                }


                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Materia, Semestre.Semestre,HorasP,HorasT,TotalHoras FROM Materia JOIN Semestre ON Materia.idSemestre = Semestre.idSemestre ", cone);
                mdaDatos.Fill(dtDatos);
                dataGridView1.DataSource = dtDatos;



                cone.Close();

                textBox1.Text = string.Empty;
                textBox3.Text = String.Empty;
                textBox4.Text = String.Empty;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cone.Open();

            MySqlCommand borrargru = new MySqlCommand($" DELETE FROM Materia where Materia = ('{textBox1.Text}')", cone);
            borrargru.ExecuteNonQuery();

            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT Materia, Semestre.Semestre,HorasP,HorasT,TotalHoras FROM Materia JOIN Semestre ON Materia.idSemestre = Semestre.idSemestre ", cone);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            cone.Close();

            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
        public void estilo_datos_datagrid()
        {
            dataGridView1.DefaultCellStyle.Font =new Font("Arial", 14);
        }
    }
}
