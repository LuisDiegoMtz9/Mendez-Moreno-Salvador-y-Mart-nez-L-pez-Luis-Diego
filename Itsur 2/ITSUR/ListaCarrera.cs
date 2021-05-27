using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
namespace ITSUR
{
    public partial class ListaCarrera : Form
    {
        public ListaCarrera()
        {
            InitializeComponent();
            cargarLista();
        }
        private void cargarLista()
        {
            DataTable resultado = new DAOCarrera().obtenerTodas();
            dgvLista.DataSource = resultado;
        }
      

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Registro form = new Registro();
            form.ShowDialog();
            cargarLista();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                String clave = dgvLista.SelectedRows[0].Cells[0].Value.ToString();
                Registro form = new Registro(clave);
                form.ShowDialog();
                cargarLista();
            }
            else
            {
                MessageBox.Show("Selecciona la carrera que deseas editar");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvLista.SelectedRows.Count > 0)
                {
                    String clave = dgvLista.SelectedRows[0].Cells[0].Value.ToString();
                    String nombre = dgvLista.SelectedRows[0].Cells[1].Value.ToString();
                    DialogResult respuesta = MessageBox.Show(this, "¿Estás seguro de que quieres eliminar la carrera " +
                        nombre + " con número de control " + clave + "?", "Eliminación de la carrera", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        DAOCarrera dao = new DAOCarrera();
                        if (dao.eliminar(clave))
                        {
                            MessageBox.Show("Carrera eliminado");
                            cargarLista();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona la carrera que deseas eliminar");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Ocupado"))
                {
                    MessageBox.Show(this, "Existe almenos un alumno dentro de esta carrera", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, "Ha ocurrido un error al realizar la operació", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
