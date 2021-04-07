using System;

    class Vehiculo
    {
        public Vehiculo(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void ArrancarMotor()
        {
            Console.WriteLine("El motor arrancó.");
        }
        public void PararMotor()
        {
            Console.WriteLine("El motor paró.");
        
        }
        public virtual void Conducir()
        {
            Console.WriteLine("Se esta conduciendo el vehiculo.");
        }
        private string nombre;
    }