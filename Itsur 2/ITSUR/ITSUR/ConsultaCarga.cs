using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Modelos;

namespace ITSUR
{
    public partial class ConsultaCarga : Form
    {
        public ConsultaCarga()
        {
            InitializeComponent();
            cargarLista();
        }



        private void cargarLista()
        {
            DAOInscripccion alumno = new DAOInscripccion();
            DataTable resultado = new DAOInscripccion().Inscripcion(FrmPrincipal.ClaveUsuario);
            dataGridView1.DataSource = resultado;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
