using System;

namespace pObj
{
    class Lavadora
    {
        public int Id { get; set; }
        public string color { get; set; }
        public string Marca { get; set; }
        public float GastoLitrosAgua { get; set; }
        public Persona DueñoLavadora { get; set; }
    }
}
