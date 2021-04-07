using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero de vehiculos: ");
            int numVehiculos = int.Parse(Console.ReadLine());
            Vehiculo[] Vehiculos = new Vehiculo[numVehiculos];
            for(int i=0; i<numVehiculos;i++)
            {
                Console.WriteLine($"Ingrese el vehiculo numero {i+1}:");
                string nombreVehiculo = Console.ReadLine();
                Vehiculos[i] = new Vehiculo(nombreVehiculo);
                if( (string.Compare(nombreVehiculo,"avion", true) == 0) || (string.Compare(nombreVehiculo,"coche", true) == 0) )
                {
                    if(string.Compare(nombreVehiculo,"avion", true) == 0)
                    {
                        Avion Avion1 = new Avion("");
                        Console.WriteLine("Desea arrancar el avión?");
                        string respuesta1 = Console.ReadLine();
                        if(string.Compare(respuesta1,"si", true) == 0)
                        {
                            Avion1.ArrancarMotor();
                            Console.WriteLine("Desea parar el avión?");
                            string respuesta2 = Console.ReadLine();
                            if(string.Compare(respuesta2,"si", true) == 0)
                            {
                                Avion1.PararMotor();
                            }else {
                                Avion1.Conducir();
                            }
                        }
                    }
                    if(string.Compare(nombreVehiculo,"coche", true) == 0)
                    {
                        Coche Coche1 = new Coche("");
                        Console.WriteLine("Desea arrancar el coche?");
                        string respuesta1 = Console.ReadLine();
                        if(string.Compare(respuesta1,"si", true) == 0)
                        {
                            Coche1.ArrancarMotor();
                            Console.WriteLine("Desea parar el avión?");
                            string respuesta2 = Console.ReadLine();
                            if(string.Compare(respuesta2,"si", true) == 0)
                            {
                                Coche1.PararMotor();
                            }else {
                                Coche1.Conducir();
                            }
                        }
                    }
                }else
                {
                    Console.WriteLine("No se puede hacer nada con el vehiculo ingresado.");
                }
            }
            foreach(Vehiculo val in Vehiculos)
            {
                Console.WriteLine($"Los vehiculos son: {val.getNombre()}");
            }
            
        }
    }
}
