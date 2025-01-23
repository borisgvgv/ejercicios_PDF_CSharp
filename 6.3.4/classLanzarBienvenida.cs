using System;

/*

6.2.2) Tras leer la descripción de Space Invaders que vimos en el apartado
anterior, crea una clase Juego,que sólo contenga un método Lanzar, void, sin
parámetros, que escriba en pantalla "Bienvenido a Console Invaders. Pulse Intro
para salir" y se parará hasta que el usuario pulse Intro. Prepara también un Main
(en la misma clase), que cree un objeto de la clase Juego y lo lance.

*/


public class classLanzarBienvenida
{

    public void Bienvenida()
    {


        classLanzarPartida lanzar = new classLanzarPartida();
        classSalir salir = new classSalir();
        ConsoleKeyInfo tecla;

        do
        {

            System.Console.WriteLine("Bienvenido Space Invaders");
            System.Console.WriteLine("Pulse para Enter para continuar o s para Salir");
            tecla = Console.ReadKey(true);

        } while ( tecla.Key != ConsoleKey.Enter || tecla.Key != ConsoleKey.Escape);


        if (tecla.Key == ConsoleKey.Enter)
        {
            lanzar.LanzarPartida();
        }
        else if(tecla.Key == ConsoleKey.Escape)
        {
            salir.Salir();
        }





    }

}

