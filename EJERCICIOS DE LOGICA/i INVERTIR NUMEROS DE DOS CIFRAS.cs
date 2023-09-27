using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_DE_LOGICA
{
    class i_INVERTIR_NUMEROS_DE_DOS_CIFRAS
    {
        public void InvertirNumeros()
        {
            int num, aux, dec, uni;
            Console.WriteLine("Ingresa nuúmero de dos cifras: ");
            num = Convert.ToInt32(Console.ReadLine());
            dec = num / 10;
            Console.WriteLine(dec);
            uni = num % 10;
            Console.WriteLine(uni);
            aux = (uni * 10) + dec;
            Console.WriteLine($"El numero invertido es: {aux}");
            Console.ReadLine();

        }
    }
}
