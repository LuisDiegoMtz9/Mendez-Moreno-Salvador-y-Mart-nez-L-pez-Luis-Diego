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
   public class DAOInscripccion
    {
        public DataTable Inscripcion(String noControl)
        {
            MySqlCommand consulta =
               new MySqlCommand(@"select al.idgrupo as Id,m.nombre as Materia, g.clavegrupo as `Clave Grupo`, 
                    g.horario as Horario, g.dias as Dias from 
                    alumnosgrupos al join grupos g join materias m
                    on @noControl=al.nocontrol and al.idgrupo=g.id and g.clavemateria=m.id");
            consulta.Parameters.AddWithValue("@NoControl", noControl);
            return Conexion.ejecutarConsulta(consulta);
        }
        public void insertar(List<int> lista, String noControl)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                MySqlCommand insert = new MySqlCommand(
                    @"INSERT INTO AlumnosGrupos VALUES(@NoControl,@IdGrupo)");
                insert.Parameters.AddWithValue("@NoControl", noControl);

                insert.Parameters.AddWithValue("@IdGrupo", lista[i]);
                int r1 = Conexion.ejecutarSentencia(insert);

                MySqlCommand updateCupo = new MySqlCommand(
                @"UPDATE Grupos
                SET cupo=cupo-1
                WHERE id=@id"
                 );
                updateCupo.Parameters.AddWithValue("@id", lista[i]);
                int r2 = Conexion.ejecutarSentencia(updateCupo);
            }
            MySqlCommand updateInscrito = new MySqlCommand(
            @"UPDATE Alumnos
                SET Inscrito='S'
                WHERE NoControl=@NoControl");
            updateInscrito.Parameters.AddWithValue("@NoControl", noControl);
            int r3 = Conexion.ejecutarSentencia(updateInscrito);
        }



    }
}

