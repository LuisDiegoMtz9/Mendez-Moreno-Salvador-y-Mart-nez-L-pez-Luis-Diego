﻿using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ITSUR
{
    public partial class FrmInicioSesion : Form
    {
        String resultado;
        public FrmInicioSesion()
        {
            InitializeComponent();
         
        }
      
            private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();
            obj.NombreUsuario = txtUsuario.Text;
            obj.Contrasenia = txtContraseña.Text;
            if (new DAOUsuario().validarUsuario(obj))
            {
                FrmPrincipal.ClaveUsuario = obj.ClaveGenerica;
                FrmPrincipal.TipoUsuario = obj.TipoUsuario;
                new FrmPrincipal().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario y/o la contraseña son incorrectos");
            }
        }
    }
}
