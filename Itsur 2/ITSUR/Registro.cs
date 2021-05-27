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
using Modelos;
using System.Text.RegularExpressions;
namespace ITSUR
{
    public partial class Registro : Form
    {
        String clave;

        public Registro()
        {
            InitializeComponent();
            this.Text = "Agregar nueva carrera";

        }
        public Registro(String clave) : this()
        {
            this.Text = "Editar carrera " + clave;

            this.clave = clave;

            DAOCarrera dao = new DAOCarrera();
            carrera ca = dao.obtenerUno(clave);

            txtclave.Text = clave;
            txtclave.Enabled = false;
            txtNombre.Text = ca.Nombre;
            txtInicial.Text = ca.Inicial;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

        }
        private bool esValido()
        {
            Regex num = new Regex(@"^[0-9]+$");
            Regex uno = new Regex(@"[A-Z]{1}|[a-z]{1}");
            Regex stri = new Regex(@"^[A-Za-z]+$");
            errorProvider1.Clear();
            if (txtclave.Text.Equals(""))
            {
                errorProvider1.SetError(txtclave, "Este campo esta vacio");
                return false;
            }
            else if (txtNombre.Text.Equals(""))
            {
                errorProvider1.SetError(txtNombre, "Este campo esta vacio");
                return false;
            }
            else if (txtInicial.Text.Equals(""))
            {
                errorProvider1.SetError(txtInicial, "Este campo esta vacio");
                return false;
            }
            else if (!num.IsMatch(txtclave.Text) && !txtclave.Text.Equals(""))
            {
                errorProvider1.SetError(txtclave, "Este campo solo acepta numeros");
                return false;
            }
            else if (!stri.IsMatch(txtNombre.Text) && txtNombre.Text.Equals(""))
            {
                errorProvider1.SetError(txtNombre, "Este campo acepta letras");
                return false;
            }
            else if (!txtInicial.Text.Equals("") && !uno.IsMatch(txtInicial.Text) | txtInicial.Text.Length > 1)
            {
                errorProvider1.SetError(txtInicial, "Este campo solo acepta una letra");
                return false;
            }
            return true;

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private carrera llenarDatos()
        {
            carrera carre = new carrera();
            carre.claveCarrera = txtclave.Text;
            carre.Nombre = txtNombre.Text;
            carre.Inicial = txtInicial.Text;

            return carre;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (esValido() == true)
            {
                carrera obj = llenarDatos();
                DAOCarrera dao = new DAOCarrera();
                bool resultado;
                try
                {
                    if (clave == null)
                    {
                        resultado = dao.insertar(obj);
                    }
                    else
                    {
                        resultado = dao.actualizar(obj);
                    }

                    if (resultado)
                    {
                        MessageBox.Show(this, "Carrera almacenada exitósamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "Ha ocurrido un error al realizar la operación", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                    if (ex.Message.Equals("Duplicado"))
                    {
                        MessageBox.Show(this, "La clave de la carrera o el nombre esta duplicada", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(this, "Ha ocurrido un error al realizar la operación", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Uno o varios de los datos del alumno no son válidos, revisa la información y vuelve a intentar", "Datos no válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
