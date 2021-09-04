using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaCalidad
{
    public class StringUtilities
    {
        public int Romano (int n)
        {
            int millar = ((n / 1000)%10);
            int centena = ((n / 100) % 10);
            int decena = ((n / 10) % 10);
            int unidad = ((n / 1) % 10);
            return millar;
        }
    }
}
