using System;
using System.IO;

namespace Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miarchivo = new ManejoArchivos();

            miarchivo.mensaje();
        }
    }
    class ManejoArchivos
    {
        StreamReader archivo = null;
        int contador = 0;
        string linea;
        public ManejoArchivos()
        {
            archivo = new StreamReader(@"texto.txt");

            while((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }
        public void mensaje()
        {
            Console.WriteLine("hay {0} lineas",contador);
        }
        ~ManejoArchivos()//ALT+126
        {
            archivo.Close();
        }
    }
}
