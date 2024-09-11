namespace interfacesejerc1
{
    partial class menu
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
            this.Layoutizq = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonEstudiante = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExalumnos = new System.Windows.Forms.Button();
            this.buttonAlumno = new System.Windows.Forms.Button();
            this.buttonEmpleado = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNodocentes = new System.Windows.Forms.Button();
            this.buttonDocentes = new System.Windows.Forms.Button();
            this.LayoutSalir = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.Layoutunder = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Layoutcentro = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listAlumnos = new System.Windows.Forms.ListBox();
            this.Datosalumno = new System.Windows.Forms.GroupBox();
            this.gropubox2 = new System.Windows.Forms.GroupBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.buttonAgregarAlumno = new System.Windows.Forms.Button();
            this.buttonCancelarAlumno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EdadBox = new System.Windows.Forms.NumericUpDown();
            this.CarreraBox = new System.Windows.Forms.ComboBox();
            this.EstadoBox = new System.Windows.Forms.ComboBox();
            this.buttonEliminarSeleccionado = new System.Windows.Forms.Button();
            this.buttonSalirsinGuardar = new System.Windows.Forms.Button();
            this.buttonGuardarArchivo = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Layoutizq.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.LayoutSalir.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Layoutcentro.SuspendLayout();
            this.Datosalumno.SuspendLayout();
            this.gropubox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdadBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Layoutizq
            // 
            this.Layoutizq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Layoutizq.Controls.Add(this.buttonEstudiante);
            this.Layoutizq.Controls.Add(this.panel1);
            this.Layoutizq.Controls.Add(this.buttonEmpleado);
            this.Layoutizq.Controls.Add(this.panel2);
            this.Layoutizq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layoutizq.Location = new System.Drawing.Point(3, 3);
            this.Layoutizq.Name = "Layoutizq";
            this.Layoutizq.Size = new System.Drawing.Size(150, 391);
            this.Layoutizq.TabIndex = 5;
            // 
            // buttonEstudiante
            // 
            this.buttonEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEstudiante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEstudiante.Location = new System.Drawing.Point(3, 3);
            this.buttonEstudiante.Name = "buttonEstudiante";
            this.buttonEstudiante.Size = new System.Drawing.Size(143, 33);
            this.buttonEstudiante.TabIndex = 0;
            this.buttonEstudiante.Text = "Estudiantes";
            this.buttonEstudiante.UseVisualStyleBackColor = false;
            this.buttonEstudiante.Click += new System.EventHandler(this.buttonEstudiante_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExalumnos);
            this.panel1.Controls.Add(this.buttonAlumno);
            this.panel1.Location = new System.Drawing.Point(3, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 92);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonExalumnos
            // 
            this.buttonExalumnos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonExalumnos.Location = new System.Drawing.Point(6, 47);
            this.buttonExalumnos.Name = "buttonExalumnos";
            this.buttonExalumnos.Size = new System.Drawing.Size(137, 38);
            this.buttonExalumnos.TabIndex = 1;
            this.buttonExalumnos.Text = "ExAlumnos";
            this.buttonExalumnos.UseVisualStyleBackColor = false;
            this.buttonExalumnos.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAlumno
            // 
            this.buttonAlumno.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAlumno.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAlumno.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonAlumno.Location = new System.Drawing.Point(6, 3);
            this.buttonAlumno.Name = "buttonAlumno";
            this.buttonAlumno.Size = new System.Drawing.Size(137, 38);
            this.buttonAlumno.TabIndex = 0;
            this.buttonAlumno.Text = "Alumnos";
            this.buttonAlumno.UseVisualStyleBackColor = false;
            this.buttonAlumno.Click += new System.EventHandler(this.buttonAlumno_Click);
            // 
            // buttonEmpleado
            // 
            this.buttonEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEmpleado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEmpleado.Location = new System.Drawing.Point(3, 140);
            this.buttonEmpleado.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.buttonEmpleado.Name = "buttonEmpleado";
            this.buttonEmpleado.Size = new System.Drawing.Size(143, 33);
            this.buttonEmpleado.TabIndex = 2;
            this.buttonEmpleado.Text = "Empleado";
            this.buttonEmpleado.UseVisualStyleBackColor = false;
            this.buttonEmpleado.Click += new System.EventHandler(this.buttonEmpleado_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonNodocentes);
            this.panel2.Controls.Add(this.buttonDocentes);
            this.panel2.Location = new System.Drawing.Point(3, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 146);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonNodocentes
            // 
            this.buttonNodocentes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNodocentes.Location = new System.Drawing.Point(6, 47);
            this.buttonNodocentes.Name = "buttonNodocentes";
            this.buttonNodocentes.Size = new System.Drawing.Size(137, 38);
            this.buttonNodocentes.TabIndex = 1;
            this.buttonNodocentes.Text = "NoDocentes";
            this.buttonNodocentes.UseVisualStyleBackColor = false;
            this.buttonNodocentes.Click += new System.EventHandler(this.buttonNodocentes_Click);
            // 
            // buttonDocentes
            // 
            this.buttonDocentes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDocentes.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDocentes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonDocentes.Location = new System.Drawing.Point(6, 3);
            this.buttonDocentes.Name = "buttonDocentes";
            this.buttonDocentes.Size = new System.Drawing.Size(137, 38);
            this.buttonDocentes.TabIndex = 0;
            this.buttonDocentes.Text = "Docentes";
            this.buttonDocentes.UseVisualStyleBackColor = false;
            this.buttonDocentes.Click += new System.EventHandler(this.buttonDocentes_Click);
            // 
            // LayoutSalir
            // 
            this.LayoutSalir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LayoutSalir.Controls.Add(this.buttonSalir);
            this.LayoutSalir.Location = new System.Drawing.Point(3, 400);
            this.LayoutSalir.Name = "LayoutSalir";
            this.LayoutSalir.Size = new System.Drawing.Size(150, 47);
            this.LayoutSalir.TabIndex = 4;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSalir.Location = new System.Drawing.Point(3, 3);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(142, 33);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Layoutunder
            // 
            this.Layoutunder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Layoutunder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layoutunder.Location = new System.Drawing.Point(159, 400);
            this.Layoutunder.Name = "Layoutunder";
            this.Layoutunder.Size = new System.Drawing.Size(638, 47);
            this.Layoutunder.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.52701F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.47298F));
            this.tableLayoutPanel1.Controls.Add(this.Layoutunder, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Layoutcentro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LayoutSalir, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Layoutizq, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.30455F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69545F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Layoutcentro
            // 
            this.Layoutcentro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Layoutcentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Layoutcentro.Controls.Add(this.gropubox2);
            this.Layoutcentro.Controls.Add(this.listAlumnos);
            this.Layoutcentro.Controls.Add(this.Datosalumno);
            this.Layoutcentro.Location = new System.Drawing.Point(159, 3);
            this.Layoutcentro.Name = "Layoutcentro";
            this.Layoutcentro.Size = new System.Drawing.Size(638, 391);
            this.Layoutcentro.TabIndex = 3;
            this.Layoutcentro.Paint += new System.Windows.Forms.PaintEventHandler(this.Layoutcentro_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // listAlumnos
            // 
            this.listAlumnos.FormattingEnabled = true;
            this.listAlumnos.Location = new System.Drawing.Point(313, 3);
            this.listAlumnos.Name = "listAlumnos";
            this.listAlumnos.Size = new System.Drawing.Size(311, 199);
            this.listAlumnos.TabIndex = 0;
            this.listAlumnos.Visible = false;
            this.listAlumnos.SelectedIndexChanged += new System.EventHandler(this.listAlumnos_SelectedIndexChanged_1);
            // 
            // Datosalumno
            // 
            this.Datosalumno.AutoSize = true;
            this.Datosalumno.Controls.Add(this.EstadoBox);
            this.Datosalumno.Controls.Add(this.CarreraBox);
            this.Datosalumno.Controls.Add(this.EdadBox);
            this.Datosalumno.Controls.Add(this.label4);
            this.Datosalumno.Controls.Add(this.label3);
            this.Datosalumno.Controls.Add(this.label2);
            this.Datosalumno.Controls.Add(this.label1);
            this.Datosalumno.Controls.Add(this.buttonCancelarAlumno);
            this.Datosalumno.Controls.Add(this.buttonAgregarAlumno);
            this.Datosalumno.Controls.Add(this.NameBox);
            this.Datosalumno.Location = new System.Drawing.Point(3, 221);
            this.Datosalumno.Name = "Datosalumno";
            this.Datosalumno.Size = new System.Drawing.Size(625, 182);
            this.Datosalumno.TabIndex = 1;
            this.Datosalumno.TabStop = false;
            this.Datosalumno.Text = "Ingrese los datos";
            this.Datosalumno.Visible = false;
            // 
            // gropubox2
            // 
            this.gropubox2.AutoSize = true;
            this.gropubox2.Controls.Add(this.buttonGuardarArchivo);
            this.gropubox2.Controls.Add(this.buttonSalirsinGuardar);
            this.gropubox2.Controls.Add(this.buttonEliminarSeleccionado);
            this.gropubox2.Location = new System.Drawing.Point(3, 3);
            this.gropubox2.Name = "gropubox2";
            this.gropubox2.Size = new System.Drawing.Size(304, 212);
            this.gropubox2.TabIndex = 2;
            this.gropubox2.TabStop = false;
            this.gropubox2.Text = "Menu";
            this.gropubox2.Visible = false;
            this.gropubox2.Enter += new System.EventHandler(this.gropubox2_Enter);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(109, 18);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(124, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.Edad_TextChanged);
            // 
            // buttonAgregarAlumno
            // 
            this.buttonAgregarAlumno.Location = new System.Drawing.Point(402, 130);
            this.buttonAgregarAlumno.Name = "buttonAgregarAlumno";
            this.buttonAgregarAlumno.Size = new System.Drawing.Size(95, 33);
            this.buttonAgregarAlumno.TabIndex = 4;
            this.buttonAgregarAlumno.Text = "Agregar";
            this.buttonAgregarAlumno.UseVisualStyleBackColor = true;
            this.buttonAgregarAlumno.Click += new System.EventHandler(this.buttonAgregarAlumno_Click);
            // 
            // buttonCancelarAlumno
            // 
            this.buttonCancelarAlumno.Location = new System.Drawing.Point(524, 130);
            this.buttonCancelarAlumno.Name = "buttonCancelarAlumno";
            this.buttonCancelarAlumno.Size = new System.Drawing.Size(95, 32);
            this.buttonCancelarAlumno.TabIndex = 5;
            this.buttonCancelarAlumno.Text = "Cancelar";
            this.buttonCancelarAlumno.UseVisualStyleBackColor = true;
            this.buttonCancelarAlumno.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estado";
            // 
            // EdadBox
            // 
            this.EdadBox.Location = new System.Drawing.Point(411, 19);
            this.EdadBox.Name = "EdadBox";
            this.EdadBox.Size = new System.Drawing.Size(124, 20);
            this.EdadBox.TabIndex = 10;
            // 
            // CarreraBox
            // 
            this.CarreraBox.FormattingEnabled = true;
            this.CarreraBox.Items.AddRange(new object[] {
            "Programacion",
            "Arquitectura",
            "Lengua",
            "Gimnasia"});
            this.CarreraBox.Location = new System.Drawing.Point(109, 71);
            this.CarreraBox.Name = "CarreraBox";
            this.CarreraBox.Size = new System.Drawing.Size(124, 21);
            this.CarreraBox.TabIndex = 11;
            this.CarreraBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // EstadoBox
            // 
            this.EstadoBox.FormattingEnabled = true;
            this.EstadoBox.Items.AddRange(new object[] {
            "Promocionado",
            "Regular",
            "Libre"});
            this.EstadoBox.Location = new System.Drawing.Point(411, 71);
            this.EstadoBox.Name = "EstadoBox";
            this.EstadoBox.Size = new System.Drawing.Size(124, 21);
            this.EstadoBox.TabIndex = 12;
            // 
            // buttonEliminarSeleccionado
            // 
            this.buttonEliminarSeleccionado.Location = new System.Drawing.Point(6, 19);
            this.buttonEliminarSeleccionado.Name = "buttonEliminarSeleccionado";
            this.buttonEliminarSeleccionado.Size = new System.Drawing.Size(292, 43);
            this.buttonEliminarSeleccionado.TabIndex = 0;
            this.buttonEliminarSeleccionado.Text = "Eliminar Seleccionado";
            this.buttonEliminarSeleccionado.UseVisualStyleBackColor = true;
            this.buttonEliminarSeleccionado.Click += new System.EventHandler(this.buttonEliminarSeleccionado_Click);
            // 
            // buttonSalirsinGuardar
            // 
            this.buttonSalirsinGuardar.Location = new System.Drawing.Point(6, 84);
            this.buttonSalirsinGuardar.Name = "buttonSalirsinGuardar";
            this.buttonSalirsinGuardar.Size = new System.Drawing.Size(292, 43);
            this.buttonSalirsinGuardar.TabIndex = 1;
            this.buttonSalirsinGuardar.Text = "Salir Sin Guardar";
            this.buttonSalirsinGuardar.UseVisualStyleBackColor = true;
            this.buttonSalirsinGuardar.Click += new System.EventHandler(this.buttonSalirsinGuardar_Click);
            // 
            // buttonGuardarArchivo
            // 
            this.buttonGuardarArchivo.Location = new System.Drawing.Point(6, 150);
            this.buttonGuardarArchivo.Name = "buttonGuardarArchivo";
            this.buttonGuardarArchivo.Size = new System.Drawing.Size(292, 43);
            this.buttonGuardarArchivo.TabIndex = 2;
            this.buttonGuardarArchivo.Text = "Guardar En Archivo";
            this.buttonGuardarArchivo.UseVisualStyleBackColor = true;
            this.buttonGuardarArchivo.Click += new System.EventHandler(this.buttonGuardarArchivo_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "menu";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.menu_Load);
            this.Layoutizq.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.LayoutSalir.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Layoutcentro.ResumeLayout(false);
            this.Layoutcentro.PerformLayout();
            this.Datosalumno.ResumeLayout(false);
            this.Datosalumno.PerformLayout();
            this.gropubox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EdadBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Layoutizq;
        private System.Windows.Forms.Button buttonEstudiante;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExalumnos;
        private System.Windows.Forms.Button buttonAlumno;
        private System.Windows.Forms.Button buttonEmpleado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonNodocentes;
        private System.Windows.Forms.Button buttonDocentes;
        private System.Windows.Forms.FlowLayoutPanel LayoutSalir;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.FlowLayoutPanel Layoutunder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel Layoutcentro;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listAlumnos;
        private System.Windows.Forms.GroupBox gropubox2;
        private System.Windows.Forms.GroupBox Datosalumno;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button buttonCancelarAlumno;
        private System.Windows.Forms.Button buttonAgregarAlumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown EdadBox;
        private System.Windows.Forms.ComboBox CarreraBox;
        private System.Windows.Forms.ComboBox EstadoBox;
        private System.Windows.Forms.Button buttonGuardarArchivo;
        private System.Windows.Forms.Button buttonSalirsinGuardar;
        private System.Windows.Forms.Button buttonEliminarSeleccionado;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}