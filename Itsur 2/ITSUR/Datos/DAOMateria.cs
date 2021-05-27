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
                new MySqlCommand(@"SELECT M.nombre Materia, G.claveGrupo Grupo, G.Horario Horario
                        FROM GRUPOS G JOIN MATERIAS M
                        ON M.ID=G.claveMateria
                        ORDER BY MATERIA");
            return Conexion.ejecutarConsulta(consulta);

        }
    

        public DataTable obtenerXCarrera(int idCarrera)
        {

            MySqlCommand consulta =
                new MySqlCommand(@"select g.id, m.nombre as Materia, g.clavegrupo as `Clave Grupo`, 
                    g.horario as Horario, g.dias as Dias, g.cupo as Cupo, m.creditos as Creditos from 
                    carreras c join materias m join grupos g
                    on @ClaveCarrera=c.clave and c.clave=m.clavecarrera and m.id=g.clavemateria
                    where g.cupo>0");
            consulta.Parameters.AddWithValue("@ClaveCarrera", idCarrera);
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
