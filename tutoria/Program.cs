using System;

namespace tutoria
{
    class Program
    {

        static void Main(string[] args) => fncMenu();
        static void fncMenu(){
            Console.WriteLine("1.Sumar.\n2.Restar.\n3.Multiplicar.\n4.Dividir.\n5.Salir");
            string opcion = Console.ReadLine();
            switch(opcion){
                case "1":
                MenuSuma();
                break;
                case "2":
                MenuResta();
                break;
                case "3":
                MenuMultiplica();
                break;
                case "4":
                MenuDivide();
                break;
                case "5":
                Console.WriteLine("Adios!");
                break;
                default :
                Console.WriteLine("Opcion erronea.");
                break;
            }
        }
        static void MenuSuma(){
            Console.Write("******Menu de Suma******\n");
            Console.Write("Ingrese un numero: ");
            float N1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            float N2 = float.Parse(Console.ReadLine());
            Console.WriteLine("La Suma es: "+fncSumar(N1,N2));
        }
        static void MenuResta(){
            Console.Write("******Menu de Resta******\n");
            Console.Write("Ingrese un numero: ");
            float N1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            float N2 = float.Parse(Console.ReadLine());
            Console.WriteLine("La Resta es: "+fncRestar(N1,N2));
        }
        static void MenuMultiplica(){
            Console.Write("******Menu de Multiplicacion******\n");
            Console.Write("Ingrese un numero: ");
            float N1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            float N2 = float.Parse(Console.ReadLine());
            Console.WriteLine("La Multiplicacion es: "+fncMultiplicar(N1,N2));
        }
        static void MenuDivide(){
            Console.Write("Ingrese un numero: ");
            Console.Write("******Menu de Division******\n");
            float N1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            float N2 = float.Parse(Console.ReadLine());
            Console.WriteLine("La Division es: "+fncDividir(N1,N2));
        }
        static float fncSumar(float n1, float n2) => n1 + n2;
        static float fncRestar(float n1, float n2) => n1 - n2;
        static float fncMultiplicar(float n1, float n2) => n1 * n2;
        static float fncDividir(float n1, float n2) => n1 / n2;
    }
}
