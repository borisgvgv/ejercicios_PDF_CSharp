using System;

public class classDibujarPartida
{
    protected ConsoleKeyInfo opcion;

    protected int x, y, enemigoX, enemigoY;
    
    public int GetX()
    {
        return x;
    }
    public int GetY()
    {
        return y;
    }

    public void SetMoverNave(int newX, int newY)
    {
        x = newX;
        y = newY;
    }

    public int GetEnemigoX()
    {
        return enemigoX;
    }

    public int GetEnemigoY()
    {
        return enemigoY;
    }

    public void SetMoverEnemigo(int newEnemigoX, int newEnemigoY)
    {
        enemigoX = newEnemigoX;
        enemigoY = newEnemigoY;
    }


    public void DibujarPartida()
    {
        //Clases
        classSalir salir = new classSalir();
        classWin win = new classWin();

        //Atributos
        string nave = "*";
        string enemigo = "0";
        bool verdadero = false;

        do
        {
            if (x == enemigoX && y == enemigoY)
            {
                verdadero = true;
            }
            else
            {
                System.Console.WriteLine("Estás en una partida");

                for (int i = 0; i < 24; i++)
                {
                    for (int j = 0; j < 79; j++)
                    {
                        if (i == y && j == x)
                        {
                            System.Console.Write(nave);

                        }
                        else if (i == enemigoY && j == enemigoX)
                        {
                            System.Console.Write(enemigo);
                        }
                        else
                        {
                            System.Console.Write(" ");
                        }
                    }
                    System.Console.WriteLine();
                }

                opcion = Console.ReadKey(true);

                switch (opcion.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y > 0) y--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (y < 24 - 1) y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > 0) x--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < 79 - 1) x++;
                        break;
                    case ConsoleKey.Escape: // Salir con la tecla Esc
                        salir.Salir();
                        break;
                }
            }

            Console.Clear();
        } while (opcion.Key != ConsoleKey.Escape && !verdadero);

        if (opcion.Key == ConsoleKey.Escape)
        {
            salir.Salir();
        }
        else
        {
            win.Win();

        }

    }
}