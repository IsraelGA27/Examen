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


            

            Console.WriteLine("Bienvenido a la Ruleta Rusaaaaaa :D");

            // Saldo con el que empieza el jugador
            //int saldo = 300;  


            //Console.WriteLine();
            //Console.WriteLine("Tu saldo es de: " + saldo + " Pesos ");


            while (true)
            {
                // Lo que vamos a apostar - empezaremos por cualquier número.
                Console.WriteLine();
                Console.Write("¿Como deseas apostar?: ");
                Console.WriteLine("");
                Console.WriteLine();
                Console.WriteLine("1.-Numero Especifico *10 ");
                Console.WriteLine("2.-Color (Rojo o Negro) * 5 ");
                Console.WriteLine("3.-Par o Impar *2 ");


                int menu = int.Parse(Console.ReadLine());
                

                switch(menu)
                {
                    case 1:
                        int saldo2 = 300;

                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Tu saldo es de: " + saldo2 + " Pesos ");
                            Console.WriteLine();
                            Console.Write("¿Cuanto deseas apostar?     -1 PARA SALIR AL MENU ");
                            Console.WriteLine();
                            
                            int apuesta2 = int.Parse(Console.ReadLine());

                            if (!EsMultiplo(apuesta2) || apuesta2 > saldo2 || apuesta2 == -1)
                            {

                                if (apuesta2 == -1)
                                {
                                    //Console.WriteLine("Estas apostando: " + apuesta2 + "  Y solo tienes: " + saldo2 + " disponibles ");
                                    break;
                                }

                                Console.WriteLine("No puedes realizar tu apuesta ");

                            }
                            else
                            {
                                // Pedimos el número al que se le va a apostar
                                Console.WriteLine();
                                Console.WriteLine("Ingresa el numero al que deseas apostar: ");
                                int numeroapostado = int.Parse(Console.ReadLine());


                                // Generamos numeros aleatorios
                                Random Generar = new Random();
                                int aleatorio = Generar.Next(1, 37);


                                if (numeroapostado == aleatorio)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("!Felicidades¡ Ha caido tu numero ");
                                    saldo2 += apuesta2 * 10;
                                    Console.WriteLine("Tu nuevo saldo es de: " + saldo2);
                                    Console.WriteLine("Presiona cualquier tecla para continuar :D  ");
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Has pedido, ah caido el numero: " + aleatorio);
                                    saldo2 -= apuesta2;
                                    Console.WriteLine("Tu nuevo saldo es de: " + saldo2);
                                    Console.WriteLine("Presiona cualquier tecla para continuar :D  ");
                                }
                                Console.ReadKey();

                            }
                        }

                        break;
                    case 2:
                        int saldo3 = 300;

                        Console.WriteLine();
                        Console.WriteLine("Tu saldo es de: " + saldo3 + " Pesos ");
                        Console.WriteLine();
                        Console.Write("APUESTA A ROJO O NEGRO     -1 PARA SALIR AL MENU ");
                        Console.WriteLine("1- rojo       2.-negro   ");
                        Console.WriteLine();


                        break;
                    case 3:
                        break;
                }            
            }
        }
    }
}