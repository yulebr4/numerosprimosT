using System;

namespace numeros
{
    class Program_principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola usuario este es un programa que fue creado para saber si el numero que ingresaste es primo \n");
            Console.WriteLine("Ingrese un numero: \n");

            int numero = int.Parse(Console.ReadLine());

            int divisor = 1, contador = 0;
            while (divisor <= numero)
            {
                if (numero % divisor == 0)
                {
                    contador++;
                }
                divisor++;
            }
            if (contador == 2)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }

        }
    }
}
