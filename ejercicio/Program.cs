using System;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0,100);
            Console.WriteLine("Se genero un numero aleatorio, adivinalo!");
            bool control = true;
            while( control ){
                Console.WriteLine("Ingrese un numero: ");
                int numeroIngresado = Int32.Parse(Console.ReadLine());
                if(numeroIngresado<numeroAleatorio){
                    Console.WriteLine("Tu numero es menor.");
                }else if(numeroIngresado>numeroAleatorio){
                    Console.WriteLine("Tu numero es mayor.");
                }else{
                    control=false;
                }
            }
            Console.WriteLine("Felicidades adivinaste el numero!");
        }
    }
}
