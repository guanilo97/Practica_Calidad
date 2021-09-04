using System;

namespace PracticaCalidad
{
    class Program
    {
        static void Main(string[] args)
        {
            var utils = new StringUtilities();
            int numeros = Int32.Parse(Console.ReadLine());
            int[] romano = utils.Romano(numeros);
            Console.WriteLine("millar" + romano[0]);
            Console.WriteLine("centana" + romano[1]);
            Console.WriteLine("desena" + romano[2]);
           // Console.WriteLine("unidad" + romano[]);

            }
        }
    }

