/*
5.9.1. Números aleatorios
En un programa de gestión o una utilidad que nos ayuda a administrar un sistema,
no es habitual que podamos permitir que las cosas ocurran al azar. Pero los juegos
se encuentran muchas veces entre los ejercicios de programación más completos,
y para un juego sí suele ser conveniente que haya algo de azar, para que una
partida no sea exactamente igual a la anterior.
Generar números al azar ("números aleatorios") usando C# no es difícil: debemos
crear un objeto de tipo "Random" (una única vez), y luego llamaremos a "Next"
cada vez que queramos obtener valores entre dos extremos:
*/

using System;
class Program
{
    static void Main()
    {

        // Creamos un objeto Random
        Random generador = new Random();

        // Generamos un número entre dos valores dados
        // (el segundo límite no está incluido)
        int aleatorio = generador.Next(1, 10);
        Console.WriteLine(aleatorio);

        //Llamando a dos números aleatorios

        int aleatorio1 = generador.Next(1,10);
        int aleatorio2 = generador.Next(1,10);
        Console.WriteLine("Los número aleatorios obtenidos son {0} y {1}", aleatorio1, aleatorio2);


        //Ver otra forma de obtener numero aleatorio en el PDF

    }
}