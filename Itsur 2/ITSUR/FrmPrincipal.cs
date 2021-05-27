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

namespace ITSUR
{
    public partial class FrmPrincipal : Form
    {
        String resultado;
        public static String ClaveUsuario { get; set; }
        public static int TipoUsuario { get; set; }
        private int childFormNumber = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
            if (TipoUsuario==1)
            {
                opcionesToolStripMenuItem.Visible = false;
            }
            else if (TipoUsuario==2)
            {
                opcionesToolStripMenuItem.Visible = false;
                alumnosToolStripMenuItem.Visible = false;
                carrerasToolStripMenuItem.Visible = false;
                materiasToolStripMenuItem.Visible = false;
            }
            else if (TipoUsuario==3)
            {
                alumnosToolStripMenuItem.Visible = false;
                carrerasToolStripMenuItem.Visible = false;
                materiasToolStripMenuItem.Visible = false;
                gruposToolStripMenuItem.Visible = false;
            }
        }
       
                  private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaAlumnos childForm = new FrmListaAlumnos();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaMaterias childForm = new FrmListaMaterias();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaGrupos childForm = new FrmListaGrupos();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public String inscrito(String ClaveUsuario)
        {
            String val;

            MySqlCommand validar = new MySqlCommand(
                @"SELECT Inscrito
                FROM Alumnos
                WHERE NoControl=@NoControl"
                );
            validar.Parameters.AddWithValue("@NoControl", ClaveUsuario);
            DataTable resultado = Conexion.ejecutarConsulta(validar);
            DataRow fila = resultado.Rows[0];
            val = fila["Inscrito"].ToString();
            return val;
        }
        private void capturaDeCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (inscrito(ClaveUsuario).Equals("N"))
            {
                Inscripcion childForm = new Inscripcion();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                ConsultaCarga childForm = new ConsultaCarga();
                childForm.MdiParent = this;
                childForm.Show();
            }
          

            
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCarrera childForm = new ListaCarrera();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
