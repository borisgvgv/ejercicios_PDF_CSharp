/*
(3.1.3.1) Crea un programa que use tres variables enteras x,y,z. Sus valores
iniciales serán 15, -10, 2147483647, Se deberá incrementar el valor de estas
variables. ¿Qué valores esperas que se obtengan? Contrástalo con el resultado
obtenido por el programa
*/
using System;
class E3131
{
    static void Main()
    {
        byte x = 15;
        sbyte y = -10;
        ulong z = 2147483647;

        x++;
        y++;
        z++;
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);

    }
}