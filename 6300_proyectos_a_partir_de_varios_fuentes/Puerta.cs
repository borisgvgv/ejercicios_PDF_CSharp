// Puerta.cs
// Clases, get y set
// Introducción a C#, por Nacho Cabanes
using System;
public class Puerta
{
int ancho; // Ancho en centimetros
int alto; // Alto en centimetros
int color; // Color en formato RGB
bool abierta; // Abierta o cerrada
public void Abrir()
{
abierta = true;
}
public void Cerrar()
{
abierta = false;
}
public int GetAncho()
{
return ancho;

}
public void SetAncho(int nuevoValor)
{
ancho = nuevoValor;
}
public void MostrarEstado()
{
Console.WriteLine("Ancho: {0}", ancho);
Console.WriteLine("Alto: {0}", alto);
Console.WriteLine("Color: {0}", color);
Console.WriteLine("Abierta: {0}", abierta);
}
} // Final de la clase 