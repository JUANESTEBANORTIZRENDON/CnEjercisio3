using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnEjercisio3
{
    internal class Program
    {
        /// <summary>
        ///nombre:Juan Esteban Ortiz Rendon
        ///Fecha:28/08/2023
        ///Descripcion:Algoritmo para asignar si valores a unos puntos en x y como si tratase de un plano atesiano y especifique si los puntos estan en el primer o segundo cuadrante
        ///</summary>

        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor escriba el palor del punto (x)");
            double px = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Porfavor escriba el palor del punto (y)");
            double py = Convert.ToDouble(Console.ReadLine());

            CuadrantePlano(px, py);

            Console.ReadKey();
        }

        static double CuadrantePlano(double px, double py)
        {
            if (px > 0 & py > 0)
            {
                Console.WriteLine("El punto en el plano se encuentra en el primer cudrante");
                return px;
            }
            else if (px < 0 & py > 0)
            {
                Console.WriteLine("El punto en el plano se encuentra en el segundo cudrante");
                return py;
            }
            else
            {
                Console.WriteLine("El punto esta en algun otro cuadrante ademas del primero y el segundo");
                return px;
            }
        }
    }
} 