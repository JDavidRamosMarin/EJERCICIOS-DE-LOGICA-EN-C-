using System;

namespace EJERCICIOS_DE_LOGICA
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.- INVERTIR NUMEROS DE DOS CIFRAS");
            Console.WriteLine("2.- INVERTIR NUMEROS DE 3 CIFRAS");
            Console.WriteLine("3.- LIBRERIA MATH");
            Console.WriteLine("4.- FORMATOS DE SALIDA");
            Console.WriteLine("5.- NUMERO MAYOR DE 3 NUMEROS");
            Console.WriteLine("6.- NUMERO INTERMEDIO");
            Console.WriteLine("7.- NUMERO, CONSONANTE O VOCAL");
            Console.WriteLine("8.- SUMA DE NUMEROS PARES E IMPARES");
            Console.WriteLine("9.- NUMERO MENOR Y MAYOR DE N NUMEROS");
            Console.WriteLine("10.- SERIE DE FIBONACCI");

            Console.WriteLine();
            Console.WriteLine("¿Que ejercicio deseas ejecutar?");
            int noEjercicio = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();

            switch (noEjercicio)
            {
                case 0:
                    Environment.Exit(noEjercicio);
                    break;
                case 1:
                    var invNum = new i_INVERTIR_NUMEROS_DE_DOS_CIFRAS();
                    invNum.InvertirNumeros();
                    break;
                case 2:
                    var invTNum = new ii_INVERTIR_NUMEROS_DE_3_CIFRAS();
                    invTNum.invTresNum();
                    break;
                case 3:
                    var libMath = new iii_LIBRERIA_MATH();
                    libMath.LibMath();
                    break;
                case 4:
                    var formOut = new iv_FORMATOS_DE_SALIDA();
                    formOut.FormOut();
                    break;
                case 5:
                    var mayTres = new v_NUMERO_MAYOR_DE_3_NUMEROS();
                    mayTres.NumMaxTres();
                    break;
                case 6:
                    var nInterm = new vi_NUMERO_INTERMEDIO();
                    nInterm.NumInt();
                    break;
                case 7:
                    var numConsVoc = new vii_NUMERO__CONSONANTE_O_VOCAL();
                    numConsVoc.NumConstVoc();
                    break;
                case 8:
                    var sumParImp = new viii_SUMA_DE_NUMEROS_PARES_E_IMPARES();
                    sumParImp.SumParImp();
                    break;
                case 9:
                    var numMayMen = new ix_NUMERO_MENOR_Y_MAYOR_DE_N_NUMEROS();
                    numMayMen.MenMayNNum();
                    break;
                case 10:
                    var serFib = new x_SERIE_DE_FIBONACCI();
                    serFib.Fibonacci();
                    break;
                    
            }

            
        }
    }
}