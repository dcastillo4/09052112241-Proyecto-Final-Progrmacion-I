namespace WFAlumnos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1Conexion = new System.Windows.Forms.Button();
            this.dataGridViewAlumno = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Parcial2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1parcial1 = new System.Windows.Forms.TextBox();
            this.textBox2parcial2 = new System.Windows.Forms.TextBox();
            this.textBox3parcial3 = new System.Windows.Forms.TextBox();
            this.BorrarAlumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumno)).BeginInit();
       
            this.SuspendLayout();
            // 
            // button1Conexion
            // 
            this.button1Conexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.button1Conexion.Location = new System.Drawing.Point(100, 486);
            this.button1Conexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1Conexion.Name = "button1Conexion";
            this.button1Conexion.Size = new System.Drawing.Size(163, 22);
            this.button1Conexion.TabIndex = 0;
            this.button1Conexion.Text = "Prueba Conexion";
            this.button1Conexion.UseVisualStyleBackColor = false;
            this.button1Conexion.Click += new System.EventHandler(this.button1Conexion_Click);
            // 
            // dataGridViewAlumno
            // 
            this.dataGridViewAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumno.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewAlumno.Location = new System.Drawing.Point(631, 0);
            this.dataGridViewAlumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAlumno.Name = "dataGridViewAlumno";
            this.dataGridViewAlumno.RowHeadersWidth = 51;
            this.dataGridViewAlumno.RowTemplate.Height = 29;
            this.dataGridViewAlumno.Size = new System.Drawing.Size(268, 230);
            this.dataGridViewAlumno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Clase";
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(138, 47);
            this.textBoxCarnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(241, 23);
            this.textBoxCarnet.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(138, 84);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(422, 23);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(138, 116);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(279, 23);
            this.textBoxCorreo.TabIndex = 10;
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxSeccion.Location = new System.Drawing.Point(138, 152);
            this.comboBoxSeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(279, 23);
            this.comboBoxSeccion.TabIndex = 11;
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Items.AddRange(new object[] {
            "PROGRAMACIÓN I",
            "PROGRAMACIÓN 2",
            "PROGRAMACIÓN 3 LA VENGANZA",
            "ELECTRONICA",
            "MATEMATICA"});
            this.comboBoxClase.Location = new System.Drawing.Point(138, 195);
            this.comboBoxClase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(279, 23);
            this.comboBoxClase.TabIndex = 12;
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.buttonConsulta.Location = new System.Drawing.Point(599, 46);
            this.buttonConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(182, 50);
            this.buttonConsulta.TabIndex = 13;
            this.buttonConsulta.Text = "Consulta por Carnet";
            this.buttonConsulta.UseVisualStyleBackColor = false;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.buttonLimpiar.Location = new System.Drawing.Point(320, 486);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(180, 22);
            this.buttonLimpiar.TabIndex = 14;
            this.buttonLimpiar.Text = "Limpiar Formulario";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.buttonInsertar.Location = new System.Drawing.Point(363, 317);
            this.buttonInsertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(223, 50);
            this.buttonInsertar.TabIndex = 15;
            this.buttonInsertar.Text = "Crear Alumno";
            this.buttonInsertar.UseVisualStyleBackColor = false;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.buttonActualizar.Location = new System.Drawing.Point(599, 317);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(223, 50);
            this.buttonActualizar.TabIndex = 16;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonImportar
            // 
        

            this.buttonImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.buttonImportar.Location = new System.Drawing.Point(5, 379);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(223, 50);
            this.buttonImportar.TabIndex = 25;
            this.buttonImportar.Text = "Importar";
            this.buttonImportar.UseVisualStyleBackColor = false;
            this.buttonImportar.Click += new System.EventHandler(this.buttonImportar_Click);
            // 
            // buttonExportar
            


            this.buttonExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.buttonExportar.Location = new System.Drawing.Point(250, 379);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(223, 50);
            this.buttonExportar.TabIndex = 25;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "parcial1";
            // 
            // Parcial2
            // 
            this.Parcial2.AutoSize = true;
            this.Parcial2.Location = new System.Drawing.Point(59, 271);
            this.Parcial2.Name = "Parcial2";
            this.Parcial2.Size = new System.Drawing.Size(48, 15);
            this.Parcial2.TabIndex = 20;
            this.Parcial2.Text = "Parcial2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "parcial3";
            // 
            // textBox1parcial1
            // 
            this.textBox1parcial1.Location = new System.Drawing.Point(138, 234);
            this.textBox1parcial1.Name = "textBox1parcial1";
            this.textBox1parcial1.Size = new System.Drawing.Size(206, 23);
            this.textBox1parcial1.TabIndex = 22;
            // 
            // textBox2parcial2
            // 
            this.textBox2parcial2.Location = new System.Drawing.Point(138, 268);
            this.textBox2parcial2.Name = "textBox2parcial2";
            this.textBox2parcial2.Size = new System.Drawing.Size(211, 23);
            this.textBox2parcial2.TabIndex = 23;
            // 
            // textBox3parcial3
            // 
            this.textBox3parcial3.Location = new System.Drawing.Point(138, 297);
            this.textBox3parcial3.Name = "textBox3parcial3";
            this.textBox3parcial3.Size = new System.Drawing.Size(205, 23);
            this.textBox3parcial3.TabIndex = 24;
            // 
            // BorrarAlumno
            // 
            this.BorrarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.BorrarAlumno.Location = new System.Drawing.Point(483, 379);
            this.BorrarAlumno.Name = "BorrarAlumno";
            this.BorrarAlumno.Size = new System.Drawing.Size(223, 50);
            this.BorrarAlumno.TabIndex = 25;
            this.BorrarAlumno.Text = "Eliminar";
            this.BorrarAlumno.UseVisualStyleBackColor = false;
            this.BorrarAlumno.Click += new System.EventHandler(this.BorrarAlumno_Click);
            // 
           
         
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1250, 630);
            this.Controls.Add(this.BorrarAlumno);
            this.Controls.Add(this.textBox3parcial3);
            this.Controls.Add(this.textBox2parcial2);
            this.Controls.Add(this.textBox1parcial1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Parcial2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.buttonImportar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.comboBoxSeccion);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAlumno);
            this.Controls.Add(this.button1Conexion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumno)).EndInit();
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button button1Conexion;
        private DataGridView dataGridViewAlumno;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxCarnet;
        private TextBox textBoxNombre;
        private TextBox textBoxCorreo;
        private ComboBox comboBoxSeccion;
        private ComboBox comboBoxClase;
        private Button buttonConsulta;
        private Button buttonLimpiar;
        private Button buttonInsertar;
        private Button buttonActualizar;
        private Button buttonImportar;
        private Button buttonExportar;
        private Label label6;
        private Label Parcial2;
        private Label label7;
        private TextBox textBox1parcial1;
        private TextBox textBox2parcial2;
        private TextBox textBox3parcial3;
        private Button BorrarAlumno;
    }
}