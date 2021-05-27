﻿using System;
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
                if (Int16.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) <= 5)
                {
                    actualizar(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    Thread.Sleep(15000);

                }
            }
            hilo();
        }

        public void actualizar(String a)
        {
            MessageBox.Show("Solo quedan 5 cupos, inscribete antes que se llene la materia: " + a);
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
                }

                MessageBox.Show("Inscripccion exitosa", "Bien", MessageBoxButtons.OK);
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
                   //label1.Text = ((int.Parse(label1.Text)) -
                   //     (int.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString()))) + "";
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

                                int aux2, total;
                                total = int.Parse(label1.Text);

                                for (int i = 0; i < list.Count; i++)
                                {
                                    aux2 = int.Parse((dataGridView1.Rows[list[i]].Cells[6].Value.ToString()));
                                    if (total >= aux2)
                                    {
                                        total = total - aux2;
                                    }
                                    else
                                    {
                                        cont++;
                                    }
                                }
                                if (cont == 0)
                                {
                                    label1.Text = total + "";
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

            int tabla = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[tabla].Selected = false;

            if (list.Contains(tabla))
            {
                list.Remove(tabla);
            }
            else
            {
                list.Add(tabla);
            }

            foreach (int i in list)
            {
                dataGridView1.Rows[i].Selected = true;
            }
        }
    }  
  }