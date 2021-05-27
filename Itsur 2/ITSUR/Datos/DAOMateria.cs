using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelos;
namespace Datos
{
    public class DAOMateria
    {
        public DataTable obtenerTodas()
        {
            MySqlCommand consulta =
                new MySqlCommand(@"SELECT Id, m.Nombre Materia, c.ClaveCarrera, 
                    Creditos, c.Nombre Carrera
                    FROM Materias m
                    JOIN Carreras c ON m.ClaveCarrera=c.claveCarrera
                    ORDER BY Carrera, Materia;");
            return Conexion.ejecutarConsulta(consulta);

        }
    

        public DataTable obtenerXCarrera(int idCarrera)
        {
            MySqlCommand consulta =
                new MySqlCommand(@"select g.id, m.nombre as Materia, g.clavegrupo as `Clave Grupo`, 
                    g.horario as Horario, g.dias as Dias, g.cupo as Cupo, m.creditos as Creditos from 
                    carreras c join materias m join grupos g
                    on @ClaveCarrera=c.claveCarrera and c.claveCarrera=m.clavecarrera and m.id=g.clavemateria
                    where g.cupo>0 
                    ");
            consulta.Parameters.AddWithValue("@ClaveCarrera",idCarrera);
            return Conexion.ejecutarConsulta(consulta);

        }



        public bool eliminar(int IdMateria)
        {
            MySqlCommand delete = new MySqlCommand(
                @"DELETE FROM Materias
                WHERE Id=@Id"
                );
            delete.Parameters.AddWithValue("@Id", IdMateria);
            
            int resultado = Conexion.ejecutarSentencia(delete);
            return (resultado > 0);
        }
    }
}
