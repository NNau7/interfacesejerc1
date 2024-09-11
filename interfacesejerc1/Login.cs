using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacesejerc1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonaceptar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "123")
            {
                this.DialogResult = DialogResult.OK;
            }
            
            else
            {
                MessageBox.Show("Contraseña INCORRECTA");
                textBox1.Clear();
            }
        }
    }
}
