using System;
//using static System.Math;
//using static System.Console;

namespace objetos2
{
    class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();
            //Son de la misma clase
            var miVariable = new {Nombre = "Jordan", Edad = 19};//numero de campos / tipo de campos / orden de campos
            var miOtraVariable = new {Nombre = "asddsa", Edad = 91};
            //se puede:
            miOtraVariable=miVariable;
            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);
        }
        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(4,3);

            double distancia = origen.HallarDistancia(destino);

            Console.WriteLine($"La distancia es: {distancia}");
            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");
        }
    }
}
