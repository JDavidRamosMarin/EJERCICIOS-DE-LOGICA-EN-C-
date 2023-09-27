using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_DE_LOGICA
{
    class ix_NUMERO_MENOR_Y_MAYOR_DE_N_NUMEROS
    {
        public void MenMayNNum()
        {
            byte can, k;
            int may, men, num;
            Console.WriteLine("Cantidad de numeros (limite):");
            can = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Digite un numero:");
            num = Convert.ToByte(Console.ReadLine());
            may = num;
            men = may;
            for (k = 2; k <= can; k++)
            {
                Console.WriteLine("Digite un numero:");
                num = Convert.ToByte(Console.ReadLine());
                if (num > may) may = num;
                if (num < men) men = num;
            }
            Console.WriteLine("EL MAYOR ES : " + may);
            Console.WriteLine("EL MENOR ES : " + men);
            Console.WriteLine("DIFERENCIA ES : " + (may - men));
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}
