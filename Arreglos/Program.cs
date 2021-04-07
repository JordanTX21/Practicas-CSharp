using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {   //Primera forma de declarar:
            int[] edades = new int[5];
            edades[0] = 12;
            edades[1] = 15;
            edades[2] = 11;
            edades[3] = 17;
            edades[4] = 14;
            //Segunda forma de declarar:
            int[] mi_matriz = {1,3,2,5,-1};
            //Tercera forma de declarar:
            int[] mi2_matriz = new int [5] {2,6,1,-5,-43};

            //Array implicito:
            var datos = new[] {"juan","jaja","asddsa"};

            //Array de objetos:
            Empleados Ana = new Empleados("ana",19);

            Empleados[] arrayEmpleados = new Empleados[2];
            arrayEmpleados[0] = new Empleados("Lisa", 21);
            arrayEmpleados[1] = Ana;

            //Array de tipos o clases anonimas:
            var personas = new[]{
                //mismo tipo, cantidad, nombre
                new{Nombre="Juan", Edad = 12},      //personas[0]
                new{Nombre="Alverto", Edad = 14},   //personas[1]
                new{Nombre="Maria", Edad = 17}      //personas[2]
            };

            //Solo sirve para buscar,se usa mas en arrays de objetos, implicitos o anonimos
                            //iterador  
            foreach(Empleados variable in arrayEmpleados)
            {
                Console.WriteLine(variable.getDatos());
            }
        }
    }

    class Empleados
    {
        public Empleados(string nombre, int edad){
            this.nombre = nombre;
            this.edad = edad;
        }

        public string getDatos()
        {
            return "Nombre: "+nombre +" Edad: "+edad;
        }

        private string nombre;
        private int edad;
    }
}
