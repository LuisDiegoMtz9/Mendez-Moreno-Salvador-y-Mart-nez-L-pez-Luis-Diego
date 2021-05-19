using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Modelos;
using MySql.Data.MySqlClient;


namespace Datos
{
    public class DAOUsuario
    {
        public bool validarUsuario(Usuario usuario)
        {
            MySqlCommand consulta =
                new MySqlCommand(@"SELECT CAST(IdUsuario as char(9)) as ClaveGenerica,
                        Nombre, Apellido, TipoUsuario
                        FROM Usuario
                        WHERE usuario=@usuario AND contrasenia=sha1(@contrasenia)
                        UNION
                        SELECT NoControl, Nombre, concat(Apellido1, ' ', Apellido2), 3
                        FROM Alumnos
                        WHERE NoControl=@usuario AND contrasenia=sha1(@contrasenia);");

            consulta.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
            consulta.Parameters.AddWithValue("@contrasenia", usuario.Contrasenia);
            DataTable resultado = Conexion.ejecutarConsulta(consulta);
            if (resultado != null && resultado.Rows.Count > 0) //Si coincide
            {
                DataRow fila = resultado.Rows[0];
                usuario.ClaveGenerica = fila["ClaveGenerica"].ToString();
                usuario.Nombre = fila["nombre"].ToString();
                usuario.Apellido = fila["apellido"].ToString();
                usuario.TipoUsuario = int.Parse(fila["tipoUsuario"].ToString());
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

