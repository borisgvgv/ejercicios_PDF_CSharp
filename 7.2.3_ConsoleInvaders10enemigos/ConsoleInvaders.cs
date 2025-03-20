/*
(7.2.3) Amplía el esqueleto del ConsoleInvaders (6.7.3), para que haya 10 enemigos
en una misma fila (todos compartirán una misma coordenada Y, pero tendrán
distinta coordenada X). Necesitarás un nuevo constructor en la clase Enemigo, que
reciba los parámetros X e Y.
*/

using System;
public class ConsoleInvaders
{
    public static void Main()
    {
        Bienvenida bienvenida = new Bienvenida();
    }
}

public class Bienvenida
{
    protected ConsoleKeyInfo key;
    public Bienvenida()
    {
        bool continuar = false;
        do
        {
            System.Console.WriteLine("Buienvenido a ConsoleInvaders");
            System.Console.WriteLine("\"Enter\" para jugar. \"Espacio\": para dalir");

            key = Console.ReadKey();
            if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Spacebar)
            {
                System.Console.WriteLine("No comprendo que quieres hacer");
            }
            else
            {
                continuar = true;
            }

        } while (!continuar);

        if (key.Key == ConsoleKey.Enter)
        {
            Partida partida = new Partida();
            partida.DibujarPartida();
        }
        else if (key.Key == ConsoleKey.Spacebar)
        {
            Salir salir = new Salir();
        }
    }
}

public class Salir
{
    public Salir()
    {
        System.Console.WriteLine("Hasta pronto");
    }
}

public class Nave
{
    protected string nave = "N";
    public void MostrarNave()
    {
        System.Console.WriteLine(nave);

    }
}

public class Enemigo
{

    public Enemigo()
    {
        System.Console.Write("X ");
    }

}

public class Partida
{

    protected byte ancho = 0;
    protected byte alto = 100;
    protected bool abandonarPartida = false;
    protected ConsoleKeyInfo key;
    protected Nave nave = new Nave();
    Enemigo[] enemigo = new Enemigo[5];
    protected byte x = 25;
    protected byte y = 25;

    public void DibujarPartida()
    {

        Console.Clear();
        do
        {
            System.Console.WriteLine("Estás en una partida");
            System.Console.WriteLine("Pulsa escape si quieres salir");
            Console.SetCursorPosition(x, y);
            nave.MostrarNave();

            Console.SetCursorPosition(10, 10);

            for (int i = 0; i < 5; i++)
            {
                enemigo[i] = new Enemigo();
            }

            Console.SetCursorPosition(ancho, alto);//Saca al crursor del área de juego

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.RightArrow:
                    if (x < 100)
                    {
                        x++;
                    }
                    else
                    {
                        x--;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (x > 0)
                    {
                        x--;
                    }
                    else
                    {
                        x++;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (y > 0)
                    {
                        y--;
                    }
                    else
                    {
                        y++;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (y < 100)
                    {
                        y++;
                    }
                    else
                    {
                        y--;
                    }
                    break;
                case ConsoleKey.Escape: // Salir con la tecla Esc
                    abandonarPartida = true;
                    break;
            }
            Console.Clear();
        } while (!abandonarPartida);

        Salir salir = new Salir();


    }

}

