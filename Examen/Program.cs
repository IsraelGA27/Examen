// Israel Garcia Agüero 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        public static bool EsMultiplo(int n1)
        {
            if (n1 % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static void Main(string[] args)
        {
            // Esto lo hizo la consola yo no tuve nada que ver #El_Duende_Verde_Lo_Hizo
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }


            List<int> rojos = new List<int>
            {
                1,
                3,
                5,
                7,
                9,
                12,
                14,
                16,
                18,
                19,
                21,
                23,
                25,
                27,
                30,
                32,
                34,
                36
            }; // Rojos 

            List<int> negros = new List<int>
            {
                2,
                4,
                6,
                8,
                10,
                11,
                13,
                15,
                17,
                20,
                22,
                24,
                26,
                28,
                29,
                31,
                33,
                35

            }; // negros


            

            Console.WriteLine("Bienvenido a la Ruleta Rusa :D");

            // Saldo con el que empieza el jugador
            int saldo = 300;  


            Console.WriteLine();
            Console.WriteLine("Tu saldo es de: " + saldo + " Pesos ");

            

            

            while (true)
            {
                // Lo que vamos a apostar - empezaremos por cualquier número.
                Console.WriteLine();
                Console.Write("¿Que cantidad vas a apostar?    /////     -1(SALIR)");
                Console.WriteLine();

                //int apuesta; 
                int apuesta = int.Parse(Console.ReadLine());
                //int mu = 10;

                if (!EsMultiplo(apuesta) || apuesta > saldo)
                {
                    Console.WriteLine("No puedes realizar tu apuesta");

                    if (apuesta == -1)
                    {
                        break;
                    }

                }
                else
                {
                    //// Metodo apostar por numero 

                    // Valorando que se tenga el dinero suficiente para apostar



                    Console.WriteLine();
                    Console.WriteLine("Ingresa el numero al que deseas apostar; ");
                    int numeroapostado = int.Parse(Console.ReadLine());


                    // Generamos numeros aleatorios
                    Random Generar = new Random();
                    int aleatorio = Generar.Next(1, 2);


                    if (numeroapostado == aleatorio)
                    {
                        Console.WriteLine("!Felicidades¡ Ha caido tu numero ");
                        saldo += apuesta * 10;
                        Console.WriteLine("Tu nuevo saldo es de: " + saldo);
                        Console.WriteLine("Presiona cualquier tecla para continuar :D  ");
                    }
                    else
                    {
                        Console.WriteLine("Has pedido, ah caido el numero: " + aleatorio);
                        saldo -= apuesta;
                        Console.WriteLine("Tu nuevo saldo es de: " + saldo);
                        Console.WriteLine("Presiona cualquier tecla para continuar :D  ");
                    }
                    Console.ReadKey();
                }
            }

        }
    }
}