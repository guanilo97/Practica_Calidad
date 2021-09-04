using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaCalidad
{
    public class StringUtilities
    {
        public int[] Romano (int n)
        {
            int[] arr = new int[4];
            int millar = ((n / 1000)%10);
             int centena = ((n / 100) % 10);
             int decena = ((n / 10) % 10);
             int unidad = ((n / 1) % 10);
            arr[0] = millar;
            arr[1] = centena;
            arr[2] = decena;
            arr[3] = unidad;
            return (arr);
        }
    }
}
