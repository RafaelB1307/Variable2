using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Perimetro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vala=20;
            int valb = 14;
            int valc = 6;
            int perimetro = vala + valb + valc;
            Console.WriteLine("El perimetro del triangulo es" + perimetro);
            Console.WriteLine("presiona cualquier tecla para finalizar");
            Console.ReadKey();
        }
    }
}
