/*
(7.2.6) Amplía el esqueleto del ConsoleInvaders (7.2.3), para que haya tres tipos de
enemigos, y un array que contenga 3x10 enemigos (3 filas, cada una con 10
enemigos de un mismo tipo, pero distinto del tipo de los elementos de las otras
filas). Cada tipo de enemigos será una subclase de Enemigo, que se distinguirá por
usar una "imagen" diferente. Puedes usar la "imagen" que quieras (siempre que
sea un string de letras, como "}{" o "XX"). Si estas imágenes no se muestran
Introducción a la programación con C#, por Nacho Cabanes
Revisión 0.99zz – Página 225
correctamente en pantalla al lanzar una partida, no te preocupes, lo
solucionaremos en el siguiente apartado.
*/

using System;

public class Program
{
    public static void Main()
    {
        Bienvenida bienvenida = new Bienvenida();
    }
}

public class Bienvenida
{
    protected bool abandonarPartida = false;
    protected ConsoleKeyInfo key;
    public Bienvenida()
    {
        do
        {
            System.Console.WriteLine("Bienvenido a Console Invaders");
            System.Console.WriteLine("Pulsa Enter para jugar o Escape para salir");

            key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Enter)
            {
                DibujarPartida dibujarPartida = new DibujarPartida();
                abandonarPartida = true;

            }
            else if (key.Key == ConsoleKey.Escape)
            {
                abandonarPartida = true;
            }

        } while (!abandonarPartida);

        Salir salir = new Salir();
    }
}

public class Nave
{
    public Nave()
    {
        System.Console.WriteLine("}:{");
    }
}

public class Enemigo1
{
    public Enemigo1()
    {
        System.Console.WriteLine(")-(");
    }
    public Enemigo1(string eliminado){
        System.Console.WriteLine(eliminado);
    }

}
public class Enemigo2
{
    public Enemigo2()
    {
        System.Console.WriteLine("):(");
    }
    public Enemigo2(string eliminado){
        System.Console.WriteLine(eliminado);
    }
}
public class Enemigo3
{
    public Enemigo3()
    {
        System.Console.WriteLine(")0(");
    }
    public Enemigo3(string eliminado){
        System.Console.WriteLine(eliminado);
    }

}

public class Eliminado{
    public Eliminado(){
        System.Console.Write("");
    }
}

public class DibujarPartida
{
    protected byte x = 10;
    protected byte y = 10;
    protected int[] x1 = new int[3];
    protected int[] y1 = new int[3];
    protected int[] x2 = new int[3];
    protected int[] y2 = new int[3];
    protected int[] x3 = new int[3];
    protected int[] y3 = new int[3];

    protected Random[] random = new Random[3];
    protected Enemigo1[] enemigo1 = new Enemigo1[3];
    protected Enemigo2[] enemigo2 = new Enemigo2[3];
    protected Enemigo3[] enemigo3 = new Enemigo3[3];
    protected Eliminado eliminado= new Eliminado();
    protected bool abandonarPartida = false;
    protected ConsoleKeyInfo key;

    protected int contador = 9;

    public DibujarPartida()
    {
        Console.Clear();

        for (int i = 0; i < random.Length; i++)
        {
            random[i] = new Random();
            x1[i] = random[i].Next(1, 79);
            y1[i] = random[i].Next(1, 40);
            x2[i] = random[i].Next(1, 79);
            y2[i] = random[i].Next(1, 40);
            x3[i] = random[i].Next(1, 79);
            y3[i] = random[i].Next(1, 40);
        }


        do
        {

            Console.Clear();
            System.Console.WriteLine("Estás en una partida");
            System.Console.WriteLine("Enemigos: {0}", contador);

            for (int i = 0; i < enemigo1.Length; i++)
            {
                Console.SetCursorPosition(x1[i], y1[i]);
                enemigo1[i] = new Enemigo1();
            }

            for (int i = 0; i < enemigo2.Length; i++)
            {
                Console.SetCursorPosition(x2[i], y2[i]);
                enemigo2[i] = new Enemigo2();
            }

            for (int i = 0; i < enemigo3.Length; i++)
            {
                Console.SetCursorPosition(x3[i], y3[i]);
                enemigo3[i] = new Enemigo3();
            }

            Console.SetCursorPosition(x, y);
            Nave nave = new Nave();

            Console.SetCursorPosition(0, 40); // Sacar cursor de la pantalla

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (x > 1)
                    {
                        x--;
                    }

                    break;
                case ConsoleKey.RightArrow:
                    if (x < 80)
                    {
                        x++;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (y > 1)
                    {
                        y--;
                    }

                    break;
                case ConsoleKey.DownArrow:
                    if (y < 39)
                    {
                        y++;
                    }
                    break;

                case ConsoleKey.Escape:
                    abandonarPartida = true;
                    break;

                default:
                    System.Console.WriteLine("La opción que que has elegido es incorrecta");
                    break;
            }

            if (x == x1[0] && y == y1[0])
            {
                contador--;
                enemigo1[0] = new Enemigo1("");
            }
            else if (x == x1[1] && y == y1[1])
            {
                contador--;
                enemigo1[1] = new Enemigo1("");
            }
            else if (x == x1[2] && y == y1[2])
            {
                contador--;
                enemigo1[2] = new Enemigo1("");
            }
            else if (x == x2[0] && y == y2[0])
            {
                contador--;
                enemigo2[0] = new Enemigo2("");
            }
            else if (x == x2[1] && y == y2[1])
            {
                contador--;
                enemigo2[1] = new Enemigo2("");
            }
            else if (x == x2[2] && y == y2[2])
            {
                contador--;
                enemigo2[2] = new Enemigo2("");
            }
            else if (x == x3[0] && y == y3[0])
            {
                contador--;
                enemigo3[0] = new Enemigo3("");
            }
            else if (x == x3[1] && y == y3[1])
            {
                contador--;
                enemigo3[1] = new Enemigo3("");
            }
            else if (x == x3[2] && y == y3[2])
            {
                contador--;
                enemigo3[2] = new Enemigo3("");
            }

            Console.SetCursorPosition(x, y);// Sacamos el cursor del espacio de juego

            if (contador == 0)
            {
                Win win = new Win();
            }

        } while (!abandonarPartida);

    }

}

public class Salir
{
    public Salir()
    {
        Console.Clear();
        System.Console.WriteLine("Hasta la próxima");
    }
}

public class Win
{
    public Win()
    {
        Console.Clear();
        System.Console.WriteLine("Has ganado la partida");
    }
}