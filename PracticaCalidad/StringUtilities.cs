using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaCalidad
{
    public class StringUtilities
    {
        public int[] Romano (int n)
        {
            string numero = " ";
            int[] arr = new int[4];
            int millar = ((n / 1000)%10);
             int centena = ((n / 100) % 10);
             int decena = ((n / 10) % 10);
             int unidad = ((n / 1) % 10);
           // return (arr);

            switch (millar)
            {
                
                case 1:
                    numero="M" ;
                    break;
                case 2:
                    numero = ("MM");
                    break;
                case 3:
                    numero = ("MMM");
                    break;
            }
            switch (centena)
            {
                case 1:
                    numero = ("C");
                    break;
                case 2:
                    numero = ("CC");
                    break;
                case 3:
                    numero = ("CCC");
                    break;
                case 4:
                    numero = ("CD");
                    break;
                case 5:
                    numero = ("D");
                    break;
                case 6:
                    numero = ("DC");
                    break;
                case 7:
                    numero = ("DCC");
                    break;
                case 8:
                    numero =("DCCC");
                    break;
                case 9:
                    numero =("CM");
                    break;
            }
            switch (decena)
            {
                case 1:
                    numero = ("X");
                    break;
                case 2:
                    numero = ("XX");
                    break;
                case 3:
                    numero = ("XXX");
                    break;
                case 4:
                    numero = ("XL");
                    break;
                case 5:
                    numero = ("L");
                    break;
                case 6:
                    numero = ("LX");
                    break;
                case 7:
                    numero = ("LXX");
                    break;
                case 8:
                    numero = ("LXXX");
                    break;
                case 9:
                    numero = ("XC");
                    break;
            }

            switch (unidad)
            {
                case 1:
                    numero = ("I");
                    break;
                case 2:
                    numero = ("II");
                    break;
                case 3:
                    numero = ("III");
                    break;
                case 4:
                    numero = ("IV");
                    break;
                case 5:
                    numero = ("V");
                    break;
                case 6:
                    numero = ("VI");
                    break;
                case 7:
                    numero = ("VII");
                    break;
                case 8:
                    numero = ("VIII");
                    break;
                case 9:
                    numero = ("IX");
                    break;
            }
            arr[0] = millar;
            arr[1] = centena;
            arr[2] = decena;
            arr[3] = unidad;
            return arr;
        }
    }
}
