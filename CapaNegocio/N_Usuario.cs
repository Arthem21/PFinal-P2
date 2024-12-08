using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;


namespace CapaNegocio
{
    public class N_Usuario
    {
        private static N_Usuario _instance;
        private static readonly object _lock = new object();
        private D_Conexion dato = new D_Conexion();

        private N_Usuario() { }

        public static N_Usuario Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new N_Usuario();
                    }
                    return _instance;
                }
            }
        }

        public List<E_Usuario> ListarUsuarios(string x)
        {
            return dato.ListarUsuarios(x);
        }

        public void guardar_Usuario(E_Usuario x)
        {
            dato.guardar_usuario(x);
        }

        public void editar_Usuario(E_Usuario x)
        {
            dato.editar_usuario(x);
        }

        public void borrar_Usuario(E_Usuario x)
        {
            dato.borrar_usuario(x.Id);
        }
    }
}
