using programacionejerc5clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacesejerc1
{
    public partial class menu : Form
    {
        List<Estudiante> listEstudiantes = new List<Estudiante>();
        public menu()
        {
            InitializeComponent();
        }

        private void LimpiarText()
        {
            NameBox.Clear();
            EdadBox.Value = 0;
            CarreraBox.Text = string.Empty;
            EstadoBox.Text = string.Empty;
        }
        private void buttonEstudiante_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void listAlumnos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
        private void gropubox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void Layoutcentro_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listAlumnos.Items.Clear();
           
            List<Estudiante> listEstudiante = new List<Estudiante>();
            

            if (listAlumnos.Visible == false) { listAlumnos.Visible = true; }
            else { listAlumnos.Visible = false; }

            string path = "C:\\Users\\mauri\\OneDrive\\Escritorio\\listas\\exalumnos.txt";
            StreamReader archivoALeer = File.OpenText(path);
            string renglon = archivoALeer.ReadLine();
            do
            {

                listAlumnos.Items.Add(renglon);
                renglon = archivoALeer.ReadLine();

            } while (renglon != null);
            archivoALeer.Close();

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void buttonEmpleado_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void buttonAlumno_Click(object sender, EventArgs e)
        {
            
            if (listAlumnos.Visible == false) { listAlumnos.Visible = true; }
            else {listAlumnos.Visible=false; }
            if (Datosalumno.Visible == false) { Datosalumno.Visible = true; }
            else { Datosalumno.Visible = false; }
            if(gropubox2.Visible == false) {  gropubox2.Visible = true; }
            else {  gropubox2.Visible=false; }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonDocentes_Click(object sender, EventArgs e)
        {
            listAlumnos.Items.Clear();
            if (listAlumnos.Visible == false) { listAlumnos.Visible = true; }
            else { listAlumnos.Visible = false; }

            string path = "C:\\Users\\mauri\\OneDrive\\Escritorio\\listas\\docentes.txt";
            StreamReader archivoALeer = File.OpenText(path);
            string renglon = archivoALeer.ReadLine();
            do
            {
                listAlumnos.Items.Add(renglon);
                renglon = archivoALeer.ReadLine();

            } while (renglon != null);
            archivoALeer.Close();
        }

        private void buttonNodocentes_Click(object sender, EventArgs e)
        {
            listAlumnos.Items.Clear();
            if (listAlumnos.Visible == false) { listAlumnos.Visible = true; }
            else { listAlumnos.Visible = false; }

            string path = "C:\\Users\\mauri\\OneDrive\\Escritorio\\listas\\nodocentes.txt";
            StreamReader archivoALeer = File.OpenText(path);
            string renglon = archivoALeer.ReadLine();
            do
            {
                listAlumnos.Items.Add(renglon);
                renglon = archivoALeer.ReadLine();

            } while (renglon != null);
            archivoALeer.Close();
        }

        private void listAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Edad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarText();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                buttonEliminarSeleccionado.Enabled = true;
                buttonAgregarAlumno.Enabled = true;

                string name = NameBox.Text;
                int edad = int.Parse(EdadBox.Text);
                string carrera = CarreraBox.Text;
                string estado = EstadoBox.Text;
                listEstudiantes.Add(new Estudiante() { Name = name,Carrera = carrera,Edad = edad,Estado=estado});
                listAlumnos.Items.Add(name+"-"+carrera+"-"+edad+"-"+estado);
            }
            catch (Exception)
            {
                MessageBox.Show("PELOTUDO");
                MessageBox.Show("DOWN");
            }
            finally 
            {
                LimpiarText();
            }
        }

        private void buttonSalirsinGuardar_Click(object sender, EventArgs e)
        {
            this.listAlumnos.Items.Clear();
            this.listAlumnos.Visible = false;
            this.gropubox2.Visible = false;
            this.Datosalumno.Visible = false;
        }

        private void buttonEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            int index = listAlumnos.SelectedIndex;
            listEstudiantes.RemoveAt(index);
            listAlumnos.Items.Remove(listAlumnos.SelectedItem);
        }

        private void buttonGuardarArchivo_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;
            StreamWriter archivo;
            if (File.Exists(path))
            {
                archivo = File.AppendText(path);
            }
            else
            {
                archivo = File.CreateText(path);
            }

            foreach (Estudiante est in listEstudiantes)
            {
                archivo.WriteLine(est.Name);
                archivo.WriteLine(est.Edad);
                archivo.WriteLine(est.Carrera);
                archivo.WriteLine(est.Estado);
            }
            archivo.Close();
            MessageBox.Show("BIEN AHI LOCO");
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
