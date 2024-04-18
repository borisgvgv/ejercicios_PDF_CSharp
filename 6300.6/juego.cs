using System;
public class Juego
{
  protected int x = 79, y = 24;
  bool jugar = true;

  public int GetX()
  {
    return x;
  }

  public int GetY()
  {
    return y;
  }

  public void LanzarJuego()
  {

    Nave nave = new Nave();
    Juego w = new Juego();
    Enemigo enemigo = new Enemigo();
    int contador = 0;
    string option = " ";
    bool finDelJuego = false;
    nave.moverNave(GetX() / 2, GetY() / 2);

    do
    {

      for (int i = 0; i <= GetY(); i++)
      {
        for (int j = 0; j <= GetX(); j++)
        {

          // Dibujamos el marco del espacio con *
          if ((i != nave.GetY()) && (i != enemigo.GetY()) && (i == 0 || i == GetY() || j == 0 || j == GetX()))
          {
            Console.Write("*");
          }
          else if (((i == nave.GetY()) && (j == 0 || j == GetX() - 1)) || ((i == enemigo.GetY()) && (j == 0 || j == GetX() - 1)))
          {
            Console.Write("*");
          }
          else if (i == nave.GetY() && j == nave.GetX()) // Mostramos la nave en el centro del espacio
          {
            nave.printNave();
          }
          else if (i == enemigo.GetY() && j == enemigo.GetX()) // Mostramos enemigo
          {
            enemigo.printEnemigo();
          }
          else
          {
            Console.Write(" ");
          }
        }
        Console.WriteLine();
      }


      do
      {
        Console.WriteLine("Quieres seguir Jugando y o n");
        option = Console.ReadLine();

        if (option == "y")
        {
          Console.WriteLine("Mover Nave");
          Console.Write("X = ");
          int x = Convert.ToInt32(Console.ReadLine());
          Console.Write("Y = ");
          int y = Convert.ToInt32(Console.ReadLine());

          nave.moverNave(x, y);
          contador++;

        }

        if (option == "n" || contador > 2)
        {
          finDelJuego = true;
        }

        else if ((contador < 2 && option == "y") && (nave.GetX() == enemigo.GetX() && nave.GetY() == enemigo.GetY()))
        {
          finDelJuego = true;
        }

        else if ((contador < 2 && option == "y") && (x != enemigo.GetX() && y != enemigo.GetY()))
        {
          finDelJuego = false;
        }
        else
        {
          Console.WriteLine("Error");
        }
      } while (option != "y" && option != "n");




    } while (!finDelJuego);





    if (finDelJuego && nave.GetX() == enemigo.GetX() && nave.GetY() == enemigo.GetY())
    {

      Winner();
      Console.WriteLine("Winner - Congratulations");
    }
    else if (option == "n")
    {
      Console.WriteLine("Hasta pronto");
    }
    else
    {
      Console.WriteLine("Loser - bite the mud");
    }

  }

  public void Winner()
  {

    Nave nave = new Nave();
    Juego w = new Juego();
    Enemigo enemigo = new Enemigo();
    int contador = 0;
    string option = " ";
    bool finDelJuego = false;
    nave.moverNave(enemigo.GetX(), enemigo.GetY());

    for (int i = 0; i <= GetY(); i++)
    {
      for (int j = 0; j <= GetX(); j++)
      {

        // Dibujamos el marco del espacio con *
        if ((i != nave.GetY()) && (i != enemigo.GetY()) && (i == 0 || i == GetY() || j == 0 || j == GetX()))
        {
          Console.Write("*");
        }
        else if (((i == nave.GetY()) && (j == 0 || j == GetX() - 1)) || ((i == enemigo.GetY()) && (j == 0 || j == GetX() - 1)))
        {
          Console.Write("*");
        }
        else if (i == nave.GetY() && j == nave.GetX()) // Mostramos la nave en el centro del espacio
        {
          nave.printNave();
        }
        else if (i == enemigo.GetY() && j == enemigo.GetX()) // Mostramos enemigo
        {
          enemigo.printEnemigo();
        }
        else
        {
          Console.Write(" ");
        }
      }
      Console.WriteLine();
    }

  }

}

