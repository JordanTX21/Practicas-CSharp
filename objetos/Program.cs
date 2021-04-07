using System;

namespace objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Circulo miCirculo;//creacion del objeto

            miCirculo = new Circulo();//instanciar una clase. iniciacion de la variable

            Console.Write("Ingrese el radio del circulo: ");
            int radio = int.Parse(Console.ReadLine());
            Console.WriteLine($"El Area es: {miCirculo.CalculoArea(radio)}");
            Console.WriteLine($"El Perimetro es: {miCirculo.CalculoPerimetro(radio)}"); */

            Jugador player1 = new Jugador("jordan");

            Console.WriteLine(player1.GetInfo());

            player1.setExtras(10);


        }
    }
    class Circulo
    {
        private const double pi = 3.1416;//propiedad 
        public double CalculoArea(int radio) => (double)pi * radio * radio;//metodo
        public double CalculoPerimetro(int radio) => (double)2 * pi * radio;
    }

    partial class Jugador
    {
        public Jugador(string jgNombre)//constructor
        {
            nombre = jgNombre;
            velocidad = 5;
            fuerza = 12;
            nivel = 0;
        }
        public Jugador(string jgNombre, double jgFuerza,double jgVelocidad)//sobrecarga
        {
            nombre = jgNombre;
            velocidad = jgVelocidad;
            fuerza = jgFuerza;
            nivel = 0;
        }
    }
    partial class Jugador//divicion de la clase
    {
        public String GetInfo(){//getter
            return "El estatus del jugador:"+ "\nNobmre: " +nombre +"\nVida: " +vida + "\nNivel: "+nivel;
        }
        public void setExtras(int jgNivel){//setter
            this.nivel=jgNivel;//especifica que se refiere al campo de clase
        }
        private string nombre;
        private const int vida = 10;
        private double velocidad;
        private double fuerza;
        private int nivel;
    }
}
