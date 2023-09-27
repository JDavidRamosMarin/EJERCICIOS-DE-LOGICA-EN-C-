using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_DE_LOGICA
{
    class ii_INVERTIR_NUMEROS_DE_3_CIFRAS
    {
        public void invTresNum()
        {
            int num, aux, dec, uni, cen;
            Console.WriteLine("Ingrese numero de tres cifras");
            num = Convert.ToInt32(Console.ReadLine());
            cen = num / 100;
            Console.WriteLine(cen);
            num = num % 100;
            Console.WriteLine(num);
            dec = num / 10;
            Console.WriteLine(dec);
            uni = num % 10;
            Console.WriteLine(uni);
            aux = (uni * 100) + (dec * 10) + cen;
            Console.WriteLine($"El numero invertido es {aux}");
            Console.ReadKey();
        }
    }
}
