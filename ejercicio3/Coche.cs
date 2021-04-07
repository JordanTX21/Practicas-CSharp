using System;
    class Coche : Vehiculo
    {
        public Coche(string nombreCoche) : base(nombreCoche)
        {

        }
        public override void Conducir()
        {
            Console.WriteLine("Se esta conduciendo el coche.");
        }
    }