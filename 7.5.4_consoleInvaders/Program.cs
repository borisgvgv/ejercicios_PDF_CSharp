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

public class Win
{

    protected bool abandonar = false;
    ConsoleKeyInfo key;
    public Win()
    {
        do
        {
            Console.Clear();
            System.Console.WriteLine("Has ganado la partida");
            System.Console.WriteLine("Enter / Scape");

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.Enter:
                    DibujarPartida dibujarPartida = new DibujarPartida();
                    break;
                case ConsoleKey.Escape:
                    abandonar = true;
                    break;
            }
        } while (!abandonar);
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

    public Nave() : this(5, 5)
    {
    }
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
        return enemigo;
    }
}

public class DibujarPartida
{

    //Parametros de Nave 
    protected int xN = 0;
    protected int yN = 2;

    protected int[,] x = new int[3, 9];
    protected int[,] y = new int[3, 9];
    protected string enemigo;
    protected Random random = new Random();
    protected const int nivel = 3;
    protected const int capacidad = 9;
    protected int cantidad = 3;
    protected Enemigos[,] enemigos = new Enemigos[nivel, capacidad];
    protected bool[,] alcanzado = new bool[nivel, capacidad];
    protected bool abandonar = false;
    protected byte contador = 9;
    protected ConsoleKeyInfo key;
    public DibujarPartida()
    {
        for (int i = 0; i < nivel; i++)
        {
            for (int j = 0; j < cantidad; j++)
            {
                x[i, j] = random.Next(3, Console.WindowWidth - 3);
                y[i, j] = random.Next(2, Console.WindowHeight);
                alcanzado[i, j] = false;
            }
        }

        do
        {
            Console.Clear();
            Console.ResetColor();


            for (int i = 0; i < nivel; i++)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    if (xN == x[i, j] && yN == y[i, j])
                    {
                        alcanzado[i, j] = true;
                        x[i, j] = 0;
                        y[i, j] = 0;
                        contador--;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Estás en una partida - Enemigos: {0}", contador);

            // Paso a naave sin parametros para que coja los que tiene por defecto en su clase con this, no tiene mjucho sentido pero así lo pedia el ejercicio
            if (xN == 0 && yN == 2)
            {
                Nave nave = new Nave();
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(nave.ToString());
            }
            else
            {
                Nave nave = new Nave(xN, yN);
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(nave.ToString());
            }



            for (int i = 0; i < nivel; i++)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        enemigos[i, j] = new Enemigos(x[i, j], y[i, j], "]:[");
                        if (!alcanzado[i, j])
                            System.Console.WriteLine(enemigos[i, j].ToString());
                    }
                    else if (i == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        enemigos[i, j] = new Enemigos(x[i, j], y[i, j], "):(");
                        if (!alcanzado[i, j])
                            System.Console.WriteLine(enemigos[i, j].ToString());

                    }
                    else if (i == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        enemigos[i, j] = new Enemigos(x[i, j], y[i, j], ">+<");
                        if (!alcanzado[i, j])
                            System.Console.WriteLine(enemigos[i, j].ToString());
                    }

                }
            }

            Console.SetCursorPosition(0, Console.WindowHeight); // sacamos el cursor de la zona de juego

            key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (xN > 0)
                    {
                        xN--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (xN < Console.WindowWidth - 3)
                    {
                        xN++;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (yN > 1)
                    {
                        yN--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (yN < Console.WindowHeight)
                    {
                        yN++;
                    }
                    break;
                case ConsoleKey.Escape:
                    abandonar = true;
                    break;
                default:
                    System.Console.WriteLine("Opción incorrecta");
                    break;
            }


        } while (!abandonar && contador > 0);

        Console.ResetColor();
        Console.Clear();

        if (contador == 0)
        {
            Win win = new Win();
        }
    }
}