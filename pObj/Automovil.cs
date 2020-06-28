using System;


namespace pObj
{
    class Automovil
    {
        public int Id { get; set; }
        public string color { get; set; }
        public string Marca { get; set; }
        public int AñoAdquicion { get; set; }
        public float GastoGasolina { get; set; }
        public Persona DueñoAuto { get; set; }
    }
}
