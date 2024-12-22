using System;
using System.Text;

/*
(4.4.9.3) Crea un juego del ahorcado, en el que un primer usuario introduzca la
ciudad a adivinar, se muestre ésta oculta con guiones (-----) y el programa acepte
las letras que introduzca el segundo usuario, cambiando los guiones por letras
correctas cada vez que acierte (por ejemplo, a---a-t-). La partida terminará cuando
se acierte la ciudad por completo o el usuario agote sus 8 intentos.
*/

/*

string[] ciudades = new string[]
{
    "La Habana, Nueva York", "Tokio", "Londres", "París", "Berlín", "Madrid", "Roma", "Moscú", "Pekín", "Sídney",
    "Los Ángeles", "Buenos Aires", "Ciudad de México", "São Paulo", "Toronto", "El Cairo", "Estambul", "Shanghái",
    "Bangkok", "Dubái", "Seúl", "Ámsterdam", "Viena", "Lisboa", "Atenas", "Praga", "Zúrich", "Dublín", "Estocolmo",
    "Bruselas", "Copenhague", "Bogotá", "Santiago", "Río de Janeiro", "Varsovia", "Lima", "Caracas", "Kuala Lumpur",
    "Ho Chi Minh", "Manila", "Nairobi", "Ciudad del Cabo", "Johannesburgo", "Melbourne", "Brisbane", "Perth", 
    "Vancouver", "Montreal", "Chicago", "San Francisco", "Houston", "Filadelfia", "Miami", "Boston", "Las Vegas",
    "Seattle", "Phoenix", "San Diego", "Orlando", "Dallas", "Guadalajara", "Monterrey", "Quito", "Guayaquil", 
    "La Paz", "Sucre", "Asunción", "Montevideo", "San José", "Panamá", "Tegucigalpa", "San Salvador", "Managua", 
    "Belice", "Kingston", "La Habana", "Punta Cana", "Medellín", "Cali", "Barranquilla", "Rosario", 
    "Córdoba (Argentina)", "Mar del Plata", "Recife", "Fortaleza", "Salvador de Bahía", "Porto Alegre", 
    "Manaos", "Curitiba", "Nueva Delhi", "Calcuta", "Mumbái", "Bangalore", "Katmandú", "Karachi", "Daca", 
    "Yakarta", "Singapur", "Hong Kong", "Taipéi"
};

*/
class Program
{
    static void Main()
    {
        Console.Clear();

        string[] ciudades = new string[]
        {
    "La Habana, Nueva York", "Tokio", "Londres", "París", "Berlín", "Madrid", "Roma", "Moscú", "Pekín", "Sídney",
    "Los Ángeles", "Buenos Aires", "Ciudad de México", "São Paulo", "Toronto", "El Cairo", "Estambul", "Shanghái",
    "Bangkok", "Dubái", "Seúl", "Ámsterdam", "Viena", "Lisboa", "Atenas", "Praga", "Zúrich", "Dublín", "Estocolmo",
    "Bruselas", "Copenhague", "Bogotá", "Santiago", "Río de Janeiro", "Varsovia", "Lima", "Caracas", "Kuala Lumpur",
    "Ho Chi Minh", "Manila", "Nairobi", "Ciudad del Cabo", "Johannesburgo", "Melbourne", "Brisbane", "Perth",
    "Vancouver", "Montreal", "Chicago", "San Francisco", "Houston", "Filadelfia", "Miami", "Boston", "Las Vegas",
    "Seattle", "Phoenix", "San Diego", "Orlando", "Dallas", "Guadalajara", "Monterrey", "Quito", "Guayaquil",
    "La Paz", "Sucre", "Asunción", "Montevideo", "San José", "Panamá", "Tegucigalpa", "San Salvador", "Managua",
    "Belice", "Kingston", "La Habana", "Punta Cana", "Medellín", "Cali", "Barranquilla", "Rosario",
    "Córdoba (Argentina)", "Mar del Plata", "Recife", "Fortaleza", "Salvador de Bahía", "Porto Alegre",
    "Manaos", "Curitiba", "Nueva Delhi", "Calcuta", "Mumbái", "Bangalore", "Katmandú", "Karachi", "Daca",
    "Yakarta", "Singapur", "Hong Kong", "Taipéi"
        };

        System.Console.Write("Ciudad: ");
        Random generator = new Random();
        int posicion = generator.Next(1, 100);
        string ciudad = ciudades[posicion];
        ciudad = ciudad.ToLower();
        StringBuilder palabraModificable = new StringBuilder(ciudad);



        Console.Clear();

        // llenamos array palabraTemporal
        for (int i = 0; i < ciudad.Length; i++)
        {
            palabraModificable[i] = '_';
        }

        //Mostramos array palabraTemporal
        System.Console.WriteLine("Ciudad");
        for (int i = 0; i < ciudad.Length; i++)
        {
            System.Console.Write(palabraModificable[i]);
        }
        System.Console.WriteLine();

        int contador = ciudad.Length + 3;
        int contadorDeLetras = 0;

        do
        {
            System.Console.Write("Introduce una letra: ");
            char letra = Convert.ToChar(Console.ReadLine());
            contador--;

            for (int i = 0; i < ciudad.Length; i++)
            {
                if (ciudad[i] == letra && i == 0)
                {
                    palabraModificable[i] = char.ToUpper(letra);
                    contadorDeLetras++;
                }
                else if (ciudad[i] == letra && palabraModificable[i] != letra)
                {
                    palabraModificable[i] = letra;
                    contadorDeLetras++;
                }

                if (contadorDeLetras == ciudad.Length)
                {
                    contador = 0;
                }

            }

            Console.Clear();
            System.Console.WriteLine("Ciudad");

            for (int i = 0; i < ciudad.Length; i++)
            {
                System.Console.Write(palabraModificable[i]);
            }
            System.Console.WriteLine();

        } while (contador != 0);

        if (contadorDeLetras == ciudad.Length)
        {
            System.Console.WriteLine("You Win");
        }
        else
        {
            System.Console.WriteLine("La ciudad correcta era: {0}", ciudad);
            System.Console.WriteLine("Game Over");
        }


    }
}


