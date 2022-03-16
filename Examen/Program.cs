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
                    case 2: //////////////////////////////////////////////////////
                        int saldo3 = 300;

                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Tu saldo es de: " + saldo3 + " Pesos ");
                            Console.WriteLine();
                            Console.Write("APUESTA A ROJO O NEGRO     -1 PARA SALIR AL MENU ");
                            Console.WriteLine();
                            Console.WriteLine("1- rojo       2.-negro   ");
                            Console.WriteLine();

                            int apuesta3 = int.Parse(Console.ReadLine());

                            if (apuesta3 == -1 || apuesta3 > 3 || apuesta3 == -1)
                            {

                                if (apuesta3 == -1)
                                {
                                    //Console.WriteLine("Estas apostando: " + apuesta2 + "  Y solo tienes: " + saldo2 + " disponibles ");
                                    break;
                                }

                                Console.WriteLine("No puedes realizar tu apuesta ");

                            }
                            else
                            {
                                if (apuesta3 == 1) // Rojos 
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Tu saldo es de: " + saldo3 + " Pesos ");
                                    Console.WriteLine();
                                    Console.Write("¿Cuanto deseas apostar?     -1 PARA SALIR AL MENU ");
                                    Console.WriteLine();

                                    int dinero = int.Parse(Console.ReadLine());


                                    // Generamos numeros aleatorios
                                    Random Generar = new Random();
                                    int aleatorio2 = Generar.Next(1, 36);

                                    if (aleatorio2 == 1 || aleatorio2 == 3 || aleatorio2 == 5 || aleatorio2 == 7 || aleatorio2 == 9 || aleatorio2 == 12 || aleatorio2 == 14 || aleatorio2 == 16 || aleatorio2 == 18 || aleatorio2 == 19|| aleatorio2 == 21 || aleatorio2 == 23 || aleatorio2 == 25 || aleatorio2 == 27 || aleatorio2 == 30 || aleatorio2 == 32 || aleatorio2 == 34 || aleatorio2 == 36)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("SALIO EL NUMERO: " + aleatorio2);
                                        Console.WriteLine("!Felicidades¡ Ha caido tu numero ");
                                        saldo3 += dinero * 5;
                                        Console.WriteLine("Tu nuevo saldo es de: " + saldo3);
                                        Console.WriteLine("Presiona una tecla para continuar ");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("SALIO EL NUMERO: " + aleatorio2);
                                        Console.WriteLine();
                                        Console.WriteLine("Has pedido, ah caido el numero: " + aleatorio2);
                                        saldo3 -= dinero;
                                        Console.WriteLine("Tu nuevo saldo es de: " + saldo3);
                                        Console.WriteLine("Presiona una tecla para continuar ");
                                        Console.WriteLine();
                                    }

                                    
                                }
                                if(apuesta3 == 2 ) // Negras 
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Tu saldo es de: " + saldo3 + " Pesos ");
                                    Console.WriteLine();
                                    Console.Write("¿Cuanto deseas apostar?     -1 PARA SALIR AL MENU ");
                                    Console.WriteLine();

                                    int dinero = int.Parse(Console.ReadLine());

                                    Random Generar = new Random();
                                    int aleatorio2 = Generar.Next(1, 36); 
                                    if (aleatorio2 == 2 || aleatorio2 == 4 || aleatorio2 == 6 || aleatorio2 == 8 || aleatorio2 == 10 || aleatorio2 == 11 || aleatorio2 == 13 || aleatorio2 == 15 || aleatorio2 == 17 || aleatorio2 == 20 || aleatorio2 == 22 || aleatorio2 == 26 || aleatorio2 == 28 || aleatorio2 == 29 || aleatorio2 == 31 || aleatorio2 == 33 || aleatorio2 == 35       )
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("SALIO EL NUMERO: " + aleatorio2);
                                        Console.WriteLine("!Felicidades¡ Ha caido tu numero ");
                                        saldo3 += dinero * 5;
                                        Console.WriteLine("Tu nuevo saldo es de: " + saldo3);
                                        Console.WriteLine("Presiona una tecla para continuar ");
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("SALIO EL NUMERO: " + aleatorio2);
                                        Console.WriteLine();
                                        Console.WriteLine("Has pedido, ah caido el numero: " + aleatorio2);
                                        saldo3 -= dinero;
                                        Console.WriteLine("Tu nuevo saldo es de: " + saldo3);
                                        Console.WriteLine("Presiona una tecla para continuar ");

                                    }
                                    Console.ReadKey();
                                }
                            }
                            Console.ReadKey();




                        }


                        break;
                    case 3:
                        break;
                }            
            }
        }
    }
}