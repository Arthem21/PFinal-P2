using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;


namespace CapaNegocio
{
    public class N_Visita
    {
        private static N_Visita _instance;
        private static readonly object _lock = new object();
        private D_Conexion dato = new D_Conexion();

        private N_Visita() { }

        public static N_Visita Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new N_Visita();
                    }
                    return _instance;
                }
            }
        }

        public List<E_Visita> ListarVisitas(string x)
        {
            return dato.ListarVisitas(x);
        }

        public void guardar_Visita(E_Visita x)
        {
            dato.guardar_visita(x);
        }

        public void editar_Visita(E_Visita x)
        {
            dato.editar_visita(x);
        }

        public void borrar_Visita(E_Visita x)
        {
            dato.borrar_visita(x.Id);
        }

        public List<E_Visita> BuscarVisitasPorEdificio(string x)
        {
            return dato.BuscarVisitasPorEdificio(x);
        }
    }
}
