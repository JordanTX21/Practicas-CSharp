using System;
    class Avion : Vehiculo
    {
        public Avion(string nombreAvion) : base(nombreAvion)
        {

        }
        public override void Conducir()
        {
            Console.WriteLine("Se esta conduciendo el avión.");
        }
    }