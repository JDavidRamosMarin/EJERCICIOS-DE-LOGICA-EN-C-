using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_DE_LOGICA
{
    class v_NUMERO_MAYOR_DE_3_NUMEROS
    {
        public void NumMaxTres()
        {
            byte MAY, MEN, NUM1, NUM2, NUM3;
            Console.Write("NÚMERO 1 :");
            NUM1 = Convert.ToByte(Console.ReadLine()); //80
            Console.Write("NÚMERO 2 :");
            NUM2 = Convert.ToByte(Console.ReadLine()); //90
            Console.Write("NÚMERO 3 :");
            NUM3 = Convert.ToByte(Console.ReadLine()); //15
            MAY = NUM1; //80
            MEN = NUM1; //80
            if ((NUM2 > MAY)) MAY = NUM2; //90 > 80 --- true MAY = 90
            if ((NUM3 > MAY)) MAY = NUM3; //15 > 90 --- False
            if ((NUM2 > MEN)) MEN = NUM2; //90 > 80 --- true MEN = 90
            if ((NUM3 < MEN)) MEN = NUM3; //15 < 90 --- true MEN = 15
            Console.WriteLine("MAYOR ES:" + MAY);
            Console.WriteLine("MENOR ES:" + MEN);
            Console.WriteLine("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}
