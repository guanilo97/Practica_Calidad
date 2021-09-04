using System;

namespace PracticaCalidad
{
    class Program
    {
        static void Main(string[] args)
        {
            var utils = new StringUtilities();
            int numero = Int32.Parse(Console.ReadLine());
            int[] romano = utils.Romano(numero);
            Console.WriteLine("millar" + romano[0]);
            Console.WriteLine("centana" + romano[1]);
            Console.WriteLine("desena" + romano[2]);
            Console.WriteLine("unidad" + romano[3]);
            //Console.WriteLine("centena"+ (numero / 100)%10);
            //Console.WriteLine("desena"+ (numero / 10)%10);
            //Console.WriteLine("unidad" + (numero / 1)%10);
        }
    }
}
