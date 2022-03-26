using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIva
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
                double producto;
                double resultado;

                Console.WriteLine("Igrese un monto de un producto");
                producto = int.Parse(Console.ReadLine());

                resultado = producto * 0.21;
                Console.WriteLine("El IVA es " + resultado);
                Console.WriteLine("El valor final es " + (resultado + producto));
                Console.ReadLine();
            
        

        }
    }
}
