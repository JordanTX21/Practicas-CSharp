using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo miCaballo = new Caballo("Caballin");
            IMamiferosTerrestres ImiCaballo = miCaballo;//utilizando sustitucion.
            miCaballo.Respirar();
            Console.WriteLine("El numero de patas son: "+ImiCaballo.NumeroDePatas());
            miCaballo.Galopar();
        }
    }
    interface IMamiferosTerrestres
    {
        int NumeroDePatas();
    }
    interface ISalto
    {
        int NumeroDePatas();
    }
    interface IMamiferosAcuaticos
    {
        int NumeroDeAletas();
    }
    abstract class Animales
    {
        public void Respirar()
        {
            Console.WriteLine("Respiro.");
        }
        public abstract void getNombre();
    }
    class Mamiferos : Animales
    {
        public Mamiferos(string nombre)
        {
            this.nombre = nombre;
        }
        public override void getNombre()
        {
            Console.WriteLine("El nombre es: "+nombre);
        }
        private string nombre;
    }
    class Lagartija : Animales
    {
        public override void getNombre()
        {
            Console.WriteLine(nombreLagarto);
        }
        private string nombreLagarto;
    }
    class Caballo : Mamiferos,IMamiferosTerrestres,ISalto
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {
            this.nombreCaballo = nombreCaballo;
        }
        public void Galopar()
        {
            Console.WriteLine("Estoy galopando.");
        }
        /*public int NumeroDePatas()
        {
            return 4;
        } */
        int IMamiferosTerrestres.NumeroDePatas()
        {
            return 4;
        }
        int ISalto.NumeroDePatas()
        {
            return 2;
        }
        private string nombreCaballo;
    }
}
