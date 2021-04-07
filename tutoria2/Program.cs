using System;

namespace tutoria2
{
    class Program
    {
        static void Main(string[] args)
        {
            checked{
                //checkea un desbordamiento de operaciones algoritmicas checked(operacion)
            }
            unchecked{
                //omite el checkeo unchecked(operacion) 
            }
            // los anteriores solo funcan con int y long
            try{
                //intenta una operacion
            }catch (Exception)
            {
                //si sucede una excepcion generica la capta y se intenta arreglar con lo que pongas aqui
            }finally{
                //codigo se ejecuta siempre
            }

            throw new Exception();// Lanza una excepcion 
        }
    }
}
