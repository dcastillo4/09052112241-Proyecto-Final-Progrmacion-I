using p1BC13Crud.Entidades;
using p1BC13Crud.Servicios;

namespace WFAlumnos
{
    public partial class Form1 : Form
    {
        ServicioAlumno srvAlumno = new();
        MdAlumno oAlumno = new();


        //inicio de la estructura
        public Form1()
        {
            InitializeComponent();
        }


        void cargaGrid()
        {
            var resultado = srvAlumno.ConsultaSQL("select * from tb_alumnos");
            dataGridViewAlumno.DataSource = resultado;
        }

        private void button1Conexion_Click(object sender, EventArgs e)
        {
            cargaGrid();
        }


        void MapeoDatosFormalio (MdAlumno _alumnos)
        {
            textBoxCarnet.Text = _alumnos.carnet;
            textBoxNombre.Text = _alumnos.nombre;
            textBoxCorreo.Text = _alumnos.correo;
            comboBoxClase.Text = _alumnos.clase;
            comboBoxSeccion.Text = _alumnos.seccion;
            textBox1parcial1.Text = Convert.ToString(_alumnos.parcial1);
            textBox2parcial2.Text = Convert.ToString(_alumnos.parcial2);
          textBox3parcial3.Text=Convert.ToString(_alumnos.parcial3);
           
        }

        void buscaAlumno(string carnet)
        {
            oAlumno = null;
            oAlumno = srvAlumno.ObtenerAlumno(carnet);

            if (oAlumno == null)
            {
                MessageBox.Show("Carnet No encontrado");
                LimpiarFormulario();
            } else
            {
                MapeoDatosFormalio(oAlumno);
            }

        }


        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            buscaAlumno(carnet);
        }


        void LimpiarFormulario()
        {
            oAlumno = new();
            MapeoDatosFormalio(oAlumno);
           // MapeoDatosFormalio(new());

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


        private MdAlumno DatosForumulario()
        {
            MdAlumno _alumnos = new();
            _alumnos.carnet = textBoxCarnet.Text.Trim();
            _alumnos.nombre = textBoxNombre.Text.Trim();
            _alumnos.correo = textBoxCorreo.Text.Trim();
            _alumnos.clase = comboBoxClase.Text;
            _alumnos.seccion = comboBoxSeccion.Text;
            _alumnos.parcial1 = Convert.ToInt32(textBox1parcial1.Text);
            _alumnos.parcial2 = Convert.ToInt32(textBox2parcial2.Text);
            _alumnos.parcial3 = Convert.ToInt32(textBox3parcial3.Text);

            return _alumnos;
        }
        public void Validacion()
        {
            MessageBox.Show("La nota ingresada no es valida");
            LimpiarFormulario();
            oAlumno =DatosForumulario();
        }


        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            oAlumno = DatosForumulario();





            if (oAlumno.parcial1 > 20)
            {
                Validacion();
            }
            else if (oAlumno.parcial2 > 25)
            {
                Validacion();
            }
            else if (oAlumno.parcial3 > 30)
            {
                Validacion();
            }
            else
            {



                int respusta = srvAlumno.CrearAlumno(oAlumno);

                if (respusta > 0)
                {
                    MessageBox.Show("Se grabo con exito");
                    LimpiarFormulario();
                    cargaGrid();
                }
                else
                {
                    MessageBox.Show("Lo lamento hubo un clavo");
                }

            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {


            if (textBoxNombre.Text != "")
            {


                oAlumno = DatosForumulario();
                int respuesta = srvAlumno.actualizarAlumno(oAlumno);
                if (respuesta > 0)
                {
                    MessageBox.Show("Se grabo con exito");
                    LimpiarFormulario();
                    cargaGrid();
                }
                else
                {
                    MessageBox.Show("Lo lamento hubo un clavo");
                }
            }
            else
            {
                MessageBox.Show("Nombre no puede quedar vacio");
            }
        


        }

        private void buttonImportar_Click(object sender, EventArgs e)
        {
            string archivo = @"D:\Descargas\p1BC13Crud-20220531T005516Z-001\p1BC13Crud\alumnos.txt";
            ClsImportExport im = new();
            MessageBox.Show(im.importar(archivo));
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            string archivo = @"D:\Descargas\p1BC13Crud-20220531T005516Z-001\p1BC13Crud\salida.csv";
            ClsImportExport im = new();
            MessageBox.Show(im.exportar("select * from tb_alumnos where seccion='B'", archivo));
        }

        private void BorrarAlumno_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro que quieres eliminar a este alumno?", "Eliminar Alumno", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                oAlumno = DatosForumulario();
                int respuesta = srvAlumno.BorrarAlumno(oAlumno);
                if (respuesta > 0)
                {
                    MessageBox.Show("Alumno eliminado exitosamente");
                    LimpiarFormulario();
                    cargaGrid();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al eliminar el alumno");
                }
            }
            if (r == DialogResult.No)
            {
                LimpiarFormulario();
            }

        }

        
    }
}