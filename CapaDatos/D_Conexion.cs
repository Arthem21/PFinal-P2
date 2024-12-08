using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Conexion
    {
        private readonly string connectionString = "Server=LAPTOP-8K5M7IF0;Database=P2DB1;User Id=sa;Password=sa;";

        public List<E_Visita> ListarVisitas(string x)
        {
            List<E_Visita> visitas = new List<E_Visita>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("buscar_visita", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscar", x);

                connection.Open();
                using (SqlDataReader leer = cmd.ExecuteReader())
                {
                    while (leer.Read())
                    {
                        visitas.Add(new E_Visita
                        {
                            Id = !leer.IsDBNull(leer.GetOrdinal("ID")) ? leer.GetInt32(leer.GetOrdinal("ID")) : 0,
                            Nombre = !leer.IsDBNull(leer.GetOrdinal("Nombre")) ? leer.GetString(leer.GetOrdinal("Nombre")) : string.Empty,
                            Apellido = !leer.IsDBNull(leer.GetOrdinal("Apellido")) ? leer.GetString(leer.GetOrdinal("Apellido")) : string.Empty,
                            Carrera = !leer.IsDBNull(leer.GetOrdinal("Carrera")) ? leer.GetString(leer.GetOrdinal("Carrera")) : string.Empty,
                            Correo = !leer.IsDBNull(leer.GetOrdinal("Correo")) ? leer.GetString(leer.GetOrdinal("Correo")) : string.Empty,
                            Edificio = !leer.IsDBNull(leer.GetOrdinal("Edificio")) ? leer.GetInt32(leer.GetOrdinal("Edificio")) : 0,
                            HoraE = !leer.IsDBNull(leer.GetOrdinal("HoraE")) ? leer.GetString(leer.GetOrdinal("HoraE")) : string.Empty,
                            HoraS = !leer.IsDBNull(leer.GetOrdinal("HoraS")) ? leer.GetString(leer.GetOrdinal("HoraS")) : string.Empty,
                            Motivo = !leer.IsDBNull(leer.GetOrdinal("Motivo")) ? leer.GetString(leer.GetOrdinal("Motivo")) : string.Empty,
                            Foto = !leer.IsDBNull(leer.GetOrdinal("Foto")) ? leer.GetString(leer.GetOrdinal("Foto")) : string.Empty,
                            Aula = !leer.IsDBNull(leer.GetOrdinal("Aula")) ? leer.GetInt32(leer.GetOrdinal("Aula")) : 0
                        });
                    }
                }
            }

            return visitas;
        }

        public void guardar_visita(E_Visita x)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("crear_visita", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", x.Nombre);
                cmd.Parameters.AddWithValue("@apellido", x.Apellido);
                cmd.Parameters.AddWithValue("@carrera", x.Carrera);
                cmd.Parameters.AddWithValue("@correo", x.Correo);
                cmd.Parameters.AddWithValue("@edificio", x.Edificio);
                cmd.Parameters.AddWithValue("@horaE", x.HoraE);
                cmd.Parameters.AddWithValue("@horaS", x.HoraS);
                cmd.Parameters.AddWithValue("@motivo", x.Motivo);
                cmd.Parameters.AddWithValue("@foto", x.Foto);
                cmd.Parameters.AddWithValue("@aula", x.Aula);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void editar_visita(E_Visita x)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("editar_visita", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", x.Id);
                cmd.Parameters.AddWithValue("@nombre", x.Nombre);
                cmd.Parameters.AddWithValue("@apellido", x.Apellido);
                cmd.Parameters.AddWithValue("@carrera", x.Carrera);
                cmd.Parameters.AddWithValue("@correo", x.Correo);
                cmd.Parameters.AddWithValue("@edificio", x.Edificio);
                cmd.Parameters.AddWithValue("@horaE", x.HoraE);
                cmd.Parameters.AddWithValue("@horaS", x.HoraS);
                cmd.Parameters.AddWithValue("@motivo", x.Motivo);
                cmd.Parameters.AddWithValue("@foto", x.Foto);
                cmd.Parameters.AddWithValue("@aula", x.Aula);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void borrar_visita(int x)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("borrar_visita", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@borrar", x);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<E_Visita> BuscarVisitasPorEdificio(string x)
        {
            List<E_Visita> visitas = new List<E_Visita>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("buscar_visita_Por_Edificio", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscar", x);

                connection.Open();
                using (SqlDataReader leer = cmd.ExecuteReader())
                {
                    while (leer.Read())
                    {
                        visitas.Add(new E_Visita
                        {
                            Id = !leer.IsDBNull(leer.GetOrdinal("ID")) ? leer.GetInt32(leer.GetOrdinal("ID")) : 0,
                            Nombre = !leer.IsDBNull(leer.GetOrdinal("Nombre")) ? leer.GetString(leer.GetOrdinal("Nombre")) : string.Empty,
                            Apellido = !leer.IsDBNull(leer.GetOrdinal("Apellido")) ? leer.GetString(leer.GetOrdinal("Apellido")) : string.Empty,
                            Carrera = !leer.IsDBNull(leer.GetOrdinal("Carrera")) ? leer.GetString(leer.GetOrdinal("Carrera")) : string.Empty,
                            Correo = !leer.IsDBNull(leer.GetOrdinal("Correo")) ? leer.GetString(leer.GetOrdinal("Correo")) : string.Empty,
                            Edificio = !leer.IsDBNull(leer.GetOrdinal("Edificio")) ? leer.GetInt32(leer.GetOrdinal("Edificio")) : 0,
                            HoraE = !leer.IsDBNull(leer.GetOrdinal("HoraE")) ? leer.GetString(leer.GetOrdinal("HoraE")) : string.Empty,
                            HoraS = !leer.IsDBNull(leer.GetOrdinal("HoraS")) ? leer.GetString(leer.GetOrdinal("HoraS")) : string.Empty,
                            Motivo = !leer.IsDBNull(leer.GetOrdinal("Motivo")) ? leer.GetString(leer.GetOrdinal("Motivo")) : string.Empty,
                            Foto = !leer.IsDBNull(leer.GetOrdinal("Foto")) ? leer.GetString(leer.GetOrdinal("Foto")) : string.Empty,
                            Aula = !leer.IsDBNull(leer.GetOrdinal("Aula")) ? leer.GetInt32(leer.GetOrdinal("Aula")) : 0
                        });
                    }
                }
            }

            return visitas;
        }
    
        public List<E_Usuario> ListarUsuarios(string x)
        {
            List<E_Usuario> usuarios = new List<E_Usuario>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("buscar_usuario", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscar", x);

                connection.Open();
                using (SqlDataReader leer = cmd.ExecuteReader())
                {
                    while (leer.Read())
                    {
                        usuarios.Add(new E_Usuario
                        {
                            Id = !leer.IsDBNull(leer.GetOrdinal("ID")) ? leer.GetInt32(leer.GetOrdinal("ID")) : 0,
                            Nombre = !leer.IsDBNull(leer.GetOrdinal("Nombre")) ? leer.GetString(leer.GetOrdinal("Nombre")) : string.Empty,
                            Apellido = !leer.IsDBNull(leer.GetOrdinal("Apellido")) ? leer.GetString(leer.GetOrdinal("Apellido")) : string.Empty,
                            Fecha = !leer.IsDBNull(leer.GetOrdinal("Fecha")) ? leer.GetString(leer.GetOrdinal("Fecha")) : string.Empty,
                            Tipo = !leer.IsDBNull(leer.GetOrdinal("Tipo")) ? leer.GetString(leer.GetOrdinal("Tipo")) : string.Empty,
                            Usuario = !leer.IsDBNull(leer.GetOrdinal("Usuario")) ? leer.GetString(leer.GetOrdinal("Usuario")) : string.Empty,
                            Contraseña = !leer.IsDBNull(leer.GetOrdinal("Contraseña")) ? leer.GetString(leer.GetOrdinal("Contraseña")) : string.Empty
                        });
                    }
                }
            }

            return usuarios;
        }

        public void guardar_usuario(E_Usuario x)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("crear_usuario", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", x.Nombre);
                cmd.Parameters.AddWithValue("@apellido", x.Apellido);
                cmd.Parameters.AddWithValue("@fecha", x.Fecha);
                cmd.Parameters.AddWithValue("@tipo", x.Tipo);
                cmd.Parameters.AddWithValue("@usuario", x.Usuario);
                cmd.Parameters.AddWithValue("@contraseña", x.Contraseña);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void editar_usuario(E_Usuario x)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("editar_usuario", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", x.Id);
                cmd.Parameters.AddWithValue("@nombre", x.Nombre);
                cmd.Parameters.AddWithValue("@apellido", x.Apellido);
                cmd.Parameters.AddWithValue("@fecha", x.Fecha);
                cmd.Parameters.AddWithValue("@tipo", x.Tipo);
                cmd.Parameters.AddWithValue("@usuario", x.Usuario);
                cmd.Parameters.AddWithValue("@contraseña", x.Contraseña);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void borrar_usuario(int x)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("borrar_usuario", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@borrar", x);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
   
        public List<E_Edificio> ListarEdificios(string x)
        {
            List<E_Edificio> edificios = new List<E_Edificio>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("buscar_edificio", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscar", x);

                connection.Open();
                using (SqlDataReader leer = cmd.ExecuteReader())
                {
                    while (leer.Read())
                    {
                        edificios.Add(new E_Edificio
                        {
                            Id = !leer.IsDBNull(leer.GetOrdinal("ID")) ? leer.GetInt32(leer.GetOrdinal("ID")) : 0,
                            Edificio = !leer.IsDBNull(leer.GetOrdinal("Edificio")) ? leer.GetString(leer.GetOrdinal("Edificio")) : string.Empty
                        });
                    }
                }
            }

            return edificios;
        }

        public void guardar_edificio(E_Edificio x)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("crear_edificio", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@edificio", x.Edificio);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void editar_edificio(E_Edificio x)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("editar_edificio", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", x.Id);
                cmd.Parameters.AddWithValue("@edificio", x.Edificio);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void borrar_edificio(int x)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("borrar_edificio", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@borrar", x);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    


        public List<E_Aula> ListarAulas(string x)
        {
            List<E_Aula> aulas = new List<E_Aula>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("buscar_aula", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscar", x);

                connection.Open();
                using (SqlDataReader leer = cmd.ExecuteReader())
                {
                    while (leer.Read())
                    {
                        aulas.Add(new E_Aula
                        {
                            Id = !leer.IsDBNull(leer.GetOrdinal("ID")) ? leer.GetInt32(leer.GetOrdinal("ID")) : 0,
                            Aula = !leer.IsDBNull(leer.GetOrdinal("Aula")) ? leer.GetString(leer.GetOrdinal("Aula")) : string.Empty,
                            Edificio = !leer.IsDBNull(leer.GetOrdinal("Edificio")) ? leer.GetInt32(leer.GetOrdinal("Edificio")) : 0
                        });
                    }
                }
            }

            return aulas;
        }

        public void guardar_aula(E_Aula x)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("crear_aula", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@aula", x.Aula);
                cmd.Parameters.AddWithValue("@edificio", x.Edificio);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void editar_aula(E_Aula x)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("editar_aula", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", x.Id);
                cmd.Parameters.AddWithValue("@aula", x.Aula);
                cmd.Parameters.AddWithValue("@edificio", x.Edificio);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void borrar_aula(int x)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("borrar_aula", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@borrar", x);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
