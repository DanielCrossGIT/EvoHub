using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_NET
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primera prueba
            Console.WriteLine("Ingrese un numero");
            //Error corregio
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingreso el numero: "+n);
            //Detengo el programa para leer 
            Console.ReadLine();
            //Fin de primera prueba
        }
    }
}
