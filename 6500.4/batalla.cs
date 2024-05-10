using System;
using System.Security.Cryptography;



public class Batalla : Sprite
{

    private RNGCryptoServiceProvider rngCrypto;

    public Batalla()
    {
        rngCrypto = new RNGCryptoServiceProvider();
    }



    Sprite area = new Sprite();
    Bienvenida bienvenida = new Bienvenida();
    Lider lider = new Lider();
    Enemigo enemigo = new Enemigo();
    protected string option;
    protected int x, y, vidas = 50;
    protected bool jugar;


    public void Mostrar()
    {



        do
        {
            byte[] randomNumber = new byte[1];

            // Generar un número aleatorio entre 0 y 1 de forma segura
            rngCrypto.GetBytes(randomNumber);
            int rx = randomNumber[0] % 2; // 0 o 1

            rngCrypto.GetBytes(randomNumber);
            int ry = randomNumber[0] % 2; // 0 o 1


            enemigo.SetXY(enemigo.GetX() + rx, enemigo.GetY() + ry);

            if ((lider.GetX() == enemigo.GetX()) && (lider.GetY() == enemigo.GetY()))
            {
                jugar = false;
            }
            else if (vidas >= 0)
            {
                Console.Clear();
                if (vidas == 50)
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
                        else if ((i == 0 || j == 0) || (i == area.GetY() - 1 || j == area.GetX() - 3) && (i == lider.GetY() || i == enemigo.GetY()) && (lider.GetY() == enemigo.GetY()) && (lider.GetX() != enemigo.GetX()))
                        {
                            Console.Write("*");
                        }
                        else if ((i == 0 || j == 0) || (i == area.GetY() - 1 || j == area.GetX() - 2) && (i == lider.GetY() && i == enemigo.GetY()) && (lider.GetY() == enemigo.GetY()) && (lider.GetX() == enemigo.GetX()))
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

                Console.WriteLine("Mover o Escape para salir");

                jugar = true;

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);


                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    jugar = false;
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (lider.GetY() > 1)
                    {
                        x = lider.GetX();
                        y = lider.GetY() - 1;
                    }

                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (lider.GetY() < 18)
                    {
                        x = lider.GetX();
                        y = lider.GetY() + 1;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    if (lider.GetX() > 1)
                    {
                        x = lider.GetX() - 1;
                        y = lider.GetY();
                    }

                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    if (lider.GetX() < 77)
                    {
                        x = lider.GetX() + 1;
                        y = lider.GetY();
                    }

                }
                else
                {
                    Console.WriteLine($"Tecla no reconocida: {keyInfo.KeyChar}");
                }



                lider.SetXY(x, y);
                vidas--;
            }
            else
            {
                vidas = 0;
                jugar = false;
            }

        } while (jugar);

        if (!jugar && (lider.GetX() != enemigo.GetX()) && (lider.GetY() != enemigo.GetY()) && vidas != 0)
        {
            Console.WriteLine("Hasta la próxima");
        }
        else if (!jugar && (lider.GetX() == enemigo.GetX()) && (lider.GetY() == enemigo.GetY()))
        {
            Console.WriteLine("Has ganado");
        }
        else if (!jugar && vidas == 0)
        {
            Console.WriteLine("Has perdido");
        }


    }



}