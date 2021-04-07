using System;

namespace properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado("Juan");
            Juan.SALARIO = 1200;
        }
    }
    class Empleado
    {
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }
        private double EvaluarSalario(double salario)
        {
            if(salario < 0) return 0;
            else return salario;
        }
        //PROPETIE sintaxis
        /*public double SALARIO
        {
            get{ return salario; }
            set{ this.salario = EvaluarSalario(value);}
        } */
        //PROPETIE sintaxis reducida
        public double SALARIO
        {
            get => this.salario;
            set => this.salario = EvaluarSalario(value);
        }
        private string nombre;
        private double salario;
    }
}
