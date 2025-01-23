using System;

public class classNave
{
    int x;
    int y;
    string nave = "*";
    string enemigo = "0";
    classSalir salir = new classSalir();
    classWin win = new classWin();
    ConsoleKeyInfo opcion;

    bool verdadero = false;

    public void MoverA(int newX, int newY)
    {
        x = newX;
        y = newY;
    }

    public void DibujarPartida()
    {

        do
        {
            if (x == 10 && y == 10)
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
                        else if (i == 10 && j == 10)
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



