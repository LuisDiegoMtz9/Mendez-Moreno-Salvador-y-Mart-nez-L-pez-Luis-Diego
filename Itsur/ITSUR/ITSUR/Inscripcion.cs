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
using Datos;
using Modelos;
namespace ITSUR
{
    public partial class Inscripcion : Form
    {
        public Inscripcion()
        {
            InitializeComponent();
            cargarLista();
        }
        private void cargarLista() {
            DAOAlumno alumno = new DAOAlumno();
            Alumno Estudiante = new Alumno();
            Estudiante = alumno.obtenerUno(FrmPrincipal.ClaveUsuario);
            DataTable resultado = new DAOMateria().obtenerXCarrera(Estudiante.ClaveCarrera);
            dataGridView1.DataSource = resultado;
        }
      

    
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Terminar_Click(object sender, EventArgs e)
        {

        }
            }
    }
