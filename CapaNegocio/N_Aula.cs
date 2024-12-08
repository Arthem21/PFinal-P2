using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;


namespace CapaNegocio
{
    public class N_Aula
    {
        private static N_Aula _instance;
        private static readonly object _lock = new object();
        private D_Conexion dato = new D_Conexion();

        private N_Aula() { }

        public static N_Aula Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new N_Aula();
                    }
                    return _instance;
                }
            }
        }

        public List<E_Aula> ListarAulas(string x)
        {
            return dato.ListarAulas(x);
        }

        public void guardar_Aula(E_Aula x)
        {
            dato.guardar_aula(x);
        }

        public void editar_Aula(E_Aula x)
        {
            dato.editar_aula(x);
        }

        public void borrar_Aula(E_Aula x)
        {
            dato.borrar_aula(x.Id);
        }
    }
}
