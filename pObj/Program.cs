using System;


namespace pObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo!");
            //construcccion de objeto
            var random = new Random();

            var smarTv = new SmartTv { //instancia
                Id = random.Next(), //inicializacion :propiedades a los objetos
                Marca = "Innova",
                Modelo = "smart Tv 001",
                GastoElectrico = 6
            };

            var estudiante = new Persona
            {
                Id = random.Next(),
                Nombre = "Tony",
                Apellido = "Larrea"
            };
            var lavadora = new Lavadora
            {
                Id = random.Next(),
                color="negro",
                GastoLitrosAgua=6,
                Marca="Indurama"

            };
            var auto = new Automovil
            {
                Id=random.Next(),
                AñoAdquicion=2018,
                color="negro",
                GastoGasolina=5,
                 Marca="porshe"
            };
            var play = new PlayStation
            {
                Id = random.Next(),
                color = "negro",
                GastoElectrico=12,
                numero=4
            };
          
            //objeto
            //estudiante.SmartTv = new SmartTv();
            estudiante.SmartTv = smarTv;
            estudiante.Lavadora=lavadora;
            estudiante.Automovil=auto;
            estudiante.PlayStation = play;
            string saludo = estudiante.Saludar();
            Console.WriteLine(saludo);

            Console.WriteLine(estudiante.MostrarSmartTv());
            Console.WriteLine(estudiante.MiLavadora());
            Console.WriteLine(estudiante.MiAutoConocelo());
            Console.WriteLine(estudiante.JuegoPlay());
            Console.ReadKey();

        }
    }
}