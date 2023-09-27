using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_DE_LOGICA
{
    class vi_NUMERO_INTERMEDIO
    {
        public void NumInt()
        {
            int num1, num2, num3;
            Console.WriteLine("Primer numero:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seguno numero:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tercer numero:");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero intermedio es: ");
            if (num1 > num2)
            {
                if (num1 < num3) Console.WriteLine(num1);
                else
                {
                    if (num2 < num3) Console.WriteLine(num3);
                    else Console.WriteLine(num2);
                }
            }
            else
            {
                if (num2 < num3) Console.WriteLine(num2);
                else
                {
                    if (num1 < num3) Console.WriteLine(num3);
                    else Console.WriteLine(num1);
                }
            }
            Console.ReadKey();
        }
    }
}
