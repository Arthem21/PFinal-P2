using System;

namespace CapaEntidad
{
    public class E_Aula
    {
        private int _id;
        private string _aula;
        private int _edificio;

        public int Id { get { return _id; } set { _id = value; } }
        public string Aula { get { return _aula; } set { _aula = value; } }
        public int Edificio { get { return _edificio; } set { _edificio = value; } }
    }
}
