using System;
//abstraccion: pasar de casos de la vida real a la programacion
namespace pObj
{
    class Persona
    {
        //datos de la propiedad
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private SmartTv smartv;
        public SmartTv SmartTv
        {
            get { return smartv; }
            set
            {
                smartv = value;
                smartv.Dueño = this;
            }

        }

        private Lavadora lavadora;
        public Lavadora Lavadora
        {
            get { return lavadora; }
            set
            {
                lavadora = value;
                lavadora.DueñoLavadora = this;
            }
        }
        private Automovil automovil;
        public Automovil Automovil
        {
            get { return automovil; }
            set
            {
                automovil = value;
                automovil.DueñoAuto = this;
            }
        }

        private PlayStation playstation;
        public PlayStation PlayStation
        {
            get { return playstation; }
            set
            {
                playstation = value;
                playstation.DueñoPlay = this;
            }
        }

        //metodos => comportamiento
        public string Saludar()
        {
            return $"hola, me llamo {Nombre}{Apellido}";
        }
        public string MostrarSmartTv()
        {
            return $"Mi smarttv es {SmartTv.Modelo}";
        }
        public string MiLavadora()
        {
            return $"mi lavadora es de marca {Lavadora.Marca}";
        }
        public string MiAutoConocelo()
        {
            return $"Mi auto es {Automovil.Marca}";
        }
        public string JuegoPlay()
        {
            return $"Yo tengo la play{PlayStation.numero}";
        }
    }
}
