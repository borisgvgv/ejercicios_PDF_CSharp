
/*
este programa se queda colgado un instante, hasta terminar finalmente
lanzando una excepción de desbordamiento de pila (Stack Overflow), porque
estamos creando una recursividad indirecta sin fin: el jugador1 crea un jugador2,
éste crea un nuevo jugador1 (en vez de utilizar el ya existente), que a su vez crea
un nuevo jugador2 y así sucesivamente, hasta finalmente desbordar la zona de
memoria que está reservada para llamadas recursivas.
*/

using System;
public class Ejemplo_07_05c
{
    public static void Main()
    {
        Jugador1 j1 = new Jugador1();
        Jugador2 j2 = new Jugador2();
    }
}

// ------------------
public class Jugador
{
    protected Jugador adversario;
}
// ------------------
public class Jugador1 : Jugador
{
    public Jugador1()
    {
        adversario = new Jugador2();
    }
}
// ------------------
public class Jugador2 : Jugador
{
    public Jugador2()
    {
        adversario = new Jugador1();
    }
}