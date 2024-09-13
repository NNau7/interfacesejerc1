namespace interfacesejerc1
{
    partial class frmlistdocentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxBuscarDocente = new System.Windows.Forms.TextBox();
            this.buttonBuscarDocente = new System.Windows.Forms.Button();
            this.buttonAgregarDocente = new System.Windows.Forms.Button();
            this.panelagregardocente = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericEdad = new System.Windows.Forms.NumericUpDown();
            this.numericSalario = new System.Windows.Forms.NumericUpDown();
            this.numericAntiguedad = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPuesto = new System.Windows.Forms.TextBox();
            this.buttonSalirDocentes = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelagregardocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAntiguedad)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonAgregarDocente);
            this.flowLayoutPanel2.Controls.Add(this.panelagregardocente);
            this.flowLayoutPanel2.Controls.Add(this.buttonSalirDocentes);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(462, 92);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(326, 346);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 346);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.buttonBuscarDocente);
            this.panel1.Controls.Add(this.textBoxBuscarDocente);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 65);
            this.panel1.TabIndex = 3;
            // 
            // textBoxBuscarDocente
            // 
            this.textBoxBuscarDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarDocente.Location = new System.Drawing.Point(286, 16);
            this.textBoxBuscarDocente.Name = "textBoxBuscarDocente";
            this.textBoxBuscarDocente.Size = new System.Drawing.Size(200, 29);
            this.textBoxBuscarDocente.TabIndex = 0;
            this.textBoxBuscarDocente.TextChanged += new System.EventHandler(this.textBoxBuscarDocente_TextChanged);
            // 
            // buttonBuscarDocente
            // 
            this.buttonBuscarDocente.Location = new System.Drawing.Point(507, 16);
            this.buttonBuscarDocente.Name = "buttonBuscarDocente";
            this.buttonBuscarDocente.Size = new System.Drawing.Size(93, 29);
            this.buttonBuscarDocente.TabIndex = 1;
            this.buttonBuscarDocente.Text = "Buscar";
            this.buttonBuscarDocente.UseVisualStyleBackColor = true;
            this.buttonBuscarDocente.Click += new System.EventHandler(this.buttonBuscarDocente_Click);
            // 
            // buttonAgregarDocente
            // 
            this.buttonAgregarDocente.Location = new System.Drawing.Point(20, 20);
            this.buttonAgregarDocente.Margin = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.buttonAgregarDocente.Name = "buttonAgregarDocente";
            this.buttonAgregarDocente.Size = new System.Drawing.Size(289, 41);
            this.buttonAgregarDocente.TabIndex = 0;
            this.buttonAgregarDocente.Text = "Agregar";
            this.buttonAgregarDocente.UseVisualStyleBackColor = true;
            this.buttonAgregarDocente.Click += new System.EventHandler(this.buttonAgregarDocente_Click);
            // 
            // panelagregardocente
            // 
            this.panelagregardocente.Controls.Add(this.label5);
            this.panelagregardocente.Controls.Add(this.label4);
            this.panelagregardocente.Controls.Add(this.label3);
            this.panelagregardocente.Controls.Add(this.label2);
            this.panelagregardocente.Controls.Add(this.label1);
            this.panelagregardocente.Controls.Add(this.numericEdad);
            this.panelagregardocente.Controls.Add(this.numericSalario);
            this.panelagregardocente.Controls.Add(this.numericAntiguedad);
            this.panelagregardocente.Controls.Add(this.textBoxName);
            this.panelagregardocente.Controls.Add(this.textBoxPuesto);
            this.panelagregardocente.Location = new System.Drawing.Point(25, 81);
            this.panelagregardocente.Margin = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.panelagregardocente.Name = "panelagregardocente";
            this.panelagregardocente.Size = new System.Drawing.Size(279, 192);
            this.panelagregardocente.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Antiguedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Puesto";
            // 
            // numericEdad
            // 
            this.numericEdad.Location = new System.Drawing.Point(94, 151);
            this.numericEdad.Name = "numericEdad";
            this.numericEdad.Size = new System.Drawing.Size(100, 20);
            this.numericEdad.TabIndex = 4;
            // 
            // numericSalario
            // 
            this.numericSalario.Location = new System.Drawing.Point(163, 82);
            this.numericSalario.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericSalario.Name = "numericSalario";
            this.numericSalario.Size = new System.Drawing.Size(100, 20);
            this.numericSalario.TabIndex = 3;
            // 
            // numericAntiguedad
            // 
            this.numericAntiguedad.Location = new System.Drawing.Point(25, 82);
            this.numericAntiguedad.Name = "numericAntiguedad";
            this.numericAntiguedad.Size = new System.Drawing.Size(100, 20);
            this.numericAntiguedad.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(163, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxPuesto
            // 
            this.textBoxPuesto.Location = new System.Drawing.Point(25, 37);
            this.textBoxPuesto.Name = "textBoxPuesto";
            this.textBoxPuesto.Size = new System.Drawing.Size(100, 20);
            this.textBoxPuesto.TabIndex = 0;
            // 
            // buttonSalirDocentes
            // 
            this.buttonSalirDocentes.Location = new System.Drawing.Point(220, 301);
            this.buttonSalirDocentes.Margin = new System.Windows.Forms.Padding(220, 3, 3, 3);
            this.buttonSalirDocentes.Name = "buttonSalirDocentes";
            this.buttonSalirDocentes.Size = new System.Drawing.Size(86, 33);
            this.buttonSalirDocentes.TabIndex = 3;
            this.buttonSalirDocentes.Text = "Salir";
            this.buttonSalirDocentes.UseVisualStyleBackColor = true;
            this.buttonSalirDocentes.Click += new System.EventHandler(this.buttonSalirDocentes_Click);
            // 
            // frmlistdocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "frmlistdocentes";
            this.Text = "frmlistdocentes";
            this.Load += new System.EventHandler(this.frmlistdocentes_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelagregardocente.ResumeLayout(false);
            this.panelagregardocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAntiguedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBuscarDocente;
        private System.Windows.Forms.TextBox textBoxBuscarDocente;
        private System.Windows.Forms.Button buttonAgregarDocente;
        private System.Windows.Forms.Panel panelagregardocente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericEdad;
        private System.Windows.Forms.NumericUpDown numericSalario;
        private System.Windows.Forms.NumericUpDown numericAntiguedad;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPuesto;
        private System.Windows.Forms.Button buttonSalirDocentes;
    }
}