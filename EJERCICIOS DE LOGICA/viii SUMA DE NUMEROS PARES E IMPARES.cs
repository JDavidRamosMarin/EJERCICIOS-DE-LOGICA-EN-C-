using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_DE_LOGICA
{
    class viii_SUMA_DE_NUMEROS_PARES_E_IMPARES
    {
        public void SumParImp()
        {
            byte num;
            int sump = 0, sumi = 0;
            Console.Write("Numero maximo: ");
            num = Convert.ToByte(Console.ReadLine());
            for (int i = 1; i <= num; i += 2)
            {
                sumi = sumi + i;
            }
            for (int i = 2; i <= num; i += 2)
            {
                sump = sump + i;
            }
            Console.WriteLine($"La suma impar es: {sumi}");
            Console.WriteLine($"La suma par es: {sump}");
            Console.ReadKey();
        }
    }
}
