using System;

namespace CapaEntidad
{
    public class E_Visita
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _carrera;
        private string _correo;
        private int _edificio;
        private string _horaE;
        private string _horaS;
        private string _motivo;
        private string _foto;
        private int _aula;

        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string Carrera { get { return _carrera; } set { _carrera = value; } }
        public string Correo { get { return _correo; } set { _correo = value; } }
        public int Edificio { get { return _edificio; } set { _edificio = value; } }
        public string HoraE { get { return _horaE; } set { _horaE = value; } }
        public string HoraS { get { return _horaS; } set { _horaS = value; } }
        public string Motivo { get { return _motivo; } set { _motivo = value; } }
        public string Foto { get { return _foto; } set { _foto = value; } }
        public int Aula { get { return _aula; } set { _aula = value; } }
    }
}
