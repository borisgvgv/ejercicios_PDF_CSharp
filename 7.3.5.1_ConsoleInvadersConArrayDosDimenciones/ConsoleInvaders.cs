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
    protected bool abandonar = false;
    protected ConsoleKeyInfo key;
    public Bienvenida()
    {
        do
        {
            Console.Clear();
            System.Console.WriteLine("Bienvenido a Console Invaders");
            System.Console.WriteLine("Enter / Scape");

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.Enter:
                    DibujarPartida dibujarPartida = new DibujarPartida();
                    abandonar = true;
                    break;
                case ConsoleKey.Escape:
                    abandonar = true;
                    break;
                default:
                    System.Console.WriteLine("Opción incorrecta");
                    break;
            }

        } while (!abandonar);
        Despedida despedida = new Despedida();

    }
}

public class Despedida
{
    public Despedida()
    {
        System.Console.WriteLine("Hasta la próxima");
    }
}

public class Nave
{
    protected int x;
    protected int y;
    public Nave(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public string ToString()
    {
        Console.SetCursorPosition(x, y);
        return "}:{";
    }
}
public class Enemigos
{
    protected int x;
    protected int y;
    protected string enemigo;
    public Enemigos(int x, int y, string enemigo)
    {
        this.x = x;
        this.y = y;
        this.enemigo = enemigo;
    }
    public string ToString()
    {
        Console.SetCursorPosition(x, y);
        return "";
    }
}

public class DibujarPartida
{
    protected int xN = 0;
    protected int yN = 0;
    protected int x;
    protected int y;
    protected Random random = new Random();
    protected const int nivel = 3;
    protected const int capacidad = 9;
    protected int cantidad = 3;
    protected Enemigos[,] enemigo = new Enemigos[nivel, capacidad];
    protected bool abandonar = false;

    protected ConsoleKeyInfo key;

    public DibujarPartida()
    {
        for (int i = 0; i < nivel; i++)
        {
            for (int j = 0; j < cantidad; j++)
            {
                x[i, j] = random.Next(0, Console.WindowWidth);
                y[i, j] = random.Next(3, ConsoleInvaders.WindowHeight);
            }
        }

        do
        {
            Console.Clear();
            System.Console.WriteLine("Estás en una partida");

            Nave nave = new Nave(xN, yN);
            nave.ToString();

            for (int i = 0; i < capacidad; i++)
            {
                if (i < 3)
                {
                    Enemigos[i] enemigo = new Enemigos[i](x, y, "]-[");
                    System.Console.WriteLine(enemigo[i].ToString());
                }
                else if (i >= 3 && i < 6)
                {
                    Enemigos[i] enemigo = new Enemigos[i](x, y, "]*[");
                    System.Console.WriteLine(enemigo[i].ToString());
                }
                else
                {
                    Enemigos[i] enemigo = new Enemigos[i](x, y, ">:<");
                    System.Console.WriteLine(enemigo[i].ToString());
                }
            }

            Console.SetCursorPosition(0, Console.WindowHeight); // sacamos el cursor de la zona de juego

            key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    abandonar = true;
                    break;
            }
        } while (!abandonar);
        Console.Clear();
    }
}