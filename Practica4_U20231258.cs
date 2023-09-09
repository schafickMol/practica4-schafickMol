using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("\n********** Sintaxis de estructura de consotrol selectivas en c#");
            Console.WriteLine("\nOPCIONES:");
            Console.WriteLine("1. Determinar si el numero es positivo, negativo o igual a cero.");
            Console.WriteLine("2. Mostrar fecha y hora actual.");
            Console.WriteLine("3. Determinar si puede votar y conducir legalmente.");
            Console.WriteLine("4. Determinar si el numero es par o impar.");
            Console.WriteLine("\n Elija un opcion.");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if(opcion == 1){
                Console.WriteLine("\n Ingrese un numero:");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero >0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSu numero es positivo");
                }

                else if (numero < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ("\nSu numero es negativo");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSu numero es igual a cero");
                }
            }

            else if (opcion == 2)
            {
                    Console.ForegroundColor = ConsoleColor.Red;
                DateTime fechaHora = DateTime.Now;
                Console.WriteLine("\nLa fecha y hora actual es:" + fechaHora+ "\n");
            }

            else
            {
                switch(opcion)
                {
                    case 3:
                        Console.WriteLine("\nIngrese su edad:");
                        int edad = Convert.ToInt32(Console.ReadLine());

                        if (edad >= 18)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nEres mayor de edad, puedes votar y conducir legalmente.\n");
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNo eres mayor de edad,no puedes votar y conducir legalmente.\n");
                        }
                    break;

                    case 4:
                    Console.WriteLine("\nIngrese un numero");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    if(numero % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEl numero ingresado es par");
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEl numero ingresado es impar");
                    }
                    break;
                    default:
                    Console.WriteLine("\nOpcion invalida, intente denuevo");
                    break;
                }
            }

            Console.ReadKey();
            Console.ResetColor();
            
        }
    }
}