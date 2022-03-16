// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace Examen
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Esto lo hizo la consola yo no tuve nada que ver #El_Duende_Verde_Lo_Hizo
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Bienvenido a la Ruleta Rusa :D");

            // Saldo con el que empieza el jugador
            int saldo = 300;  // Si para solo 300, es pobre el pana

            while (true) // Para poder usar: break y continue
            {
                Console.WriteLine();
                Console.WriteLine("Tu saldo es de: " + saldo + " Pesos ");

                if (saldo <= 0)
                {
                    Console.WriteLine("Carnal no tienes dinero, largate");
                    break;
                }

                // Lo que vamos a apostar - empezaremos por cualquier número.
                Console.WriteLine();
                Console.Write("¿Que cantidad vas a apostar?    /////     -1(SALIR)");
                Console.WriteLine();

                //int apuesta; 
                int apuesta = int.Parse(Console.ReadLine());

                if (apuesta == -1)
                {
                    break;
                }
                if (apuesta > saldo)
                {
                    Console.WriteLine("No tienes dinero");
                    continue;
                }



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