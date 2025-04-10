﻿/*
(7.3.5) Amplía el esqueleto de ConsoleInvaders (7.2.6) para que muestre las
imágenes correctas de los enemigos, usando "virtual" y "override". Además, cada
tipo de enemigos debe ser de un color distinto. (Nota: para cambiar colores
puedes usar Console.ForegroundColor = ConsoleColor.Green;). La nave que
maneja el usuario debe ser blanca.
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
    protected bool abandonar = false;
    protected ConsoleKeyInfo key;
    public Bienvenida()
    {
        Console.Clear();

        do
        {
            System.Console.WriteLine("Bienvenidos a Console Invaders");
            System.Console.WriteLine("Jugar = Enter / Abandonar = Escape");
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

        System.Console.WriteLine();
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
    public virtual string ToString()
    {
        return "";
    }
}
public class Enemigo1 : Enemigos
{
    protected int x;
    protected int y;
    public Enemigo1(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public override string ToString()
    {
        Console.SetCursorPosition(x, y);
        return "]-[";
    }
}


public class Enemigo2 : Enemigos
{
    protected int x;
    protected int y;

    public Enemigo2(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        Console.SetCursorPosition(x, y);
        return ">x<";
    }
}
public class Enemigo3 : Enemigos
{
    protected int x;
    protected int y;

    public Enemigo3(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public override string ToString()
    {
        Console.SetCursorPosition(x, y);
        return ")x(";
    }
}


public class Win
{
    protected bool abandonar = false;
    protected ConsoleKeyInfo key;
    public Win()
    {
        do
        {
            Console.Clear();
            System.Console.WriteLine("Has ganado la partida");
            System.Console.WriteLine("Nueva partida: Enter / Salir: Escape");
            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    abandonar = true;
                    break;
                case ConsoleKey.Enter:
                    DibujarPartida dibujarPartida = new DibujarPartida();
                    break;
                default:
                    System.Console.WriteLine("Opción incorrecta");
                    break;
            }

        } while (!abandonar);
       
    }
}




public class DibujarPartida
{
    protected const byte capacidad = 9;
    protected Random random = new Random();
    Enemigos[] enemigos = new Enemigos[capacidad];
    protected bool abandonar = false;
    protected ConsoleKeyInfo key;
    protected int[] x = new int[9];
    protected int[] y = new int[9];
    protected int contador = 9;
    protected int xNave;
    protected int yNave = 5;
    protected bool[] alcanzado = new bool[9];


    public DibujarPartida()
    {

        for (int i = 0; i < capacidad; i++)
        {
            x[i] = random.Next(0, 100);
            y[i] = random.Next(5, 30);
            alcanzado[i] = false;
        }

        do
        {
            Console.Clear();
            System.Console.WriteLine("Estás en una partida - Enemigos: {0}", contador);

            for (int i = 0; i < capacidad; i++)
            {
                if (xNave == x[i] && yNave == y[i])
                {
                    alcanzado[i] = true;
                    x[i] = 0;
                    y[i] = 0;
                    contador--;
                }
            }

            for (int i = 0; i < capacidad; i++)
            {
                if (i < 3)
                {
                    enemigos[i] = new Enemigo1(x[i], y[i]);
                    if (!alcanzado[i])
                        System.Console.WriteLine(enemigos[i].ToString());
                }
                else if (i >= 3 && i < 6)
                {
                    enemigos[i] = new Enemigo2(x[i], y[i]);
                    if (!alcanzado[i])
                        System.Console.WriteLine(enemigos[i].ToString());

                }
                else if (i >= 6)
                {
                    enemigos[i] = new Enemigo3(x[i], y[i]);
                    if (!alcanzado[i])
                        System.Console.WriteLine(enemigos[i].ToString());

                }
            }

            Nave nave = new Nave(xNave, yNave);
            System.Console.WriteLine(nave.ToString());

            Console.SetCursorPosition(0, 30);

            key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.RightArrow:
                    if (xNave < 100)
                        xNave++;
                    break;
                case ConsoleKey.LeftArrow:
                    if (xNave > 0)
                        xNave--;
                    break;
                case ConsoleKey.DownArrow:
                    if (yNave < 30)
                        yNave++;
                    break;

                case ConsoleKey.UpArrow:
                    if (yNave > 5)
                        yNave--;
                    break;
                case ConsoleKey.Escape:
                    abandonar = true;
                    break;
            }

        } while (!abandonar && contador > 0);

        if (contador == 0)
        {
            Win win = new Win();
        }
       
    }
}

