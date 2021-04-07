using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Object yaValiste = new Mamifero("Este men");
            Mamifero animal = new Caballo("Lizbeth");//sustitucion de herencia
            Humano Juan = new Humano("Juan");
            Mamifero EuMacaco = new Mamifero("EuMacaco");
            //EuMacaco = Juan;//sustitucion;
            Juan.CuidarCrias();
            Juan.Pensar();
            animal.getNombre();

            Mamifero[] almacenAnimales = new Mamifero[3];
            almacenAnimales[0] = Juan;
            almacenAnimales[1] = animal;
            almacenAnimales[2] = EuMacaco;

            foreach(Mamifero val in almacenAnimales)
            {
                val.getNombre();
            }
        }
    }
    class Mamifero
    {
        public Mamifero(string nombreMamifero){
            this.nombre = nombreMamifero;
        }
        public void CuidarCrias(){
            Console.WriteLine("Cuido a mis crias.");
        }
            // se puede modificar en los heredados
        public virtual void Pensar(){
            Console.WriteLine("Soy capaz de Pensar.");
        }
        public void Respirar(){
            Console.WriteLine("Soy capaz de Respirar.");
        }
        public void getNombre()
        {
            Console.WriteLine($"El nombre del ser vivo es: {nombre}");
        }
        public void nadar(){
            Console.WriteLine("Soy capaz de nadar");
        }
        protected void Cagar(){
            Console.WriteLine("Soy capaz de Cagar.");
        }
        private string nombre;
    }
    class Caballo : Mamifero
    {
        public Caballo(string nombreCaballo):base(nombreCaballo)
        {

        }
        public void Galopa(){
            Console.WriteLine("Soy capaz de galopar.");
        }
    }
    class Humano : Mamifero
    {
        public Humano(string nombreHumano):base(nombreHumano)
        {

        }
            //sobreescritura
        public override void Pensar()
        {
            Console.WriteLine("Pienzo luego existo.");
        }
        new public void nadar(){
            Console.WriteLine("Soy capaz de nadar");
        }
    }
}

/*
  Polimorfismo:
    Es la flexibilidad que le puedes dar a los metodos heredados de una clase
  Modificador de acceso:
    public: accesible desde cualquier clase
    private: solo accesible desde la clase
    protected: accesible desde la misma clase y las clases heredades
 */
