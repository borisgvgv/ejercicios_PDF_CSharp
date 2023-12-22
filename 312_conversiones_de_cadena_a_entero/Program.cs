/*
para datos de tipo "byte" usaremos Convert.ToByte (sin signo) y ToSByte (con
signo), para datos de 2 bytes (short) tenemos ToInt16 (con signo) y ToUInt16 (sin
signo), y para los de 8 bytes (long) existen ToInt64 (con signo) y ToUInt64 (sin
signo). De igual modo, para los enteros de 32 bits sin signo se empleará ToUInt32.
*/
// Ejemplo_03_01_02a.cs
// Conversiones para otros tipos de números enteros
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_03_01_02a
{
    static void Main()
    {
        string ejemplo1 = "74";
        string ejemplo2 = "2001";
        string ejemplo3 = "1000000000";
        string ejemplo4 = "1000000000000000";

        byte edad = Convert.ToByte(ejemplo1);
        ushort anyo = Convert.ToUInt16(ejemplo2);
        int  cuenta = Convert.ToInt32(ejemplo3);
        long resultado = Convert.ToInt64(ejemplo4);
        Console.WriteLine("Los datos son {0}, {1} , {2} y {3}",
        edad, anyo, cuenta, resultado);
    }
}