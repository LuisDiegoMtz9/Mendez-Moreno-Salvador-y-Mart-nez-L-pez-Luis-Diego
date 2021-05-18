using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSUR
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
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

        private void capturaDeCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscripcion childForm = new Inscripcion();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCarrera childForm = new ListaCarrera();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
