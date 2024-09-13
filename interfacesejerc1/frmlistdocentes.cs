using programacionejerc5clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Xml.Linq;
using System.IO;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;
using System.Runtime.Remoting.Contexts;

namespace interfacesejerc1
{
    public partial class frmlistdocentes : Form
    {
        public frmlistdocentes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Limpiartext()
        {
            textBoxName.Clear();
            textBoxPuesto.Clear();
            numericAntiguedad.Value = 0;
            numericEdad.Value = 0;
            numericSalario.Value = 0;
            textBoxBuscarDocente.Clear();
        }

        private void frmlistdocentes_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectSQL connect = new ConnectSQL();
                dataGridView1.DataSource = connect.ListarDocentes();

                dataGridView1.Columns["Puesto"].DisplayIndex = 0;
                dataGridView1.Columns["Name"].DisplayIndex = 1;
                dataGridView1.Columns["Antiguedad"].DisplayIndex = 2;
                dataGridView1.Columns["Salario"].DisplayIndex = 3;
                dataGridView1.Columns["Edad"].DisplayIndex = 4;
            }
            catch (Exception)
            {
                MessageBox.Show("A");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        

        public void buttonAgregarDocente_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
    
            conn.ConnectionString = "data source=MAURIPC; initial catalog=Empleados_DB; integrated security=sspi";
            string comando = "Insert into Docentess([Puesto] ,[Nombre] ,[Antiguedad],[Salario] ,[Edad]) " +
                "values('" + textBoxPuesto.Text + "','" + textBoxName.Text + "','" + numericAntiguedad.Value + "','" + numericSalario.Value + "','" + numericEdad.Value + "')";
            SqlCommand cmd = new SqlCommand(comando,conn);
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            
            ConnectSQL a = new ConnectSQL();
            dataGridView1.DataSource = a.ListarDocentes();

            dataGridView1.Columns["Puesto"].DisplayIndex = 0;
            dataGridView1.Columns["Name"].DisplayIndex = 1;
            dataGridView1.Columns["Antiguedad"].DisplayIndex = 2;
            dataGridView1.Columns["Salario"].DisplayIndex = 3;
            dataGridView1.Columns["Edad"].DisplayIndex = 4;

            Limpiartext();

        }

        private void buttonSalirDocentes_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonBuscarDocente_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comand = new SqlCommand();
            List<Docente> listbusqueda = new List<Docente>();
            conexion.ConnectionString = "data source=MAURIPC; initial catalog=Empleados_DB; integrated security=sspi";
            comand.CommandType = System.Data.CommandType.Text;
            comand.CommandText = "select * FROM Docentess WHERE Nombre = '" + textBoxBuscarDocente.Text + "'";
            comand.Connection = conexion;
            conexion.Open();
            SqlDataReader reader;
            reader = comand.ExecuteReader();
            while (reader.Read())
            {
                Docente aux = new Docente();
                aux.Puesto = reader.GetString(0);
                aux.Name = reader.GetString(1);
                aux.Antiguedad = reader.GetInt32(2);
                aux.Salario = reader.GetInt32(3);
                aux.Edad = reader.GetInt32(4);
                listbusqueda.Add(aux);


            }
            

            ConnectSQL a = new ConnectSQL();
            dataGridView1.DataSource = listbusqueda;

            dataGridView1.Columns["Puesto"].DisplayIndex = 0;
            dataGridView1.Columns["Name"].DisplayIndex = 1;
            dataGridView1.Columns["Antiguedad"].DisplayIndex = 2;
            dataGridView1.Columns["Salario"].DisplayIndex = 3;
            dataGridView1.Columns["Edad"].DisplayIndex = 4;
            Limpiartext();

        }

        public void textBoxBuscarDocente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
