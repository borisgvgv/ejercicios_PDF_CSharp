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

    ConsoleKeyInfo key;
    public Bienvenida()
    {
        do
        {
            Console.Clear();

            System.Console.WriteLine("Bienvenido a Console Invaders");
            System.Console.WriteLine("Escape : Salir");
            System.Console.WriteLine("Enter: Jugar");

            key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Enter)
            {
                Partida partida = new Partida();
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                Salir salir = new Salir();
            }


        } while (key.Key != ConsoleKey.Escape && key.Key != ConsoleKey.Enter);

    }
}

public class Nave
{
    public Nave()
    {
        System.Console.WriteLine("N");
    }
}
public class Enemigo
{
    public Enemigo()
    {
        System.Console.Write("X");
    }
}

public class Partida
{
    protected byte x = 50;
    protected byte y = 25;
    protected ConsoleKeyInfo key;
    protected bool abandonar = false;
    protected Enemigo[] enemigo = new Enemigo[3];

    public Partida()
    {
        Console.Clear();
        do
        {
            System.Console.WriteLine("Estás en una partida");
            Console.SetCursorPosition(x, y);
            Nave nave = new Nave();
            Console.SetCursorPosition(25, 12);
            for (int i = 0; i < enemigo.Length; i++)
            {
                enemigo[i] = new Enemigo();
            }
            Console.SetCursorPosition(0, 50);//sacamos el cursor del juego

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.RightArrow:

                    if (x > 60)
                    {
                        x--;
                    }
                    else
                    {
                        x++;
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
                    if (y < 30)
                    {
                        y++;
                    }
                    else
                    {
                        y--;
                    }
                    break;
                case ConsoleKey.Escape:
                    abandonar = true;
                    break;
            }
            Console.Clear();

        } while (!abandonar);

        Salir salir = new Salir();
    }

}

public class Salir
{
    public Salir()
    {
        System.Console.WriteLine("Hasta la próxima");
    }
}
