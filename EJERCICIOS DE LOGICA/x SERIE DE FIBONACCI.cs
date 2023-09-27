using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_DE_LOGICA
{
    class x_SERIE_DE_FIBONACCI
    {
        public void Fibonacci()
        {
            byte can, k;
            int a, b, c;
            Console.Write("Cuantos numeros:");
            can = Convert.ToByte(Console.ReadLine());
            a = 1;
            b = 1;
            Console.Write(a + " " + b + " ");
            for (k = 3; k <= can; k++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
