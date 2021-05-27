using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Modelos;
namespace Datos
{
    public class DAOCarrera
    {
        public DataTable obtenerTodas()
        {
            MySqlCommand consulta =
                new MySqlCommand(@"SELECT clave, Nombre, Inicial FROM carreras
                   ORDER BY Nombre");
            return Conexion.ejecutarConsulta(consulta);
        }

        public carrera obtenerUno(String clave)
        {
            MySqlCommand consulta =
                new MySqlCommand(@"SELECT clave, Nombre, Inicial
                    FROM carreras  
                    WHERE clave=@claveCarrera");
            consulta.Parameters.AddWithValue("@claveCarrera", clave);
            DataTable resultado = Conexion.ejecutarConsulta(consulta);
            if (resultado != null && resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];
                carrera carre = new carrera()
                {
                    claveCarrera = clave,
                    Nombre = fila["Nombre"].ToString(),
                    Inicial = fila["Inicial"].ToString(),
                   
                };
                return carre;
            }
            else
            {
                return null;
            }

        }
        public bool insertar(carrera obj)
        {
            MySqlCommand insert = new MySqlCommand(
                @"INSERT INTO carreras VALUES(@claveCarrera,
                    @Nombre,@Inicial)"
                );
            insert.Parameters.AddWithValue("@claveCarrera", obj.claveCarrera);
            insert.Parameters.AddWithValue("@Nombre", obj.Nombre);
            insert.Parameters.AddWithValue("@Inicial", obj.Inicial);


            int resultado = Conexion.ejecutarSentencia(insert);
            return (resultado > 0);
        }

        public bool actualizar(carrera obj)
        {
            MySqlCommand update = new MySqlCommand(
                @"UPDATE carreras
                SET Nombre=@Nombre,Inicial=@Inicial
                WHERE clave=@claveCarrera"
                );
            update.Parameters.AddWithValue("@claveCarrera", obj.claveCarrera);
            update.Parameters.AddWithValue("@Nombre", obj.Nombre);
            update.Parameters.AddWithValue("@Inicial", obj.Inicial);
            int resultado = Conexion.ejecutarSentencia(update);
            return (resultado > 0);
        }

        public bool eliminar(String clave)
        {
            MySqlCommand delete = new MySqlCommand(
                     @"DELETE FROM carreras
                WHERE clave=@claveCarrera"
                     );
            delete.Parameters.AddWithValue("@claveCarrera", clave);

            int resultado = Conexion.ejecutarSentencia(delete);
            return (resultado > 0);
        }
    }
}

