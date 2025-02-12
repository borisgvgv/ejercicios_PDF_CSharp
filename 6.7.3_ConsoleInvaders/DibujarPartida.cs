using System;

public class DibujarPartida
{

    int x = 30;
    int y = 10;

    protected ConsoleKeyInfo key;
    bool abandonarPartida = false;
    protected Nave nave = new Nave();
    protected Enemigo enemigo = new Enemigo(30, 22);
    protected Salir salir = new Salir();
    protected Win win = new Win();
    public void MostrarDibujarPartida()
    {

        do
        {
            Console.Clear();
            System.Console.WriteLine("Estás en una partida");
            System.Console.WriteLine();
            Console.SetCursorPosition(x, y);
            nave.MostrarNave();
            enemigo.MostrarEnemigo();
            Console.SetCursorPosition(0, 26);// saca el cursor de la consola de juego
            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (y > 0) y--;
                    break;
                case ConsoleKey.DownArrow:
                    if (y < 23) y++;
                    break;
                case ConsoleKey.LeftArrow:
                    if (x > 0) x--;
                    break;
                case ConsoleKey.RightArrow:
                    if (x < 78) x++;
                    break;
                case ConsoleKey.Escape: // Salir con la tecla Esc
                    abandonarPartida = true;
                    break;
            }

            if (x == 30 && y == 22)
                abandonarPartida = true;


        } while (!abandonarPartida);

        if (x == 30 && y == 22)
        {
            win.MostrarWin();
        }
        else
        {
            salir.MostrarSalir();

        }
    }
}

