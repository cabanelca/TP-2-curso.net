using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void CalcularIva(int numero)
        {
            
            double resultado;

            
            resultado = numero * 1.21;
            Console.WriteLine("El valor final es " + (resultado));
            Console.ReadLine();
        }
       static void Main (string[] args)
        {
            Console.WriteLine("Igrese un monto de un producto");
            CalcularIva(int.Parse(Console.ReadLine()));
           
        }



    }
}
