using System;

namespace structEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Empleado Empleado1 = new Empleado(1200,250);
            Empleado1.CambiarSalario(Empleado1,100);
            Console.WriteLine(Empleado1); */
            Bonus extra = Bonus.Bueno;
            Console.WriteLine(extra);
        }
    }
    struct Empleado
    {
        public double salarioBase, comision;
        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }
        public override string ToString()
        {
            return string.Format("Salario y comision del empleado({0},{1}):",this.salarioBase,this.comision);
        }
        public void CambiarSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;
            emp.comision += incremento;
        }
    }
    enum Bonus { Bajo, Normal, Bueno, Extra };
}
