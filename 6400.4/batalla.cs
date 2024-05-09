using System;

public class Batalla : Sprite
{
    Sprite area = new Sprite();
    Bienvenida bienvenida = new Bienvenida();
    Lider lider = new Lider();
    Enemigo enemigo = new Enemigo();
    protected string option;
    protected int x, y, vidas = 3;
    protected bool jugar;

    public void Mostrar()
    {

        do
        {


            if(vidas > 0)
            {
                Console.Clear();
                if (vidas == 3)
                {
                    bienvenida.Mostrar();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("   **** Te quedan {0} vidas ****   ", vidas);
                    Console.WriteLine();
                }

                for (int i = 0; i < area.GetY(); i++)
                {
                    for (int j = 0; j < area.GetX(); j++)
                    {
                        if ((i == 0 || j == 0) || (i == area.GetY() - 1 || j == area.GetX() - 1) && (i != lider.GetY() && i != enemigo.GetY()))
                        {
                            Console.Write("*");
                        }
                        else if ((i == 0 || j == 0) || (i == area.GetY() - 1 || j == area.GetX() - 2) && (i == lider.GetY() || i == enemigo.GetY()) && (lider.GetY() != enemigo.GetY()))
                        {
                            Console.Write("*");
                        }
                        else if ((i == 0 || j == 0) || (i == area.GetY() - 1 || j == area.GetX() - 3) && (i == lider.GetY() || i == enemigo.GetY()) && (lider.GetY() == enemigo.GetY()))
                        {
                            Console.Write("*");
                        }

                        else if (i == lider.GetY() && j == lider.GetX())
                        {
                            lider.Mostrar();
                        }
                        else if (i == enemigo.GetY() && j == enemigo.GetX())
                        {
                            enemigo.Mostrar();
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Seguir jugando y o n");
                option = Console.ReadLine();
                if (option == "y")
                {
                    jugar = true;
                    do
                    {
                        Console.Write("X: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        if (x < 1 || x >= 77)
                        {
                            Console.WriteLine("Los valores de x deben estar entre 1 y 76");
                        }
                    } while (x < 1 || x >= 77);
                    do
                    {
                        Console.Write("Y: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        if (y < 1 || y >= 19)
                        {
                            Console.WriteLine("Los valores de y deben estar entre 1 y 18");
                        }
                    } while (y < 1 || y >= 19);


                    lider.SetXY(x, y);
                    vidas--;


                }
                else if (option == "n")
                {
                    jugar = false;
                }



            }
            else
            {
                jugar = false;
            }

        } while (jugar);

        if (option == "n")
        {
            Console.WriteLine("Hasta la próxima");
        }
        else if (vidas == 0)
        {
            Console.WriteLine("Has perdido");
        }


    }



}