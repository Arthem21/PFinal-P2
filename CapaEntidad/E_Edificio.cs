using System;

namespace CapaEntidad
{
    public class E_Edificio
    {
        private int _id;
        private string _edificio;
        public int Id { get { return _id; } set { _id = value; } }
        public string Edificio { get { return _edificio; } set { _edificio = value; } }
    }
}
