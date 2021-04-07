using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        { 
            //pidiendo string
            Console.WriteLine("Ingrese una operacion");
            string operacion1 = Console.ReadLine();
            Calculadora opera = new Calculadora(operacion1);
            opera.Calcular();
        }
        class Calculadora 
        {
            public Calculadora(string operacion)
            {
                this.operacion = operacion;
                this.tipoOperacion = "";
            }
            static double Sumar(double num1, double num2) => num1 + num2;
            static double Restar(double num1, double num2) => num1 - num2;
            static double Multiplicar(double num1, double num2) => num1 * num2;
            static double Dividir(double num1, double num2) => num1 / num2;
            protected string Operaciones( double valor1, double valor2)
            {
                 switch (tipoOperacion)
                {
                    case "+":
                        total = Sumar(valor1,valor2);
                        break;

                    case "-":
                        total = Restar(valor1,valor2);
                        break;

                    case "*":
                        total = Multiplicar(valor1,valor2);
                        break;

                    case "/":
                        total = Dividir(valor1,valor2);
                        break;
                }
                return Convert.ToString(total);
            }
            public void Calcular()
            {
                a = double.Parse(operacion.Substring(0,1));
                b = double.Parse(operacion.Substring(2,1));
                for( int i = 0; i < (operacion.Length); i++ )
                {
                    tipoOperacion = operacion.Substring(i,1);
                    
                    if( (operacion.Substring(i,1) == "+") || (operacion.Substring(i,1) == "-") || (operacion.Substring(i,1) == "*") || (operacion.Substring(i,1) == "/") )
                    {
                        c = double.Parse(Operaciones(a,b));
                        a=c;
                        if(operacion.Substring(i,1) != operacion.Substring(operacion.Length-2,1) )
                        {
                            b = double.Parse(operacion.Substring(i+3,1));
                        }
                    }
                }
                Console.WriteLine(c);
            }
            private string operacion;
            private string tipoOperacion;
            private double total,a,b,c;
        }
    }
}
