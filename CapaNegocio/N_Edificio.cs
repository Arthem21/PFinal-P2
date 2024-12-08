using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;


namespace CapaNegocio
{
    public class N_Edificio
    {
        private static N_Edificio _instance;
        private static readonly object _lock = new object();
        private D_Conexion dato = new D_Conexion();

        private N_Edificio() { }

        public static N_Edificio Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new N_Edificio();
                    }
                    return _instance;
                }
            }
        }

        public List<E_Edificio> ListarEdificios(string x)
        {
            return dato.ListarEdificios(x);
        }

        public void guardar_Edificio(E_Edificio x)
        {
            dato.guardar_edificio(x);
        }

        public void editar_Edificio(E_Edificio x)
        {
            dato.editar_edificio(x);
        }

        public void borrar_Edificio(E_Edificio x)
        {
            dato.borrar_edificio(x.Id);
        }
    }
}
