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
using System.Threading;

namespace ITSUR
{
    public partial class Inscripcion : Form
    {
        List<int> list;
        List<int> listG;
        public Inscripcion()
        {
            InitializeComponent();
            cargarLista();
            list = new List<int>();
            Thread h = new Thread(new ThreadStart(hilo));
            h.Start();
        }
        public void hilo()
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
            
                if (Int32.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) <= 5)
                {
                    actualizar();
                    Thread.Sleep(15000);

                }
            }
            hilo();
           
        }

        public void actualizar()
        {
            //notify.Text = "Quedan pocos espacios";
            //notify.BalloonTipTitle="Corre";
            //notify.BalloonTipText = "Quedan pocos espacios en los grupos";
            //notify.BalloonTipIcon = ToolTipIcon.Info;
            //notify.Visible = true;
            //notify.ShowBalloonTip(4000);
            MessageBox.Show("Quedan pocos lugares en los grupos");

        }

        private void cargarLista()
        {
            DAOAlumno alumno = new DAOAlumno();
            Alumno Estudiante = new Alumno();
            Estudiante = alumno.obtenerUno(FrmPrincipal.ClaveUsuario);
            DataTable resultado = new DAOMateria().obtenerXCarrera(Estudiante.ClaveCarrera);
            dataGridView1.DataSource = resultado;
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }
        int p;
        private void Terminar_Click(object sender, EventArgs e)
        {
            DAOAlumno obj = new DAOAlumno();
            if (obj.inscripcion(FrmPrincipal.ClaveUsuario).Equals("N"))
            {
                if (esValido())
                {
                    llenado();
                    DAOInscripccion ins = new DAOInscripccion();

                    ins.insertar(listG, FrmPrincipal.ClaveUsuario);
                }
                else
                {
                    MessageBox.Show(this, "Los Datos no son validos", "Datos no válidos", MessageBoxButtons.OK);
                    p = 1;
                }
                if (p!=0)
                {

                }
                else
                {
                    MessageBox.Show("Inscripccion exitosa", "Bien", MessageBoxButtons.OK);
                    ConsultaCarga a = new ConsultaCarga();
                    a.Show();
                    this.Hide();
                }
                
            }
            else
            {
                ConsultaCarga a = new ConsultaCarga();
                a.Show();
                this.Hide();
            }
            
        }

        public bool esValido()
        {
            list.Sort();
            int cont = 0;
            if (list.Count != 0)
            {
                if (list.Count == 1)
                {
                    MessageBox.Show("Agregado correctamente.", "LISTO",
                    MessageBoxButtons.OK);

                    //int lb = Int16.Parse(label1.Text.);

                    label2.Text = ((int.Parse(label2.Text)) -
                         (int.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString()))) + "";
                    return true;
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        for (int j = 0; j < list.Count; j++)
                        {
                            if ((dataGridView1.Rows[list[i]].Cells[1].Value.ToString() ==
                                dataGridView1.Rows[list[j]].Cells[1].Value.ToString()) && i != j)
                            {
                                cont++;
                            }
                        }
                    }
                    if (cont == 0)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            for (int j = 0; j < list.Count; j++)
                            {
                                if ((dataGridView1.Rows[list[i]].Cells[3].Value.ToString() ==
                                    dataGridView1.Rows[list[j]].Cells[3].Value.ToString()) && i != j)
                                {
                                    cont++;
                                }
                            }
                        }
                        if (cont==0)
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                int aux = int.Parse((dataGridView1.Rows[list[i]].Cells[5].Value.ToString()));
                                if (aux == 0)
                                {
                                    cont++;
                                }
                            }
                        }
                        if (cont ==0)
                        {

                            if (cont == 0)
                            {

                                int re;
                                int final;
                                final = int.Parse(label2.Text);

                                for (int i = 0; i < list.Count; i++)
                                {
                                    re = int.Parse((dataGridView1.Rows[list[i]].Cells[6].Value.ToString()));
                                    if (final >= re)
                                    {
                                        final= final - re;
                                    }
                                    else
                                    {
                                        cont++;
                                    }
                                }
                                if (cont == 0)
                                {
                                    label2.Text = final + "";
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {

                                return false;
                            }

                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            else
            {
                MessageBox.Show("Seleccione por lo menos una materia", "Error",
                    MessageBoxButtons.OK);
                return false;
            }
        }

        private void llenado()
        {
            listG = new List<int>();
            int a;
            for (int i = 0; i < list.Count; i++)
            {
                a = int.Parse(dataGridView1.Rows[list[i]].Cells[0].Value.ToString());
                listG.Add(a);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int data= dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[data].Selected = false;

            if (list.Contains(data))
            {
                list.Remove(data);
            }
            else
            {
                list.Add(data);
            }

            foreach (int i in list)
            {
                dataGridView1.Rows[i].Selected = true;
            }
        }
    }  
  }
