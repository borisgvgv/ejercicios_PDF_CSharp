using System;

public class Juego
{

    protected int ancho = 120;
    protected int alto = 30;

    public int Ancho
    {

        get { return ancho; }

    }

    public int Alto
    {

        get { return alto; }

    }

    public void Espacio()
    {

        for (int i = 0; i <= Alto; i++)
        {
            for (int h = 0; h <= 10; h++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j <= Ancho; j++)
            {
                if (i == 0 ||i == Alto||j==0 || j==Ancho)
                {
                    Console.Write("*");
                }else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}


