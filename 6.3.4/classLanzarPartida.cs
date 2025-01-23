using System;

class classLanzarPartida
{

    public void LanzarPartida()
    {

        classSalir salir = new classSalir();

        string s;

        do
        {
            System.Console.WriteLine("Esta sería una partida");
            System.Console.WriteLine("Pulsa s para salir");
            //s = Console.ReadLine();

        } while (Console.ReadLine() != Convert.ToString('s'));

        salir.Salir();

    }

}


