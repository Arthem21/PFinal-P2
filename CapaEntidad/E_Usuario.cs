using System;

namespace CapaEntidad
{
    public class E_Usuario
    {
        private static E_Usuario _instance;   
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _fecha;
        private string _tipo;
        private string _usuario;
        private string _contraseña;

        public static E_Usuario Instacia { get { return _instance; } set { _instance = value; } }
        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string Fecha { get { return _fecha; } set { _fecha = value; } }
        public string Tipo { get { return _tipo; } set { _tipo = value; } }
        public string Usuario { get { return _usuario; } set { _usuario = value; } }
        public string Contraseña { get { return _contraseña; } set { _contraseña = value; } }
    }
}
