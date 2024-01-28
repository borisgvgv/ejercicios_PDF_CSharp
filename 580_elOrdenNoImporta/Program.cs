/*
En algunos lenguajes, una función debe estar declarada antes de usarse. Esto no
es necesario en C#. Pruba a poner la función antes o después del MAIN y funcionará igualmente
*/ 

// Ejemplo_05_08a.cs
// Función tras Main
// Introducción a C#, por Nacho Cabanes
using System;
public class Ejemplo_05_08a
{
public static void Main()
{
int n = 5;
Console.WriteLine("n vale {0}", n);
Duplicar(ref n);
Console.WriteLine("Ahora n vale {0}", n);
}
public static void Duplicar(ref int x)
{
Console.WriteLine(" El valor recibido vale {0}", x);
x = x * 2;
Console.WriteLine(" y ahora vale {0}", x);
}
}