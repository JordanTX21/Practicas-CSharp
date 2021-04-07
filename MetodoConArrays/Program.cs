using System;

namespace MetodoConArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = LeerDatos();

            Console.WriteLine("Se regresa al main: ");

            foreach(int i in numeros) Console.WriteLine(i);

            /*int[] numeros = new int[4];
            numeros[0] = 4;
            numeros[1] = 5;
            numeros[2] = 3;
            numeros[3] = 1;

            ProcesoDatos(numeros);

            foreach(int i in numeros){
                Console.WriteLine(i);
            }  */

        }
        static void ProcesoDatos(int[] Datos)
        {
            /*foreach(int i in Datos){
                Console.WriteLine(i);
            } */

            for(int i=0;i<4;i++){
                Datos[i] += 10;
            }
        }
        static int[] LeerDatos(){
            Console.WriteLine($"Ingrese el tamaño del array:");
            int numElementos = int.Parse(Console.ReadLine());
            int[] datos = new int[numElementos];
            for(int i=0;i<numElementos;i++){
                Console.WriteLine($"Ingrese un numero en la posicion {i}:");
                datos[i] = int.Parse(Console.ReadLine());
            }
            return datos;//devuelve todo el array / por eso se iguala a otro array
        }
    }
}
