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
    }
}
