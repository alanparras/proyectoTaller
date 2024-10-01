using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CapaDatosFinal
{
    public class Permiso_Datos
    {
        public List<Permiso> Listar(int idusuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.id_permiso, p.nombreAcceso from Permiso p");
                    query.AppendLine("inner join perfiles r on r.id_perfiles = p.id_perfil");
                    query.AppendLine("inner join usuarios u on u.perfil_id = r.id_perfiles");
                    query.AppendLine("where u.id = @idusuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("id", idusuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                objPerfil = new Perfil() { id_perfil = Convert.ToInt32(dataReader["id_perfiles"])},
                                nombreAcceso = dataReader["nombreAcceso"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }
            }
            return lista;
        }
    }
}
